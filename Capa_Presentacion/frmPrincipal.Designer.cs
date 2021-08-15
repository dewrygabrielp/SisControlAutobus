
namespace Capa_Presentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelIzquierdo = new System.Windows.Forms.Panel();
            this.btnRegistrarInsp = new System.Windows.Forms.Button();
            this.btnGuardarInsp = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.btnRutas = new System.Windows.Forms.Button();
            this.btnChofer = new System.Windows.Forms.Button();
            this.btnAutobus = new System.Windows.Forms.Button();
            this.btnInscripcion = new System.Windows.Forms.Button();
            this.btnPanelInicio = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.pnlInscripcion = new System.Windows.Forms.Panel();
            this.Controles = new System.Windows.Forms.TabControl();
            this.LISTADO = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblBuscarNombre = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.MANTENIMIENTO = new System.Windows.Forms.TabPage();
            this.btnReiniciarBD = new System.Windows.Forms.Button();
            this.cbxRutaname = new System.Windows.Forms.ComboBox();
            this.cbxAutobusname = new System.Windows.Forms.ComboBox();
            this.cbxChoferesname = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNChofer = new System.Windows.Forms.Label();
            this.lblPlacaBus = new System.Windows.Forms.Label();
            this.lblRutaAsig = new System.Windows.Forms.Label();
            this.cbxAutobus = new System.Windows.Forms.ComboBox();
            this.cbxRutaAsig = new System.Windows.Forms.ComboBox();
            this.cbxChoferes = new System.Windows.Forms.ComboBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.ErrorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.dragcpnlTop = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragcLateral = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.PanelIzquierdo.SuspendLayout();
            this.pnl.SuspendLayout();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            this.PanelContenedor.SuspendLayout();
            this.pnlInscripcion.SuspendLayout();
            this.Controles.SuspendLayout();
            this.LISTADO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.MANTENIMIENTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorP)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelIzquierdo
            // 
            this.PanelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PanelIzquierdo.Controls.Add(this.btnRegistrarInsp);
            this.PanelIzquierdo.Controls.Add(this.btnGuardarInsp);
            this.PanelIzquierdo.Controls.Add(this.btnTicket);
            this.PanelIzquierdo.Controls.Add(this.btnEstudiante);
            this.PanelIzquierdo.Controls.Add(this.btnRutas);
            this.PanelIzquierdo.Controls.Add(this.btnChofer);
            this.PanelIzquierdo.Controls.Add(this.btnAutobus);
            this.PanelIzquierdo.Controls.Add(this.btnInscripcion);
            this.PanelIzquierdo.Controls.Add(this.btnPanelInicio);
            this.PanelIzquierdo.Controls.Add(this.pnl);
            this.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.PanelIzquierdo.Name = "PanelIzquierdo";
            this.PanelIzquierdo.Size = new System.Drawing.Size(200, 600);
            this.PanelIzquierdo.TabIndex = 0;
            // 
            // btnRegistrarInsp
            // 
            this.btnRegistrarInsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegistrarInsp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarInsp.FlatAppearance.BorderSize = 0;
            this.btnRegistrarInsp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnRegistrarInsp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnRegistrarInsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarInsp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarInsp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrarInsp.Image = global::SisControlBus.Properties.Resources.icons8_editar_60;
            this.btnRegistrarInsp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarInsp.Location = new System.Drawing.Point(-3, 178);
            this.btnRegistrarInsp.Name = "btnRegistrarInsp";
            this.btnRegistrarInsp.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnRegistrarInsp.Size = new System.Drawing.Size(204, 51);
            this.btnRegistrarInsp.TabIndex = 6;
            this.btnRegistrarInsp.Text = "Registrar";
            this.btnRegistrarInsp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarInsp.UseVisualStyleBackColor = false;
            this.btnRegistrarInsp.Click += new System.EventHandler(this.btnRegistrarInsp_Click_1);
            // 
            // btnGuardarInsp
            // 
            this.btnGuardarInsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardarInsp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarInsp.FlatAppearance.BorderSize = 0;
            this.btnGuardarInsp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnGuardarInsp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnGuardarInsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarInsp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarInsp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardarInsp.Image = global::SisControlBus.Properties.Resources.icons8_guardar_48;
            this.btnGuardarInsp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarInsp.Location = new System.Drawing.Point(-1, 235);
            this.btnGuardarInsp.Name = "btnGuardarInsp";
            this.btnGuardarInsp.Padding = new System.Windows.Forms.Padding(18, 10, 0, 0);
            this.btnGuardarInsp.Size = new System.Drawing.Size(201, 49);
            this.btnGuardarInsp.TabIndex = 6;
            this.btnGuardarInsp.Text = "Guardar";
            this.btnGuardarInsp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarInsp.UseVisualStyleBackColor = false;
            this.btnGuardarInsp.Click += new System.EventHandler(this.btnGuardarInsp_Click_1);
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTicket.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnTicket.FlatAppearance.BorderSize = 0;
            this.btnTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.ForeColor = System.Drawing.Color.White;
            this.btnTicket.Image = global::SisControlBus.Properties.Resources.icons8_boleto_confirmado_50;
            this.btnTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicket.Location = new System.Drawing.Point(1, 555);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnTicket.Size = new System.Drawing.Size(200, 45);
            this.btnTicket.TabIndex = 25;
            this.btnTicket.Text = "Tickets";
            this.btnTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstudiante.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnEstudiante.FlatAppearance.BorderSize = 0;
            this.btnEstudiante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnEstudiante.Image = global::SisControlBus.Properties.Resources.icons8_estudiante_masculino_50;
            this.btnEstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiante.Location = new System.Drawing.Point(-1, 504);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnEstudiante.Size = new System.Drawing.Size(200, 45);
            this.btnEstudiante.TabIndex = 24;
            this.btnEstudiante.Text = "Estudiantes";
            this.btnEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstudiante.UseVisualStyleBackColor = false;
            this.btnEstudiante.Click += new System.EventHandler(this.btnEstudiante_Click);
            // 
            // btnRutas
            // 
            this.btnRutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRutas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRutas.FlatAppearance.BorderSize = 0;
            this.btnRutas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnRutas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRutas.Image = global::SisControlBus.Properties.Resources.icons8_ruta_50;
            this.btnRutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRutas.Location = new System.Drawing.Point(-2, 435);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnRutas.Size = new System.Drawing.Size(203, 48);
            this.btnRutas.TabIndex = 19;
            this.btnRutas.Text = "Rutas";
            this.btnRutas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRutas.UseVisualStyleBackColor = false;
            this.btnRutas.Click += new System.EventHandler(this.btnRutas_Click_1);
            // 
            // btnChofer
            // 
            this.btnChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChofer.FlatAppearance.BorderSize = 0;
            this.btnChofer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnChofer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChofer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChofer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChofer.Image = global::SisControlBus.Properties.Resources.icons8_conductor_48;
            this.btnChofer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChofer.Location = new System.Drawing.Point(-2, 384);
            this.btnChofer.Name = "btnChofer";
            this.btnChofer.Size = new System.Drawing.Size(200, 45);
            this.btnChofer.TabIndex = 17;
            this.btnChofer.Text = "Conductores";
            this.btnChofer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChofer.UseVisualStyleBackColor = false;
            this.btnChofer.Click += new System.EventHandler(this.btnChofer_Click);
            // 
            // btnAutobus
            // 
            this.btnAutobus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAutobus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutobus.FlatAppearance.BorderSize = 0;
            this.btnAutobus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnAutobus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnAutobus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutobus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutobus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAutobus.Image = global::SisControlBus.Properties.Resources.icons8_autobús_48;
            this.btnAutobus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutobus.Location = new System.Drawing.Point(0, 333);
            this.btnAutobus.Name = "btnAutobus";
            this.btnAutobus.Size = new System.Drawing.Size(200, 45);
            this.btnAutobus.TabIndex = 0;
            this.btnAutobus.Text = "Autobus";
            this.btnAutobus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAutobus.UseVisualStyleBackColor = false;
            this.btnAutobus.Click += new System.EventHandler(this.btnAutobus_Click);
            // 
            // btnInscripcion
            // 
            this.btnInscripcion.BackColor = System.Drawing.Color.White;
            this.btnInscripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInscripcion.FlatAppearance.BorderSize = 0;
            this.btnInscripcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnInscripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInscripcion.Image = global::SisControlBus.Properties.Resources.btnInscripcion;
            this.btnInscripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscripcion.Location = new System.Drawing.Point(0, 122);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Size = new System.Drawing.Size(200, 50);
            this.btnInscripcion.TabIndex = 20;
            this.btnInscripcion.Text = "Inscripción";
            this.btnInscripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInscripcion.UseVisualStyleBackColor = false;
            this.btnInscripcion.Click += new System.EventHandler(this.btnInscripcion_Click);
            // 
            // btnPanelInicio
            // 
            this.btnPanelInicio.BackColor = System.Drawing.Color.White;
            this.btnPanelInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPanelInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanelInicio.FlatAppearance.BorderSize = 0;
            this.btnPanelInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnPanelInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnPanelInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelInicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPanelInicio.Image = global::SisControlBus.Properties.Resources.btnInicio;
            this.btnPanelInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelInicio.Location = new System.Drawing.Point(0, 58);
            this.btnPanelInicio.Name = "btnPanelInicio";
            this.btnPanelInicio.Size = new System.Drawing.Size(200, 45);
            this.btnPanelInicio.TabIndex = 21;
            this.btnPanelInicio.Text = "Inicio";
            this.btnPanelInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPanelInicio.UseVisualStyleBackColor = false;
            this.btnPanelInicio.Click += new System.EventHandler(this.btnPanelInicio_Click);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnl.Controls.Add(this.lblFecha);
            this.pnl.Controls.Add(this.lblHora);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(200, 58);
            this.pnl.TabIndex = 6;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(0, 24);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 16);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "FECHA:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHora.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(0, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(66, 24);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "HORA:";
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PanelTop.Controls.Add(this.pictureBox2);
            this.PanelTop.Controls.Add(this.btnMin);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(200, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(900, 58);
            this.PanelTop.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::SisControlBus.Properties.Resources.cerrar;
            this.pictureBox2.Location = new System.Drawing.Point(861, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pictureBox2.Size = new System.Drawing.Size(39, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = global::SisControlBus.Properties.Resources.icons8_minimizar_la_ventana_60;
            this.btnMin.Location = new System.Drawing.Point(817, -6);
            this.btnMin.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnMin.Size = new System.Drawing.Size(52, 47);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 1;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PanelContenedor.Controls.Add(this.pnlInscripcion);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(200, 58);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(900, 542);
            this.PanelContenedor.TabIndex = 2;
            // 
            // pnlInscripcion
            // 
            this.pnlInscripcion.BackColor = System.Drawing.Color.White;
            this.pnlInscripcion.Controls.Add(this.Controles);
            this.pnlInscripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInscripcion.Location = new System.Drawing.Point(0, 0);
            this.pnlInscripcion.Name = "pnlInscripcion";
            this.pnlInscripcion.Size = new System.Drawing.Size(900, 542);
            this.pnlInscripcion.TabIndex = 22;
            // 
            // Controles
            // 
            this.Controles.Controls.Add(this.LISTADO);
            this.Controles.Controls.Add(this.MANTENIMIENTO);
            this.Controles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controles.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.Controles.Location = new System.Drawing.Point(0, 0);
            this.Controles.Multiline = true;
            this.Controles.Name = "Controles";
            this.Controles.SelectedIndex = 0;
            this.Controles.Size = new System.Drawing.Size(900, 542);
            this.Controles.TabIndex = 1;
            this.Controles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Controles_MouseClick);
            // 
            // LISTADO
            // 
            this.LISTADO.BackColor = System.Drawing.Color.White;
            this.LISTADO.Controls.Add(this.pictureBox1);
            this.LISTADO.Controls.Add(this.dgvDatos);
            this.LISTADO.Controls.Add(this.lblCantidad);
            this.LISTADO.Controls.Add(this.chkEliminar);
            this.LISTADO.Controls.Add(this.btnEliminar);
            this.LISTADO.Controls.Add(this.lblBuscarNombre);
            this.LISTADO.Controls.Add(this.txtBuscar);
            this.LISTADO.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LISTADO.Location = new System.Drawing.Point(4, 22);
            this.LISTADO.Name = "LISTADO";
            this.LISTADO.Padding = new System.Windows.Forms.Padding(3);
            this.LISTADO.Size = new System.Drawing.Size(892, 516);
            this.LISTADO.TabIndex = 0;
            this.LISTADO.Text = "LISTADO";
            this.LISTADO.ToolTipText = "LISTADO GENERAL";
            this.LISTADO.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SisControlBus.Properties.Resources.icons8_espionaje_60;
            this.pictureBox1.Location = new System.Drawing.Point(729, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ELIMINAR});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatos.GridColor = System.Drawing.Color.White;
            this.dgvDatos.Location = new System.Drawing.Point(-4, 184);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(883, 326);
            this.dgvDatos.TabIndex = 5;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.ReadOnly = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.ForeColor = System.Drawing.Color.Magenta;
            this.lblCantidad.Location = new System.Drawing.Point(562, 109);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(89, 18);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "CANTIDAD:";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chkEliminar.Location = new System.Drawing.Point(34, 126);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(194, 20);
            this.chkEliminar.TabIndex = 3;
            this.chkEliminar.Text = "¿Desea eliminar registros?";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Image = global::SisControlBus.Properties.Resources.icons8_eliminar_48;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(234, 109);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 51);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblBuscarNombre
            // 
            this.lblBuscarNombre.AutoSize = true;
            this.lblBuscarNombre.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBuscarNombre.Location = new System.Drawing.Point(60, 44);
            this.lblBuscarNombre.Name = "lblBuscarNombre";
            this.lblBuscarNombre.Size = new System.Drawing.Size(152, 21);
            this.lblBuscarNombre.TabIndex = 1;
            this.lblBuscarNombre.Text = "INGRESE APELLIDO:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(218, 42);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(505, 26);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.Text = "Buscar...";
            this.txtBuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscar_MouseClick_1);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // MANTENIMIENTO
            // 
            this.MANTENIMIENTO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MANTENIMIENTO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MANTENIMIENTO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MANTENIMIENTO.Controls.Add(this.btnReiniciarBD);
            this.MANTENIMIENTO.Controls.Add(this.cbxRutaname);
            this.MANTENIMIENTO.Controls.Add(this.cbxAutobusname);
            this.MANTENIMIENTO.Controls.Add(this.cbxChoferesname);
            this.MANTENIMIENTO.Controls.Add(this.txtID);
            this.MANTENIMIENTO.Controls.Add(this.lblNChofer);
            this.MANTENIMIENTO.Controls.Add(this.lblPlacaBus);
            this.MANTENIMIENTO.Controls.Add(this.lblRutaAsig);
            this.MANTENIMIENTO.Controls.Add(this.cbxAutobus);
            this.MANTENIMIENTO.Controls.Add(this.cbxRutaAsig);
            this.MANTENIMIENTO.Controls.Add(this.cbxChoferes);
            this.MANTENIMIENTO.Controls.Add(this.txtSerial);
            this.MANTENIMIENTO.Controls.Add(this.lblCedula);
            this.MANTENIMIENTO.Controls.Add(this.btnCancelar);
            this.MANTENIMIENTO.Location = new System.Drawing.Point(4, 22);
            this.MANTENIMIENTO.Name = "MANTENIMIENTO";
            this.MANTENIMIENTO.Padding = new System.Windows.Forms.Padding(3);
            this.MANTENIMIENTO.Size = new System.Drawing.Size(892, 516);
            this.MANTENIMIENTO.TabIndex = 1;
            this.MANTENIMIENTO.Text = "MANTENIMIENTO";
            this.MANTENIMIENTO.ToolTipText = "MANTENIMIENTO DE Choferes";
            // 
            // btnReiniciarBD
            // 
            this.btnReiniciarBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReiniciarBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciarBD.FlatAppearance.BorderSize = 0;
            this.btnReiniciarBD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnReiniciarBD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnReiniciarBD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReiniciarBD.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciarBD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReiniciarBD.Image = global::SisControlBus.Properties.Resources.icons8_eliminar_48;
            this.btnReiniciarBD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReiniciarBD.Location = new System.Drawing.Point(390, 280);
            this.btnReiniciarBD.Name = "btnReiniciarBD";
            this.btnReiniciarBD.Size = new System.Drawing.Size(236, 51);
            this.btnReiniciarBD.TabIndex = 23;
            this.btnReiniciarBD.Text = "Eliminar todos los datos";
            this.btnReiniciarBD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReiniciarBD.UseVisualStyleBackColor = false;
            this.btnReiniciarBD.Click += new System.EventHandler(this.btnReiniciarBD_Click);
            // 
            // cbxRutaname
            // 
            this.cbxRutaname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cbxRutaname.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRutaname.FormattingEnabled = true;
            this.cbxRutaname.Location = new System.Drawing.Point(304, 217);
            this.cbxRutaname.Name = "cbxRutaname";
            this.cbxRutaname.Size = new System.Drawing.Size(340, 27);
            this.cbxRutaname.TabIndex = 22;
            this.cbxRutaname.Text = "Nombre de la ruta...";
            // 
            // cbxAutobusname
            // 
            this.cbxAutobusname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cbxAutobusname.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAutobusname.FormattingEnabled = true;
            this.cbxAutobusname.Location = new System.Drawing.Point(304, 166);
            this.cbxAutobusname.Name = "cbxAutobusname";
            this.cbxAutobusname.Size = new System.Drawing.Size(340, 27);
            this.cbxAutobusname.TabIndex = 21;
            this.cbxAutobusname.Text = "Ver serial de placa...";
            // 
            // cbxChoferesname
            // 
            this.cbxChoferesname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cbxChoferesname.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChoferesname.FormattingEnabled = true;
            this.cbxChoferesname.Location = new System.Drawing.Point(304, 109);
            this.cbxChoferesname.Name = "cbxChoferesname";
            this.cbxChoferesname.Size = new System.Drawing.Size(340, 27);
            this.cbxChoferesname.TabIndex = 20;
            this.cbxChoferesname.Text = "Ver el nombre...";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtID.Location = new System.Drawing.Point(812, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(77, 22);
            this.txtID.TabIndex = 19;
            this.txtID.Visible = false;
            // 
            // lblNChofer
            // 
            this.lblNChofer.AutoSize = true;
            this.lblNChofer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNChofer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNChofer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblNChofer.Location = new System.Drawing.Point(30, 114);
            this.lblNChofer.Name = "lblNChofer";
            this.lblNChofer.Size = new System.Drawing.Size(143, 16);
            this.lblNChofer.TabIndex = 18;
            this.lblNChofer.Text = "NOMBRE DE CHOFER:";
            // 
            // lblPlacaBus
            // 
            this.lblPlacaBus.AutoSize = true;
            this.lblPlacaBus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPlacaBus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaBus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblPlacaBus.Location = new System.Drawing.Point(30, 171);
            this.lblPlacaBus.Name = "lblPlacaBus";
            this.lblPlacaBus.Size = new System.Drawing.Size(137, 16);
            this.lblPlacaBus.TabIndex = 17;
            this.lblPlacaBus.Text = "PLACA DE AUTOBUS:";
            // 
            // lblRutaAsig
            // 
            this.lblRutaAsig.AutoSize = true;
            this.lblRutaAsig.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRutaAsig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaAsig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblRutaAsig.Location = new System.Drawing.Point(48, 223);
            this.lblRutaAsig.Name = "lblRutaAsig";
            this.lblRutaAsig.Size = new System.Drawing.Size(119, 16);
            this.lblRutaAsig.TabIndex = 16;
            this.lblRutaAsig.Text = "RUTA ASIGNADA:";
            // 
            // cbxAutobus
            // 
            this.cbxAutobus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cbxAutobus.Font = new System.Drawing.Font("Lucida Sans", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAutobus.FormattingEnabled = true;
            this.cbxAutobus.Location = new System.Drawing.Point(179, 166);
            this.cbxAutobus.Name = "cbxAutobus";
            this.cbxAutobus.Size = new System.Drawing.Size(108, 22);
            this.cbxAutobus.TabIndex = 15;
            this.cbxAutobus.Text = "Seleccione Id...";
            // 
            // cbxRutaAsig
            // 
            this.cbxRutaAsig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cbxRutaAsig.Font = new System.Drawing.Font("Lucida Sans", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRutaAsig.FormattingEnabled = true;
            this.cbxRutaAsig.Location = new System.Drawing.Point(179, 220);
            this.cbxRutaAsig.Name = "cbxRutaAsig";
            this.cbxRutaAsig.Size = new System.Drawing.Size(108, 22);
            this.cbxRutaAsig.TabIndex = 14;
            this.cbxRutaAsig.Text = "Seleccione Id...";
            // 
            // cbxChoferes
            // 
            this.cbxChoferes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cbxChoferes.Font = new System.Drawing.Font("Lucida Sans", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChoferes.FormattingEnabled = true;
            this.cbxChoferes.Location = new System.Drawing.Point(179, 109);
            this.cbxChoferes.Name = "cbxChoferes";
            this.cbxChoferes.Size = new System.Drawing.Size(108, 22);
            this.cbxChoferes.TabIndex = 13;
            this.cbxChoferes.Text = "Seleccione Id...";
            // 
            // txtSerial
            // 
            this.txtSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtSerial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSerial.Location = new System.Drawing.Point(179, 43);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(227, 22);
            this.txtSerial.TabIndex = 12;
            this.txtSerial.TextChanged += new System.EventHandler(this.txtSerial_TextChanged);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCedula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblCedula.Location = new System.Drawing.Point(30, 43);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(143, 16);
            this.lblCedula.TabIndex = 6;
            this.lblCedula.Text = "N. Serial Inscripción:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(90, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(197, 39);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // ErrorP
            // 
            this.ErrorP.ContainerControl = this;
            // 
            // dragcpnlTop
            // 
            this.dragcpnlTop.Fixed = true;
            this.dragcpnlTop.Horizontal = true;
            this.dragcpnlTop.TargetControl = this.PanelTop;
            this.dragcpnlTop.Vertical = true;
            // 
            // dragcLateral
            // 
            this.dragcLateral.Fixed = true;
            this.dragcLateral.Horizontal = true;
            this.dragcLateral.TargetControl = this.pnl;
            this.dragcLateral.Vertical = true;
            // 
            // timerFechaHora
            // 
            this.timerFechaHora.Enabled = true;
            this.timerFechaHora.Interval = 1000;
            this.timerFechaHora.Tick += new System.EventHandler(this.timerFechaHora_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 500);
            this.Name = "frmPrincipal";
            this.Opacity = 0.9D;
            this.Text = "CONTROL AUTOBUSES";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.PanelIzquierdo.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            this.PanelContenedor.ResumeLayout(false);
            this.pnlInscripcion.ResumeLayout(false);
            this.Controles.ResumeLayout(false);
            this.LISTADO.ResumeLayout(false);
            this.LISTADO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.MANTENIMIENTO.ResumeLayout(false);
            this.MANTENIMIENTO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelIzquierdo;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Button btnAutobus;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider ErrorP;
        private System.Windows.Forms.Button btnRutas;
        private System.Windows.Forms.Button btnChofer;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.Panel pnlInscripcion;
        private System.Windows.Forms.TabControl Controles;
        private System.Windows.Forms.TabPage LISTADO;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblBuscarNombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TabPage MANTENIMIENTO;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNChofer;
        private System.Windows.Forms.Label lblPlacaBus;
        private System.Windows.Forms.Label lblRutaAsig;
        private System.Windows.Forms.ComboBox cbxAutobus;
        private System.Windows.Forms.ComboBox cbxRutaAsig;
        private System.Windows.Forms.ComboBox cbxChoferes;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ELIMINAR;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button btnPanelInicio;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnEstudiante;
        private System.Windows.Forms.ComboBox cbxRutaname;
        private System.Windows.Forms.ComboBox cbxAutobusname;
        private System.Windows.Forms.ComboBox cbxChoferesname;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.Button btnGuardarInsp;
        public System.Windows.Forms.Button btnRegistrarInsp;
        private System.Windows.Forms.Button btnReiniciarBD;
        private Bunifu.Framework.UI.BunifuDragControl dragcpnlTop;
        private Bunifu.Framework.UI.BunifuDragControl dragcLateral;
        private System.Windows.Forms.Timer timerFechaHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

