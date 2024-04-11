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

namespace Capa_presentacion
{
    public partial class Recibos_Mensuales : Form
    {

        int mesActual;
        int anioActual;

        public Recibos_Mensuales()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            DateTime fechaActual = DateTime.Now;

            mesActual = fechaActual.Month;
            anioActual = fechaActual.Year;
            if (mesActual != 1)
            { mesActual = mesActual - 1; }
            else
            {
                mesActual = 12;
            }

            txtMes.Text = mesActual.ToString();
            txtAnio.Text = anioActual.ToString();
        }
        private void Recibos_Mensuales_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            ReciboNegocio rn = new ReciboNegocio();
            DataTable recibosMesAnio = rn.recibosPorMesYAnio(mesActual, anioActual);
            recibosMesAnio.Columns["nro_comprobante"].ColumnName = "nro_comprobante_clon";
            recibosMesAnio.Columns.Add("nro_comprobante", typeof(string));
            foreach (DataRow row in recibosMesAnio.Rows)
            {
                row["nro_comprobante"] = row["nro_comprobante_clon"].ToString();
            }

            recibosMesAnio.Columns["nro_comprobante"].SetOrdinal(5);
            recibosMesAnio.Columns["nro_comprobante_clon"].SetOrdinal(9);

            recibosMesAnio.Columns.RemoveAt(9);

            dgvRecibos.DataSource = recibosMesAnio;

            dgvRecibos.Columns[0].Visible = false;
            dgvRecibos.Columns[1].HeaderText = "ID Cliente";
            dgvRecibos.Columns[2].HeaderText = "Cliente";
            dgvRecibos.Columns[3].HeaderText = "Cuit";
            dgvRecibos.Columns[4].HeaderText = "Categoria";
            dgvRecibos.Columns[5].HeaderText = "Nro. Recibo";
            dgvRecibos.Columns[6].HeaderText = "Fecha de emisión";
            dgvRecibos.Columns[7].HeaderText = "Descripción";
            dgvRecibos.Columns[8].HeaderText = "Importe";

            //Lleno los campos vacios y muestro la categoria completa
            foreach (DataGridViewRow row in dgvRecibos.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value.ToString().Length == 0)
                        {
                            cell.Value = "-";
                        }
                        if (cell.ColumnIndex == 4)
                        {
                            //Deberia usar el enum de persona.categoria pero no se como ya que no me coinciden los tipos
                            switch (cell.Value)
                            {
                                case "M":
                                    cell.Value = "Monotributo";
                                    break;
                                case "R":
                                    cell.Value = "Responsable inscripto";
                                    break;
                                case "E":
                                    cell.Value = "Exento";
                                    break;
                                case "C":
                                    cell.Value = "Consumidor final";
                                    break;
                            }
                        }
                        if (cell.ColumnIndex == 5)
                        {
                            cell.Value = "0000-" + cell.Value.ToString().PadLeft(8, '0');
                        }
                        if (cell.ColumnIndex == 7)
                        {
                            cell.Value = "HONORARIOS " + cell.Value;
                        }
                    }
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
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

                    if (dgvRecibos.Rows.Count == 0) { MessageBox.Show("No hay recibos emitidos para el mes y año seleccionados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                btnImprimir.Enabled = false;
                ReciboNegocio rn = new ReciboNegocio();
                if (dgvRecibos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No hay ningun recibo seleccionado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int id_recibo = Int16.Parse(dgvRecibos.CurrentRow.Cells[0].Value.ToString());
                    DataTable recibo = rn.getRecibo(id_recibo);

                    string categoriaFormated = "";
                    switch (recibo.Rows[0]["categoria"])
                    {
                        case "M": categoriaFormated = "MONOTRIBUTO"; break;
                        case "R": categoriaFormated = "RESPONSABLE INSCRIPTO"; break;
                        case "E": categoriaFormated = "EXENTO"; break;
                        case "C": categoriaFormated = "CONSUMIDOR FINAL"; break;
                    }
                    recibo.Rows[0]["categoria"] = categoriaFormated;

                    Recibo r = new Recibo(recibo);
                    r.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnImprimir.Enabled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtMes_Enter(object sender, EventArgs e)
        {
            txtMes.SelectionStart = txtMes.Text.Length;
            txtMes.SelectionLength = 0;
        }

        private void txtAnio_Enter(object sender, EventArgs e)
        {
            txtAnio.SelectionStart = txtAnio.Text.Length;
            txtAnio.SelectionLength = 0;
        }
    }
}
