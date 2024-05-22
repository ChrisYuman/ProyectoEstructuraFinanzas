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
        private decimal _presupuestoActual;


        public decimal Presupuesto { get; private set; }
        public PresupuestoForm(string userFilePath, decimal presupuestoActual)
        {
            InitializeComponent();
            _userFilePath = userFilePath;
            _presupuestoActual = presupuestoActual;
            lblPresupuestoActual.Text = $"Presupuesto Actual: {_presupuestoActual:C}";
        }

        private void btnGuardarPresupuesto_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPresupuesto.Text, out decimal presupuesto))
            {
                Presupuesto = _presupuestoActual + presupuesto;
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
            var usuarioData = new UsuarioData { Presupuesto = presupuesto };
            var jsonString = JsonConvert.SerializeObject(usuarioData, Formatting.Indented);
            File.WriteAllText(_userFilePath, jsonString);
        }
        public class UsuarioData
        {
            public decimal Presupuesto { get; set; }
            public List<Registro> Registros { get; set; } = new List<Registro>();
        }

        public class Registro
        {
            public string Descripcion { get; set; }
            public string Categoria { get; set; }
            public decimal Monto { get; set; }
            public DateTime Fecha { get; set; }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
