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
            PagoRecurrente.IntervaloDias = int.Parse(txtIntervaloDias.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
