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
using Capa_negocio.Negocio;
using Capa_entidades.Entidades;
using Capa_dominio.Negocio;

namespace Capa_presentacion
{
    public partial class PantallaGastos : Form
    {

        GastoNegocio gn = new GastoNegocio();
        GastoEntity ge = new GastoEntity();

        public PantallaGastos()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            try
            {
                if (txtDescripcion.Text.Length == 0)
                {
                    MessageBox.Show("La descripción no puede estar vacía!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtImporte.Text.Length == 0)
                    {
                        MessageBox.Show("El importe no puede estar vacío!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        float parsedValueFloat;
                        if (!float.TryParse(txtImporte.Text, out parsedValueFloat))
                        {
                            MessageBox.Show("El importe ingresado no es valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ge.Fecha = txtFecha.Value;
                            ge.Descripcion = txtDescripcion.Text;
                            ge.Importe = float.Parse(txtImporte.Text, CultureInfo.InvariantCulture);

                            gn.crearGasto(ge);

                            txtDescripcion.Text = "";
                            txtImporte.Text = "";

                            MessageBox.Show("Gasto guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }
    }
}
