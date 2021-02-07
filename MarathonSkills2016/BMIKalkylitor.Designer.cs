namespace MarathonSkills2016
{
    partial class BMIKalkylitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMIKalkylitor));
            this.text1 = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Marathon = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.Male = new System.Windows.Forms.Button();
            this.Female = new System.Windows.Forms.Button();
            this.HeightText = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.Label();
            this.WeightText = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.Foto = new System.Windows.Forms.PictureBox();
            this.text2 = new System.Windows.Forms.Label();
            this.Cm = new System.Windows.Forms.Label();
            this.Kg = new System.Windows.Forms.Label();
            this.Timer_of_start = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TopPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text1.Location = new System.Drawing.Point(402, 83);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(161, 29);
            this.text1.TabIndex = 57;
            this.text1.Text = "BMIКалькулятор";
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
            this.TopPanel.TabIndex = 58;
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
            this.ButtonPanel.TabIndex = 59;
            // 
            // Male
            // 
            this.Male.BackColor = System.Drawing.Color.White;
            this.Male.Location = new System.Drawing.Point(37, 127);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(132, 104);
            this.Male.TabIndex = 60;
            this.Male.Text = "Мужской";
            this.Male.UseVisualStyleBackColor = false;
            this.Male.Click += new System.EventHandler(this.Male_Click);
            // 
            // Female
            // 
            this.Female.BackColor = System.Drawing.Color.White;
            this.Female.Location = new System.Drawing.Point(184, 127);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(132, 104);
            this.Female.TabIndex = 61;
            this.Female.Text = "Женский";
            this.Female.UseVisualStyleBackColor = false;
            this.Female.Click += new System.EventHandler(this.Female_Click);
            // 
            // HeightText
            // 
            this.HeightText.Location = new System.Drawing.Point(129, 248);
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(98, 22);
            this.HeightText.TabIndex = 63;
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Height.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Height.Location = new System.Drawing.Point(80, 247);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(43, 22);
            this.Height.TabIndex = 62;
            this.Height.Text = "Рост:";
            // 
            // WeightText
            // 
            this.WeightText.Location = new System.Drawing.Point(129, 274);
            this.WeightText.Name = "WeightText";
            this.WeightText.Size = new System.Drawing.Size(98, 22);
            this.WeightText.TabIndex = 65;
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Weight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Weight.Location = new System.Drawing.Point(85, 274);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(38, 22);
            this.Weight.TabIndex = 64;
            this.Weight.Text = "Вес:";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(190, 337);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(132, 50);
            this.Cancel.TabIndex = 67;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.White;
            this.Calculate.Location = new System.Drawing.Point(37, 337);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(132, 50);
            this.Calculate.TabIndex = 66;
            this.Calculate.Text = "Расчитать";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Foto
            // 
            this.Foto.Image = ((System.Drawing.Image)(resources.GetObject("Foto.Image")));
            this.Foto.Location = new System.Drawing.Point(691, 127);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(159, 168);
            this.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Foto.TabIndex = 68;
            this.Foto.TabStop = false;
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text2.Location = new System.Drawing.Point(734, 298);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(75, 22);
            this.text2.TabIndex = 69;
            this.text2.Text = "Здоровый";
            // 
            // Cm
            // 
            this.Cm.AutoSize = true;
            this.Cm.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Cm.Location = new System.Drawing.Point(233, 248);
            this.Cm.Name = "Cm";
            this.Cm.Size = new System.Drawing.Size(27, 22);
            this.Cm.TabIndex = 70;
            this.Cm.Text = "см";
            // 
            // Kg
            // 
            this.Kg.AutoSize = true;
            this.Kg.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Kg.Location = new System.Drawing.Point(233, 274);
            this.Kg.Name = "Kg";
            this.Kg.Size = new System.Drawing.Size(21, 22);
            this.Kg.TabIndex = 71;
            this.Kg.Text = "кг";
            // 
            // Timer_of_start
            // 
            this.Timer_of_start.AutoSize = true;
            this.Timer_of_start.Location = new System.Drawing.Point(404, 40);
            this.Timer_of_start.Name = "Timer_of_start";
            this.Timer_of_start.Size = new System.Drawing.Size(38, 17);
            this.Timer_of_start.TabIndex = 72;
            this.Timer_of_start.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BMIKalkylitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 551);
            this.Controls.Add(this.Kg);
            this.Controls.Add(this.Cm);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.Foto);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.WeightText);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.HeightText);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.text1);
            this.Name = "BMIKalkylitor";
            this.Text = "BMIKalkylitor";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label Marathon;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button Male;
        private System.Windows.Forms.Button Female;
        private System.Windows.Forms.TextBox HeightText;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.TextBox WeightText;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.PictureBox Foto;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label Cm;
        private System.Windows.Forms.Label Kg;
        private System.Windows.Forms.Label Timer_of_start;
        private System.Windows.Forms.Timer timer1;
    }
}