using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoEstructuraFinanzas
{
    public partial class Form1 : Form
    {
        private const string UserFilePath = "users.json";
        private Dictionary<string, string> users;
        private string currentUser;

        public Form1()
        {

            InitializeComponent();
            CargarUsuarios();

        }
        private void CargarUsuarios()
        {
            if (File.Exists(UserFilePath))
            {
                var json = File.ReadAllText(UserFilePath);
                users = JsonConvert.DeserializeObject<Dictionary<string, string>>(json) ?? new Dictionary<string, string>();
            }
            else
            {
                users = new Dictionary<string, string>();
            }
        }
        private void SaveUsers()
        {
            var json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(UserFilePath, json);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var username = txtUsuario.Text;
            var password = txtContraseña.Text;

            if (users.ContainsKey(username) && users[username] == password)
            {
                currentUser = username;
                this.Hide();
                var form2 = new Form2(username);
                form2.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var registrarForm = new Form3();
            registrarForm.Show();
            this.Hide();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //cerrar la aplicacion
            Application.Exit();

        }
        private string GetUserFilePath(string username)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{username}_data.json");
        }
    }
}