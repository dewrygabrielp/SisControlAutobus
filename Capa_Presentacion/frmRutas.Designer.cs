namespace Capa_Presentacion
{
    partial class frmRutas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.txtIDRuta = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.lblIDRuta = new System.Windows.Forms.Label();
            this.dgvRutas = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ErrorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlRutas = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarRuta = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditarRuta = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picboxlateral = new System.Windows.Forms.PictureBox();
            this.btnRegistrarRuta = new System.Windows.Forms.Button();
            this.pcbItla = new System.Windows.Forms.PictureBox();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorP)).BeginInit();
            this.pnlRutas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlateral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRuta
            // 
            this.txtRuta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRuta.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRuta.Location = new System.Drawing.Point(308, 41);
            this.txtRuta.MaxLength = 100;
            this.txtRuta.Multiline = true;
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtRuta.Size = new System.Drawing.Size(176, 51);
            this.txtRuta.TabIndex = 19;
            // 
            // txtIDRuta
            // 
            this.txtIDRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIDRuta.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDRuta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIDRuta.Location = new System.Drawing.Point(308, 16);
            this.txtIDRuta.Name = "txtIDRuta";
            this.txtIDRuta.ReadOnly = true;
            this.txtIDRuta.Size = new System.Drawing.Size(53, 26);
            this.txtIDRuta.TabIndex = 18;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.BackColor = System.Drawing.Color.White;
            this.lblRuta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblRuta.Location = new System.Drawing.Point(227, 50);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(47, 19);
            this.lblRuta.TabIndex = 17;
            this.lblRuta.Text = "Ruta:";
            // 
            // lblIDRuta
            // 
            this.lblIDRuta.AutoSize = true;
            this.lblIDRuta.BackColor = System.Drawing.Color.White;
            this.lblIDRuta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblIDRuta.Location = new System.Drawing.Point(217, 16);
            this.lblIDRuta.Name = "lblIDRuta";
            this.lblIDRuta.Size = new System.Drawing.Size(66, 19);
            this.lblIDRuta.TabIndex = 16;
            this.lblIDRuta.Text = "ID Ruta:";
            // 
            // dgvRutas
            // 
            this.dgvRutas.AllowUserToAddRows = false;
            this.dgvRutas.AllowUserToDeleteRows = false;
            this.dgvRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRutas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRutas.BackgroundColor = System.Drawing.Color.White;
            this.dgvRutas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRutas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRutas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvRutas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRutas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRutas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRutas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvRutas.Location = new System.Drawing.Point(199, 215);
            this.dgvRutas.Name = "dgvRutas";
            this.dgvRutas.ReadOnly = true;
            this.dgvRutas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRutas.RowHeadersVisible = false;
            this.dgvRutas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRutas.Size = new System.Drawing.Size(700, 315);
            this.dgvRutas.TabIndex = 20;
            this.dgvRutas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRutas_CellContentClick);
            this.dgvRutas.DoubleClick += new System.EventHandler(this.dgvRutas_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // ErrorP
            // 
            this.ErrorP.ContainerControl = this;
            // 
            // pnlRutas
            // 
            this.pnlRutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(29)))));
            this.pnlRutas.Controls.Add(this.btnCancelar);
            this.pnlRutas.Controls.Add(this.btnGuardarRuta);
            this.pnlRutas.Controls.Add(this.btnEliminar);
            this.pnlRutas.Controls.Add(this.label1);
            this.pnlRutas.Controls.Add(this.btnEditarRuta);
            this.pnlRutas.Controls.Add(this.pictureBox2);
            this.pnlRutas.Controls.Add(this.picboxlateral);
            this.pnlRutas.Controls.Add(this.btnRegistrarRuta);
            this.pnlRutas.Controls.Add(this.pcbItla);
            this.pnlRutas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRutas.Location = new System.Drawing.Point(0, 0);
            this.pnlRutas.Name = "pnlRutas";
            this.pnlRutas.Size = new System.Drawing.Size(200, 542);
            this.pnlRutas.TabIndex = 21;
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
            this.btnCancelar.Location = new System.Drawing.Point(0, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 40);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "       Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarRuta
            // 
            this.btnGuardarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardarRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarRuta.FlatAppearance.BorderSize = 0;
            this.btnGuardarRuta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnGuardarRuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnGuardarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRuta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRuta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardarRuta.Image = global::SisControlBus.Properties.Resources.icons8_guardar_48;
            this.btnGuardarRuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarRuta.Location = new System.Drawing.Point(0, 109);
            this.btnGuardarRuta.Name = "btnGuardarRuta";
            this.btnGuardarRuta.Size = new System.Drawing.Size(200, 40);
            this.btnGuardarRuta.TabIndex = 14;
            this.btnGuardarRuta.Text = "       Guardar";
            this.btnGuardarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarRuta.UseVisualStyleBackColor = false;
            this.btnGuardarRuta.Click += new System.EventHandler(this.btnGuardarRuta_Click_1);
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
            this.btnEliminar.Location = new System.Drawing.Point(0, 201);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(200, 40);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = " Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(63, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dewry GP";
            // 
            // btnEditarRuta
            // 
            this.btnEditarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditarRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarRuta.FlatAppearance.BorderSize = 0;
            this.btnEditarRuta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnEditarRuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnEditarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarRuta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRuta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditarRuta.Image = global::SisControlBus.Properties.Resources.icons8_editar_60;
            this.btnEditarRuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarRuta.Location = new System.Drawing.Point(0, 155);
            this.btnEditarRuta.Name = "btnEditarRuta";
            this.btnEditarRuta.Size = new System.Drawing.Size(200, 40);
            this.btnEditarRuta.TabIndex = 8;
            this.btnEditarRuta.Text = "Editar";
            this.btnEditarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarRuta.UseVisualStyleBackColor = false;
            this.btnEditarRuta.Click += new System.EventHandler(this.btnEditarRuta_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 492);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 50);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // picboxlateral
            // 
            this.picboxlateral.BackColor = System.Drawing.Color.White;
            this.picboxlateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picboxlateral.Location = new System.Drawing.Point(0, 103);
            this.picboxlateral.Name = "picboxlateral";
            this.picboxlateral.Size = new System.Drawing.Size(200, 439);
            this.picboxlateral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxlateral.TabIndex = 9;
            this.picboxlateral.TabStop = false;
            // 
            // btnRegistrarRuta
            // 
            this.btnRegistrarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegistrarRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarRuta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarRuta.FlatAppearance.BorderSize = 0;
            this.btnRegistrarRuta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnRegistrarRuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnRegistrarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarRuta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarRuta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrarRuta.Image = global::SisControlBus.Properties.Resources.icons8_crear_nuevo_50;
            this.btnRegistrarRuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarRuta.Location = new System.Drawing.Point(0, 50);
            this.btnRegistrarRuta.Name = "btnRegistrarRuta";
            this.btnRegistrarRuta.Size = new System.Drawing.Size(200, 53);
            this.btnRegistrarRuta.TabIndex = 13;
            this.btnRegistrarRuta.Text = "     Registrar";
            this.btnRegistrarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarRuta.UseVisualStyleBackColor = false;
            this.btnRegistrarRuta.Click += new System.EventHandler(this.btnRegistrarRuta_Click_1);
            // 
            // pcbItla
            // 
            this.pcbItla.BackColor = System.Drawing.Color.White;
            this.pcbItla.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcbItla.Location = new System.Drawing.Point(0, 0);
            this.pcbItla.Name = "pcbItla";
            this.pcbItla.Size = new System.Drawing.Size(200, 50);
            this.pcbItla.TabIndex = 10;
            this.pcbItla.TabStop = false;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.chkEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminar.ForeColor = System.Drawing.Color.White;
            this.chkEliminar.Location = new System.Drawing.Point(202, 189);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(72, 20);
            this.chkEliminar.TabIndex = 24;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = false;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SisControlBus.Properties.Resources.autobus;
            this.pictureBox1.Location = new System.Drawing.Point(490, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 542);
            this.Controls.Add(this.chkEliminar);
            this.Controls.Add(this.pnlRutas);
            this.Controls.Add(this.dgvRutas);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.txtIDRuta);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.lblIDRuta);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRutas";
            this.Opacity = 0.9D;
            this.Text = "6";
            this.Load += new System.EventHandler(this.frmRutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorP)).EndInit();
            this.pnlRutas.ResumeLayout(false);
            this.pnlRutas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlateral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblIDRuta;
        private System.Windows.Forms.ErrorProvider ErrorP;
        public System.Windows.Forms.TextBox txtRuta;
        public System.Windows.Forms.TextBox txtIDRuta;
        public System.Windows.Forms.DataGridView dgvRutas;
        public System.Windows.Forms.Panel pnlRutas;
        public System.Windows.Forms.Button btnGuardarRuta;
        public System.Windows.Forms.Button btnRegistrarRuta;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnEditarRuta;
        private System.Windows.Forms.PictureBox picboxlateral;
        private System.Windows.Forms.PictureBox pcbItla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCancelar;
    }
}