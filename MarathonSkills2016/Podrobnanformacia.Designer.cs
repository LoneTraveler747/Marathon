namespace MarathonSkills2016
{
    partial class Podrobnanformacia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Marathon = new System.Windows.Forms.Button();
            this.Rezult = new System.Windows.Forms.Button();
            this.BMI = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.Button();
            this.BMR = new System.Windows.Forms.Button();
            this.Timer_of_start = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 80);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marathon Skills2021";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.Timer_of_start);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 485);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 66);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(381, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Подробная информация";
            // 
            // Marathon
            // 
            this.Marathon.BackColor = System.Drawing.Color.White;
            this.Marathon.Location = new System.Drawing.Point(177, 133);
            this.Marathon.Name = "Marathon";
            this.Marathon.Size = new System.Drawing.Size(301, 60);
            this.Marathon.TabIndex = 5;
            this.Marathon.Text = "Marathon Skills 2016";
            this.Marathon.UseVisualStyleBackColor = false;
            this.Marathon.Click += new System.EventHandler(this.Marathon_Click);
            // 
            // Rezult
            // 
            this.Rezult.BackColor = System.Drawing.Color.White;
            this.Rezult.Location = new System.Drawing.Point(177, 228);
            this.Rezult.Name = "Rezult";
            this.Rezult.Size = new System.Drawing.Size(301, 60);
            this.Rezult.TabIndex = 6;
            this.Rezult.Text = "Предыдущие результаты";
            this.Rezult.UseVisualStyleBackColor = false;
            this.Rezult.Click += new System.EventHandler(this.Rezult_Click);
            // 
            // BMI
            // 
            this.BMI.BackColor = System.Drawing.Color.White;
            this.BMI.Location = new System.Drawing.Point(177, 325);
            this.BMI.Name = "BMI";
            this.BMI.Size = new System.Drawing.Size(301, 60);
            this.BMI.TabIndex = 7;
            this.BMI.Text = "BMIкалькулятор";
            this.BMI.UseVisualStyleBackColor = false;
            this.BMI.Click += new System.EventHandler(this.BMI_Click);
            // 
            // Time
            // 
            this.Time.BackColor = System.Drawing.Color.White;
            this.Time.Location = new System.Drawing.Point(523, 133);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(301, 60);
            this.Time.TabIndex = 8;
            this.Time.Text = "Насколько долгий марафон";
            this.Time.UseVisualStyleBackColor = false;
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.Color.White;
            this.List.Location = new System.Drawing.Point(523, 228);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(301, 60);
            this.List.TabIndex = 9;
            this.List.Text = "Список благотворительных организаций";
            this.List.UseVisualStyleBackColor = false;
            this.List.Click += new System.EventHandler(this.List_Click);
            // 
            // BMR
            // 
            this.BMR.BackColor = System.Drawing.Color.White;
            this.BMR.Location = new System.Drawing.Point(523, 325);
            this.BMR.Name = "BMR";
            this.BMR.Size = new System.Drawing.Size(301, 60);
            this.BMR.TabIndex = 10;
            this.BMR.Text = "BMRкалькулятор";
            this.BMR.UseVisualStyleBackColor = false;
            this.BMR.Click += new System.EventHandler(this.BMR_Click);
            // 
            // Timer_of_start
            // 
            this.Timer_of_start.AutoSize = true;
            this.Timer_of_start.Location = new System.Drawing.Point(384, 40);
            this.Timer_of_start.Name = "Timer_of_start";
            this.Timer_of_start.Size = new System.Drawing.Size(38, 17);
            this.Timer_of_start.TabIndex = 11;
            this.Timer_of_start.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Podrobnanformacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 551);
            this.Controls.Add(this.BMR);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.BMI);
            this.Controls.Add(this.Rezult);
            this.Controls.Add(this.Marathon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Podrobnanformacia";
            this.Text = "Подробная_информация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Marathon;
        private System.Windows.Forms.Button Rezult;
        private System.Windows.Forms.Button BMI;
        private System.Windows.Forms.Button Time;
        private System.Windows.Forms.Button List;
        private System.Windows.Forms.Button BMR;
        private System.Windows.Forms.Label Timer_of_start;
        private System.Windows.Forms.Timer timer1;
    }
}