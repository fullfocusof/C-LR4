using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4._8
{
    public partial class EmployerQuestionForm : Form
    {
        Random rand;
        public EmployerQuestionForm()
        {
            InitializeComponent();
            toolTipYes.SetToolTip(buttonYes, "Нажми сюда");
            rand = new Random();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы так и думали", "Хаха", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Close();
        }

        private void buttonNo_MouseMove(object sender, MouseEventArgs e)
        {
            buttonNo.Left = rand.Next(0, ClientSize.Width - buttonNo.Width);
            buttonNo.Top = rand.Next(0, ClientSize.Height - buttonNo.Height);
        }
    }
}
