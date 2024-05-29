using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstructuraFinanzas
{
    public partial class FormAgregarPagoRecurrente : Form
    {
        public static event EventHandler OnPagoRecurrenteAdded; // Evento estático

        public PagoRecurrente PagoRecurrente { get; private set; }

        public FormAgregarPagoRecurrente()
        {
            InitializeComponent();
            PagoRecurrente = new PagoRecurrente();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PagoRecurrente.Descripcion = txtDescripcion.Text;
            PagoRecurrente.Monto = decimal.Parse(txtMonto.Text);
            PagoRecurrente.FechaInicio = dateTimePicker1.Value;
            PagoRecurrente.IntervaloMeses = int.Parse(txtIntervaloDias.Text);

            // Calcular la fecha del primer pago
            PagoRecurrente.FechaPago = CalcularFechaProximoPago(PagoRecurrente.FechaInicio, PagoRecurrente.IntervaloMeses);
            OnPagoRecurrenteAdded?.Invoke(this, EventArgs.Empty);

            this.DialogResult = DialogResult.OK;
            this.Close();

            string destinatario = "finanzasproc@gmail.com"; // Cambiar con el correo del usuario
            string asunto = "Recordatorio de pago recurrente";
            string cuerpo = $"Recuerda realizar el pago de {PagoRecurrente.Descripcion} por un monto de {PagoRecurrente.Monto}Q el día {PagoRecurrente.FechaPago.ToShortDateString()}.";
            EmailSender.SendPaymentReminder(destinatario, asunto, cuerpo);

            OnPagoRecurrenteAdded?.Invoke(this, EventArgs.Empty);

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        private DateTime CalcularFechaProximoPago(DateTime fechaInicio, int intervaloMeses)
        {
            DateTime fechaPago = fechaInicio.AddMonths(intervaloMeses);
            return fechaPago;
        }
    }

}
