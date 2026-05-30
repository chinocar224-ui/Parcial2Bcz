namespace CpParcial2Bcz
{
    partial class FrmPrograma
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components      = new System.ComponentModel.Container();
            this.lblTitulo       = new System.Windows.Forms.Label();
            this.txtParametro    = new System.Windows.Forms.TextBox();
            this.btnBuscar       = new System.Windows.Forms.Button();
            this.dgvLista        = new System.Windows.Forms.DataGridView();
            this.btnNuevo        = new System.Windows.Forms.Button();
            this.btnEditar       = new System.Windows.Forms.Button();
            this.btnEliminar     = new System.Windows.Forms.Button();
            this.btnCerrar       = new System.Windows.Forms.Button();
            this.pnlDetalle      = new System.Windows.Forms.Panel();
            this.lblCanal        = new System.Windows.Forms.Label();
            this.cbxCanal        = new System.Windows.Forms.ComboBox();
            this.lblCategoria    = new System.Windows.Forms.Label();
            this.cbxCategoria    = new System.Windows.Forms.ComboBox();
            this.lblTituloField  = new System.Windows.Forms.Label();
            this.txtTitulo       = new System.Windows.Forms.TextBox();
            this.lblDescripcion  = new System.Windows.Forms.Label();
            this.txtDescripcion  = new System.Windows.Forms.TextBox();
            this.lblDuracion     = new System.Windows.Forms.Label();
            this.nudDuracion     = new System.Windows.Forms.NumericUpDown();
            this.lblProductor    = new System.Windows.Forms.Label();
            this.txtProductor    = new System.Windows.Forms.TextBox();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar      = new System.Windows.Forms.Button();
            this.btnCancelar     = new System.Windows.Forms.Button();
            this.erpTitulo       = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDescripcion  = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpProductor    = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDuracion     = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCanal        = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCategoria    = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlAcciones     = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCanal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCategoria)).BeginInit();
            this.pnlDetalle.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize  = false;
            this.lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTitulo.Location  = new System.Drawing.Point(12, 9);
            this.lblTitulo.Size      = new System.Drawing.Size(300, 28);
            this.lblTitulo.Text      = "Gestión de Programas";

            // txtParametro
            this.txtParametro.Location  = new System.Drawing.Point(12, 46);
            this.txtParametro.Size      = new System.Drawing.Size(300, 23);
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);

            // btnBuscar
            this.btnBuscar.Location = new System.Drawing.Point(320, 45);
            this.btnBuscar.Size     = new System.Drawing.Size(80, 25);
            this.btnBuscar.Text     = "Buscar";
            this.btnBuscar.Click   += new System.EventHandler(this.btnBuscar_Click);

            // dgvLista
            this.dgvLista.AllowUserToAddRows    = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ReadOnly              = true;
            this.dgvLista.SelectionMode         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.RowHeadersVisible     = false;
            this.dgvLista.BackgroundColor       = System.Drawing.Color.White;
            this.dgvLista.Location              = new System.Drawing.Point(12, 78);
            this.dgvLista.Size                  = new System.Drawing.Size(860, 200);

            // pnlAcciones
            this.pnlAcciones.Location = new System.Drawing.Point(12, 286);
            this.pnlAcciones.Size     = new System.Drawing.Size(860, 36);

            this.btnNuevo.Location  = new System.Drawing.Point(0, 4);
            this.btnNuevo.Size      = new System.Drawing.Size(80, 28);
            this.btnNuevo.Text      = "Nuevo";
            this.btnNuevo.Click    += new System.EventHandler(this.btnNuevo_Click);

            this.btnEditar.Enabled  = false;
            this.btnEditar.Location = new System.Drawing.Point(88, 4);
            this.btnEditar.Size     = new System.Drawing.Size(80, 28);
            this.btnEditar.Text     = "Editar";
            this.btnEditar.Click   += new System.EventHandler(this.btnEditar_Click);

            this.btnEliminar.Enabled  = false;
            this.btnEliminar.Location = new System.Drawing.Point(176, 4);
            this.btnEliminar.Size     = new System.Drawing.Size(80, 28);
            this.btnEliminar.Text     = "Eliminar";
            this.btnEliminar.Click   += new System.EventHandler(this.btnEliminar_Click);

            this.btnCerrar.Location = new System.Drawing.Point(780, 4);
            this.btnCerrar.Size     = new System.Drawing.Size(80, 28);
            this.btnCerrar.Text     = "Cerrar";
            this.btnCerrar.Click   += new System.EventHandler(this.btnCerrar_Click);

            this.pnlAcciones.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnNuevo, this.btnEditar, this.btnEliminar, this.btnCerrar });

            // pnlDetalle
            this.pnlDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetalle.Location    = new System.Drawing.Point(12, 330);
            this.pnlDetalle.Size        = new System.Drawing.Size(860, 265);
            this.pnlDetalle.Visible     = false;

            int lx = 10, fx = 155, lw = 140, fw = 350, ly = 14, step = 34;

            // Canal
            this.lblCanal.Location      = new System.Drawing.Point(lx, ly);
            this.lblCanal.Size          = new System.Drawing.Size(lw, 23);
            this.lblCanal.Text          = "Canal:";
            this.cbxCanal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCanal.Location      = new System.Drawing.Point(fx, ly);
            this.cbxCanal.Size          = new System.Drawing.Size(fw, 23);
            ly += step;

            // Categoría
            this.lblCategoria.Location      = new System.Drawing.Point(lx, ly);
            this.lblCategoria.Size          = new System.Drawing.Size(lw, 23);
            this.lblCategoria.Text          = "Categoría:";
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.Location      = new System.Drawing.Point(fx, ly);
            this.cbxCategoria.Size          = new System.Drawing.Size(fw, 23);
            ly += step;

            // Título
            this.lblTituloField.Location = new System.Drawing.Point(lx, ly);
            this.lblTituloField.Size     = new System.Drawing.Size(lw, 23);
            this.lblTituloField.Text     = "Título:";
            this.txtTitulo.Location      = new System.Drawing.Point(fx, ly);
            this.txtTitulo.MaxLength     = 100;
            this.txtTitulo.Size          = new System.Drawing.Size(fw, 23);
            ly += step;

            // Descripción
            this.lblDescripcion.Location  = new System.Drawing.Point(lx, ly);
            this.lblDescripcion.Size      = new System.Drawing.Size(lw, 23);
            this.lblDescripcion.Text      = "Descripción:";
            this.txtDescripcion.Location  = new System.Drawing.Point(fx, ly);
            this.txtDescripcion.MaxLength = 250;
            this.txtDescripcion.Size      = new System.Drawing.Size(fw, 23);
            ly += step;

            // Duración
            this.lblDuracion.Location = new System.Drawing.Point(lx, ly);
            this.lblDuracion.Size     = new System.Drawing.Size(lw, 23);
            this.lblDuracion.Text     = "Duración (min):";
            this.nudDuracion.Location = new System.Drawing.Point(fx, ly);
            this.nudDuracion.Minimum  = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudDuracion.Maximum  = new decimal(new int[] { 1440, 0, 0, 0 });
            this.nudDuracion.Size     = new System.Drawing.Size(120, 23);
            ly += step;

            // Productor
            this.lblProductor.Location  = new System.Drawing.Point(lx, ly);
            this.lblProductor.Size      = new System.Drawing.Size(lw, 23);
            this.lblProductor.Text      = "Productor:";
            this.txtProductor.Location  = new System.Drawing.Point(fx, ly);
            this.txtProductor.MaxLength = 100;
            this.txtProductor.Size      = new System.Drawing.Size(fw, 23);
            ly += step;

            // Fecha de Estreno
            this.lblFechaEstreno.Location = new System.Drawing.Point(lx, ly);
            this.lblFechaEstreno.Size     = new System.Drawing.Size(lw, 23);
            this.lblFechaEstreno.Text     = "Fecha de Estreno:";
            this.dtpFechaEstreno.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEstreno.Location = new System.Drawing.Point(fx, ly);
            this.dtpFechaEstreno.Size     = new System.Drawing.Size(180, 23);
            ly += step;

            // Botones Guardar / Cancelar
            this.btnGuardar.Location  = new System.Drawing.Point(fx, ly);
            this.btnGuardar.Size      = new System.Drawing.Size(80, 28);
            this.btnGuardar.Text      = "Guardar";
            this.btnGuardar.Click    += new System.EventHandler(this.btnGuardar_Click);

            this.btnCancelar.Location = new System.Drawing.Point(fx + 88, ly);
            this.btnCancelar.Size     = new System.Drawing.Size(80, 28);
            this.btnCancelar.Text     = "Cancelar";
            this.btnCancelar.Click   += new System.EventHandler(this.btnCancelar_Click);

            this.pnlDetalle.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblCanal,        this.cbxCanal,
                this.lblCategoria,    this.cbxCategoria,
                this.lblTituloField,  this.txtTitulo,
                this.lblDescripcion,  this.txtDescripcion,
                this.lblDuracion,     this.nudDuracion,
                this.lblProductor,    this.txtProductor,
                this.lblFechaEstreno, this.dtpFechaEstreno,
                this.btnGuardar,      this.btnCancelar
            });

            // ErrorProviders
            this.erpCanal.ContainerControl       = this;
            this.erpCategoria.ContainerControl   = this;
            this.erpTitulo.ContainerControl      = this;
            this.erpDescripcion.ContainerControl = this;
            this.erpDuracion.ContainerControl    = this;
            this.erpProductor.ContainerControl   = this;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(884, 610);
            this.Text                = "Parcial2Bcz - Programas";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load               += new System.EventHandler(this.FrmPrograma_Load);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitulo, this.txtParametro, this.btnBuscar,
                this.dgvLista, this.pnlAcciones, this.pnlDetalle
            });

            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCanal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCategoria)).EndInit();
            this.pnlDetalle.ResumeLayout(false);
            this.pnlAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Label          lblTitulo;
        private System.Windows.Forms.TextBox        txtParametro;
        private System.Windows.Forms.Button         btnBuscar;
        private System.Windows.Forms.DataGridView   dgvLista;
        private System.Windows.Forms.Panel          pnlAcciones;
        private System.Windows.Forms.Panel          pnlDetalle;
        private System.Windows.Forms.Button         btnNuevo;
        private System.Windows.Forms.Button         btnEditar;
        private System.Windows.Forms.Button         btnEliminar;
        private System.Windows.Forms.Button         btnCerrar;
        private System.Windows.Forms.Label          lblCanal;
        private System.Windows.Forms.ComboBox       cbxCanal;
        private System.Windows.Forms.Label          lblCategoria;
        private System.Windows.Forms.ComboBox       cbxCategoria;
        private System.Windows.Forms.Label          lblTituloField;
        private System.Windows.Forms.TextBox        txtTitulo;
        private System.Windows.Forms.Label          lblDescripcion;
        private System.Windows.Forms.TextBox        txtDescripcion;
        private System.Windows.Forms.Label          lblDuracion;
        private System.Windows.Forms.NumericUpDown  nudDuracion;
        private System.Windows.Forms.Label          lblProductor;
        private System.Windows.Forms.TextBox        txtProductor;
        private System.Windows.Forms.Label          lblFechaEstreno;
        private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
        private System.Windows.Forms.Button         btnGuardar;
        private System.Windows.Forms.Button         btnCancelar;
        private System.Windows.Forms.ErrorProvider  erpTitulo;
        private System.Windows.Forms.ErrorProvider  erpDescripcion;
        private System.Windows.Forms.ErrorProvider  erpProductor;
        private System.Windows.Forms.ErrorProvider  erpDuracion;
        private System.Windows.Forms.ErrorProvider  erpCanal;
        private System.Windows.Forms.ErrorProvider  erpCategoria;
    }
}
