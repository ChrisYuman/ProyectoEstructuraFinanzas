using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using static ProyectoEstructuraFinanzas.Form3;

namespace ProyectoEstructuraFinanzas
{
    public partial class Registrar : Form
    {
        private string _userFilePath;
        private UsuarioData _usuarioData;

        public Registrar(string userFilePath)
        {
            InitializeComponent();
            _userFilePath = userFilePath;
        }

        private void Registrar_Load(object sender, EventArgs e)
        {
            if (!File.Exists(_userFilePath))
            {
                _usuarioData = new UsuarioData();
                using (var presupuestoForm = new PresupuestoForm(_userFilePath, _usuarioData.Presupuesto))
                {
                    if (presupuestoForm.ShowDialog() == DialogResult.OK)
                    {
                        _usuarioData.Presupuesto = presupuestoForm.Presupuesto;
                        GuardarUsuarioData();
                    }
                    else
                    {
                        this.Close();
                        return;
                    }
                }
            }
            else
            {
                var jsonData = File.ReadAllText(_userFilePath);
                _usuarioData = JsonConvert.DeserializeObject<UsuarioData>(jsonData);
            }

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
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                cmbCategoria.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtMonto.Text) ||
                !decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show("Por favor, completa todos los campos correctamente.");
                return;
            }

            // Obtener la fecha seleccionada del DateTimePicker
            DateTime fecha = dateTimePicker1.Value;

            var registro = new Registro
            {
                Descripcion = txtDescripcion.Text,
                Categoria = cmbCategoria.SelectedItem.ToString(),
                Monto = monto,
                Fecha = fecha // Aquí se agrega la fecha seleccionada
            };

            _usuarioData.Registros.Add(registro);
            _usuarioData.Presupuesto -= monto;

            GuardarUsuarioData();

            MessageBox.Show("Registro guardado exitosamente.");
            txtDescripcion.Clear();
            cmbCategoria.SelectedItem = null;
            txtMonto.Clear();
        }


        private void GuardarUsuarioData()
        {
            var jsonString = JsonConvert.SerializeObject(_usuarioData, Formatting.Indented);
            File.WriteAllText(_userFilePath, jsonString);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            // Lógica para el cambio de texto en txtDescripcion
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            // Lógica para el cambio de texto en txtMonto
        }

        private void btnActualizarPresupuesto_Click(object sender, EventArgs e)
        {
            using (var presupuestoForm = new PresupuestoForm(_userFilePath, _usuarioData.Presupuesto))
            {
                if (presupuestoForm.ShowDialog() == DialogResult.OK)
                {
                    _usuarioData.Presupuesto = presupuestoForm.Presupuesto;
                    GuardarUsuarioData();
                }
            }
        }
        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el control que generó el evento es un TextBox
            if (sender is TextBox textBox)
            {
                // Permitir solo números y el carácter de punto para decimales
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // Solo permitir un punto decimal
                if ((e.KeyChar == '.') && (textBox.Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }

    }
    public class Registro
    {
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class UsuarioData
    {
        public decimal Presupuesto { get; set; }
        public List<Registro> Registros { get; set; } = new List<Registro>();

        public void AgregarGasto(decimal monto, DateTime fecha, string descripcion)
        {
            Registros.Add(new Registro { Monto = -Math.Abs(monto), Fecha = fecha, Descripcion = descripcion });
        }

        public void AgregarIngreso(decimal monto, DateTime fecha, string descripcion)
        {
            Registros.Add(new Registro { Monto = Math.Abs(monto), Fecha = fecha, Descripcion = descripcion });
        }
    }
}
