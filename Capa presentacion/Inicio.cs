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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnRecibos_Click(object sender, EventArgs e)
        {
            PanelClientes pc = new PanelClientes();
            pc.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            PantallaGastos pg = new PantallaGastos();
            pg.ShowDialog();
        }

        private void btnLibroDiario_Click(object sender, EventArgs e)
        {
            PantallaLibroDiario pld = new PantallaLibroDiario();
            pld.ShowDialog();
        }
    }
}
