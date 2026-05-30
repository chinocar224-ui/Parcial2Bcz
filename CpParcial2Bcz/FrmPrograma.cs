using CadParcial2Bcz;
using ClnParcial2Bcz;
using System;
using System.Windows.Forms;

namespace CpParcial2Bcz
{
    public partial class FrmPrograma : Form
    {
        private bool esNuevo = false;

        public FrmPrograma()
        {
            InitializeComponent();
        }

        private void FrmPrograma_Load(object sender, EventArgs e)
        {
            listar();
            cargarCanales();
            cargarCategorias();
        }

        private void listar()
        {
            var lista = ProgramaCln.listar(txtParametro.Text);
            dgvLista.DataSource = lista;

            if (dgvLista.Columns.Contains("id"))                  dgvLista.Columns["id"].Visible                  = false;
            if (dgvLista.Columns.Contains("idCanal"))             dgvLista.Columns["idCanal"].Visible             = false;
            if (dgvLista.Columns.Contains("estado"))              dgvLista.Columns["estado"].Visible              = false;
            if (dgvLista.Columns.Contains("idCategoriaPrograma")) dgvLista.Columns["idCategoriaPrograma"].Visible = false;

            if (dgvLista.Columns.Contains("canal"))        dgvLista.Columns["canal"].HeaderText        = "Canal";
            if (dgvLista.Columns.Contains("titulo"))       dgvLista.Columns["titulo"].HeaderText       = "Título";
            if (dgvLista.Columns.Contains("descripcion"))  dgvLista.Columns["descripcion"].HeaderText  = "Descripción";
            if (dgvLista.Columns.Contains("duracion"))     dgvLista.Columns["duracion"].HeaderText     = "Duración (min)";
            if (dgvLista.Columns.Contains("productor"))    dgvLista.Columns["productor"].HeaderText    = "Productor";
            if (dgvLista.Columns.Contains("fechaEstreno")) dgvLista.Columns["fechaEstreno"].HeaderText = "Fecha de Estreno";
            if (dgvLista.Columns.Contains("categoria"))    dgvLista.Columns["categoria"].HeaderText    = "Categoría";

            bool hayRegistros = lista.Count > 0;
            if (hayRegistros) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["titulo"];
            btnEditar.Enabled   = hayRegistros;
            btnEliminar.Enabled = hayRegistros;
        }

        private void cargarCanales()
        {
            cbxCanal.DataSource    = CanalCln.listar();
            cbxCanal.ValueMember   = "id";
            cbxCanal.DisplayMember = "nombre";
            cbxCanal.SelectedIndex = -1;
        }

        private void cargarCategorias()
        {
            cbxCategoria.DataSource    = CategoriaProgramaCln.listar();
            cbxCategoria.ValueMember   = "id";
            cbxCategoria.DisplayMember = "nombre";
            cbxCategoria.SelectedIndex = -1;
        }

        private void limpiar()
        {
            txtTitulo.Clear();
            txtDescripcion.Clear();
            txtProductor.Clear();
            nudDuracion.Value      = 1;
            dtpFechaEstreno.Value  = DateTime.Today;
            cbxCanal.SelectedIndex     = -1;
            cbxCategoria.SelectedIndex = -1;
            resetearErrores();
        }

        private void resetearErrores()
        {
            erpTitulo.Clear();
            erpDescripcion.Clear();
            erpProductor.Clear();
            erpDuracion.Clear();
            erpCanal.Clear();
            erpCategoria.Clear();
        }

        private bool validar()
        {
            bool esValido = true;
            resetearErrores();

            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                erpTitulo.SetError(txtTitulo, "El Título es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                erpDescripcion.SetError(txtDescripcion, "La Descripción es obligatoria");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtProductor.Text))
            {
                erpProductor.SetError(txtProductor, "El Productor es obligatorio");
                esValido = false;
            }
            if (nudDuracion.Value <= 0)
            {
                erpDuracion.SetError(nudDuracion, "La Duración debe ser mayor a cero");
                esValido = false;
            }
            if (cbxCanal.SelectedIndex < 0)
            {
                erpCanal.SetError(cbxCanal, "Debe seleccionar un Canal");
                esValido = false;
            }
            if (cbxCategoria.SelectedIndex < 0)
            {
                erpCategoria.SetError(cbxCategoria, "Debe seleccionar una Categoría");
                esValido = false;
            }
            return esValido;
        }

        private void btnBuscar_Click(object sender, EventArgs e) => listar();

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            pnlAcciones.Enabled = false;
            pnlDetalle.Visible  = true;
            limpiar();
            txtTitulo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            pnlAcciones.Enabled = false;
            pnlDetalle.Visible  = true;
            resetearErrores();

            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            var programa = ProgramaCln.obtenerUno(id);

            txtTitulo.Text             = programa.titulo;
            txtDescripcion.Text        = programa.descripcion;
            txtProductor.Text          = programa.productor;
            nudDuracion.Value          = programa.duracion;
            dtpFechaEstreno.Value      = programa.fechaEstreno;
            cbxCanal.SelectedValue     = programa.idCanal;
            cbxCategoria.SelectedValue = programa.idCategoriaPrograma;
            txtTitulo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlAcciones.Enabled = true;
            pnlDetalle.Visible  = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;

            var programa = new Programa()
            {
                idCanal             = (int)cbxCanal.SelectedValue,
                titulo              = txtTitulo.Text.Trim(),
                descripcion         = txtDescripcion.Text.Trim(),
                duracion            = (int)nudDuracion.Value,
                productor           = txtProductor.Text.Trim(),
                fechaEstreno        = dtpFechaEstreno.Value.Date,
                idCategoriaPrograma = (int)cbxCategoria.SelectedValue
            };

            if (esNuevo)
                ProgramaCln.crear(programa);
            else
            {
                programa.id = (int)dgvLista.CurrentRow.Cells["id"].Value;
                ProgramaCln.modificar(programa);
            }

            listar();
            btnCancelar.PerformClick();
            MessageBox.Show("Programa guardado correctamente.",
                "::: Parcial2Bcz :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int    id     = (int)dgvLista.CurrentRow.Cells["id"].Value;
            string titulo = dgvLista.CurrentRow.Cells["titulo"].Value.ToString();

            var confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea eliminar \"{titulo}\"?",
                "::: Parcial2Bcz :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                ProgramaCln.eliminar(id);
                listar();
                MessageBox.Show("Programa eliminado correctamente.",
                    "::: Parcial2Bcz :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Close();
    }
}
