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
using Capa_dominio.Negocio;

namespace Capa_presentacion
{
    public partial class PantallaCajaPorDia : Form
    {
        float totalDia = 0;
        string fecha;

        public PantallaCajaPorDia()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            txtFecha.Value = DateTime.Now;

            //Config para no poder seleccionar ninguna fila
            dgvCaja.ReadOnly = true; // Hace que el DataGridView sea de solo lectura
            dgvCaja.AllowUserToAddRows = false; // Evita que se puedan agregar filas nuevas
            // Manejar eventos para evitar que las celdas se seleccionen
            dgvCaja.CellClick += (sender, e) =>
            {
                dgvCaja.ClearSelection(); // Limpiar la selección después de hacer clic en una celda
            };

            dgvCaja.RowStateChanged += (sender, e) =>
            {
                if (e.StateChanged == DataGridViewElementStates.Selected)
                {
                    dgvCaja.ClearSelection(); // Limpiar la selección si se selecciona una fila
                }
            };
        }

        public void getData()
        {
            ReciboNegocio rn = new ReciboNegocio();

            txtSaldo.Text = "Saldo: $ ";

            fecha = txtFecha.Value.ToShortDateString();

            DataTable dt = rn.detalleCajaPorDia(fecha);

            dt.Columns["ingresos"].ColumnName = "ingresos_clon";
            dt.Columns.Add("ingresos", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                row["ingresos"] = row["ingresos_clon"].ToString();
            }

            dt.Columns["ingresos"].SetOrdinal(1);
            dt.Columns["ingresos_clon"].SetOrdinal(3);

            dt.Columns.RemoveAt(3);

            dt.Columns["egresos"].ColumnName = "egresos_clon";
            dt.Columns.Add("egresos", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                row["egresos"] = row["egresos_clon"].ToString();
            }

            dt.Columns["egresos"].SetOrdinal(2);
            dt.Columns["egresos_clon"].SetOrdinal(3);

            dt.Columns.RemoveAt(3);

            dgvCaja.DataSource = dt;

            dgvCaja.Columns[0].HeaderText = "Descripcion";
            dgvCaja.Columns[1].HeaderText = "Ingreso";
            dgvCaja.Columns[2].HeaderText = "Egreso";

            //Lleno los campos vacios
            foreach (DataGridViewRow row in dgvCaja.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null || cell.Value.ToString().Length == 0)
                        {
                            cell.Value = "-";
                        }
                        else
                        {
                            if (cell.ColumnIndex == 1)
                            {
                                cell.Style.BackColor = Color.LightGreen;
                            }

                            if (cell.ColumnIndex == 2)
                            {
                                cell.Style.BackColor = Color.IndianRed;
                            }
                        }
                    }
                }
            }

            totalDia = rn.getSaldoPorDia(fecha);

            txtSaldo.Text = txtSaldo.Text + totalDia;
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

        private void txtFecha_ValueChanged(object sender, EventArgs e)
        {      
            getData();
        }

        private void PantallaCajaPorDia_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}

