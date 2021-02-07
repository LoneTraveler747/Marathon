namespace MarathonSkills2016
{
    partial class BMRKalkylator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Marathon = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.Kg = new System.Windows.Forms.Label();
            this.Cm = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.WeightText = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.Label();
            this.HeightText = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.Label();
            this.Female = new System.Windows.Forms.Button();
            this.Male = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.YourBMR = new System.Windows.Forms.Label();
            this.BMR = new System.Windows.Forms.Label();
            this.CaloriesInfo = new System.Windows.Forms.Label();
            this.CaloriesText1 = new System.Windows.Forms.Label();
            this.CaloriesText2 = new System.Windows.Forms.Label();
            this.CaloriesText3 = new System.Windows.Forms.Label();
            this.CaloriesText4 = new System.Windows.Forms.Label();
            this.CaloriesText5 = new System.Windows.Forms.Label();
            this.Calories1 = new System.Windows.Forms.Label();
            this.Calories2 = new System.Windows.Forms.Label();
            this.Calories3 = new System.Windows.Forms.Label();
            this.Calories4 = new System.Windows.Forms.Label();
            this.Calories5 = new System.Windows.Forms.Label();
            this.information = new System.Windows.Forms.Button();
            this.Year = new System.Windows.Forms.Label();
            this.AgeText = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.Timer_of_start = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TopPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.TopPanel.Controls.Add(this.Marathon);
            this.TopPanel.Controls.Add(this.Back);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(982, 80);
            this.TopPanel.TabIndex = 1;
            // 
            // Marathon
            // 
            this.Marathon.AutoSize = true;
            this.Marathon.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Marathon.ForeColor = System.Drawing.Color.White;
            this.Marathon.Location = new System.Drawing.Point(121, 12);
            this.Marathon.Name = "Marathon";
            this.Marathon.Size = new System.Drawing.Size(301, 44);
            this.Marathon.TabIndex = 1;
            this.Marathon.Text = "Marathon Skills2021";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(103, 43);
            this.Back.TabIndex = 0;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ButtonPanel.Controls.Add(this.Timer_of_start);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 485);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(982, 66);
            this.ButtonPanel.TabIndex = 2;
            // 
            // Kg
            // 
            this.Kg.AutoSize = true;
            this.Kg.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Kg.Location = new System.Drawing.Point(246, 274);
            this.Kg.Name = "Kg";
            this.Kg.Size = new System.Drawing.Size(21, 22);
            this.Kg.TabIndex = 82;
            this.Kg.Text = "кг";
            // 
            // Cm
            // 
            this.Cm.AutoSize = true;
            this.Cm.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Cm.Location = new System.Drawing.Point(246, 248);
            this.Cm.Name = "Cm";
            this.Cm.Size = new System.Drawing.Size(27, 22);
            this.Cm.TabIndex = 81;
            this.Cm.Text = "см";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(203, 337);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(132, 50);
            this.Cancel.TabIndex = 80;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.White;
            this.Calculate.Location = new System.Drawing.Point(50, 337);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(132, 50);
            this.Calculate.TabIndex = 79;
            this.Calculate.Text = "Расчитать";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // WeightText
            // 
            this.WeightText.Location = new System.Drawing.Point(142, 274);
            this.WeightText.Name = "WeightText";
            this.WeightText.Size = new System.Drawing.Size(98, 22);
            this.WeightText.TabIndex = 78;
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Weight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Weight.Location = new System.Drawing.Point(98, 274);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(38, 22);
            this.Weight.TabIndex = 77;
            this.Weight.Text = "Вес:";
            // 
            // HeightText
            // 
            this.HeightText.Location = new System.Drawing.Point(142, 248);
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(98, 22);
            this.HeightText.TabIndex = 76;
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Height.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Height.Location = new System.Drawing.Point(93, 247);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(43, 22);
            this.Height.TabIndex = 75;
            this.Height.Text = "Рост:";
            // 
            // Female
            // 
            this.Female.BackColor = System.Drawing.Color.White;
            this.Female.Location = new System.Drawing.Point(197, 127);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(132, 104);
            this.Female.TabIndex = 74;
            this.Female.Text = "Женский";
            this.Female.UseVisualStyleBackColor = false;
            this.Female.Click += new System.EventHandler(this.Female_Click);
            // 
            // Male
            // 
            this.Male.BackColor = System.Drawing.Color.White;
            this.Male.Location = new System.Drawing.Point(50, 127);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(132, 104);
            this.Male.TabIndex = 73;
            this.Male.Text = "Мужской";
            this.Male.UseVisualStyleBackColor = false;
            this.Male.Click += new System.EventHandler(this.Male_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text1.Location = new System.Drawing.Point(414, 83);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(171, 29);
            this.text1.TabIndex = 72;
            this.text1.Text = "BMRКалькулятор";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text2.Location = new System.Drawing.Point(512, 127);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(384, 22);
            this.text2.TabIndex = 83;
            this.text2.Text = "Информация о показателях калорий показывается здесь";
            // 
            // YourBMR
            // 
            this.YourBMR.AutoSize = true;
            this.YourBMR.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YourBMR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.YourBMR.Location = new System.Drawing.Point(675, 149);
            this.YourBMR.Name = "YourBMR";
            this.YourBMR.Size = new System.Drawing.Size(102, 29);
            this.YourBMR.TabIndex = 84;
            this.YourBMR.Text = "Ваш BMR";
            // 
            // BMR
            // 
            this.BMR.AutoSize = true;
            this.BMR.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.BMR.Location = new System.Drawing.Point(695, 202);
            this.BMR.Name = "BMR";
            this.BMR.Size = new System.Drawing.Size(57, 29);
            this.BMR.TabIndex = 85;
            this.BMR.Text = "1670";
            // 
            // CaloriesInfo
            // 
            this.CaloriesInfo.AutoSize = true;
            this.CaloriesInfo.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaloriesInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CaloriesInfo.Location = new System.Drawing.Point(579, 243);
            this.CaloriesInfo.Name = "CaloriesInfo";
            this.CaloriesInfo.Size = new System.Drawing.Size(281, 29);
            this.CaloriesInfo.TabIndex = 86;
            this.CaloriesInfo.Text = "Ежедневно тратится калорий";
            // 
            // CaloriesText1
            // 
            this.CaloriesText1.AutoSize = true;
            this.CaloriesText1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaloriesText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CaloriesText1.Location = new System.Drawing.Point(776, 296);
            this.CaloriesText1.Name = "CaloriesText1";
            this.CaloriesText1.Size = new System.Drawing.Size(57, 29);
            this.CaloriesText1.TabIndex = 87;
            this.CaloriesText1.Text = "1670";
            // 
            // CaloriesText2
            // 
            this.CaloriesText2.AutoSize = true;
            this.CaloriesText2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaloriesText2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CaloriesText2.Location = new System.Drawing.Point(776, 328);
            this.CaloriesText2.Name = "CaloriesText2";
            this.CaloriesText2.Size = new System.Drawing.Size(57, 29);
            this.CaloriesText2.TabIndex = 88;
            this.CaloriesText2.Text = "1670";
            // 
            // CaloriesText3
            // 
            this.CaloriesText3.AutoSize = true;
            this.CaloriesText3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaloriesText3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CaloriesText3.Location = new System.Drawing.Point(776, 358);
            this.CaloriesText3.Name = "CaloriesText3";
            this.CaloriesText3.Size = new System.Drawing.Size(57, 29);
            this.CaloriesText3.TabIndex = 89;
            this.CaloriesText3.Text = "1670";
            // 
            // CaloriesText4
            // 
            this.CaloriesText4.AutoSize = true;
            this.CaloriesText4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaloriesText4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CaloriesText4.Location = new System.Drawing.Point(776, 387);
            this.CaloriesText4.Name = "CaloriesText4";
            this.CaloriesText4.Size = new System.Drawing.Size(57, 29);
            this.CaloriesText4.TabIndex = 90;
            this.CaloriesText4.Text = "1670";
            // 
            // CaloriesText5
            // 
            this.CaloriesText5.AutoSize = true;
            this.CaloriesText5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaloriesText5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CaloriesText5.Location = new System.Drawing.Point(776, 415);
            this.CaloriesText5.Name = "CaloriesText5";
            this.CaloriesText5.Size = new System.Drawing.Size(57, 29);
            this.CaloriesText5.TabIndex = 91;
            this.CaloriesText5.Text = "1670";
            // 
            // Calories1
            // 
            this.Calories1.AutoSize = true;
            this.Calories1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calories1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Calories1.Location = new System.Drawing.Point(618, 299);
            this.Calories1.Name = "Calories1";
            this.Calories1.Size = new System.Drawing.Size(71, 22);
            this.Calories1.TabIndex = 92;
            this.Calories1.Text = "Сидячий:";
            // 
            // Calories2
            // 
            this.Calories2.AutoSize = true;
            this.Calories2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calories2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Calories2.Location = new System.Drawing.Point(513, 328);
            this.Calories2.Name = "Calories2";
            this.Calories2.Size = new System.Drawing.Size(176, 22);
            this.Calories2.TabIndex = 93;
            this.Calories2.Text = "Маленькая актививность:";
            // 
            // Calories3
            // 
            this.Calories3.AutoSize = true;
            this.Calories3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calories3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Calories3.Location = new System.Drawing.Point(529, 357);
            this.Calories3.Name = "Calories3";
            this.Calories3.Size = new System.Drawing.Size(160, 22);
            this.Calories3.TabIndex = 94;
            this.Calories3.Text = "Средняя актививность:";
            // 
            // Calories4
            // 
            this.Calories4.AutoSize = true;
            this.Calories4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calories4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Calories4.Location = new System.Drawing.Point(530, 386);
            this.Calories4.Name = "Calories4";
            this.Calories4.Size = new System.Drawing.Size(159, 22);
            this.Calories4.TabIndex = 95;
            this.Calories4.Text = "Сильная актививность:";
            // 
            // Calories5
            // 
            this.Calories5.AutoSize = true;
            this.Calories5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calories5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Calories5.Location = new System.Drawing.Point(488, 415);
            this.Calories5.Name = "Calories5";
            this.Calories5.Size = new System.Drawing.Size(201, 22);
            this.Calories5.TabIndex = 96;
            this.Calories5.Text = "Максимальная актививность:";
            // 
            // information
            // 
            this.information.BackColor = System.Drawing.Color.White;
            this.information.Location = new System.Drawing.Point(867, 247);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(29, 22);
            this.information.TabIndex = 97;
            this.information.Text = "!";
            this.information.UseVisualStyleBackColor = false;
            this.information.Click += new System.EventHandler(this.information_Click);
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Year.Location = new System.Drawing.Point(246, 300);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(31, 22);
            this.Year.TabIndex = 100;
            this.Year.Text = "лет";
            // 
            // AgeText
            // 
            this.AgeText.Location = new System.Drawing.Point(142, 300);
            this.AgeText.Name = "AgeText";
            this.AgeText.Size = new System.Drawing.Size(98, 22);
            this.AgeText.TabIndex = 99;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Age.Location = new System.Drawing.Point(71, 299);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(65, 22);
            this.Age.TabIndex = 98;
            this.Age.Text = "Возраст:";
            // 
            // Timer_of_start
            // 
            this.Timer_of_start.AutoSize = true;
            this.Timer_of_start.Location = new System.Drawing.Point(416, 40);
            this.Timer_of_start.Name = "Timer_of_start";
            this.Timer_of_start.Size = new System.Drawing.Size(38, 17);
            this.Timer_of_start.TabIndex = 1;
            this.Timer_of_start.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BMRKalkylator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 551);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.AgeText);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.information);
            this.Controls.Add(this.Calories5);
            this.Controls.Add(this.Calories4);
            this.Controls.Add(this.Calories3);
            this.Controls.Add(this.Calories2);
            this.Controls.Add(this.Calories1);
            this.Controls.Add(this.CaloriesText5);
            this.Controls.Add(this.CaloriesText4);
            this.Controls.Add(this.CaloriesText3);
            this.Controls.Add(this.CaloriesText2);
            this.Controls.Add(this.CaloriesText1);
            this.Controls.Add(this.CaloriesInfo);
            this.Controls.Add(this.BMR);
            this.Controls.Add(this.YourBMR);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.Kg);
            this.Controls.Add(this.Cm);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.WeightText);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.HeightText);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "BMRKalkylator";
            this.Text = "BMRKalkylator";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label Marathon;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Label Kg;
        private System.Windows.Forms.Label Cm;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox WeightText;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.TextBox HeightText;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Button Female;
        private System.Windows.Forms.Button Male;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label YourBMR;
        private System.Windows.Forms.Label BMR;
        private System.Windows.Forms.Label CaloriesInfo;
        private System.Windows.Forms.Label CaloriesText1;
        private System.Windows.Forms.Label CaloriesText2;
        private System.Windows.Forms.Label CaloriesText3;
        private System.Windows.Forms.Label CaloriesText4;
        private System.Windows.Forms.Label CaloriesText5;
        private System.Windows.Forms.Label Calories1;
        private System.Windows.Forms.Label Calories2;
        private System.Windows.Forms.Label Calories3;
        private System.Windows.Forms.Label Calories4;
        private System.Windows.Forms.Label Calories5;
        private System.Windows.Forms.Button information;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.TextBox AgeText;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Timer_of_start;
        private System.Windows.Forms.Timer timer1;
    }
}