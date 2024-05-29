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
using System.Net.Mail;
using System.Net;

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
            EnviarCorreoMetaFinanciera(nuevaMeta);

        }
        private void EnviarCorreoMetaFinanciera(MetaFinanciera meta)
        {
            // Configurar los detalles del correo
            string destinatario = "finanzasproc@gmail.com";
            string asunto = "Nueva Meta Financiera Agregada";
            string cuerpoMensaje = $"Se ha agregado una nueva meta financiera:\n\n" +
                                   $"Nombre: {meta.Nombre}\n" +
                                   $"Monto Deseado: Q{meta.MontoDeseado}\n" +
                                   $"Fecha Objetivo: {meta.FechaObjetivo.ToShortDateString()}";

            // Configurar el cliente SMTP
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("finanzasproc@gmail.com", "aaup mrzl yzjs egtt"),
                EnableSsl = true
            };

            // Crear el mensaje de correo
            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress("finanzasproc@gmail.com"),
                Subject = asunto,
                Body = cuerpoMensaje,
                IsBodyHtml = false
            };

            mailMessage.To.Add(destinatario);

            try
            {
                // Enviar el correo
                smtpClient.Send(mailMessage);
                MessageBox.Show("Correo electrónico enviado exitosamente.", "Correo Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar correo electrónico: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
