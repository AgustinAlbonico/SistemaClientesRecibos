using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_presentacion
{
    public partial class Recibo : Form
    {

        //Para crear el reporte uso el dataset, desde crystal report de fuente de datos uso el dataset.
        //Desde la capa de datos traigo una tabla, en este caso uso un stored procedure

        public Recibo(DataTable dataForm)
        {
            Console.WriteLine(dataForm.Rows.Count);
            InitializeComponent();
            Reporte rep = new Reporte();
            rep.Database.Tables["DatatableRecibo"].SetDataSource(dataForm);

            reporteCrystal.ReportSource = null;
            reporteCrystal.ReportSource = rep;
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

        private void Recibo_Load(object sender, EventArgs e)
        {

        }
    }
}
