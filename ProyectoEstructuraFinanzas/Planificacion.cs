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
namespace ProyectoEstructuraFinanzas
{
    public partial class Planificacion : Form
    {
        private List<Registro> registros;
        private List<PagoRecurrente> pagosRecurrentes;
        private UsuarioData _userData;
        private string _userFilePath;
        public Planificacion(UsuarioData usuarioData, string userFilePath)
        {
            InitializeComponent();
            _userData = usuarioData;
            _userFilePath = userFilePath;
            CargarUsuarioData(); // Cargar los registros desde el archivo
            MostrarGastosEnCalendario();
            InicializarPagosRecurrentes();
            InicializarCategorias();

        }
        private void CargarUsuarioData()
        {
            try
            {
                if (File.Exists(_userFilePath))
                {
                    string jsonData = File.ReadAllText(_userFilePath);
                    _userData = JsonConvert.DeserializeObject<UsuarioData>(jsonData);
                    registros = _userData?.Registros ?? new List<Registro>();
                    pagosRecurrentes = _userData?.PagosRecurrentes ?? new List<PagoRecurrente>();
                }
                else
                {
                    registros = new List<Registro>();
                    pagosRecurrentes = new List<PagoRecurrente>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos del usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InicializarCategorias()
        {
            cmbMes.Items.AddRange(new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            cmbAno.Items.AddRange(new string[] { "2024", "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013" });
        }

        private void MostrarGastosEnCalendario()
        {
            // Limpiar el calendario
            calendarGrid.Rows.Clear();

            // Obtener el primer día del mes actual
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            int currentDay = 1;
            int row = 0;

            while (currentDay <= daysInMonth)
            {
                calendarGrid.Rows.Add();
                for (int col = 0; col < 7; col++)
                {
                    if ((row == 0 && col < (int)firstDayOfMonth.DayOfWeek) || currentDay > daysInMonth)
                    {
                        calendarGrid[col, row].Value = "";
                    }
                    else
                    {
                        calendarGrid[col, row].Value = currentDay.ToString();
                        var gastos = registros.Where(r => r.Fecha.Date == new DateTime(DateTime.Now.Year, DateTime.Now.Month, currentDay)).ToList();
                        foreach (var gasto in gastos)
                        {
                            calendarGrid[col, row].Style.BackColor = Color.LightCoral;
                        }
                        currentDay++;
                    }
                }
                row++;
            }
        }

        private void InicializarPagosRecurrentes()
        {
            pagosRecurrentes = new List<PagoRecurrente>();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarPagoRecurrente_Click(object sender, EventArgs e)
        {
            using (var form = new FormAgregarPagoRecurrente())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var pago = form.PagoRecurrente;
                    pagosRecurrentes.Add(pago);
                    AgregarPagosRecurrentesAlCalendario(pago);
                }
            }
        }
        private void AgregarPagosRecurrentesAlCalendario(PagoRecurrente pago)
        {
            DateTime fecha = pago.FechaInicio;
            while (fecha <= DateTime.Today.AddYears(1)) // Agregamos los pagos recurrentes para un año
            {
                int day = fecha.Day;
                int month = fecha.Month;
                if (month == DateTime.Now.Month)
                {
                    int rowIndex = (day + (int)new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).DayOfWeek - 1) / 7;
                    int colIndex = (day + (int)new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).DayOfWeek - 1) % 7;
                    calendarGrid[colIndex, rowIndex].Style.BackColor = Color.LightGreen;
                }
                fecha = fecha.AddDays(pago.IntervaloDias);
            }
        }

        private void Planificacion_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Maneja el botón de mes anterior
            if (cmbMes.SelectedIndex > 0)
            {
                cmbMes.SelectedIndex--;
            }
            else
            {
                cmbMes.SelectedIndex = 11; // diciembre
                cmbAno.SelectedIndex = cmbAno.SelectedIndex - 1;
            }

            ActualizarCalendario();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // Maneja el botón de mes siguiente
            if (cmbMes.SelectedIndex < 11) // índice de diciembre es 11
            {
                cmbMes.SelectedIndex++;
            }
            else
            {
                cmbMes.SelectedIndex = 0; // enero
                cmbAno.SelectedIndex = cmbAno.SelectedIndex + 1;
            }

            ActualizarCalendario();
        }
        private void ActualizarCalendario()
        {
            int selectedYear = (int)cmbAno.SelectedItem;
            int selectedMonth = cmbMes.SelectedIndex + 1;
            DateTime firstDayOfMonth = new DateTime(selectedYear, selectedMonth, 1);
            int daysInMonth = DateTime.DaysInMonth(selectedYear, selectedMonth);
            int currentDay = 1;
            int row = 0;
            if (_userData == null)
            {
                // Manejar el caso donde _userData no está inicializado
                MessageBox.Show("No se ha cargado correctamente la información del usuario.");
                return;
            }

            // Limpiar el calendario previo
            calendarGrid.Rows.Clear();

            while (currentDay <= daysInMonth)
            {
                calendarGrid.Rows.Add();
                for (int col = 0; col < 7; col++)
                {
                    if ((row == 0 && col < (int)firstDayOfMonth.DayOfWeek) || currentDay > daysInMonth)
                    {
                        calendarGrid[col, row].Value = "";
                    }
                    else
                    {
                        calendarGrid[col, row].Value = currentDay.ToString();

                        DateTime currentDate = new DateTime(selectedYear, selectedMonth, currentDay);
                        bool hasExpense = CheckForExpense(currentDate);
                        bool hasRecurringPayment = CheckForRecurringPayment(currentDate);

                        if (hasExpense)
                        {
                            calendarGrid[col, row].Style.BackColor = Color.LightSalmon; // Color para gastos
                        }

                        if (hasRecurringPayment)
                        {
                            calendarGrid[col, row].Style.BackColor = Color.LightGreen; // Color para pagos recurrentes
                        }

                        currentDay++;
                    }
                }
                row++;
            }
        }

        private bool CheckForExpense(DateTime date)
        {
            if (_userData == null || _userData.Registros == null)
                return false;

            return _userData.Registros.Any(r => r.Fecha.Date == date.Date && r.Monto < 0);
        }

        private bool CheckForRecurringPayment(DateTime date)
        {
            if (_userData == null || _userData.PagosRecurrentes == null)
                return false;

            return _userData.PagosRecurrentes.Any(pr => pr.FechaPago.Date == date.Date);
        }
        private void calendarGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Maneja el clic en una celda del calendario
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = calendarGrid[e.ColumnIndex, e.RowIndex];
                string dayClicked = cell.Value.ToString();

                if (!string.IsNullOrEmpty(dayClicked))
                {
                    int day = int.Parse(dayClicked);
                    DateTime clickedDate = new DateTime(int.Parse(cmbAno.SelectedItem.ToString()), cmbMes.SelectedIndex + 1, day);

                    // Verifica si hay gasto o pago recurrente en la fecha seleccionada
                    bool hasExpense = CheckForExpense(clickedDate);
                    bool hasRecurringPayment = CheckForRecurringPayment(clickedDate);

                    // Muestra detalles en un MessageBox
                    string message = $"Detalles de {clickedDate.ToShortDateString()}:\n\n";

                    if (hasExpense)
                    {
                        message += "Hay un gasto registado para este dia.\n";
                    }
                    if (hasRecurringPayment)
                    {
                        message += "Hay un pago recurrente programado para este día.\n";
                        // Aquí puedes añadir más detalles del pago recurrente si lo deseas
                    }

                    if (!hasExpense && !hasRecurringPayment)
                    {
                        message += "No hay eventos registrados para este día.";
                    }

                    MessageBox.Show(message, "Detalles del Día", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        
    }


        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarCalendario();

        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarCalendario();

        }

    }
}
