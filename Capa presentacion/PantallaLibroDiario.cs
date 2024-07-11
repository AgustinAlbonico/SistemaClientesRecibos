using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_negocio.Negocio;
using Capa_entidades.Entidades;
using Capa_dominio.Negocio;

namespace Capa_presentacion
{
    public partial class PantallaLibroDiario : Form
    {

        GastoNegocio gn = new GastoNegocio();
        ReciboNegocio rn = new ReciboNegocio();

        int mesActual;
        int anioActual;

        float saldoMensual;

        public PantallaLibroDiario()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            DateTime fechaActual = DateTime.Now;

            mesActual = fechaActual.Month;
            anioActual = fechaActual.Year;

            //Config para no poder seleccionar ninguna fila
            dgvDatos.ReadOnly = true; // Hace que el DataGridView sea de solo lectura
            dgvDatos.AllowUserToAddRows = false; // Evita que se puedan agregar filas nuevas

            // Manejar eventos para evitar que las celdas se seleccionen
            dgvDatos.CellClick += (sender, e) =>
            {
                dgvDatos.ClearSelection(); // Limpiar la selección después de hacer clic en una celda
            };

            dgvDatos.RowStateChanged += (sender, e) =>
            {
                if (e.StateChanged == DataGridViewElementStates.Selected)
                {
                    dgvDatos.ClearSelection(); // Limpiar la selección si se selecciona una fila
                }
            };

        }

        public void getData()
        {
            GastoNegocio gn = new GastoNegocio();

            saldoMensual = 0;
            txtSaldoMes.Text = saldoMensual.ToString();
            txtMes.Text = mesActual.ToString();
            txtAnio.Text = anioActual.ToString();

            dgvDatos.DataSource = gn.ingresosEgresosPorDia(mesActual, anioActual);

            dgvDatos.Columns[0].HeaderText = "Fecha";
            dgvDatos.Columns[1].HeaderText = "Ingresos";
            dgvDatos.Columns[2].HeaderText = "Egresos";
            dgvDatos.Columns[3].HeaderText = "Saldo";

            //Lleno los campos vacios
            foreach (DataGridViewRow row in dgvDatos.Rows)
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
                            if (cell.ColumnIndex == 3)
                            {
                                if (float.Parse(cell.Value.ToString()) < 0)
                                {
                                    cell.Style.BackColor = Color.IndianRed;
                                }
                                else
                                {
                                    cell.Style.BackColor = Color.LightGreen;
                                }
                                saldoMensual += float.Parse(cell.Value.ToString());
                                
                            }
                        }

                    }
                }
            }
            saldoMensual = rn.getSaldoPorMesAnio(System.Int16.Parse(txtMes.Text), System.Int16.Parse(txtAnio.Text));
            txtSaldoMes.Text = saldoMensual.ToString();
            if (saldoMensual < 0)
            {
                txtSaldoMes.BackColor = Color.IndianRed;
            }
            else
            {
                txtSaldoMes.BackColor = Color.LightGreen;
            }
        }

        private void PantallaLibroDiario_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int16.Parse(txtMes.Text) < 1 || Int16.Parse(txtMes.Text) > 12)
                {
                    MessageBox.Show("El mes ingresado no es valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mesActual = Int16.Parse(txtMes.Text);
                    anioActual = Int16.Parse(txtAnio.Text);

                    getData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDatos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Lleno los campos vacios
            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {

                        if (cell.ColumnIndex == 3)
                        {
                            if (float.Parse(cell.Value.ToString()) < 0)
                            {
                                cell.Style.BackColor = Color.IndianRed;
                            }
                            else
                            {
                                cell.Style.BackColor = Color.LightGreen;
                            }
                        }
                    }


                }
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            PantallaCajaPorDia pcjpd = new PantallaCajaPorDia();
            pcjpd.ShowDialog();
        }
    }
}
