using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace Molina.Valentina_TPI_PP1
{
    internal class clsVentas
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=AjoYCo.mdb";
        private string Tabla = "Ventas";

        private Int32 idVen;
        private DateTime fec;
        private string medio;
        private decimal monto;
        private Int32 idProd;
        private Int32 cant;

        private Double Monto;
        private Int32 Cantidad;

        public Double MontoVentas
        {
            get {return Monto; }
        }
        public Int32 CantidadVentas
        {
            get {return Cantidad; }
        }
        public Int32 idVentas
        {
            get { return idVen; }
            set { idVen = value; }
        }
        public DateTime Fecha
        {
            get { return fec; }
            set { fec = value; }
        }
        public string MedioDePago
        {
            get { return medio; }
            set { medio = value; }
        }
        public decimal MontoTotal
        {
            get { return monto; }
            set { monto = value; }
        }
        public Int32 idProducto
        {
            get { return idProd; }
            set { idProd = value; }
        }
        public Int32 CantidadProducto
        {
            get { return cant; }
            set { cant = value; }
        }

        public void ListarMediosDePago(ComboBox Combo)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT DISTINCT MedioDePago FROM Ventas";

                adaptador = new OleDbDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);

                Combo.DataSource = ds.Tables[0];
                Combo.DisplayMember = "MedioDePago";
                Combo.ValueMember = "MedioDePago"; 
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void AgregarVentas(MonthCalendar dtpFecha, ComboBox comboMedioPago, ComboBox comboProducto, TextBox txtCantidad, TextBox txtMonto)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds, Tabla);

                DataTable tabla = ds.Tables[Tabla];
                DataRow fila = tabla.NewRow();

                // Fecha
                fila["Fecha"] = dtpFecha.SelectionStart;

                // Medio de pago (ID)
                fila["MedioDePago"] = comboMedioPago.SelectedValue;

                // Producto (ID)
                var productoID = comboProducto.SelectedValue;
                fila["idProducto"] = productoID;

                // Cantidad
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                fila["Cantidad"] = cantidad;

                // Monto total
                decimal monto = Convert.ToDecimal(txtMonto.Text);
                fila["MontoTotal"] = monto;

                // Verificamos stock actual antes de continuar
                string sqlVerificar = "SELECT Cantidad FROM Productos WHERE idProducto = ?";
                OleDbCommand cmdVerificar = new OleDbCommand(sqlVerificar, conexion);
                cmdVerificar.Parameters.AddWithValue("?", productoID);

                int stockActual = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                if (stockActual >= cantidad)
                {
                    // Guardamos la venta
                    tabla.Rows.Add(fila);
                    OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                    adaptador.Update(ds, Tabla);

                    // Actualizamos el stock del producto
                    string sqlActualizarStock = "UPDATE Productos SET Cantidad = Cantidad - ? WHERE idProducto = ?";
                    OleDbCommand cmdActualizarStock = new OleDbCommand(sqlActualizarStock, conexion);
                    cmdActualizarStock.Parameters.AddWithValue("?", cantidad);
                    cmdActualizarStock.Parameters.AddWithValue("?", productoID);
                    cmdActualizarStock.ExecuteNonQuery();

                    MessageBox.Show("¡Venta cargada con éxito!");
                }
                else
                {
                    MessageBox.Show("No hay suficiente stock para realizar la venta.");
                }

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void ConsultaVenta(DataGridView Grilla, ComboBox combo, MonthCalendar dtpFecha)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader dr = comando.ExecuteReader();

                Monto = 0; 
                Cantidad = 0;
                Grilla.Rows.Clear();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (combo.SelectedValue?.ToString() == dr.GetString(2))
                        {
                            if (dtpFecha.SelectionStart.Date == dr.GetDateTime(1).Date) 
                            {
                                int idVenta = dr.GetInt32(0);
                                DateTime fecha = dr.GetDateTime(1);
                                string mediodepago = dr.GetString(2);
                                string montototal = dr[3].ToString();
                                int idProducto = dr.GetInt32(4);
                                int cantidad = dr.GetInt32(5);

                                double monto = 0;
                                double.TryParse(montototal, out monto);

                                Grilla.Rows.Add(idVenta, fecha, mediodepago, monto.ToString("C"), idProducto, cantidad);
                                Cantidad++;
                                Monto = Monto + monto;
                            }
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
        public void GenerarReporte(ComboBox combo, MonthCalendar dtpFecha)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader dr = comando.ExecuteReader();

                StreamWriter ad = new StreamWriter("ReporteVentas.csv", false);
                ad.WriteLine("Listado de Ventas\n");
                ad.WriteLine("Codigo venta; Fecha; Medio de pago; Monto total; Codigo producto; Cantidad vendida\n");

                Monto = 0;
                Cantidad = 0;
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (combo.SelectedValue?.ToString() == dr.GetString(2) && dtpFecha.SelectionStart.Date == dr.GetDateTime(1).Date)
                        {
                            int idVenta = dr.GetInt32(0);
                            DateTime fecha = dr.GetDateTime(1);
                            string mediodepago = dr.GetString(2);
                            string montototal = dr[3].ToString();
                            int idProducto = dr.GetInt32(4);
                            int cantidad = dr.GetInt32(5);

                            double monto = 0;
                            double.TryParse(montototal, out monto);

                            ad.Write(idVenta);
                            ad.Write(";");
                            ad.Write(fecha);
                            ad.Write(";");
                            ad.Write(mediodepago);
                            ad.Write(";");
                            ad.Write(monto.ToString("C"));
                            ad.Write(";");
                            ad.Write(idProducto);
                            ad.Write(";");
                            ad.WriteLine(cantidad);

                            Cantidad++;
                            Monto = Monto + monto;
                        }
                    }
                    ad.WriteLine(";");
                    ad.Write("Cantidad de ventas:;;");
                    ad.WriteLine(Cantidad);
                    ad.WriteLine(";");
                    ad.Write("Monto total de ventas:;;");
                    ad.WriteLine(Monto);
                }
                conexion.Close();
                ad.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
        public void Graficar(Chart grafico)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                string consulta = "SELECT Fecha, SUM(MontoTotal) as Total FROM Ventas GROUP BY Fecha ORDER BY Fecha";

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = consulta;

                DataTable tabla = new DataTable();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tabla);

                grafico.Series.Clear();
                Series serie = new Series("Importe por Fecha");
                serie.ChartType = SeriesChartType.Column;
                serie.Color = Color.Red;

                foreach (DataRow fila in tabla.Rows)
                {
                    DateTime fecha = Convert.ToDateTime(fila["Fecha"]);
                    Int32 total = Convert.ToInt32(fila["Total"]);

                    serie.Points.AddXY(fecha.ToShortDateString(), total);

                }
                grafico.Series.Add(serie);

                grafico.ChartAreas[0].AxisX.Interval = 1;

                grafico.ChartAreas[0].AxisX.Title = "Fecha";
                grafico.ChartAreas[0].AxisY.Title = "Importe";

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void GraficarPorFecha(Chart grafico, DateTimePicker dtpDesde, DateTimePicker dtpHasta, Label lblTotal)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                string consulta = "SELECT Fecha, SUM(MontoTotal) as Total " +
                                  "FROM Ventas " +
                                  "WHERE Fecha BETWEEN ? AND ? " +
                                  "GROUP BY Fecha " +
                                  "ORDER BY Fecha";

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = consulta;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("?", dtpDesde.Value.Date);
                comando.Parameters.AddWithValue("?", dtpHasta.Value.Date);

                DataTable tabla = new DataTable();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tabla);

                grafico.Series.Clear();

                Series serie = new Series("Importe por Fecha");
                serie.ChartType = SeriesChartType.Column;
                serie.Color = Color.Red;
                serie.BorderWidth = 2;
                serie.IsValueShownAsLabel = true;
                serie.LabelForeColor = Color.Black;

                int totalGeneral = 0;

                foreach (DataRow fila in tabla.Rows)
                {
                    DateTime fecha = Convert.ToDateTime(fila["Fecha"]);
                    Int32 total = Convert.ToInt32(fila["Total"]);

                    totalGeneral += total;

                    serie.Points.AddXY(fecha.ToShortDateString(), total);
                }

                grafico.Series.Add(serie);

                ChartArea area = grafico.ChartAreas[0];
                area.AxisX.Interval = 1;
                area.AxisX.Title = "Fecha";
                area.AxisY.Title = "Importe";
                area.BackColor = Color.WhiteSmoke;
                area.AxisX.MajorGrid.LineColor = Color.LightGray;
                area.AxisY.MajorGrid.LineColor = Color.LightGray;

                lblTotal.Text = $"Total del período: ${totalGeneral}";

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }







    }
}
