using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace LR4._4
{
    public partial class KeyboardTrainForm : Form
    {
        string TargetString = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        int CurrentIndex;
        const int MaxCount = 10;
        int count = 0;
        Graphics g;
        Font MyFont = new Font("Arial", 32);
        Random Rand = new Random();
        DateTime start;


        public KeyboardTrainForm()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void KeyboardTrainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            g.Dispose();
            MyFont.Dispose();
        }

        private void KeyboardTrainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) && (count == 0))
            {   
                start = DateTime.Now;                                  
                CurrentIndex = Rand.Next(TargetString.Length);
                g.DrawString(TargetString.Substring(CurrentIndex, 1),
                MyFont, Brushes.Black, 160, 75);
                count = 1;
            }
            else if ((count > 0) && (e.KeyChar == TargetString[CurrentIndex]))
            {   
                if (count == MaxCount) 
                {
                    int time = DateTime.Now.Subtract(start).Seconds;
                    MessageBox.Show("Время выполнения = " + time.ToString() + " секунд");
                    Close();    
                }
                else    
                {
                    g.Clear(BackColor);
                    CurrentIndex = Rand.Next(TargetString.Length);
                    g.DrawString(TargetString[CurrentIndex].ToString(), MyFont, Brushes.Black, 160, 75);
                    count++;
                }
            }
            else System.Media.SystemSounds.Hand.Play();

        }

        private void KeyboardTrainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
