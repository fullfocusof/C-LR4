namespace LR4
{
    partial class ConverterForm
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
            this.groupBoxInit = new System.Windows.Forms.GroupBox();
            this.textBoxInit = new System.Windows.Forms.TextBox();
            this.MeterRadioButtonInit = new System.Windows.Forms.RadioButton();
            this.CmRadioButtonInit = new System.Windows.Forms.RadioButton();
            this.YardRadioButtonInit = new System.Windows.Forms.RadioButton();
            this.FootRadioButtonInit = new System.Windows.Forms.RadioButton();
            this.InchRadioButtonInit = new System.Windows.Forms.RadioButton();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.MeterRadioButtonResult = new System.Windows.Forms.RadioButton();
            this.CmRadioButtonResult = new System.Windows.Forms.RadioButton();
            this.YardRadioButtonResult = new System.Windows.Forms.RadioButton();
            this.FootRadioButtonResult = new System.Windows.Forms.RadioButton();
            this.InchRadioButtonResult = new System.Windows.Forms.RadioButton();
            this.ExecButton = new System.Windows.Forms.Button();
            this.groupBoxInit.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInit
            // 
            this.groupBoxInit.Controls.Add(this.textBoxInit);
            this.groupBoxInit.Controls.Add(this.MeterRadioButtonInit);
            this.groupBoxInit.Controls.Add(this.CmRadioButtonInit);
            this.groupBoxInit.Controls.Add(this.YardRadioButtonInit);
            this.groupBoxInit.Controls.Add(this.FootRadioButtonInit);
            this.groupBoxInit.Controls.Add(this.InchRadioButtonInit);
            this.groupBoxInit.Location = new System.Drawing.Point(12, 33);
            this.groupBoxInit.Name = "groupBoxInit";
            this.groupBoxInit.Size = new System.Drawing.Size(216, 145);
            this.groupBoxInit.TabIndex = 0;
            this.groupBoxInit.TabStop = false;
            this.groupBoxInit.Text = "Исходные данные";
            // 
            // textBoxInit
            // 
            this.textBoxInit.Location = new System.Drawing.Point(110, 19);
            this.textBoxInit.Name = "textBoxInit";
            this.textBoxInit.Size = new System.Drawing.Size(100, 20);
            this.textBoxInit.TabIndex = 0;
            this.textBoxInit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInit_KeyPress);
            // 
            // MeterRadioButtonInit
            // 
            this.MeterRadioButtonInit.AutoSize = true;
            this.MeterRadioButtonInit.Location = new System.Drawing.Point(7, 116);
            this.MeterRadioButtonInit.Name = "MeterRadioButtonInit";
            this.MeterRadioButtonInit.Size = new System.Drawing.Size(70, 17);
            this.MeterRadioButtonInit.TabIndex = 4;
            this.MeterRadioButtonInit.TabStop = true;
            this.MeterRadioButtonInit.Text = "в метрах";
            this.MeterRadioButtonInit.UseVisualStyleBackColor = true;
            this.MeterRadioButtonInit.Click += new System.EventHandler(this.ExecButton_Click);
            // 
            // CmRadioButtonInit
            // 
            this.CmRadioButtonInit.AutoSize = true;
            this.CmRadioButtonInit.Location = new System.Drawing.Point(7, 92);
            this.CmRadioButtonInit.Name = "CmRadioButtonInit";
            this.CmRadioButtonInit.Size = new System.Drawing.Size(99, 17);
            this.CmRadioButtonInit.TabIndex = 3;
            this.CmRadioButtonInit.TabStop = true;
            this.CmRadioButtonInit.Text = "в сантиметрах";
            this.CmRadioButtonInit.UseVisualStyleBackColor = true;
            this.CmRadioButtonInit.Click += new System.EventHandler(this.ExecButton_Click);
            // 
            // YardRadioButtonInit
            // 
            this.YardRadioButtonInit.AutoSize = true;
            this.YardRadioButtonInit.Location = new System.Drawing.Point(7, 68);
            this.YardRadioButtonInit.Name = "YardRadioButtonInit";
            this.YardRadioButtonInit.Size = new System.Drawing.Size(63, 17);
            this.YardRadioButtonInit.TabIndex = 2;
            this.YardRadioButtonInit.TabStop = true;
            this.YardRadioButtonInit.Text = "в ярдах";
            this.YardRadioButtonInit.UseVisualStyleBackColor = true;
            this.YardRadioButtonInit.Click += new System.EventHandler(this.ExecButton_Click);
            // 
            // FootRadioButtonInit
            // 
            this.FootRadioButtonInit.AutoSize = true;
            this.FootRadioButtonInit.Location = new System.Drawing.Point(7, 44);
            this.FootRadioButtonInit.Name = "FootRadioButtonInit";
            this.FootRadioButtonInit.Size = new System.Drawing.Size(63, 17);
            this.FootRadioButtonInit.TabIndex = 1;
            this.FootRadioButtonInit.TabStop = true;
            this.FootRadioButtonInit.Text = "в футах";
            this.FootRadioButtonInit.UseVisualStyleBackColor = true;
            this.FootRadioButtonInit.Click += new System.EventHandler(this.ExecButton_Click);
            // 
            // InchRadioButtonInit
            // 
            this.InchRadioButtonInit.AutoSize = true;
            this.InchRadioButtonInit.Location = new System.Drawing.Point(7, 21);
            this.InchRadioButtonInit.Name = "InchRadioButtonInit";
            this.InchRadioButtonInit.Size = new System.Drawing.Size(73, 17);
            this.InchRadioButtonInit.TabIndex = 5;
            this.InchRadioButtonInit.TabStop = true;
            this.InchRadioButtonInit.Text = "в дюймах";
            this.InchRadioButtonInit.UseVisualStyleBackColor = true;
            this.InchRadioButtonInit.Click += new System.EventHandler(this.ExecButton_Click);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.textBoxResult);
            this.groupBoxResult.Controls.Add(this.MeterRadioButtonResult);
            this.groupBoxResult.Controls.Add(this.CmRadioButtonResult);
            this.groupBoxResult.Controls.Add(this.YardRadioButtonResult);
            this.groupBoxResult.Controls.Add(this.FootRadioButtonResult);
            this.groupBoxResult.Controls.Add(this.InchRadioButtonResult);
            this.groupBoxResult.Location = new System.Drawing.Point(256, 33);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(216, 145);
            this.groupBoxResult.TabIndex = 1;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результат";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Location = new System.Drawing.Point(110, 18);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 6;
            // 
            // MeterRadioButtonResult
            // 
            this.MeterRadioButtonResult.AutoSize = true;
            this.MeterRadioButtonResult.Location = new System.Drawing.Point(7, 116);
            this.MeterRadioButtonResult.Name = "MeterRadioButtonResult";
            this.MeterRadioButtonResult.Size = new System.Drawing.Size(70, 17);
            this.MeterRadioButtonResult.TabIndex = 4;
            this.MeterRadioButtonResult.TabStop = true;
            this.MeterRadioButtonResult.Text = "в метрах";
            this.MeterRadioButtonResult.UseVisualStyleBackColor = true;
            this.MeterRadioButtonResult.Click += new System.EventHandler(this.ExecButton_Click);
            // 
            // CmRadioButtonResult
            // 
            this.CmRadioButtonResult.AutoSize = true;
            this.CmRadioButtonResult.Location = new System.Drawing.Point(7, 92);
            this.CmRadioButtonResult.Name = "CmRadioButtonResult";
            this.CmRadioButtonResult.Size = new System.Drawing.Size(99, 17);
            this.CmRadioButtonResult.TabIndex = 3;
            this.CmRadioButtonResult.TabStop = true;
            this.CmRadioButtonResult.Text = "в сантиметрах";
            this.CmRadioButtonResult.UseVisualStyleBackColor = true;
            this.CmRadioButtonResult.Click += new System.EventHandler(this.ExecButton_Click);
            // 
            // YardRadioButtonResult
            // 
            this.YardRadioButtonResult.AutoSize = true;
            this.YardRadioButtonResult.Location = new System.Drawing.Point(7, 68);
            this.YardRadioButtonResult.Name = "YardRadioButtonResult";
            this.YardRadioButtonResult.Size = new System.Drawing.Size(63, 17);
            this.YardRadioButtonResult.TabIndex = 2;
            this.YardRadioButtonResult.TabStop = true;
            this.YardRadioButtonResult.Text = "в ярдах";
            this.YardRadioButtonResult.UseVisualStyleBackColor = true;
            this.YardRadioButtonResult.Click += new System.EventHandler(this.ExecButton_Click);
            // 
            // FootRadioButtonResult
            // 
            this.FootRadioButtonResult.AutoSize = true;
            this.FootRadioButtonResult.Location = new System.Drawing.Point(7, 44);
            this.FootRadioButtonResult.Name = "FootRadioButtonResult";
            this.FootRadioButtonResult.Size = new System.Drawing.Size(63, 17);
            this.FootRadioButtonResult.TabIndex = 1;
            this.FootRadioButtonResult.TabStop = true;
            this.FootRadioButtonResult.Text = "в футах";
            this.FootRadioButtonResult.UseVisualStyleBackColor = true;
            this.FootRadioButtonResult.Click += new System.EventHandler(this.ExecButton_Click);
            // 
            // InchRadioButtonResult
            // 
            this.InchRadioButtonResult.AutoSize = true;
            this.InchRadioButtonResult.Location = new System.Drawing.Point(7, 21);
            this.InchRadioButtonResult.Name = "InchRadioButtonResult";
            this.InchRadioButtonResult.Size = new System.Drawing.Size(73, 17);
            this.InchRadioButtonResult.TabIndex = 0;
            this.InchRadioButtonResult.TabStop = true;
            this.InchRadioButtonResult.Text = "в дюймах";
            this.InchRadioButtonResult.UseVisualStyleBackColor = true;
            this.InchRadioButtonResult.Click += new System.EventHandler(this.ExecButton_Click);
            // 
            // ExecButton
            // 
            this.ExecButton.Location = new System.Drawing.Point(178, 226);
            this.ExecButton.Name = "ExecButton";
            this.ExecButton.Size = new System.Drawing.Size(133, 23);
            this.ExecButton.TabIndex = 2;
            this.ExecButton.Text = "ПЕРЕВЕСТИ";
            this.ExecButton.UseVisualStyleBackColor = true;
            this.ExecButton.Click += new System.EventHandler(this.ExecButton_Click);
            // 
            // ConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.ExecButton);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxInit);
            this.Name = "ConverterForm";
            this.Text = "Конвертер";
            this.groupBoxInit.ResumeLayout(false);
            this.groupBoxInit.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInit;
        private System.Windows.Forms.RadioButton MeterRadioButtonInit;
        private System.Windows.Forms.RadioButton CmRadioButtonInit;
        private System.Windows.Forms.RadioButton YardRadioButtonInit;
        private System.Windows.Forms.RadioButton FootRadioButtonInit;
        private System.Windows.Forms.RadioButton InchRadioButtonInit;
        private System.Windows.Forms.TextBox textBoxInit;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.RadioButton MeterRadioButtonResult;
        private System.Windows.Forms.RadioButton CmRadioButtonResult;
        private System.Windows.Forms.RadioButton YardRadioButtonResult;
        private System.Windows.Forms.RadioButton FootRadioButtonResult;
        private System.Windows.Forms.RadioButton InchRadioButtonResult;
        private System.Windows.Forms.Button ExecButton;
    }
}

