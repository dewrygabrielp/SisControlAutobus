namespace Capa_Presentacion
{
    partial class frmEstudiantes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.lblCantEstudiantes = new System.Windows.Forms.Label();
            this.txtBuscarRuta = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.AllowUserToAddRows = false;
            this.dgvEstudiantes.AllowUserToDeleteRows = false;
            this.dgvEstudiantes.AllowUserToOrderColumns = true;
            this.dgvEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEstudiantes.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstudiantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstudiantes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstudiantes.GridColor = System.Drawing.Color.White;
            this.dgvEstudiantes.Location = new System.Drawing.Point(-1, 192);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.ReadOnly = true;
            this.dgvEstudiantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEstudiantes.RowHeadersVisible = false;
            this.dgvEstudiantes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiantes.Size = new System.Drawing.Size(900, 349);
            this.dgvEstudiantes.TabIndex = 0;
            // 
            // lblCantEstudiantes
            // 
            this.lblCantEstudiantes.AutoSize = true;
            this.lblCantEstudiantes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCantEstudiantes.Location = new System.Drawing.Point(208, 122);
            this.lblCantEstudiantes.Name = "lblCantEstudiantes";
            this.lblCantEstudiantes.Size = new System.Drawing.Size(128, 17);
            this.lblCantEstudiantes.TabIndex = 1;
            this.lblCantEstudiantes.Text = "lblCantEstudiantes";
            // 
            // txtBuscarRuta
            // 
            this.txtBuscarRuta.Location = new System.Drawing.Point(314, 55);
            this.txtBuscarRuta.Name = "txtBuscarRuta";
            this.txtBuscarRuta.Size = new System.Drawing.Size(294, 23);
            this.txtBuscarRuta.TabIndex = 2;
            this.txtBuscarRuta.TextChanged += new System.EventHandler(this.txtBuscarRuta_TextChanged);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(208, 58);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(100, 16);
            this.lblRuta.TabIndex = 3;
            this.lblRuta.Text = "Digite la Ruta:";
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
            this.btnEliminar.Location = new System.Drawing.Point(733, 122);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 51);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsertar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInsertar.Image = global::SisControlBus.Properties.Resources.icons8_guardar_48;
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.Location = new System.Drawing.Point(593, 122);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnInsertar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInsertar.Size = new System.Drawing.Size(134, 51);
            this.btnInsertar.TabIndex = 8;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SisControlBus.Properties.Resources.icons8_espionaje_60;
            this.pictureBox1.Location = new System.Drawing.Point(605, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.txtBuscarRuta);
            this.Controls.Add(this.lblCantEstudiantes);
            this.Controls.Add(this.dgvEstudiantes);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEstudiantes";
            this.Text = "frmEstudiantes";
            this.Load += new System.EventHandler(this.frmEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Label lblCantEstudiantes;
        private System.Windows.Forms.TextBox txtBuscarRuta;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}