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
    public partial class Form3 : Form
    {
        private const string FilePath = "users.json";
        private Dictionary<string, string> users;
        public Form3()
        {
            InitializeComponent();
            LoadUsers();

        }
        private void LoadUsers()
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
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
            File.WriteAllText(FilePath, json);
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var username = txtUsuario.Text;
            var password = txtContraseña.Text;
            var confirmPassword = txtConfirmar.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("La contraseña no coincide");
                return;
            }

            if (!users.ContainsKey(username))
            {
                users.Add(username, password);
                SaveUsers();
                MessageBox.Show("Usuario Registrado Exitosamente");
                this.Close();
                var loginForm = new Form1();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("El usuario ya existe");
            }
        }
        private void CreateUserFile(string username)
        {
            var userFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{username}_data.json");
            var userData = new UsuarioData();
            var jsonString = JsonConvert.SerializeObject(userData, Formatting.Indented);
            File.WriteAllText(userFilePath, jsonString);
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            var loginForm = new Form1();
            loginForm.Show();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
        public class UsuarioData
        {
            public decimal Presupuesto { get; set; }
            public List<Registro> Registros { get; set; } = new List<Registro>();
            public List<PagoRecurrente> PagosRecurrentes { get; set; } = new List<PagoRecurrente>();

        }
    }
}
