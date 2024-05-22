namespace ProyectoEstructuraFinanzas
{
    partial class PresupuestoForm
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
            this.txtPresupuesto = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGuardarPresupuesto = new Guna.UI2.WinForms.Guna2Button();
            this.lblPresupuestoActual = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPresupuesto.DefaultText = "";
            this.txtPresupuesto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPresupuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPresupuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPresupuesto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPresupuesto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPresupuesto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPresupuesto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPresupuesto.Location = new System.Drawing.Point(119, 69);
            this.txtPresupuesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.PasswordChar = '\0';
            this.txtPresupuesto.PlaceholderText = "";
            this.txtPresupuesto.SelectedText = "";
            this.txtPresupuesto.Size = new System.Drawing.Size(229, 48);
            this.txtPresupuesto.TabIndex = 0;
            // 
            // btnGuardarPresupuesto
            // 
            this.btnGuardarPresupuesto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarPresupuesto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarPresupuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardarPresupuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardarPresupuesto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardarPresupuesto.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPresupuesto.Location = new System.Drawing.Point(119, 159);
            this.btnGuardarPresupuesto.Name = "btnGuardarPresupuesto";
            this.btnGuardarPresupuesto.Size = new System.Drawing.Size(180, 45);
            this.btnGuardarPresupuesto.TabIndex = 1;
            this.btnGuardarPresupuesto.Text = "Añadir Fondos";
            this.btnGuardarPresupuesto.Click += new System.EventHandler(this.btnGuardarPresupuesto_Click);
            // 
            // lblPresupuestoActual
            // 
            this.lblPresupuestoActual.AutoSize = true;
            this.lblPresupuestoActual.Location = new System.Drawing.Point(492, 170);
            this.lblPresupuestoActual.Name = "lblPresupuestoActual";
            this.lblPresupuestoActual.Size = new System.Drawing.Size(44, 16);
            this.lblPresupuestoActual.TabIndex = 2;
            this.lblPresupuestoActual.Text = "label1";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(119, 243);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Cancelar";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // PresupuestoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.lblPresupuestoActual);
            this.Controls.Add(this.btnGuardarPresupuesto);
            this.Controls.Add(this.txtPresupuesto);
            this.Name = "PresupuestoForm";
            this.Text = "PresupuestoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtPresupuesto;
        private Guna.UI2.WinForms.Guna2Button btnGuardarPresupuesto;
        private System.Windows.Forms.Label lblPresupuestoActual;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}