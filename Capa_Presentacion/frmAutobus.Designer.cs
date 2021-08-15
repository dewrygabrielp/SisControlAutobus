namespace Capa_Presentacion
{
    partial class frmAutobus
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
            this.dgvAutobus = new System.Windows.Forms.DataGridView();
            this.EliminarA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblIDAutobus = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtIDBus = new System.Windows.Forms.TextBox();
            this.txtPlacaBus = new System.Windows.Forms.TextBox();
            this.txtMarcaBus = new System.Windows.Forms.TextBox();
            this.txtModeloBus = new System.Windows.Forms.TextBox();
            this.txtColorBus = new System.Windows.Forms.TextBox();
            this.ErrorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpAno = new System.Windows.Forms.DateTimePicker();
            this.pnlBus = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditarBus = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGuardarBus = new System.Windows.Forms.Button();
            this.btnRegistrarBus = new System.Windows.Forms.Button();
            this.picboxlateral = new System.Windows.Forms.PictureBox();
            this.pcbItla = new System.Windows.Forms.PictureBox();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutobus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorP)).BeginInit();
            this.pnlBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlateral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutobus
            // 
            this.dgvAutobus.AllowUserToAddRows = false;
            this.dgvAutobus.AllowUserToDeleteRows = false;
            this.dgvAutobus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutobus.BackgroundColor = System.Drawing.Color.White;
            this.dgvAutobus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAutobus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAutobus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutobus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAutobus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAutobus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EliminarA});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAutobus.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAutobus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvAutobus.Location = new System.Drawing.Point(187, 249);
            this.dgvAutobus.Name = "dgvAutobus";
            this.dgvAutobus.ReadOnly = true;
            this.dgvAutobus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutobus.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAutobus.RowHeadersVisible = false;
            this.dgvAutobus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAutobus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutobus.Size = new System.Drawing.Size(712, 223);
            this.dgvAutobus.TabIndex = 7;
            this.dgvAutobus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutobus_CellContentClick);
            this.dgvAutobus.DoubleClick += new System.EventHandler(this.dgvAutobus_DoubleClick);
            // 
            // EliminarA
            // 
            this.EliminarA.HeaderText = "Eliminar";
            this.EliminarA.Name = "EliminarA";
            this.EliminarA.ReadOnly = true;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblPlaca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlaca.Location = new System.Drawing.Point(206, 70);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(58, 19);
            this.lblPlaca.TabIndex = 9;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblIDAutobus
            // 
            this.lblIDAutobus.AutoSize = true;
            this.lblIDAutobus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblIDAutobus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDAutobus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIDAutobus.Location = new System.Drawing.Point(207, 20);
            this.lblIDAutobus.Name = "lblIDAutobus";
            this.lblIDAutobus.Size = new System.Drawing.Size(57, 19);
            this.lblIDAutobus.TabIndex = 8;
            this.lblIDAutobus.Text = "ID Bus:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMarca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMarca.Location = new System.Drawing.Point(205, 191);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(64, 19);
            this.lblMarca.TabIndex = 11;
            this.lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblModelo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblModelo.Location = new System.Drawing.Point(197, 109);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(72, 19);
            this.lblModelo.TabIndex = 10;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblColor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(210, 222);
            this.lblColor.Margin = new System.Windows.Forms.Padding(0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(54, 19);
            this.lblColor.TabIndex = 13;
            this.lblColor.Text = "Color:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAno.Location = new System.Drawing.Point(214, 150);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(45, 19);
            this.lblAno.TabIndex = 12;
            this.lblAno.Text = "Año:";
            // 
            // txtIDBus
            // 
            this.txtIDBus.BackColor = System.Drawing.Color.DarkOrange;
            this.txtIDBus.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDBus.ForeColor = System.Drawing.Color.Black;
            this.txtIDBus.Location = new System.Drawing.Point(330, 20);
            this.txtIDBus.Name = "txtIDBus";
            this.txtIDBus.ReadOnly = true;
            this.txtIDBus.Size = new System.Drawing.Size(100, 22);
            this.txtIDBus.TabIndex = 14;
            // 
            // txtPlacaBus
            // 
            this.txtPlacaBus.BackColor = System.Drawing.Color.DarkOrange;
            this.txtPlacaBus.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaBus.ForeColor = System.Drawing.Color.Black;
            this.txtPlacaBus.Location = new System.Drawing.Point(330, 67);
            this.txtPlacaBus.MaxLength = 6;
            this.txtPlacaBus.Name = "txtPlacaBus";
            this.txtPlacaBus.Size = new System.Drawing.Size(100, 22);
            this.txtPlacaBus.TabIndex = 15;
            this.txtPlacaBus.TextChanged += new System.EventHandler(this.txtPlacaBus_TextChanged);
            this.txtPlacaBus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlacaBus_KeyPress);
            // 
            // txtMarcaBus
            // 
            this.txtMarcaBus.BackColor = System.Drawing.Color.DarkOrange;
            this.txtMarcaBus.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaBus.ForeColor = System.Drawing.Color.Black;
            this.txtMarcaBus.Location = new System.Drawing.Point(330, 191);
            this.txtMarcaBus.MaxLength = 15;
            this.txtMarcaBus.Name = "txtMarcaBus";
            this.txtMarcaBus.Size = new System.Drawing.Size(100, 22);
            this.txtMarcaBus.TabIndex = 16;
            this.txtMarcaBus.TextChanged += new System.EventHandler(this.txtMarcaBus_TextChanged);
            this.txtMarcaBus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarcaBus_KeyPress);
            // 
            // txtModeloBus
            // 
            this.txtModeloBus.BackColor = System.Drawing.Color.DarkOrange;
            this.txtModeloBus.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeloBus.ForeColor = System.Drawing.Color.Black;
            this.txtModeloBus.Location = new System.Drawing.Point(330, 109);
            this.txtModeloBus.MaxLength = 15;
            this.txtModeloBus.Name = "txtModeloBus";
            this.txtModeloBus.Size = new System.Drawing.Size(100, 22);
            this.txtModeloBus.TabIndex = 17;
            // 
            // txtColorBus
            // 
            this.txtColorBus.BackColor = System.Drawing.Color.DarkOrange;
            this.txtColorBus.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorBus.ForeColor = System.Drawing.Color.Black;
            this.txtColorBus.Location = new System.Drawing.Point(330, 219);
            this.txtColorBus.MaxLength = 10;
            this.txtColorBus.Name = "txtColorBus";
            this.txtColorBus.Size = new System.Drawing.Size(100, 22);
            this.txtColorBus.TabIndex = 18;
            this.txtColorBus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColorBus_KeyPress);
            // 
            // ErrorP
            // 
            this.ErrorP.ContainerControl = this;
            // 
            // dtpAno
            // 
            this.dtpAno.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtpAno.CustomFormat = "yyyy";
            this.dtpAno.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAno.Location = new System.Drawing.Point(327, 149);
            this.dtpAno.Name = "dtpAno";
            this.dtpAno.Size = new System.Drawing.Size(110, 23);
            this.dtpAno.TabIndex = 19;
            // 
            // pnlBus
            // 
            this.pnlBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(29)))));
            this.pnlBus.Controls.Add(this.btnEliminar);
            this.pnlBus.Controls.Add(this.btnCancelar);
            this.pnlBus.Controls.Add(this.label1);
            this.pnlBus.Controls.Add(this.btnEditarBus);
            this.pnlBus.Controls.Add(this.pictureBox2);
            this.pnlBus.Controls.Add(this.btnGuardarBus);
            this.pnlBus.Controls.Add(this.btnRegistrarBus);
            this.pnlBus.Controls.Add(this.picboxlateral);
            this.pnlBus.Controls.Add(this.pcbItla);
            this.pnlBus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBus.Location = new System.Drawing.Point(0, 0);
            this.pnlBus.Name = "pnlBus";
            this.pnlBus.Size = new System.Drawing.Size(181, 542);
            this.pnlBus.TabIndex = 24;
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
            this.btnEliminar.Location = new System.Drawing.Point(0, 214);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(181, 43);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(0, 263);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(181, 45);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "       Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dewry GP";
            // 
            // btnEditarBus
            // 
            this.btnEditarBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditarBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarBus.FlatAppearance.BorderSize = 0;
            this.btnEditarBus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnEditarBus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnEditarBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarBus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarBus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditarBus.Image = global::SisControlBus.Properties.Resources.icons8_editar_60;
            this.btnEditarBus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarBus.Location = new System.Drawing.Point(0, 161);
            this.btnEditarBus.Name = "btnEditarBus";
            this.btnEditarBus.Size = new System.Drawing.Size(181, 47);
            this.btnEditarBus.TabIndex = 3;
            this.btnEditarBus.Text = "Editar";
            this.btnEditarBus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarBus.UseVisualStyleBackColor = false;
            this.btnEditarBus.Click += new System.EventHandler(this.btnEditarBus_Click_2);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 492);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 50);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnGuardarBus
            // 
            this.btnGuardarBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardarBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarBus.FlatAppearance.BorderSize = 0;
            this.btnGuardarBus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnGuardarBus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnGuardarBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarBus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarBus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardarBus.Image = global::SisControlBus.Properties.Resources.icons8_guardar_48;
            this.btnGuardarBus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarBus.Location = new System.Drawing.Point(0, 109);
            this.btnGuardarBus.Name = "btnGuardarBus";
            this.btnGuardarBus.Size = new System.Drawing.Size(181, 45);
            this.btnGuardarBus.TabIndex = 2;
            this.btnGuardarBus.Text = "Guardar";
            this.btnGuardarBus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarBus.UseVisualStyleBackColor = false;
            this.btnGuardarBus.Click += new System.EventHandler(this.btnGuardarBus_Click_2);
            // 
            // btnRegistrarBus
            // 
            this.btnRegistrarBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegistrarBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarBus.FlatAppearance.BorderSize = 0;
            this.btnRegistrarBus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnRegistrarBus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnRegistrarBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarBus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarBus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrarBus.Image = global::SisControlBus.Properties.Resources.icons8_crear_nuevo_50;
            this.btnRegistrarBus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarBus.Location = new System.Drawing.Point(0, 50);
            this.btnRegistrarBus.Name = "btnRegistrarBus";
            this.btnRegistrarBus.Size = new System.Drawing.Size(181, 53);
            this.btnRegistrarBus.TabIndex = 1;
            this.btnRegistrarBus.Text = "Registrar";
            this.btnRegistrarBus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarBus.UseVisualStyleBackColor = false;
            this.btnRegistrarBus.Click += new System.EventHandler(this.btnRegistrarBus_Click_2);
            // 
            // picboxlateral
            // 
            this.picboxlateral.BackColor = System.Drawing.Color.White;
            this.picboxlateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picboxlateral.Location = new System.Drawing.Point(0, 50);
            this.picboxlateral.Name = "picboxlateral";
            this.picboxlateral.Size = new System.Drawing.Size(181, 492);
            this.picboxlateral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxlateral.TabIndex = 4;
            this.picboxlateral.TabStop = false;
            // 
            // pcbItla
            // 
            this.pcbItla.BackColor = System.Drawing.Color.White;
            this.pcbItla.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcbItla.Location = new System.Drawing.Point(0, 0);
            this.pcbItla.Name = "pcbItla";
            this.pcbItla.Size = new System.Drawing.Size(181, 50);
            this.pcbItla.TabIndex = 5;
            this.pcbItla.TabStop = false;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chkEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminar.ForeColor = System.Drawing.Color.White;
            this.chkEliminar.Location = new System.Drawing.Point(816, 214);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(72, 20);
            this.chkEliminar.TabIndex = 28;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = false;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::SisControlBus.Properties.Resources.autobus;
            this.pictureBox1.Location = new System.Drawing.Point(303, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frmAutobus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 542);
            this.Controls.Add(this.chkEliminar);
            this.Controls.Add(this.pnlBus);
            this.Controls.Add(this.dtpAno);
            this.Controls.Add(this.txtColorBus);
            this.Controls.Add(this.txtModeloBus);
            this.Controls.Add(this.txtMarcaBus);
            this.Controls.Add(this.txtPlacaBus);
            this.Controls.Add(this.txtIDBus);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblIDAutobus);
            this.Controls.Add(this.dgvAutobus);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAutobus";
            this.Text = "frmAutobus";
            this.Load += new System.EventHandler(this.frmAutobus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutobus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorP)).EndInit();
            this.pnlBus.ResumeLayout(false);
            this.pnlBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlateral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutobus;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblIDAutobus;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtIDBus;
        private System.Windows.Forms.TextBox txtPlacaBus;
        private System.Windows.Forms.TextBox txtMarcaBus;
        private System.Windows.Forms.TextBox txtModeloBus;
        private System.Windows.Forms.TextBox txtColorBus;
        private System.Windows.Forms.ErrorProvider ErrorP;
        private System.Windows.Forms.DateTimePicker dtpAno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlBus;
        private System.Windows.Forms.PictureBox picboxlateral;
        public System.Windows.Forms.Button btnRegistrarBus;
        public System.Windows.Forms.Button btnGuardarBus;
        public System.Windows.Forms.Button btnEditarBus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pcbItla;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EliminarA;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
    }
}