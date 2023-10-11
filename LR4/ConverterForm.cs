using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4
{
    public partial class ConverterForm : Form
    {
        public ConverterForm()
        {
            InitializeComponent();
        }

        private void ExecButton_Click(object sender, EventArgs e)
        {
            try
            {
                double kInit = 0, kResult = 0;
                string textInit = " ", textResult = " ";

                for (int i = 0; i < groupBoxInit.Controls.Count; i++) 
                {
                    RadioButton initButton = groupBoxInit.Controls[i] as RadioButton;
                    if (initButton != null && initButton.Checked)
                    {
                        textInit = initButton.Text;
                        break;
                    }
                }

                switch (textInit)
                {
                    case "в дюймах":
                        {
                            kInit = 2.54;
                        }
                    break;

                    case "в футах":
                        {
                            kInit = 30.48;
                        }
                    break;

                    case "в ярдах":
                        {
                            kInit = 91.44;
                        }
                    break;

                    case "в сантиметрах":
                        {
                            kInit = 1;
                        }
                    break;

                    case "в метрах":
                        {
                            kInit = 100;
                        }
                    break;

                    default:
                        break;
                }

               
                for (int i = 0; i < groupBoxResult.Controls.Count; i++)
                {
                    RadioButton resultButton = groupBoxResult.Controls[i] as RadioButton;
                    if (resultButton != null && resultButton.Checked)
                    {
                        textResult = resultButton.Text;
                    }
                }

                switch (textResult)
                {
                    case "в дюймах":
                        {
                            kResult = 2.54;
                        }
                        break;

                    case "в футах":
                        {
                            kResult = 30.48;
                        }
                        break;

                    case "в ярдах":
                        {
                            kResult = 91.44;
                        }
                        break;

                    case "в сантиметрах":
                        {
                            kResult = 1;
                        }
                        break;

                    case "в метрах":
                        {
                            kResult = 100;
                        }
                        break;

                    default:
                        break;
                }

                if(textInit == textResult || double.Parse(textBoxInit.Text) < 0)
                {
                    throw new Exception();
                }

                textBoxResult.Text = ((double.Parse(textBoxInit.Text) * kInit) / kResult).ToString("N5");
            }
            catch(Exception)
            {
                MessageBox.Show("Некорректный ввод исходных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxInit.Text = "0";
                textBoxResult.Text = "0";
            }

        }

        private void textBoxInit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ExecButton_Click(sender, e);
            }
        }
    }
}
