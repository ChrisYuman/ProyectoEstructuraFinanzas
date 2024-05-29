namespace ProyectoEstructuraFinanzas
{
    partial class FormMetas
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
            this.txtNombreMeta = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMontoDeseado = new Guna.UI2.WinForms.Guna2TextBox();
            this.lstMetas = new System.Windows.Forms.ListBox();
            this.dtpFechaObjetivo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAgregarMeta = new Guna.UI2.WinForms.Guna2Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreMeta
            // 
            this.txtNombreMeta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreMeta.DefaultText = "";
            this.txtNombreMeta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreMeta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreMeta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreMeta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreMeta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreMeta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreMeta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreMeta.Location = new System.Drawing.Point(38, 59);
            this.txtNombreMeta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombreMeta.Name = "txtNombreMeta";
            this.txtNombreMeta.PasswordChar = '\0';
            this.txtNombreMeta.PlaceholderText = "";
            this.txtNombreMeta.SelectedText = "";
            this.txtNombreMeta.Size = new System.Drawing.Size(172, 39);
            this.txtNombreMeta.TabIndex = 0;
            // 
            // txtMontoDeseado
            // 
            this.txtMontoDeseado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontoDeseado.DefaultText = "";
            this.txtMontoDeseado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMontoDeseado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMontoDeseado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMontoDeseado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMontoDeseado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMontoDeseado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMontoDeseado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMontoDeseado.Location = new System.Drawing.Point(38, 148);
            this.txtMontoDeseado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMontoDeseado.Name = "txtMontoDeseado";
            this.txtMontoDeseado.PasswordChar = '\0';
            this.txtMontoDeseado.PlaceholderText = "";
            this.txtMontoDeseado.SelectedText = "";
            this.txtMontoDeseado.Size = new System.Drawing.Size(172, 39);
            this.txtMontoDeseado.TabIndex = 1;
            // 
            // lstMetas
            // 
            this.lstMetas.FormattingEnabled = true;
            this.lstMetas.Location = new System.Drawing.Point(292, 46);
            this.lstMetas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstMetas.Name = "lstMetas";
            this.lstMetas.Size = new System.Drawing.Size(270, 277);
            this.lstMetas.TabIndex = 3;
            // 
            // dtpFechaObjetivo
            // 
            this.dtpFechaObjetivo.Checked = true;
            this.dtpFechaObjetivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaObjetivo.ForeColor = System.Drawing.SystemColors.Control;
            this.dtpFechaObjetivo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaObjetivo.Location = new System.Drawing.Point(20, 223);
            this.dtpFechaObjetivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaObjetivo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaObjetivo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaObjetivo.Name = "dtpFechaObjetivo";
            this.dtpFechaObjetivo.Size = new System.Drawing.Size(206, 29);
            this.dtpFechaObjetivo.TabIndex = 4;
            this.dtpFechaObjetivo.Value = new System.DateTime(2024, 5, 28, 23, 2, 17, 548);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(259, 366);
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnAgregarMeta
            // 
            this.btnAgregarMeta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarMeta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarMeta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarMeta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarMeta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarMeta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMeta.Location = new System.Drawing.Point(56, 285);
            this.btnAgregarMeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarMeta.Name = "btnAgregarMeta";
            this.btnAgregarMeta.Size = new System.Drawing.Size(135, 37);
            this.btnAgregarMeta.TabIndex = 6;
            this.btnAgregarMeta.Text = "Guardar";
            this.btnAgregarMeta.Click += new System.EventHandler(this.btnAgregarMeta_Click_1);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblMonto.Location = new System.Drawing.Point(35, 132);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 8;
            this.lblMonto.Text = "Monto";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDescripcion.Location = new System.Drawing.Point(35, 43);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // FormMetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnAgregarMeta);
            this.Controls.Add(this.dtpFechaObjetivo);
            this.Controls.Add(this.lstMetas);
            this.Controls.Add(this.txtMontoDeseado);
            this.Controls.Add(this.txtNombreMeta);
            this.Controls.Add(this.guna2PictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMetas";
            this.Text = "FormMetas";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtNombreMeta;
        private Guna.UI2.WinForms.Guna2TextBox txtMontoDeseado;
        private System.Windows.Forms.ListBox lstMetas;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaObjetivo;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnAgregarMeta;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblDescripcion;
    }
}