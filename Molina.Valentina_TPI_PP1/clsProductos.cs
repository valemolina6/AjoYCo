using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Drawing;

namespace Molina.Valentina_TPI_PP1
{
    internal class clsProductos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=AjoYCo.mdb";
        private string Tabla = "Productos";

        private Int32 stock;
        private Int32 idProd;
        private String nom;
        private Int32 prec;
        private Int32 cant;

        public Int32 Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public Int32 idProducto
        {
            get { return idProd; }
            set { idProd = value; }
        }
        public String NombreProducto
        {
            get { return nom; }
            set { nom = value; }
        }
        public Int32 PrecioProducto
        {
            get { return prec; }
            set { prec = value; }
        }
        public Int32 CantidadProducto
        {
            get { return cant; }
            set { cant = value; }
        }

        public void AgregarProducto()
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

                fila["Nombre"] = nom;
                fila["Precio"] = prec;
                fila["Cantidad"] = 0;

                tabla.Rows.Add(fila);
                OleDbCommandBuilder ConciliaCambios = new OleDbCommandBuilder(adaptador);
                adaptador.Update(ds, Tabla);
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void AgregarStockProducto(ComboBox combo, TextBox txtCantidad)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                int idProducto = Convert.ToInt32(combo.SelectedValue);
                int cantidadASumar = Convert.ToInt32(txtCantidad.Text);

                // Traer cantidad actual
                string consultaCantidad = $"SELECT Cantidad FROM Productos WHERE idProducto = {idProducto}";
                OleDbCommand cmdCantidad = new OleDbCommand(consultaCantidad, conexion);
                int cantidadActual = Convert.ToInt32(cmdCantidad.ExecuteScalar());

                // Nueva cantidad
                int nuevaCantidad = cantidadActual + cantidadASumar;

                // Actualizar
                string consultaUpdate = $"UPDATE Productos SET Cantidad = {nuevaCantidad} WHERE idProducto = {idProducto}";
                OleDbCommand cmdUpdate = new OleDbCommand(consultaUpdate, conexion);
                cmdUpdate.ExecuteNonQuery();

                MessageBox.Show("Stock actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar stock: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        public void Listar(ComboBox Combo)
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
                adaptador.Fill(ds);
                Combo.DataSource = ds.Tables[0];
                Combo.DisplayMember = "Nombre";
                Combo.ValueMember = "idProducto";
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }
        public void EliminarStockProducto(ComboBox combo, TextBox txtCantidad)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                int idProducto = Convert.ToInt32(combo.SelectedValue);
                int cantidadARestar = Convert.ToInt32(txtCantidad.Text);

                // Traer cantidad actual
                string consultaCantidad = $"SELECT Cantidad FROM Productos WHERE idProducto = {idProducto}";
                OleDbCommand cmdCantidad = new OleDbCommand(consultaCantidad, conexion);
                int cantidadActual = Convert.ToInt32(cmdCantidad.ExecuteScalar());

                // Verificar que no reste más de lo disponible
                if (cantidadARestar > cantidadActual)
                {
                    MessageBox.Show("No se puede eliminar más stock del disponible");
                    return;
                }

                // Nueva cantidad
                int nuevaCantidad = cantidadActual - cantidadARestar;

                // Actualizar
                string consultaUpdate = $"UPDATE Productos SET Cantidad = {nuevaCantidad} WHERE idProducto = {idProducto}";
                OleDbCommand cmdUpdate = new OleDbCommand(consultaUpdate, conexion);
                cmdUpdate.ExecuteNonQuery();

                MessageBox.Show("Stock eliminado correctamente 🗑️");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar stock: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        public void ConsultaStock(DataGridView Grilla, ComboBox combo)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader dr = comando.ExecuteReader();

                Grilla.Rows.Clear();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (Convert.ToInt32(combo.SelectedValue) == dr.GetInt32(0))
                        {
                            int id = dr.GetInt32(0);
                            string nombre = dr.GetString(1);            
                            int cantidad = dr.GetInt32(3);             
                            string precioTexto = dr[2].ToString();      

                            double precio = 0;
                            double.TryParse(precioTexto, out precio);  

                            Grilla.Rows.Add(id, nombre, precio.ToString("C"), cantidad); 
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
        public void GenerarReporte(ComboBox combo)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader dr = comando.ExecuteReader();

                StreamWriter ad = new StreamWriter("ReporteProductos.csv", false);
                ad.WriteLine("Listado de Productos\n");
                ad.WriteLine("Codigo;Nombre;Precio;Cantidad\n");

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (Convert.ToInt32(combo.SelectedValue) == dr.GetInt32(0))
                        {
                            int id = dr.GetInt32(0);
                            string nombre = dr.GetString(1);
                            int cantidad = dr.GetInt32(3);
                            string precioTexto = dr[2].ToString();

                            double precio = 0;
                            double.TryParse(precioTexto, out precio);

                            ad.Write(id);
                            ad.Write(";");
                            ad.Write(nombre);
                            ad.Write(";");
                            ad.Write(precio.ToString("C"));
                            ad.Write(";");
                            ad.WriteLine(cantidad);
                        }
                    }
                }
                conexion.Close();
                ad.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
        public void Imprimir(PrintPageEventArgs Reporte)
        {
            try
            {
                Font Titulo1 = new Font("Calibri", 20, FontStyle.Bold);
                Font Titulo2 = new Font("Calibri", 10, FontStyle.Bold);
                Font tipoLetra = new Font("Calibri", 8);

                Int32 linea = 100;
                Int32 columna1 = 105;
                Int32 columna2 = 185;
                Int32 columna3 = 355;
                Int32 columna4 = 485;

                Reporte.Graphics.DrawString("Listado de Stock", Titulo1, Brushes.HotPink, 100, 45);
                Reporte.Graphics.DrawString("Codigo", Titulo2, Brushes.LightPink, columna1, 75);
                Reporte.Graphics.DrawString("Nombre producto", Titulo2, Brushes.LightPink, columna2, 75);
                Reporte.Graphics.DrawString("Precio por unidad", Titulo2, Brushes.LightPink, columna3, 75);
                Reporte.Graphics.DrawString("Cantidad en stock", Titulo2, Brushes.LightPink, columna4, 75);

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Productos";

                adaptador = new OleDbDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds, "Productos");

                if (ds.Tables["Productos"].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables["Productos"].Rows)
                    {
                        Reporte.Graphics.DrawString(row["idProducto"].ToString(), tipoLetra, Brushes.Black, columna1, linea);
                        Reporte.Graphics.DrawString(row["Nombre"].ToString(), tipoLetra, Brushes.Black, columna2, linea);
                        Reporte.Graphics.DrawString(row["Precio"].ToString(), tipoLetra, Brushes.Black, columna3, linea);
                        Reporte.Graphics.DrawString(row["Cantidad"].ToString(), tipoLetra, Brushes.Black, columna4, linea);

                        linea += 15;

                    }
                }
                conexion.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


    }
}
