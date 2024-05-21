using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstructuraFinanzas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            //cambio de pantalla a form1
            Form1 form1 = new Form1();
                form1.Show();
            this.Hide();

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if(!bunifuCards2.Visible)
            {
                guna2Transition1.ShowSync(bunifuCards2);
                guna2Transition1.ShowSync(bunifuCards3);
                guna2Transition1.ShowSync(bunifuCards4);


            }
            else
            {
                guna2Transition1.HideSync(bunifuCards2);
                guna2Transition1.HideSync(bunifuCards3);
                guna2Transition1.HideSync(bunifuCards4);
            }
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelHijo.Controls.Add(childForm);
            panelHijo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Registrar());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Seguimiento());
        }
    }
}
