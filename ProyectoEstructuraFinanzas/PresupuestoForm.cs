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
using static ProyectoEstructuraFinanzas.Form3;
using System.IO;


namespace ProyectoEstructuraFinanzas
{
    public partial class PresupuestoForm : Form
    {
        private string _userFilePath;
        private UsuarioData _usuarioData;

        public decimal Presupuesto { get; private set; }

        public PresupuestoForm(string userFilePath, decimal presupuestoActual)
        {
            InitializeComponent();
            _userFilePath = userFilePath;
            CargarUsuarioData(); // Cargar los datos del usuario al iniciar el formulario
            lblPresupuestoActual.Text = $"Presupuesto Actual: Q{_usuarioData.Presupuesto:N2}";
        }

        private void btnGuardarPresupuesto_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPresupuesto.Text, out decimal presupuesto))
            {
                Presupuesto = _usuarioData.Presupuesto + presupuesto; // Sumar al presupuesto existente
                GuardarPresupuesto(Presupuesto);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un presupuesto válido.");
            }
        }

        private void GuardarPresupuesto(decimal presupuesto)
        {
            _usuarioData.Presupuesto = presupuesto;
            var jsonString = JsonConvert.SerializeObject(_usuarioData, Formatting.Indented);
            File.WriteAllText(_userFilePath, jsonString);
        }

        private void CargarUsuarioData()
        {
            if (File.Exists(_userFilePath))
            {
                var jsonData = File.ReadAllText(_userFilePath);
                _usuarioData = JsonConvert.DeserializeObject<UsuarioData>(jsonData);
            }
            else
            {
                _usuarioData = new UsuarioData();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
