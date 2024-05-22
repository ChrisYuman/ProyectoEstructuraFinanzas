using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ProyectoEstructuraFinanzas
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {
            // Inicializar categorías
            InicializarCategorias();
        }

        private void InicializarCategorias()
        {
            // Agregar categorías al ComboBox
            cmbCategoria.Items.Add("Alimentos");
            cmbCategoria.Items.Add("Transporte");
            cmbCategoria.Items.Add("Entretenimiento");
            cmbCategoria.Items.Add("Salud");
            cmbCategoria.Items.Add("Otros");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar los campos antes de guardar
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                cmbCategoria.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtMonto.Text) ||
                !decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show("Por favor, completa todos los campos correctamente.");
                return;
            }

            // Crear un nuevo registro
            var registro = new Registro
            {
                Descripcion = txtDescripcion.Text,
                Categoria = cmbCategoria.SelectedItem.ToString(),
                Monto = monto,
                Fecha = DateTime.Now
            };

            // Ruta del archivo JSON
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "registros.json");

            // Leer registros existentes
            List<Registro> registros;
            if (File.Exists(jsonFilePath))
            {
                var jsonData = File.ReadAllText(jsonFilePath);
                registros = JsonConvert.DeserializeObject<List<Registro>>(jsonData) ?? new List<Registro>();
            }
            else
            {
                registros = new List<Registro>();
            }

            // Agregar el nuevo registro a la lista
            registros.Add(registro);

            // Guardar la lista de registros en el archivo JSON
            var jsonString = JsonConvert.SerializeObject(registros, Formatting.Indented);
            File.WriteAllText(jsonFilePath, jsonString);

            MessageBox.Show("Registro guardado exitosamente.");
            txtDescripcion.Clear();
            cmbCategoria.Items.Clear();
            txtMonto.Clear();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Registro
    {
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }
}

