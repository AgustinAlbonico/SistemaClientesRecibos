using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_negocio.Negocio;
using System.Windows.Forms;
using Capa_entidades.Entidades;

namespace Capa_presentacion
{
    public partial class PantallaRecibos : Form
    {
        ReciboNegocio rn = new ReciboNegocio();
        
        ReciboEntity re = new ReciboEntity();

        public PantallaRecibos(int id_cliente, string nombre, string localidad, string telefono, string cuit, string categoria, string provincia)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
            lblId.Text += id_cliente.ToString();
            lblNombre.Text += nombre;
            lblLocalidad.Text += localidad + ", " + provincia;
            lblTelefono.Text += telefono;
            lblCuit.Text += cuit;
            lblCategoria.Text += categoria;

            DateTime fechaActual = DateTime.Now;

            int mesActual = fechaActual.Month;
            if (mesActual != 1)
            { txtMes.Text = (mesActual - 1).ToString(); }
            else
            {
                txtMes.Text = 12.ToString();
            }
            txtAnio.Text = fechaActual.Year.ToString();
            
            re.Cliente.ID = id_cliente;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            if (Int16.Parse(txtMes.Text) < 1 || Int16.Parse(txtMes.Text) > 12)
            {
                MessageBox.Show("El mes ingresado no es valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int parsedValue;
                if (!int.TryParse(txtAnio.Text, out parsedValue))
                {
                    MessageBox.Show("El año ingresado no es valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    float parsedValueFloat;
                    if(!float.TryParse(txtImporte.Text, out parsedValueFloat))
                    {
                        MessageBox.Show("El importe ingresado no es valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        re.Mes = Int16.Parse(txtMes.Text);
                        re.Anio = Int16.Parse(txtAnio.Text);
                        re.Importe = float.Parse(txtImporte.Text);
                        re.Descripcion = txtDescripcion.Text.ToUpper();

                        DataTable dataRecibo = rn.crearYDevolverRecibo(re);

                        //Modifico algunos campos para mostrarlos
                        ////Formateo el nro de la factura(Creo que es mejor crear un campo string en la bd y listo)
                        //////(Lo termine arreglando desde el report de crystal report)
                        //string nroFormated = dataRecibo.Rows[0]["nro_recibo"].ToString().PadLeft(8, '0');

                        //dataRecibo.Columns.Remove("nro_recibo");
                        //dataRecibo.Columns.Add("nro_recibo", typeof(string));

                        //dataRecibo.Rows[0]["nro_recibo"] = nroFormated;

                        //Muestro bien la categoria
                        string categoriaFormated = "";
                        switch (dataRecibo.Rows[0]["categoria"])
                        {
                            case "M": categoriaFormated = "MONOTRIBUTO"; break;
                            case "R": categoriaFormated = "RESPONSABLE INSCRIPTO"; break;
                            case "E": categoriaFormated = "EXENTO"; break;
                            case "C": categoriaFormated = "CONSUMIDOR FINAL"; break;
                        }
                        dataRecibo.Rows[0]["categoria"] = categoriaFormated;

                        Recibo reciboForm = new Recibo(dataRecibo);
                        reciboForm.ShowDialog();

                        this.Dispose();
                    }
                }
            }
        }
    }
}
