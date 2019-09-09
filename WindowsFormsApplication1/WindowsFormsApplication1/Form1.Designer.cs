namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label1 = new System.Windows.Forms.Label();
            this.LabelS = new System.Windows.Forms.Label();
            this.EnterR = new System.Windows.Forms.Button();
            this.TextR = new System.Windows.Forms.TextBox();
            this.TextS = new System.Windows.Forms.TextBox();
            this.CalcS = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.LabelC = new System.Windows.Forms.Label();
            this.TextC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(22, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(160, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Окно ввода значения радиуса";
            
            // 
            // LabelS
            // 
            this.LabelS.AutoSize = true;
            this.LabelS.Location = new System.Drawing.Point(22, 170);
            this.LabelS.Name = "LabelS";
            this.LabelS.Size = new System.Drawing.Size(85, 13);
            this.LabelS.TabIndex = 2;
            this.LabelS.Text = "Площадь круга";
            // 
            // EnterR
            // 
            this.EnterR.Location = new System.Drawing.Point(25, 73);
            this.EnterR.Name = "EnterR";
            this.EnterR.Size = new System.Drawing.Size(177, 23);
            this.EnterR.TabIndex = 3;
            this.EnterR.Text = "Исходные данные введены";
            this.EnterR.UseVisualStyleBackColor = true;
            this.EnterR.Click += new System.EventHandler(this.EnterR_Click);
            // 
            // TextR
            // 
            this.TextR.Location = new System.Drawing.Point(25, 47);
            this.TextR.Name = "TextR";
            this.TextR.Size = new System.Drawing.Size(157, 20);
            this.TextR.TabIndex = 4;
            // 
            // TextS
            // 
            this.TextS.Location = new System.Drawing.Point(25, 186);
            this.TextS.Name = "TextS";
            this.TextS.Size = new System.Drawing.Size(100, 20);
            this.TextS.TabIndex = 5;
            // 
            // CalcS
            // 
            this.CalcS.Enabled = false;
            this.CalcS.Location = new System.Drawing.Point(126, 222);
            this.CalcS.Name = "CalcS";
            this.CalcS.Size = new System.Drawing.Size(139, 23);
            this.CalcS.TabIndex = 6;
            this.CalcS.Text = "Вычислить";
            this.CalcS.UseVisualStyleBackColor = true;
            this.CalcS.Click += new System.EventHandler(this.CalcS_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(158, 271);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LabelC
            // 
            this.LabelC.AutoSize = true;
            this.LabelC.Location = new System.Drawing.Point(261, 170);
            this.LabelC.Name = "LabelC";
            this.LabelC.Size = new System.Drawing.Size(103, 13);
            this.LabelC.TabIndex = 9;
            this.LabelC.Text = "Длина окружности";
            // 
            // TextC
            // 
            this.TextC.Location = new System.Drawing.Point(264, 186);
            this.TextC.Name = "TextC";
            this.TextC.Size = new System.Drawing.Size(100, 20);
            this.TextC.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(386, 335);
            this.Controls.Add(this.TextC);
            this.Controls.Add(this.LabelC);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CalcS);
            this.Controls.Add(this.TextS);
            this.Controls.Add(this.TextR);
            this.Controls.Add(this.EnterR);
            this.Controls.Add(this.LabelS);
            this.Controls.Add(this.Label1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Вычисление площади круга и окружности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label LabelS;
        private System.Windows.Forms.Button EnterR;
        private System.Windows.Forms.TextBox TextR;
        private System.Windows.Forms.TextBox TextS;
        private System.Windows.Forms.Button CalcS;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label LabelC;
        private System.Windows.Forms.TextBox TextC;
    }
}

