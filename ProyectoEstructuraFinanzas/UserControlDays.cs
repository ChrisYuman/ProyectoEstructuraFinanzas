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
        public void AddExpense(string description, decimal amount)
        {
            UserControlBlank expenseControl = new UserControlBlank();
            expenseControl.SetExpense(description, amount);
            this.Controls.Add(expenseControl); // Agrega el control de gasto al día
        }

    }
}
