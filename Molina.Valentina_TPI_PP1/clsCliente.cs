using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Molina.Valentina_TPI_PP1
{
    internal class clsCliente
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=AjoYCo.mdb";
        private string Tabla = "Clientes";

        private Int32 idCli;
        private Int32 dni;
        private Int32 tel;
        private string domic;
        private string nomb;
        private string corr;

        public Int32 idCliente
        {
            get { return idCli; }
            set { idCli = value; }
        }
        public Int32 DNI
        {
            get { return dni; }
            set { dni = value; }
        }
        public Int32 Telefono
        {
            get { return tel; }
            set { tel = value; }
        }
        public string Domicilio
        {
            get { return domic; }
            set { domic = value; }
        }
        public string NombreCompleto
        {
            get { return nomb; }
            set { nomb = value; }
        }
        public string CorreoElectronico
        {
            get { return corr; }
            set { corr = value; }
        }


        public void AgregarCliente(TextBox txtDNI, TextBox txtDomicilio, TextBox txtNombreCompleto, TextBox txtCorreoElectronico)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Clientes"; 

                adaptador = new OleDbDataAdapter(comando);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptador); 

                DataSet ds = new DataSet();
                adaptador.Fill(ds, "Clientes");

                DataTable tabla = ds.Tables["Clientes"];
                DataRow fila = tabla.NewRow();

                int dni = Convert.ToInt32(txtDNI.Text);
                fila["DNI"] = dni;
                fila["Domicilio"] = txtDomicilio.Text;
                fila["NombreCompleto"] = txtNombreCompleto.Text;
                fila["CorreoElectronico"] = txtCorreoElectronico.Text;

                tabla.Rows.Add(fila);

                adaptador.Update(ds, "Clientes");

                MessageBox.Show("Cliente ingresado con éxito");

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }
        public void Imprimir(PrintPageEventArgs Reporte, ComboBox comboClientes)
        {
            try
            {
                Font Titulo1 = new Font("Calibri", 20, FontStyle.Bold);
                Font Titulo2 = new Font("Calibri", 10, FontStyle.Bold);
                Font tipoLetra = new Font("Calibri", 8);

                Int32 linea = 100;
                Int32 columna1 = 100;
                Int32 columna2 = 220;
                Int32 columna3 = 360;

                Reporte.Graphics.DrawString("FACTURA CONSUMIDOR FINAL", Titulo1, Brushes.HotPink, 100, 45);
                Reporte.Graphics.DrawString("Codigo factura", Titulo2, Brushes.LightPink, columna1, 75);
                Reporte.Graphics.DrawString("Monto final", Titulo2, Brushes.LightPink, columna2, 75);
                Reporte.Graphics.DrawString("Codigo cliente", Titulo2, Brushes.LightPink, columna3, 75);

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Facturas";

                adaptador = new OleDbDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds, "Facturas");

                int idClienteSeleccionado = Convert.ToInt32(comboClientes.SelectedValue);

                foreach (DataRow row in ds.Tables["Facturas"].Rows)
                {
                    int idFacturaCliente = Convert.ToInt32(row["IdCliente"]);

                    if (idFacturaCliente == idClienteSeleccionado)
                    {
                        Reporte.Graphics.DrawString(row["IdFactura"].ToString(), tipoLetra, Brushes.Black, columna1, linea);
                        Reporte.Graphics.DrawString(row["MontoTotal"].ToString(), tipoLetra, Brushes.Black, columna2, linea);
                        Reporte.Graphics.DrawString(row["IdCliente"].ToString(), tipoLetra, Brushes.Black, columna3, linea);

                        linea += 15;
                    }
                }

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void AgregarFactura(TextBox txtMontoTotal, ComboBox comboCliente)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Facturas";

                adaptador = new OleDbDataAdapter(comando);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptador);

                DataSet ds = new DataSet();
                adaptador.Fill(ds, "Facturas");

                DataTable tabla = ds.Tables["Facturas"];
                DataRow fila = tabla.NewRow();

                // Monto total
                decimal monto = Convert.ToDecimal(txtMontoTotal.Text);
                fila["MontoTotal"] = monto;

                var clienteID = comboCliente.SelectedValue;
                fila["IdCliente"] = clienteID;

                tabla.Rows.Add(fila);

                adaptador.Update(ds, "Facturas");

                MessageBox.Show("Factura ingresada con éxito");

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
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
                Combo.DisplayMember = "NombreCompleto";
                Combo.ValueMember = "IdCliente";
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }




    }
}
