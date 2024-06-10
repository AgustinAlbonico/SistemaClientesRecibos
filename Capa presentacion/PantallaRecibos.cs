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
using System.Globalization;

namespace Capa_presentacion
{
    public partial class PantallaRecibos : Form
    {
        ReciboNegocio rn = new ReciboNegocio();

        ReciboEntity re = new ReciboEntity();

        int cantLineas = 1;

        bool error = false;

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
            { txtMesLineaUno.Text = (mesActual - 1).ToString(); }
            else
            {
                txtMesLineaUno.Text = 12.ToString();
            }
            txtAnioLineaUno.Text = fechaActual.Year.ToString();

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

        private void guardarDatos()
        {
            re.LineaUno = txtLineaUno.Text.ToUpper();
            re.MesLineaUno = Int16.Parse(txtMesLineaUno.Text);
            re.AnioLineaUno = Int16.Parse(txtAnioLineaUno.Text);
            if (cantLineas > 1)
            {
                if (cantLineas == 2)
                {
                    re.LineaDos = txtLineaDos.Text.ToUpper();
                    re.MesLineaDos = Int16.Parse(txtMesLineaDos.Text);
                    re.AnioLineaDos = Int16.Parse(txtAnioLineaDos.Text);
                }
                if (cantLineas == 3)
                {
                    re.LineaTres = txtLineaTres.Text.ToUpper();
                    re.MesLineaDos = Int16.Parse(txtMesLineaTres.Text);
                    re.AnioLineaTres = Int16.Parse(txtAnioLineaTres.Text);
                }
            }
            re.Importe = float.Parse(txtImporte.Text, CultureInfo.InvariantCulture);


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

            Console.WriteLine(dataRecibo);

            Recibo reciboForm = new Recibo(dataRecibo);
            reciboForm.ShowDialog();

            btnImprimir.Enabled = true;

            this.Dispose();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                btnImprimir.Enabled = false;
                if (txtLineaUno.Text.Length == 0)
                {
                    MessageBox.Show("Descripcion linea uno vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                }
                else
                {
                    if (txtMesLineaUno.Text.Length == 0 || Int16.Parse(txtMesLineaUno.Text) < 1 || Int16.Parse(txtMesLineaUno.Text) > 12)
                    {
                        MessageBox.Show("El mes ingresado no es valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        error = true;
                    }
                    else
                    {
                        int parsedValue;
                        if (!int.TryParse(txtAnioLineaUno.Text, out parsedValue))
                        {
                            MessageBox.Show("El año ingresado no es valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            error = true;
                        }
                        else
                        {
                            float parsedValueFloat;
                            if (!float.TryParse(txtImporte.Text, out parsedValueFloat))
                            {
                                MessageBox.Show("El importe ingresado no es valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                error = true;
                            }
                            else
                            {
                                if (cantLineas > 1)
                                {
                                    if (txtLineaDos.Text.Length == 0)
                                    {
                                        MessageBox.Show("Descripcion linea dos vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        error = true;
                                    }
                                    else
                                    {
                                        if (txtMesLineaDos.Text.Length == 0 || Int16.Parse(txtMesLineaDos.Text) < 1 || Int16.Parse(txtMesLineaDos.Text) > 12)
                                        {
                                            MessageBox.Show("El mes ingresado en la linea dos no es valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            error = true;
                                        }
                                        else
                                        {
                                            int parsedAnioLineaDos;
                                            if (!int.TryParse(txtAnioLineaDos.Text, out parsedAnioLineaDos))
                                            {
                                                MessageBox.Show("El año ingresado en la linea dos no es valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                error = true;
                                            }
                                            if (cantLineas == 3)
                                            {
                                                if (txtLineaTres.Text.Length == 0)
                                                {
                                                    MessageBox.Show("Descripcion linea tres vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    error = true;
                                                }
                                                else
                                                {
                                                    if (txtMesLineaTres.Text.Length == 0 || Int16.Parse(txtMesLineaTres.Text) < 1 || Int16.Parse(txtMesLineaTres.Text) > 12)
                                                    {
                                                        MessageBox.Show("El mes ingresado en la linea dos no es valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        error = true;
                                                    }
                                                    else
                                                    {
                                                        int parsedAnioLineaTres;
                                                        if (!int.TryParse(txtAnioLineaTres.Text, out parsedAnioLineaTres))
                                                        {
                                                            MessageBox.Show("El año ingresado en la linea tres no es valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            error = true;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                btnImprimir.Enabled = true;
                if(!error)
                {
                    guardarDatos();
                }
                else
                {
                    error = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnImprimir.Enabled = true;
            }
        }



        private void btnAgregarLinea_Click(object sender, EventArgs e)
        {
            cantLineas++;
            switch (cantLineas)
            {
                case 2:
                    lblLineaDos.Visible = true;
                    txtLineaDos.Visible = true;
                    txtLineaDos.Enabled = true;
                    txtMesLineaDos.Visible = true;
                    txtMesLineaDos.Enabled = true;
                    txtAnioLineaDos.Visible = true;
                    txtAnioLineaDos.Enabled = true;
                    break;
                case 3:
                    lblLineaTres.Visible = true;
                    txtLineaTres.Visible = true;
                    txtLineaTres.Enabled = true;
                    txtMesLineaTres.Visible = true;
                    txtMesLineaTres.Enabled = true;
                    txtAnioLineaTres.Visible = true;
                    txtAnioLineaTres.Enabled = true;
                    btnAgregarLinea.Enabled = false;
                    break;
            }

        }
    }
}
