namespace ProyectoEstructuraFinanzas
{
    partial class FormAgregarPagoRecurrente
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMonto = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtIntervaloDias = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblIntervaloDias = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(133, 71);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripcion";
            this.lblDescripcion.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.DefaultText = "";
            this.txtDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.Location = new System.Drawing.Point(273, 71);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.Size = new System.Drawing.Size(288, 44);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtMonto
            // 
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonto.DefaultText = "";
            this.txtMonto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMonto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMonto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMonto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonto.Location = new System.Drawing.Point(273, 151);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.PlaceholderText = "";
            this.txtMonto.SelectedText = "";
            this.txtMonto.Size = new System.Drawing.Size(288, 44);
            this.txtMonto.TabIndex = 3;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(133, 151);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(44, 16);
            this.lblMonto.TabIndex = 2;
            this.lblMonto.Text = "Monto";
            // 
            // txtIntervaloDias
            // 
            this.txtIntervaloDias.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIntervaloDias.DefaultText = "";
            this.txtIntervaloDias.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIntervaloDias.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIntervaloDias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIntervaloDias.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIntervaloDias.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIntervaloDias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIntervaloDias.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIntervaloDias.Location = new System.Drawing.Point(273, 315);
            this.txtIntervaloDias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIntervaloDias.Name = "txtIntervaloDias";
            this.txtIntervaloDias.PasswordChar = '\0';
            this.txtIntervaloDias.PlaceholderText = "";
            this.txtIntervaloDias.SelectedText = "";
            this.txtIntervaloDias.Size = new System.Drawing.Size(288, 44);
            this.txtIntervaloDias.TabIndex = 5;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(133, 231);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(98, 16);
            this.lblFechaInicio.TabIndex = 4;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            this.lblFechaInicio.Click += new System.EventHandler(this.lblFechaInicio_Click);
            // 
            // lblIntervaloDias
            // 
            this.lblIntervaloDias.AutoSize = true;
            this.lblIntervaloDias.Location = new System.Drawing.Point(133, 315);
            this.lblIntervaloDias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntervaloDias.Name = "lblIntervaloDias";
            this.lblIntervaloDias.Size = new System.Drawing.Size(120, 16);
            this.lblIntervaloDias.TabIndex = 6;
            this.lblIntervaloDias.Text = "Intervalo en Meses";
            this.lblIntervaloDias.Click += new System.EventHandler(this.lblIntervaloDias_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = true;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker1.Location = new System.Drawing.Point(273, 231);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 44);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2024, 5, 26, 0, 22, 18, 790);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(273, 409);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(288, 55);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormAgregarPagoRecurrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblIntervaloDias);
            this.Controls.Add(this.txtIntervaloDias);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAgregarPagoRecurrente";
            this.Text = "FormAgregarPagoRecurrente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
        private Guna.UI2.WinForms.Guna2TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private Guna.UI2.WinForms.Guna2TextBox txtIntervaloDias;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblIntervaloDias;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
    }
}