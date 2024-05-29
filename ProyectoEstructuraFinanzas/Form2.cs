using iTextSharp.text.pdf;
using iTextSharp.text;
using Newtonsoft.Json;
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
        }

        private void btnGenrepor_Click(object sender, EventArgs e)
        {
            GenerarReportePDF();
        }

        private void GenerarReportePDF()
        {
            var userFilePath = GetUserFilePath(currentUser);
            _usuarioData = CargarUsuarioData(userFilePath);

            Document doc = new Document();
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ResumenFinanzas.pdf");

            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            doc.Open();

            // Agregar título
            var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 22);
            var sectionFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
            var textFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

            Paragraph title = new Paragraph("FINANZASPRO", titleFont)
            {
                Alignment = Element.ALIGN_CENTER
            };
            doc.Add(title);
            doc.Add(Chunk.NEWLINE);

            // Agregar sección de gastos
            Paragraph gastosTitle = new Paragraph("- Gastos realizados:", sectionFont);
            doc.Add(gastosTitle);

            foreach (var registro in _usuarioData.Registros)
            {
                Paragraph gasto = new Paragraph($"{registro.Fecha.ToString("dd/MM/yyyy")}: {registro.Descripcion} - ${registro.Monto}", textFont);
                doc.Add(gasto);
            }
            doc.Add(Chunk.NEWLINE);

            // Agregar sección de pagos recurrentes
            Paragraph pagosTitle = new Paragraph("- Pagos a realizar:", sectionFont);
            doc.Add(pagosTitle);

            foreach (var pago in _usuarioData.PagosRecurrentes)
            {
                Paragraph pagoRecurrente = new Paragraph($"{pago.FechaInicio.ToString("dd/MM/yyyy")}: {pago.Descripcion} - ${pago.Monto} cada {pago.IntervaloMeses} meses", textFont);
                doc.Add(pagoRecurrente);
            }

            doc.Add(Chunk.NEWLINE);

            // Agregar subtítulo de gráficas
            Paragraph graficasTitle = new Paragraph("- Gráfica:", sectionFont);
            doc.Add(graficasTitle);

            // Agregar las gráficas desde Seguimiento.cs
            using (MemoryStream memoryStream = new MemoryStream())
            {
                Seguimiento seguimientoForm = new Seguimiento(GetUserFilePath(currentUser));
                seguimientoForm.GuardarGraficasComoImagen(memoryStream);
                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(memoryStream.ToArray());
                doc.Add(image);
            }

            doc.Close();

            MessageBox.Show($"Reporte generado exitosamente en {path}", "Reporte Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private UsuarioData CargarUsuarioData(string filePath)
        {
            if (File.Exists(filePath))
            {
                var jsonData = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<UsuarioData>(jsonData);
            }
            else
            {
                return new UsuarioData();
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            // cambio de pantalla a form1
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
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
            openChildForm(new Planificacion(userFilePath, currentUser));
        }

        private string GetUserFilePath(string username)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{username}_data.json");
        }

        private void btnGenrepor_Click_1(object sender, EventArgs e)
        {
            GenerarReportePDF();
        }
    }
}
