using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoEstructuraFinanzas.Form3;

namespace ProyectoEstructuraFinanzas
{
    public partial class Form2 : Form
    {
        private string currentUser;
        private UsuarioData _usuarioData;
        public Form2(string user)
        {
            InitializeComponent();
            currentUser = user;
            _usuarioData = new UsuarioData();

            //labelHora.BackColor = Color.Transparent;

            //Timer timer = new Timer();
            //timer.Interval = 1000; // 1000 ms = 1 segundo
            //timer.Tick += new EventHandler(ActualizarHoraYFecha);
            //timer.Start();
        }
        //private void ActualizarHoraYFecha(object sender, EventArgs e)
        //{
        //    // Actualiza el label de la hora
        //    labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        //    // Actualiza el label de la fecha
        //    labelFecha.Text = CapitalizeFirstLetter(DateTime.Now.ToString("dddd, MMMM dd, yyyy", new CultureInfo("es-ES")));
        //}

        private string CapitalizeFirstLetter(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
                else if (words[i].Length == 1)
                {
                    words[i] = words[i].ToUpper();
                }
            }
            return string.Join(" ", words);
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
            //if(!bunifuCards2.Visible)
            //{
            //    guna2Transition1.ShowSync(bunifuCards2);
             
            //}
            //else
            //{
            //    guna2Transition1.HideSync(bunifuCards2);
            
            //}
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
            var userFilePath = GetUserFilePath(currentUser);
            openChildForm(new Registrar(userFilePath));
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var userFilePath = GetUserFilePath(currentUser);
            openChildForm(new Seguimiento(userFilePath));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelHijo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var userFilePath = GetUserFilePath(currentUser);
            openChildForm(new Planificacion()); // Asegúrate de pasar _usuarioData

        }
        private string GetUserFilePath(string username)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{username}_data.json");
        }
    }
}
