namespace LR4._7
{
    partial class ChaseForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChaseForm));
            this.pictureBoxMouse = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheese = new System.Windows.Forms.PictureBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.timerEndGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheese)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMouse
            // 
            this.pictureBoxMouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMouse.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxMouse.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMouse.Image")));
            this.pictureBoxMouse.Location = new System.Drawing.Point(367, 314);
            this.pictureBoxMouse.Name = "pictureBoxMouse";
            this.pictureBoxMouse.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxMouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMouse.TabIndex = 0;
            this.pictureBoxMouse.TabStop = false;
            // 
            // pictureBoxCheese
            // 
            this.pictureBoxCheese.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCheese.Image")));
            this.pictureBoxCheese.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCheese.Name = "pictureBoxCheese";
            this.pictureBoxCheese.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxCheese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCheese.TabIndex = 1;
            this.pictureBoxCheese.TabStop = false;
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 5000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // timerEndGame
            // 
            this.timerEndGame.Enabled = true;
            this.timerEndGame.Interval = 10000;
            this.timerEndGame.Tick += new System.EventHandler(this.timerEndGame_Tick);
            // 
            // ChaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 360);
            this.Controls.Add(this.pictureBoxCheese);
            this.Controls.Add(this.pictureBoxMouse);
            this.Name = "ChaseForm";
            this.Text = "CheeseChase";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChaseForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheese)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMouse;
        private System.Windows.Forms.PictureBox pictureBoxCheese;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Timer timerEndGame;
    }
}

