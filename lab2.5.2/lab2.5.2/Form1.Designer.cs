namespace lab2._5._2 {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.labelPlus = new System.Windows.Forms.Label();
            this.buttonSum = new System.Windows.Forms.Button();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.listBoxPeople = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxPerson = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonAddBut = new System.Windows.Forms.Button();
            this.buttonClick = new System.Windows.Forms.Button();
            this.groupBoxColor.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.Location = new System.Drawing.Point(14, 28);
            this.textBoxFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(68, 20);
            this.textBoxFirst.TabIndex = 0;
            
            this.textBoxFirst.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFirst_Validating);
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.Location = new System.Drawing.Point(145, 28);
            this.textBoxSecond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(68, 20);
            this.textBoxSecond.TabIndex = 1;
            this.textBoxSecond.TextChanged += new System.EventHandler(this.textBoxSecond_TextChanged);
            // 
            // textBoxSum
            // 
            this.textBoxSum.Enabled = false;
            this.textBoxSum.Location = new System.Drawing.Point(325, 28);
            this.textBoxSum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(68, 20);
            this.textBoxSum.TabIndex = 2;
            // 
            // labelPlus
            // 
            this.labelPlus.AutoSize = true;
            this.labelPlus.Location = new System.Drawing.Point(101, 28);
            this.labelPlus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(13, 13);
            this.labelPlus.TabIndex = 3;
            this.labelPlus.Text = "+";
            // 
            // buttonSum
            // 
            this.buttonSum.Enabled = false;
            this.buttonSum.Location = new System.Drawing.Point(233, 28);
            this.buttonSum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(71, 21);
            this.buttonSum.TabIndex = 4;
            this.buttonSum.Text = "Сумма";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.radioButtonGreen);
            this.groupBoxColor.Controls.Add(this.radioButtonBlue);
            this.groupBoxColor.Controls.Add(this.radioButtonRed);
            this.groupBoxColor.Location = new System.Drawing.Point(14, 78);
            this.groupBoxColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxColor.Size = new System.Drawing.Size(130, 97);
            this.groupBoxColor.TabIndex = 5;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Change color";
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(17, 66);
            this.radioButtonGreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(70, 17);
            this.radioButtonGreen.TabIndex = 2;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Зеленый";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(17, 46);
            this.radioButtonBlue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(56, 17);
            this.radioButtonBlue.TabIndex = 1;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Синий";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButtonBlue_CheckedChanged);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(17, 26);
            this.radioButtonRed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(70, 17);
            this.radioButtonRed.TabIndex = 0;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Красный";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // listBoxPeople
            // 
            this.listBoxPeople.FormattingEnabled = true;
            this.listBoxPeople.Items.AddRange(new object[] {
            "Сидоров",
            "Петров"});
            this.listBoxPeople.Location = new System.Drawing.Point(158, 81);
            this.listBoxPeople.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxPeople.Name = "listBoxPeople";
            this.listBoxPeople.Size = new System.Drawing.Size(97, 95);
            this.listBoxPeople.TabIndex = 6;
            this.listBoxPeople.SelectedIndexChanged += new System.EventHandler(this.listBoxPeople_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(293, 117);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(77, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(293, 153);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(77, 22);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxPerson
            // 
            this.textBoxPerson.Location = new System.Drawing.Point(275, 81);
            this.textBoxPerson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPerson.Name = "textBoxPerson";
            this.textBoxPerson.Size = new System.Drawing.Size(108, 20);
            this.textBoxPerson.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(411, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.fontToolStripMenuItem.Text = "Фрифт";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.closeToolStripMenuItem.Text = "Закрыть";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            
            // 
            // buttonAddBut
            // 
            this.buttonAddBut.Location = new System.Drawing.Point(38, 204);
            this.buttonAddBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddBut.Name = "buttonAddBut";
            this.buttonAddBut.Size = new System.Drawing.Size(106, 49);
            this.buttonAddBut.TabIndex = 11;
            this.buttonAddBut.Text = "Добавить кнопку";
            this.buttonAddBut.UseVisualStyleBackColor = true;
            this.buttonAddBut.Click += new System.EventHandler(this.buttonClickMe_Click);
            // 
            // buttonClick
            // 
            this.buttonClick.Location = new System.Drawing.Point(223, 204);
            this.buttonClick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClick.Name = "buttonClick";
            this.buttonClick.Size = new System.Drawing.Size(106, 49);
            this.buttonClick.TabIndex = 12;
            this.buttonClick.Text = "Нажмите";
            this.buttonClick.UseVisualStyleBackColor = true;
            this.buttonClick.Visible = false;
            this.buttonClick.Click += new System.EventHandler(this.buttonClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 289);
            this.Controls.Add(this.buttonClick);
            this.Controls.Add(this.buttonAddBut);
            this.Controls.Add(this.textBoxPerson);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxPeople);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.labelPlus);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxSecond);
            this.Controls.Add(this.textBoxFirst);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirst;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label labelPlus;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.ListBox listBoxPeople;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxPerson;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonAddBut;
        private System.Windows.Forms.Button buttonClick;
    }
}

