namespace Capa_Presentacion
{
    partial class frmChoferes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvChoferes = new System.Windows.Forms.DataGridView();
            this.EliminarC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblNombreChofer = new System.Windows.Forms.Label();
            this.lblIIdChofer = new System.Windows.Forms.Label();
            this.lblFechaNacChofer = new System.Windows.Forms.Label();
            this.lblCedulaChofer = new System.Windows.Forms.Label();
            this.lblApellidoChofer = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombreChofer = new System.Windows.Forms.TextBox();
            this.txtApellidoChofer = new System.Windows.Forms.TextBox();
            this.txtCedulaChofer = new System.Windows.Forms.TextBox();
            this.dtpFecha_Nac = new System.Windows.Forms.DateTimePicker();
            this.ErrorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlChofer = new System.Windows.Forms.Panel();
            this.pnlRutas = new System.Windows.Forms.Panel();
            this.btnGuardarChofer = new System.Windows.Forms.Button();
            this.btnRegistrarChofer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditarChofer = new System.Windows.Forms.Button();
            this.picboxlateral = new System.Windows.Forms.PictureBox();
            this.pcbItla = new System.Windows.Forms.PictureBox();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorP)).BeginInit();
            this.pnlChofer.SuspendLayout();
            this.pnlRutas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlateral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChoferes
            // 
            this.dgvChoferes.AllowUserToAddRows = false;
            this.dgvChoferes.AllowUserToDeleteRows = false;
            this.dgvChoferes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvChoferes.BackgroundColor = System.Drawing.Color.White;
            this.dgvChoferes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChoferes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvChoferes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChoferes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvChoferes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EliminarC});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChoferes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChoferes.GridColor = System.Drawing.Color.White;
            this.dgvChoferes.Location = new System.Drawing.Point(161, 268);
            this.dgvChoferes.Name = "dgvChoferes";
            this.dgvChoferes.ReadOnly = true;
            this.dgvChoferes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChoferes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChoferes.RowHeadersVisible = false;
            this.dgvChoferes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvChoferes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChoferes.Size = new System.Drawing.Size(736, 223);
            this.dgvChoferes.TabIndex = 7;
            this.dgvChoferes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChoferes_CellContentClick);
            this.dgvChoferes.DoubleClick += new System.EventHandler(this.dgvChoferes_DoubleClick);
            // 
            // EliminarC
            // 
            this.EliminarC.HeaderText = "Eliminar";
            this.EliminarC.Name = "EliminarC";
            this.EliminarC.ReadOnly = true;
            this.EliminarC.Width = 59;
            // 
            // lblNombreChofer
            // 
            this.lblNombreChofer.AutoSize = true;
            this.lblNombreChofer.BackColor = System.Drawing.Color.White;
            this.lblNombreChofer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreChofer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNombreChofer.Location = new System.Drawing.Point(190, 109);
            this.lblNombreChofer.Name = "lblNombreChofer";
            this.lblNombreChofer.Size = new System.Drawing.Size(77, 19);
            this.lblNombreChofer.TabIndex = 9;
            this.lblNombreChofer.Text = "Nombre:";
            // 
            // lblIIdChofer
            // 
            this.lblIIdChofer.AutoSize = true;
            this.lblIIdChofer.BackColor = System.Drawing.Color.White;
            this.lblIIdChofer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIIdChofer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblIIdChofer.Location = new System.Drawing.Point(190, 59);
            this.lblIIdChofer.Name = "lblIIdChofer";
            this.lblIIdChofer.Size = new System.Drawing.Size(83, 19);
            this.lblIIdChofer.TabIndex = 8;
            this.lblIIdChofer.Text = "ID Chofer:";
            // 
            // lblFechaNacChofer
            // 
            this.lblFechaNacChofer.AutoSize = true;
            this.lblFechaNacChofer.BackColor = System.Drawing.Color.White;
            this.lblFechaNacChofer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacChofer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFechaNacChofer.Location = new System.Drawing.Point(445, 87);
            this.lblFechaNacChofer.Name = "lblFechaNacChofer";
            this.lblFechaNacChofer.Size = new System.Drawing.Size(180, 19);
            this.lblFechaNacChofer.TabIndex = 10;
            this.lblFechaNacChofer.Text = "Fecha de nacimiento:";
            // 
            // lblCedulaChofer
            // 
            this.lblCedulaChofer.AutoSize = true;
            this.lblCedulaChofer.BackColor = System.Drawing.Color.White;
            this.lblCedulaChofer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaChofer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCedulaChofer.Location = new System.Drawing.Point(196, 221);
            this.lblCedulaChofer.Name = "lblCedulaChofer";
            this.lblCedulaChofer.Size = new System.Drawing.Size(71, 19);
            this.lblCedulaChofer.TabIndex = 13;
            this.lblCedulaChofer.Text = "Cedula:";
            // 
            // lblApellidoChofer
            // 
            this.lblApellidoChofer.AutoSize = true;
            this.lblApellidoChofer.BackColor = System.Drawing.Color.White;
            this.lblApellidoChofer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoChofer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblApellidoChofer.Location = new System.Drawing.Point(188, 169);
            this.lblApellidoChofer.Name = "lblApellidoChofer";
            this.lblApellidoChofer.Size = new System.Drawing.Size(79, 19);
            this.lblApellidoChofer.TabIndex = 12;
            this.lblApellidoChofer.Text = "Apellido:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtID.Location = new System.Drawing.Point(298, 59);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(56, 23);
            this.txtID.TabIndex = 14;
            // 
            // txtNombreChofer
            // 
            this.txtNombreChofer.BackColor = System.Drawing.Color.White;
            this.txtNombreChofer.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreChofer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtNombreChofer.Location = new System.Drawing.Point(298, 109);
            this.txtNombreChofer.MaxLength = 30;
            this.txtNombreChofer.Name = "txtNombreChofer";
            this.txtNombreChofer.Size = new System.Drawing.Size(100, 23);
            this.txtNombreChofer.TabIndex = 15;
            this.txtNombreChofer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreChofer_KeyPress);
            // 
            // txtApellidoChofer
            // 
            this.txtApellidoChofer.BackColor = System.Drawing.Color.White;
            this.txtApellidoChofer.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoChofer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtApellidoChofer.Location = new System.Drawing.Point(298, 169);
            this.txtApellidoChofer.MaxLength = 30;
            this.txtApellidoChofer.Name = "txtApellidoChofer";
            this.txtApellidoChofer.Size = new System.Drawing.Size(100, 23);
            this.txtApellidoChofer.TabIndex = 16;
            this.txtApellidoChofer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoChofer_KeyPress);
            // 
            // txtCedulaChofer
            // 
            this.txtCedulaChofer.BackColor = System.Drawing.Color.White;
            this.txtCedulaChofer.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaChofer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtCedulaChofer.Location = new System.Drawing.Point(298, 221);
            this.txtCedulaChofer.MaxLength = 11;
            this.txtCedulaChofer.Name = "txtCedulaChofer";
            this.txtCedulaChofer.Size = new System.Drawing.Size(100, 23);
            this.txtCedulaChofer.TabIndex = 17;
            this.txtCedulaChofer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaChofer_KeyPress);
            // 
            // dtpFecha_Nac
            // 
            this.dtpFecha_Nac.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha_Nac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha_Nac.Location = new System.Drawing.Point(475, 122);
            this.dtpFecha_Nac.Name = "dtpFecha_Nac";
            this.dtpFecha_Nac.Size = new System.Drawing.Size(132, 23);
            this.dtpFecha_Nac.TabIndex = 18;
            // 
            // ErrorP
            // 
            this.ErrorP.ContainerControl = this;
            // 
            // pnlChofer
            // 
            this.pnlChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(29)))));
            this.pnlChofer.Controls.Add(this.pnlRutas);
            this.pnlChofer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlChofer.Location = new System.Drawing.Point(0, 0);
            this.pnlChofer.Name = "pnlChofer";
            this.pnlChofer.Size = new System.Drawing.Size(158, 542);
            this.pnlChofer.TabIndex = 19;
            // 
            // pnlRutas
            // 
            this.pnlRutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(29)))));
            this.pnlRutas.Controls.Add(this.btnGuardarChofer);
            this.pnlRutas.Controls.Add(this.btnRegistrarChofer);
            this.pnlRutas.Controls.Add(this.label1);
            this.pnlRutas.Controls.Add(this.btnEditarChofer);
            this.pnlRutas.Controls.Add(this.picboxlateral);
            this.pnlRutas.Controls.Add(this.pcbItla);
            this.pnlRutas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRutas.Location = new System.Drawing.Point(0, 0);
            this.pnlRutas.Name = "pnlRutas";
            this.pnlRutas.Size = new System.Drawing.Size(155, 542);
            this.pnlRutas.TabIndex = 22;
            // 
            // btnGuardarChofer
            // 
            this.btnGuardarChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardarChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarChofer.FlatAppearance.BorderSize = 0;
            this.btnGuardarChofer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnGuardarChofer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnGuardarChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarChofer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarChofer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardarChofer.Image = global::SisControlBus.Properties.Resources.icons8_guardar_48;
            this.btnGuardarChofer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarChofer.Location = new System.Drawing.Point(0, 101);
            this.btnGuardarChofer.Name = "btnGuardarChofer";
            this.btnGuardarChofer.Size = new System.Drawing.Size(155, 42);
            this.btnGuardarChofer.TabIndex = 14;
            this.btnGuardarChofer.Text = "        Guardar";
            this.btnGuardarChofer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarChofer.UseVisualStyleBackColor = false;
            this.btnGuardarChofer.Click += new System.EventHandler(this.btnGuardarChofer_Click_1);
            // 
            // btnRegistrarChofer
            // 
            this.btnRegistrarChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegistrarChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarChofer.FlatAppearance.BorderSize = 0;
            this.btnRegistrarChofer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnRegistrarChofer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnRegistrarChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarChofer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarChofer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrarChofer.Image = global::SisControlBus.Properties.Resources.icons8_crear_nuevo_50;
            this.btnRegistrarChofer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarChofer.Location = new System.Drawing.Point(0, 56);
            this.btnRegistrarChofer.Name = "btnRegistrarChofer";
            this.btnRegistrarChofer.Size = new System.Drawing.Size(155, 42);
            this.btnRegistrarChofer.TabIndex = 13;
            this.btnRegistrarChofer.Text = "      Registrar";
            this.btnRegistrarChofer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarChofer.UseVisualStyleBackColor = false;
            this.btnRegistrarChofer.Click += new System.EventHandler(this.btnRegistrarChofer_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dewry GP";
            // 
            // btnEditarChofer
            // 
            this.btnEditarChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditarChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarChofer.FlatAppearance.BorderSize = 0;
            this.btnEditarChofer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnEditarChofer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnEditarChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarChofer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarChofer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditarChofer.Image = global::SisControlBus.Properties.Resources.icons8_editar_usuaria_48;
            this.btnEditarChofer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarChofer.Location = new System.Drawing.Point(0, 146);
            this.btnEditarChofer.Name = "btnEditarChofer";
            this.btnEditarChofer.Size = new System.Drawing.Size(155, 42);
            this.btnEditarChofer.TabIndex = 8;
            this.btnEditarChofer.Text = "Editar";
            this.btnEditarChofer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarChofer.UseVisualStyleBackColor = false;
            this.btnEditarChofer.Click += new System.EventHandler(this.btnEditarChofer_Click_1);
            // 
            // picboxlateral
            // 
            this.picboxlateral.BackColor = System.Drawing.Color.White;
            this.picboxlateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxlateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picboxlateral.Location = new System.Drawing.Point(0, 50);
            this.picboxlateral.Name = "picboxlateral";
            this.picboxlateral.Size = new System.Drawing.Size(155, 492);
            this.picboxlateral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxlateral.TabIndex = 9;
            this.picboxlateral.TabStop = false;
            // 
            // pcbItla
            // 
            this.pcbItla.BackColor = System.Drawing.Color.White;
            this.pcbItla.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcbItla.Location = new System.Drawing.Point(0, 0);
            this.pcbItla.Name = "pcbItla";
            this.pcbItla.Size = new System.Drawing.Size(155, 50);
            this.pcbItla.TabIndex = 10;
            this.pcbItla.TabStop = false;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.chkEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminar.ForeColor = System.Drawing.Color.White;
            this.chkEliminar.Location = new System.Drawing.Point(784, 223);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(72, 20);
            this.chkEliminar.TabIndex = 26;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = false;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Image = global::SisControlBus.Properties.Resources.icons8_eliminar_48;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(710, 51);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 44);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Image = global::SisControlBus.Properties.Resources.icons8_cancelar_48;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(710, 101);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 44);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "       Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmChoferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 542);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.chkEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pnlChofer);
            this.Controls.Add(this.dtpFecha_Nac);
            this.Controls.Add(this.txtCedulaChofer);
            this.Controls.Add(this.txtApellidoChofer);
            this.Controls.Add(this.txtNombreChofer);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblCedulaChofer);
            this.Controls.Add(this.lblApellidoChofer);
            this.Controls.Add(this.lblFechaNacChofer);
            this.Controls.Add(this.lblNombreChofer);
            this.Controls.Add(this.lblIIdChofer);
            this.Controls.Add(this.dgvChoferes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChoferes";
            this.Opacity = 0.9D;
            this.Text = "frmChoferes";
            this.Load += new System.EventHandler(this.frmChoferes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorP)).EndInit();
            this.pnlChofer.ResumeLayout(false);
            this.pnlRutas.ResumeLayout(false);
            this.pnlRutas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlateral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChoferes;
        private System.Windows.Forms.Label lblNombreChofer;
        private System.Windows.Forms.Label lblIIdChofer;
        private System.Windows.Forms.Label lblFechaNacChofer;
        private System.Windows.Forms.Label lblCedulaChofer;
        private System.Windows.Forms.Label lblApellidoChofer;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombreChofer;
        private System.Windows.Forms.TextBox txtApellidoChofer;
        private System.Windows.Forms.TextBox txtCedulaChofer;
        private System.Windows.Forms.DateTimePicker dtpFecha_Nac;
        private System.Windows.Forms.ErrorProvider ErrorP;
        private System.Windows.Forms.Panel pnlChofer;
        public System.Windows.Forms.Panel pnlRutas;
        public System.Windows.Forms.Button btnGuardarChofer;
        public System.Windows.Forms.Button btnRegistrarChofer;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnEditarChofer;
        private System.Windows.Forms.PictureBox picboxlateral;
        private System.Windows.Forms.PictureBox pcbItla;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EliminarC;
        private System.Windows.Forms.Button btnCancelar;
    }
}