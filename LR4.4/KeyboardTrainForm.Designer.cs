namespace LR4._4
{
    partial class KeyboardTrainForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxDifficulty = new System.Windows.Forms.GroupBox();
            this.radioButtonEasy = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonHard = new System.Windows.Forms.RadioButton();
            this.groupBoxDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDifficulty
            // 
            this.groupBoxDifficulty.Controls.Add(this.radioButtonHard);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonMedium);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonEasy);
            this.groupBoxDifficulty.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDifficulty.Name = "groupBoxDifficulty";
            this.groupBoxDifficulty.Size = new System.Drawing.Size(179, 105);
            this.groupBoxDifficulty.TabIndex = 0;
            this.groupBoxDifficulty.TabStop = false;
            // 
            // radioButtonEasy
            // 
            this.radioButtonEasy.AutoSize = true;
            this.radioButtonEasy.Location = new System.Drawing.Point(7, 20);
            this.radioButtonEasy.Name = "radioButtonEasy";
            this.radioButtonEasy.Size = new System.Drawing.Size(62, 17);
            this.radioButtonEasy.TabIndex = 0;
            this.radioButtonEasy.TabStop = true;
            this.radioButtonEasy.Text = "Легкий";
            this.radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(7, 44);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(68, 17);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Средний";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonHard
            // 
            this.radioButtonHard.AutoSize = true;
            this.radioButtonHard.Location = new System.Drawing.Point(7, 68);
            this.radioButtonHard.Name = "radioButtonHard";
            this.radioButtonHard.Size = new System.Drawing.Size(104, 17);
            this.radioButtonHard.TabIndex = 2;
            this.radioButtonHard.TabStop = true;
            this.radioButtonHard.Text = "Максимальный";
            this.radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // KeyboardTrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxDifficulty);
            this.Name = "KeyboardTrainForm";
            this.Text = "Клавиатурный тренажер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KeyboardTrainForm_FormClosing);
            this.Load += new System.EventHandler(this.KeyboardTrainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyboardTrainForm_KeyPress);
            this.groupBoxDifficulty.ResumeLayout(false);
            this.groupBoxDifficulty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBoxDifficulty;
        private System.Windows.Forms.RadioButton radioButtonHard;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonEasy;
    }
}

