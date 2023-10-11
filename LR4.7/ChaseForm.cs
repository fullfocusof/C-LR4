using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4._7
{
    public partial class ChaseForm : Form
    {
        Random rand;
        int cnt = 0, startXMouse = 367, startYMouse = 314, startXCheese = 12, startYCheese = 12;

        public ChaseForm()
        {
            InitializeComponent();
            KeyPreview = true;
            pictureBoxMouse.BringToFront();
            pictureBoxCheese.BackColor = Color.Transparent;
            rand = new Random();
        }

        private void ChaseForm_KeyDown(object sender, KeyEventArgs e)
        {
            int stepSize = 30, currentX = pictureBoxMouse.Left, currentY = pictureBoxMouse.Top;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    {
                        currentX -= stepSize;
                    }
                    break;

                case Keys.Right:
                    {
                        currentX += stepSize;
                    }
                    break;

                case Keys.Up:
                    {
                        currentY -= stepSize;
                    }
                    break;

                case Keys.Down:
                    {
                        currentY += stepSize;
                    }
                    break;
            }

            if(currentX >= 0 && currentX <= (ClientSize.Width - pictureBoxMouse.Width))
            {
                pictureBoxMouse.Left = currentX;
            }

            if (currentY >= 0 && currentY <= (ClientSize.Height - pictureBoxMouse.Height))
            {
                pictureBoxMouse.Top = currentY;
            }

            Rectangle mouseBounds = pictureBoxMouse.Bounds;
            Rectangle cheeseBounds = pictureBoxCheese.Bounds;

            if(mouseBounds.IntersectsWith(cheeseBounds))
            {
                cnt++;
                timerGame.Stop();
                pictureBoxCheese.Left = rand.Next(0, (ClientSize.Width - pictureBoxCheese.Width) / 10) * 10;
                pictureBoxCheese.Top = rand.Next(0, (ClientSize.Height - pictureBoxCheese.Height) / 10) * 10;
                timerGame.Start();
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            pictureBoxCheese.Left = rand.Next(0, (ClientSize.Width - pictureBoxCheese.Width) / 10) * 10;
            pictureBoxCheese.Top = rand.Next(0, (ClientSize.Height - pictureBoxCheese.Height) / 10) * 10;
        }

        private void timerEndGame_Tick(object sender, EventArgs e)
        {
            timerEndGame.Stop();
            timerGame.Stop();
            if(MessageBox.Show("Score - " + cnt + "\nRestart?", "Endgame", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cnt = 0;
                pictureBoxCheese.Left = startXCheese;
                pictureBoxCheese.Top = startYCheese;
                pictureBoxMouse.Left = startXMouse;
                pictureBoxMouse.Top = startYMouse;
                timerEndGame.Start();
                timerGame.Start();
            }
            else
            {
                Close();
            }
        }
    }
}
