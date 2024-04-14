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

namespace Capa_presentacion
{
    public partial class PanelClientes : Form
    {

        ClienteNegocio cn = new ClienteNegocio();

        bool edit = false;
        bool nuevo = false;

        public PanelClientes()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Cargo la grilla con los clientes
        private void getData()
        {
            //Si no creo pern en este entorno me carga los datos varias veces idk
            ClienteNegocio cli = new ClienteNegocio();
            dgvDatos.DataSource = cli.GetClientes();

            dgvDatos.Columns[0].HeaderText = "ID";
            dgvDatos.Columns[1].HeaderText = "Nombre";
            dgvDatos.Columns[2].HeaderText = "Direccion";
            dgvDatos.Columns[3].HeaderText = "Localidad";
            dgvDatos.Columns[4].HeaderText = "Cod. Postal";
            dgvDatos.Columns[5].HeaderText = "Telefono";
            dgvDatos.Columns[6].HeaderText = "Cuit";
            dgvDatos.Columns[7].HeaderText = "Categoria";
            dgvDatos.Columns[8].HeaderText = "Provincia";

            //Lleno los campos vacios y muestro la categoria completa
            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value.ToString().Length == 0)
                        {

                            cell.Value = "-";
                        }
                        if (cell.ColumnIndex == 7)
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
                    }
                }
            }

        }

        private void activarInputs()
        {
            txtNombre.Enabled = true;
            txtLocalidad.Enabled = true;
            txtDireccion.Enabled = true;
            txtCodPostal.Enabled = true;
            txtTelefono.Enabled = true;
            txtCuit.Enabled = true;
            txtProvincia.Enabled = true;
            cbCategoria.Enabled = true;
        }

        private void desactivarInputs()
        {
            txtNombre.Enabled = false;
            txtLocalidad.Enabled = false;
            txtDireccion.Enabled = false;
            txtCodPostal.Enabled = false;
            txtTelefono.Enabled = false;
            txtCuit.Enabled = false;
            txtProvincia.Enabled = false;
            cbCategoria.Enabled = false;
        }

        private void llenarInputs()
        {
            txtNombre.Text = dgvDatos.CurrentRow.Cells[1].Value.ToString(); ;
            txtLocalidad.Text = dgvDatos.CurrentRow.Cells[2].Value.ToString();
            txtDireccion.Text = dgvDatos.CurrentRow.Cells[3].Value.ToString();
            txtCodPostal.Text = dgvDatos.CurrentRow.Cells[4].Value.ToString();
            txtTelefono.Text = dgvDatos.CurrentRow.Cells[5].Value.ToString();
            txtCuit.Text = dgvDatos.CurrentRow.Cells[6].Value.ToString();
            cbCategoria.Text = dgvDatos.CurrentRow.Cells[7].Value.ToString();
            txtProvincia.Text = dgvDatos.CurrentRow.Cells[8].Value.ToString();
        }

        private void limpiarInputs()
        {
            txtNombre.Text = "";
            txtLocalidad.Text = "";
            txtDireccion.Text = "";
            txtCodPostal.Text = "";
            txtTelefono.Text = "";
            txtCuit.Text = "";
            txtProvincia.Text = "";
        }

        private void Home_Load(object sender, EventArgs e)
        {
            cbCategoria.SelectedIndex = 0;
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

        private void handleNuevoUsuario()
        {
            if (nuevo)
            {
                limpiarInputs();
                desactivarInputs();
                btnModificar.Enabled = true;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = true;
                btnReciboPorMes.Enabled = true;
                btnCrearRecibo.Enabled = true;
                btnNuevo.Text = "Nuevo";
                btnNuevo.FillColor = Color.CornflowerBlue;
            }
            else
            {
                activarInputs();
                btnModificar.Enabled = false;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = false;
                btnCrearRecibo.Enabled = false;
                btnReciboPorMes.Enabled = false;
                btnNuevo.Text = "Cancelar";
                btnNuevo.FillColor = Color.IndianRed;
                txtNombre.Focus();
            }

            nuevo = !nuevo;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            handleNuevoUsuario();
        }

        private void handleModificarUsuario()
        {
            if (edit)
            {
                limpiarInputs();
                desactivarInputs();
                dgvDatos.Enabled = true;
                btnModificar.Text = "Modificar";
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEliminar.Enabled = true;
                btnCrearRecibo.Enabled = true;
                btnReciboPorMes.Enabled = true;
                btnModificar.FillColor = Color.CornflowerBlue;
                dgvDatos.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            }
            else
            {
                activarInputs();
                llenarInputs();
                dgvDatos.Enabled = false;
                btnGuardar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEliminar.Enabled = false;
                btnCrearRecibo.Enabled = false;
                btnReciboPorMes.Enabled = false;
                btnModificar.Text = "Cancelar";
                btnModificar.FillColor = Color.IndianRed;
                dgvDatos.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
                txtNombre.Focus();
            }

            edit = !edit;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) { MessageBox.Show("No hay ningun usuario seleccionado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                handleModificarUsuario();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) { MessageBox.Show("No hay ningun usuario seleccionado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {

                string nombre = dgvDatos.CurrentRow.Cells[1].Value.ToString();

                DialogResult respuesta = MessageBox.Show("Seguro que desea borrar al usuario " + nombre + "?", "Confirmar eliminacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                {
                    try
                    {
                        cn.EliminarCliente(dgvDatos.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("Usuario eliminado con exito");
                        getData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string localidad = txtLocalidad.Text;
            string codPostal = txtCodPostal.Text;
            string telefono = txtTelefono.Text;
            string cuit = txtCuit.Text;
            string categoria = cbCategoria.Text;
            string provincia = txtProvincia.Text;

            if (nombre.Length == 0)
            {
                MessageBox.Show("No se puede guardar un cliente sin nombre!", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (nuevo)
                {
                    try
                    {
                        cn.CrearCliente(nombre, direccion, localidad, codPostal, telefono, cuit, provincia, categoria);
                        MessageBox.Show("Usuario cargado con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        handleNuevoUsuario();
                        getData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al crear usuario: " + ex.Message.ToString(), "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (edit)
                {
                    int id_cliente = Int32.Parse(dgvDatos.CurrentRow.Cells[0].Value.ToString());
                    try
                    {
                        cn.ModificarCliente(id_cliente, nombre, direccion, localidad, codPostal, telefono, cuit, provincia, categoria);
                        MessageBox.Show("Usuario modificado con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        handleModificarUsuario();
                        getData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar usuario: " + ex.Message.ToString(), "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCrearRecibo_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) { MessageBox.Show("No hay ningun usuario seleccionado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {

                int id_cliente = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
                string nombre = dgvDatos.CurrentRow.Cells["nombre"].Value.ToString();
                //string direccion = dgvDatos.CurrentRow.Cells[2].Value.ToString();
                string localidad = dgvDatos.CurrentRow.Cells["localidad"].Value.ToString();
                //string codPostal = dgvDatos.CurrentRow.Cells[4].Value.ToString();
                string telefono = dgvDatos.CurrentRow.Cells["telefono"].Value.ToString();
                string cuit = dgvDatos.CurrentRow.Cells["cuit"].Value.ToString();
                string categoria = dgvDatos.CurrentRow.Cells["categoria"].Value.ToString();
                string provincia = dgvDatos.CurrentRow.Cells["provincia"].Value.ToString();

                //per.ID = id_cliente;
                //per.Nombre = nombre;
                //per.Localidad = localidad == "-" ? null : localidad;
                //per.Direccion = direccion == "-" ? null : direccion;
                //per.CodPostal = codPostal == "-" ? null : codPostal;
                //per.Telefono = telefono == "-" ? null : telefono;
                //per.Cuit = cuit == "-" ? null : cuit;
                //switch (categoria)
                //{
                //    case "Responsable inscripto":
                //        per.Categoria = Persona.CategoriaCliente.ResponsableInscripto; break;
                //    case "Monotributo":
                //        per.Categoria = Persona.CategoriaCliente.Monotributo; break;
                //    case "Exento":
                //        per.Categoria = Persona.CategoriaCliente.Exento; break;
                //    case "Consumidor final":
                //        per.Categoria = Persona.CategoriaCliente.ConsumidorFinal; break;
                //}
                //per.Provincia = provincia == "-" ? null : provincia;

                PantallaRecibos pr = new PantallaRecibos(id_cliente, nombre, localidad, telefono, cuit, categoria, provincia);
                pr.ShowDialog();
            }
        }

        private void btnReciboPorMes_Click(object sender, EventArgs e)
        {
            Recibos_Mensuales rm = new Recibos_Mensuales();
            rm.ShowDialog();
        }
    }
}
