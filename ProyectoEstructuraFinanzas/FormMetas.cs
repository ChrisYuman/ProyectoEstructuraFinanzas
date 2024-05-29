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
    public partial class FormMetas : Form
    {
        private List<MetaFinanciera> metasFinancieras = new List<MetaFinanciera>();
        private string userFilePath;

        public FormMetas(string userFilePath)
        {
            InitializeComponent();
            this.userFilePath = userFilePath;
            CargarMetasFinancieras();
            MostrarMetasFinancieras();
        }

        private void CargarMetasFinancieras()
        {
            if (File.Exists(userFilePath))
            {
                var json = File.ReadAllText(userFilePath);
                var meta = JsonConvert.DeserializeObject<MetaFinanciera>(json);
                if (meta != null)
                {
                    metasFinancieras.Add(meta);
                }
            }
        }

        private void MostrarMetasFinancieras()
        {
            lstMetas.Items.Clear();
            foreach (var meta in metasFinancieras)
            {
                lstMetas.Items.Add($"{meta.Nombre} - Monto Deseado: {meta.MontoDeseado} - Fecha Objetivo: {meta.FechaObjetivo.ToShortDateString()}");
            }
        }

        private void btnAgregarMeta_Click(object sender, EventArgs e)
        {
           
        }

        private void GuardarMetasFinancieras()
        {
            var json = JsonConvert.SerializeObject(metasFinancieras, Formatting.Indented);
            File.WriteAllText(userFilePath, json);
        }

        private void btnAgregarMeta_Click_1(object sender, EventArgs e)
        {
            // Validación de entrada
            if (string.IsNullOrWhiteSpace(txtNombreMeta.Text) || !decimal.TryParse(txtMontoDeseado.Text, out decimal monto) || !DateTime.TryParse(dtpFechaObjetivo.Text, out DateTime fecha))
            {
                MessageBox.Show("Por favor ingrese datos válidos para la meta financiera.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Creación de la meta financiera y agregación a la lista
            var nuevaMeta = new MetaFinanciera(txtNombreMeta.Text, monto, fecha);
            metasFinancieras.Add(nuevaMeta);

            // Actualización de la interfaz de usuario y persistencia de datos
            MostrarMetasFinancieras();
            GuardarMetasFinancieras();
        }
    }

    public class MetaFinanciera
    {
        public string Nombre { get; set; }
        public decimal MontoDeseado { get; set; }
        public DateTime FechaObjetivo { get; set; }

        public MetaFinanciera(string nombre, decimal montoDeseado, DateTime fechaObjetivo)
        {
            Nombre = nombre;
            MontoDeseado = montoDeseado;
            FechaObjetivo = fechaObjetivo;
        }
    }
}
