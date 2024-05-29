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
using Newtonsoft.Json;
using static ProyectoEstructuraFinanzas.Form3;
using System.Globalization;
using static ProyectoEstructuraFinanzas.Registrar;
namespace ProyectoEstructuraFinanzas
{
    public partial class Planificacion : Form
    {
        int month, year;
        private string currentUser;
        private string userFilePath;

        public Planificacion(string userFilePath, string currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            this.userFilePath = userFilePath;

            FormAgregarPagoRecurrente.OnPagoRecurrenteAdded += FormAgregarPagoRecurrente_OnPagoRecurrenteAdded;
        }

        private void Planificacion_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = new DateTime(year, month, 1);
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = $"{monthname} {year}";

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            daycontainer.Controls.Clear();

            var userFilePath = GetUserFilePath(currentUser);
            UsuarioData usuarioData = CargarUsuarioData(userFilePath);

            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlank ucblak = new UserControlBlank();
                daycontainer.Controls.Add(ucblak);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);

                var registrosDelDia = usuarioData.Registros
                    .Where(r => r.Fecha.Day == i && r.Fecha.Month == month && r.Fecha.Year == year)
                    .ToList();

                if (registrosDelDia.Count > 0)
                {
                    foreach (var registro in registrosDelDia)
                    {
                        ucdays.AddExpense(registro.Descripcion, registro.Monto);
                    }
                }

                foreach (var pagoRecurrente in usuarioData.PagosRecurrentes)
                {
                    DateTime fechaPagoEsperada = pagoRecurrente.FechaInicio.AddMonths(i - 1);

                    if (fechaPagoEsperada.Day == i)
                    {
                        ucdays.AddExpense(pagoRecurrente.Descripcion, pagoRecurrente.Monto);
                    }
                }

                daycontainer.Controls.Add(ucdays);
            }

            int totalControls = daycontainer.Controls.Count;
            int remainingDays = 42 - totalControls;
            for (int i = 0; i < remainingDays; i++)
            {
                UserControlBlank ucblak = new UserControlBlank();
                daycontainer.Controls.Add(ucblak);
            }
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

        private string GetUserFilePath(string username)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{username}_data.json");
        }

        private void calendarGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Manejar el evento de clic en el contenido de la celda si es necesario
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Manejar el evento de clic en la etiqueta si es necesario
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if (month == 1)
            {
                month = 12;
                year--;
            }
            else
            {
                month--;
            }
            displayDays();
        }

        private void btnAgregarPagoRecurrente_Click(object sender, EventArgs e)
        {
            using (var formAgregarPagoRecurrente = new FormAgregarPagoRecurrente())
            {
                if (formAgregarPagoRecurrente.ShowDialog() == DialogResult.OK)
                {
                    PagoRecurrente pagoRecurrente = formAgregarPagoRecurrente.PagoRecurrente;

                    var userFilePath = GetUserFilePath(currentUser);
                    UsuarioData usuarioData = CargarUsuarioData(userFilePath);

                    usuarioData.AgregarPagoRecurrente(pagoRecurrente);
                    GuardarUsuarioData(usuarioData, userFilePath);

                    displayDays();
                }
            }
        }

        private void GuardarUsuarioData(UsuarioData usuarioData, string filePath)
        {
            var jsonString = JsonConvert.SerializeObject(usuarioData, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }

        private void FormAgregarPagoRecurrente_OnPagoRecurrenteAdded(object sender, EventArgs e)
        {
            displayDays();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (month == 12)
            {
                month = 1;
                year++;
            }
            else
            {
                month++;
            }
            displayDays();
        }
    }
}

