using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LR4._2
{
    public partial class DateTimeForm : Form
    {
        public DateTimeForm()
        {
            InitializeComponent();
        }

        private void ExecButton_Click(object sender, EventArgs e)
        {
            try
            {
                int dayInit = int.Parse(textBoxDay.Text);
                int monthInit = int.Parse(textBoxMonth.Text);
                int yearInit = int.Parse(textBoxYear.Text);
                int daysInYear, daysInMonth, result;

                if (dayInit < 1 || dayInit > 31 || monthInit < 1 || monthInit > 12 || yearInit < 0)
                {
                    throw new Exception();
                }

                if(yearInit > 1582)
                {
                    daysInYear = DateTime.IsLeapYear(yearInit) ? 366 : 365;
                    daysInMonth = DateTime.DaysInMonth(yearInit, monthInit);
                    if (dayInit > daysInMonth)
                    {
                        throw new Exception();
                    }
                    DateTime date = new DateTime(yearInit, monthInit, dayInit);
                    result = daysInYear - date.DayOfYear;
                }
                else
                {
                    Calendar calendar = new JulianCalendar();
                    daysInYear = calendar.IsLeapYear(yearInit) ? 366 : 365;
                    daysInMonth = calendar.GetDaysInMonth(yearInit, monthInit);
                    if (dayInit > daysInMonth)
                    {
                        throw new Exception();
                    }
                    result = daysInYear - calendar.GetDayOfYear(); // ???????
                }

                labelResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректный ввод исходных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
