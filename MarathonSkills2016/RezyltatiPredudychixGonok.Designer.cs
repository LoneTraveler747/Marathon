namespace MarathonSkills2016
{
    partial class RezyltatiPredudychixGonok
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
            this.text1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RunText = new System.Windows.Forms.ComboBox();
            this.Run = new System.Windows.Forms.Label();
            this.DistanceText = new System.Windows.Forms.ComboBox();
            this.Distance = new System.Windows.Forms.Label();
            this.GenderText = new System.Windows.Forms.ComboBox();
            this.Gender = new System.Windows.Forms.Label();
            this.CategoryText = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.Timer_of_start = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TopPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.TopPanel.TabIndex = 4;
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
            this.ButtonPanel.TabIndex = 5;
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text1.Location = new System.Drawing.Point(331, 83);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(295, 29);
            this.text1.TabIndex = 7;
            this.text1.Text = "Результаты предыдущих гонок";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(906, 260);
            this.dataGridView1.TabIndex = 37;
            // 
            // RunText
            // 
            this.RunText.FormattingEnabled = true;
            this.RunText.Location = new System.Drawing.Point(121, 127);
            this.RunText.Name = "RunText";
            this.RunText.Size = new System.Drawing.Size(301, 24);
            this.RunText.TabIndex = 39;
            // 
            // Run
            // 
            this.Run.AutoSize = true;
            this.Run.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Run.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Run.Location = new System.Drawing.Point(37, 126);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(78, 22);
            this.Run.TabIndex = 38;
            this.Run.Text = "Марафон:";
            // 
            // DistanceText
            // 
            this.DistanceText.FormattingEnabled = true;
            this.DistanceText.Location = new System.Drawing.Point(121, 166);
            this.DistanceText.Name = "DistanceText";
            this.DistanceText.Size = new System.Drawing.Size(301, 24);
            this.DistanceText.TabIndex = 41;
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Distance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Distance.Location = new System.Drawing.Point(32, 165);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(83, 22);
            this.Distance.TabIndex = 40;
            this.Distance.Text = "Дистанция:";
            // 
            // GenderText
            // 
            this.GenderText.FormattingEnabled = true;
            this.GenderText.Location = new System.Drawing.Point(547, 127);
            this.GenderText.Name = "GenderText";
            this.GenderText.Size = new System.Drawing.Size(140, 24);
            this.GenderText.TabIndex = 43;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Gender.Location = new System.Drawing.Point(490, 129);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(40, 22);
            this.Gender.TabIndex = 42;
            this.Gender.Text = "Пол:";
            // 
            // CategoryText
            // 
            this.CategoryText.FormattingEnabled = true;
            this.CategoryText.Location = new System.Drawing.Point(547, 166);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(140, 24);
            this.CategoryText.TabIndex = 45;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Category.Location = new System.Drawing.Point(450, 168);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(80, 22);
            this.Category.TabIndex = 44;
            this.Category.Text = "Категория:";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(693, 126);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(132, 50);
            this.Search.TabIndex = 46;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Timer_of_start
            // 
            this.Timer_of_start.AutoSize = true;
            this.Timer_of_start.Location = new System.Drawing.Point(384, 40);
            this.Timer_of_start.Name = "Timer_of_start";
            this.Timer_of_start.Size = new System.Drawing.Size(38, 17);
            this.Timer_of_start.TabIndex = 47;
            this.Timer_of_start.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RezyltatiPredudychixGonok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 551);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.CategoryText);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.GenderText);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.DistanceText);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.RunText);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "RezyltatiPredudychixGonok";
            this.Text = "RezyltatiPredudychixGonok";
            this.Load += new System.EventHandler(this.RezyltatiPredudychixGonok_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label Marathon;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox RunText;
        private System.Windows.Forms.Label Run;
        private System.Windows.Forms.ComboBox DistanceText;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.ComboBox GenderText;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.ComboBox CategoryText;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label Timer_of_start;
        private System.Windows.Forms.Timer timer1;
    }
}