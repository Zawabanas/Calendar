using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int month, year;

        public static int static_month, static_year;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializar month y year con el primer día del mes anterior
            DateTime now = DateTime.Now;
            DateTime firstDayOfPreviousMonth = new DateTime(now.Year, now.Month, 1);

            // Avanzar un día para llegar al primer día del mes actual
            DateTime firstDayOfMonth = firstDayOfPreviousMonth.AddDays(1);
            month = firstDayOfMonth.Month;
            year = firstDayOfMonth.Year;

            displayDays();
        }

        private void displayDays()
        {
            string monthdname = DateTimeFormatInfo.CurrentInfo.MonthNames[month - 1];
            lbDate.Text = monthdname + " " + year;
            static_month = month;
            static_year = year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            // Ajustar el valor de daysoftheweek para que sea cero en lugar de uno cuando el día de la semana sea domingo
            int daysoftheweek = (int)startofthemonth.DayOfWeek + 1;
            if (daysoftheweek == 0) daysoftheweek = 7;

            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            static_month = month;
            static_year = year;
            month--;
            if (month < 1)
            {
                year--;
                month = 12;
            }

            string monthdname = DateTimeFormatInfo.CurrentInfo.MonthNames[month - 1];
            lbDate.Text = monthdname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int daysoftheweek = (int)startofthemonth.DayOfWeek;

            for (int i = 0; i < daysoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            static_month = month;
            static_year = year;
            month++;
            if (month > 12)
            {
                year++;
                month = 1;
            }


            string monthdname = DateTimeFormatInfo.CurrentInfo.MonthNames[month - 1];
            lbDate.Text = monthdname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int daysoftheweek = (int)startofthemonth.DayOfWeek;

            for (int i = 0; i < daysoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }


    }
}

