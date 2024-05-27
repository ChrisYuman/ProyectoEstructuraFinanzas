using Microsoft.Win32;
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
    public partial class DetallesForm : Form
    {
        public DetallesForm(DateTime fecha, List<Registro> registros)
        {
            InitializeComponent();
            lblFecha.Text = fecha.ToString("dd/MM/yyyy");
            lstDetalles.Items.Clear();
            foreach (var registro in registros)
            {
                string detalle = $"Descripción: {registro.Descripcion}, Categoría: {registro.Categoria}, Monto: Q{Math.Abs(registro.Monto)}, Fecha: {registro.Fecha:dd/MM/yyyy}";
                lstDetalles.Items.Add(detalle);
            }
        }

        private void DetallesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
