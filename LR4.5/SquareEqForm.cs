using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4._5
{
    public partial class SquareEqForm : Form
    {
        public SquareEqForm()
        {
            InitializeComponent();
        }

        private void ExecButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if()
                //{
                //    throw new Exception();
                //}

                if (double.Parse(textBoxKoefA.Text) == 0)
                {
                    label1.Text = "Корень уравнения";
                    labelResultX1.Text = "x1 = " + (-1 * double.Parse(textBoxKoefC.Text) / double.Parse(textBoxKoefB.Text)).ToString("N3");
                    labelResultX2.Text = "";
                }
                else
                {
                    double D = Math.Pow(double.Parse(textBoxKoefB.Text), 2) - 4 * double.Parse(textBoxKoefA.Text) * double.Parse(textBoxKoefC.Text);
                    
                    if(D == 0)
                    {
                        label1.Text = "Корень уравнения";
                        labelResultX1.Text = "x1,2 = " + (-1 * double.Parse(textBoxKoefB.Text) / (2 * double.Parse(textBoxKoefA.Text))).ToString("N3");
                        labelResultX2.Text = "";
                    }
                    else if(D < 0)
                    {
                        labelResultX1.Text = "";
                        labelResultX2.Text = "";
                        label1.Text = "Уравнение не имеет действительных корней";
                    }
                    else if(D > 0)
                    {
                        label1.Text = "Корни уравнения";
                        labelResultX1.Text = "x1 = " + ((-1 * double.Parse(textBoxKoefB.Text) + Math.Sqrt(D)) / (2 * double.Parse(textBoxKoefA.Text))).ToString("N3");
                        labelResultX2.Text = "x2 = " + ((-1 * double.Parse(textBoxKoefB.Text) - Math.Sqrt(D)) / (2 * double.Parse(textBoxKoefA.Text))).ToString("N3");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректный ввод исходных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
