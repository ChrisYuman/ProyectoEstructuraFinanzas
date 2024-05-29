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
namespace ProyectoEstructuraFinanzas
{
    public partial class Planificacion : Form
    {
        int month, year;
        public Planificacion()
        {
            InitializeComponent();
            

        }
       

        
      
        private void Planificacion_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32 (startofthemonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlank ucblak = new UserControlBlank();
                daycontainer.Controls.Add(ucblak);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucday = new UserControlDays();
                ucday.days(i);
                daycontainer.Controls.Add(ucday);
            }
        }
      

       
        private void calendarGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month--;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlank ucblak = new UserControlBlank();
                daycontainer.Controls.Add(ucblak);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucday = new UserControlDays();
                ucday.days(i);
                daycontainer.Controls.Add(ucday);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month++;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlank ucblak = new UserControlBlank();
                daycontainer.Controls.Add(ucblak);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucday = new UserControlDays();
                ucday.days(i);
                daycontainer.Controls.Add(ucday);
            }
        }
    }


       

    }

