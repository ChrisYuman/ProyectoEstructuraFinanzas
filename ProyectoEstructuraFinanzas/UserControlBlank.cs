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
    public partial class UserControlBlank : UserControl
    {
        public UserControlBlank()
        {
            InitializeComponent();
        }
        public void SetExpense(string categoria, decimal monto)
        {

            lbl.Text = $"{categoria}: {monto:C}";
            lbl.AutoSize = true;
            this.Controls.Add(lbl);
        }

        private void UserControlBlank_Load(object sender, EventArgs e)
        {

        }
    }
}
