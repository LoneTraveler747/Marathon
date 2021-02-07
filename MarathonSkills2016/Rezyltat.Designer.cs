namespace MarathonSkills2016
{
    partial class Rezyltat
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
            this.text3 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.text4 = new System.Windows.Forms.Label();
            this.text5 = new System.Windows.Forms.Label();
            this.Registration = new System.Windows.Forms.Button();
            this.text6 = new System.Windows.Forms.Label();
            this.text7 = new System.Windows.Forms.Label();
            this.text8 = new System.Windows.Forms.Label();
            this.text9 = new System.Windows.Forms.Label();
            this.text10 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.TopPanel.TabIndex = 43;
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
            this.ButtonPanel.TabIndex = 44;
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text3.Location = new System.Drawing.Point(377, 134);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(268, 22);
            this.text3.TabIndex = 47;
            this.text3.Text = "Общее место сравнивает всех бегунов.";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text2.Location = new System.Drawing.Point(253, 112);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(485, 22);
            this.text2.TabIndex = 46;
            this.text2.Text = "Это - список всех ваших прошлых результатов гонки для Marathon Skills.";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text1.Location = new System.Drawing.Point(428, 83);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(162, 29);
            this.text1.TabIndex = 45;
            this.text1.Text = "Мои результаты";
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text4.Location = new System.Drawing.Point(239, 156);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(516, 22);
            this.text4.TabIndex = 48;
            this.text4.Text = "Место по категории compares runners in the same gender and age categories.";
            // 
            // text5
            // 
            this.text5.AutoSize = true;
            this.text5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text5.Location = new System.Drawing.Point(358, 178);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(287, 22);
            this.text5.TabIndex = 49;
            this.text5.Text = "Пол: мужской Возрастная категория:18-29";
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.White;
            this.Registration.Location = new System.Drawing.Point(381, 429);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(264, 50);
            this.Registration.TabIndex = 59;
            this.Registration.Text = "Показать все результаты";
            this.Registration.UseVisualStyleBackColor = false;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // text6
            // 
            this.text6.AutoSize = true;
            this.text6.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text6.Location = new System.Drawing.Point(12, 216);
            this.text6.Name = "text6";
            this.text6.Size = new System.Drawing.Size(74, 22);
            this.text6.TabIndex = 60;
            this.text6.Text = "Марафон";
            // 
            // text7
            // 
            this.text7.AutoSize = true;
            this.text7.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text7.Location = new System.Drawing.Point(239, 216);
            this.text7.Name = "text7";
            this.text7.Size = new System.Drawing.Size(79, 22);
            this.text7.TabIndex = 61;
            this.text7.Text = "Дистанция";
            // 
            // text8
            // 
            this.text8.AutoSize = true;
            this.text8.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text8.Location = new System.Drawing.Point(457, 216);
            this.text8.Name = "text8";
            this.text8.Size = new System.Drawing.Size(53, 22);
            this.text8.TabIndex = 62;
            this.text8.Text = "Время";
            // 
            // text9
            // 
            this.text9.AutoSize = true;
            this.text9.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text9.Location = new System.Drawing.Point(656, 216);
            this.text9.Name = "text9";
            this.text9.Size = new System.Drawing.Size(98, 22);
            this.text9.TabIndex = 63;
            this.text9.Text = "Общее место";
            // 
            // text10
            // 
            this.text10.AutoSize = true;
            this.text10.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text10.Location = new System.Drawing.Point(815, 216);
            this.text10.Name = "text10";
            this.text10.Size = new System.Drawing.Size(139, 22);
            this.text10.TabIndex = 64;
            this.text10.Text = "Место по категории";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Status.Location = new System.Drawing.Point(30, 256);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(85, 22);
            this.Status.TabIndex = 65;
            this.Status.Text = "2014 Japan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(30, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 66;
            this.label1.Text = "2012 Vietnam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(206, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 67;
            this.label2.Text = "21km Полумарафон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(206, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 68;
            this.label3.Text = "21km Полумарафон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(440, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 69;
            this.label4.Text = "2h 24m 42s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(440, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 70;
            this.label5.Text = "2h 07m 51s";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(681, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 22);
            this.label6.TabIndex = 71;
            this.label6.Text = "#357";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(681, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 22);
            this.label7.TabIndex = 72;
            this.label7.Text = "#331";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(847, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 22);
            this.label8.TabIndex = 73;
            this.label8.Text = "#105";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label9.Location = new System.Drawing.Point(847, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 22);
            this.label9.TabIndex = 74;
            this.label9.Text = "#124";
            // 
            // Timer_of_start
            // 
            this.Timer_of_start.AutoSize = true;
            this.Timer_of_start.Location = new System.Drawing.Point(384, 40);
            this.Timer_of_start.Name = "Timer_of_start";
            this.Timer_of_start.Size = new System.Drawing.Size(38, 17);
            this.Timer_of_start.TabIndex = 75;
            this.Timer_of_start.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Rezyltat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 551);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.text10);
            this.Controls.Add(this.text9);
            this.Controls.Add(this.text8);
            this.Controls.Add(this.text7);
            this.Controls.Add(this.text6);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.text5);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "Rezyltat";
            this.Text = "Rezyltat";
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
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text4;
        private System.Windows.Forms.Label text5;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Label text6;
        private System.Windows.Forms.Label text7;
        private System.Windows.Forms.Label text8;
        private System.Windows.Forms.Label text9;
        private System.Windows.Forms.Label text10;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Timer_of_start;
        private System.Windows.Forms.Timer timer1;
    }
}