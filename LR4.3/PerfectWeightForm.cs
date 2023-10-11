using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4._3
{
    public partial class PerfectWieghtForm : Form
    {
        public PerfectWieghtForm()
        {
            InitializeComponent();
        }

        private void ExecButton_Click(object sender, EventArgs e)
        {
            try
            {
                int age = int.Parse(textBoxAge.Text), height = int.Parse(textBoxHeight.Text);
                double k = 0;

                if(radioButtonFemale.Checked)
                {
                    k = 0.9;
                }
                else if(radioButtonMale.Checked)
                {
                    k = 1;
                }

                if(height < 120 || height > 200 || age < 15 || age > 80)
                {
                    throw new Exception();
                }

                labelResult.Text = (k * (50 + 0.75 * (height - 150) + 0.25 * (age - 20))).ToString("N0");
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректный ввод исходных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
