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
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lbdays.Text = numday+"";
        }
        public void AddExpense(string descripcion, decimal monto)
        {
            // Formatear el monto con el símbolo de moneda de Guatemala
            string montoFormateado = $"Q{monto:N2}";

            // Lógica para agregar el gasto con la descripción y el monto formateado
            // Por ejemplo, podrías agregar un Label o algún otro control visual
            Label lblGasto = new Label();
            lblGasto.Text = $"{descripcion}: {montoFormateado}";
            lblGasto.AutoSize = true;
            this.Controls.Add(lblGasto);
        }
    }
}
