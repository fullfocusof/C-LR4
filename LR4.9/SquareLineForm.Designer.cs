namespace LR4._9
{
    partial class SquareLineForm
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
            this.ExecButtonDraw = new System.Windows.Forms.Button();
            this.textBoxSteps = new System.Windows.Forms.TextBox();
            this.ExecButtonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExecButtonDraw
            // 
            this.ExecButtonDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecButtonDraw.Location = new System.Drawing.Point(12, 12);
            this.ExecButtonDraw.Name = "ExecButtonDraw";
            this.ExecButtonDraw.Size = new System.Drawing.Size(582, 31);
            this.ExecButtonDraw.TabIndex = 0;
            this.ExecButtonDraw.Text = "Изобразить новый треугольник";
            this.ExecButtonDraw.UseVisualStyleBackColor = true;
            this.ExecButtonDraw.Click += new System.EventHandler(this.ExecButtonDraw_Click);
            // 
            // textBoxSteps
            // 
            this.textBoxSteps.Location = new System.Drawing.Point(473, 389);
            this.textBoxSteps.Name = "textBoxSteps";
            this.textBoxSteps.Size = new System.Drawing.Size(40, 20);
            this.textBoxSteps.TabIndex = 1;
            // 
            // ExecButtonStart
            // 
            this.ExecButtonStart.Location = new System.Drawing.Point(519, 389);
            this.ExecButtonStart.Name = "ExecButtonStart";
            this.ExecButtonStart.Size = new System.Drawing.Size(75, 22);
            this.ExecButtonStart.TabIndex = 2;
            this.ExecButtonStart.Text = "Начать";
            this.ExecButtonStart.UseVisualStyleBackColor = true;
            this.ExecButtonStart.Click += new System.EventHandler(this.ExecButtonStart_Click);
            // 
            // SquareLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 423);
            this.Controls.Add(this.ExecButtonStart);
            this.Controls.Add(this.textBoxSteps);
            this.Controls.Add(this.ExecButtonDraw);
            this.Name = "SquareLineForm";
            this.Text = "Треугольники + линии";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SquareLineForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecButtonDraw;
        private System.Windows.Forms.TextBox textBoxSteps;
        private System.Windows.Forms.Button ExecButtonStart;
    }
}

