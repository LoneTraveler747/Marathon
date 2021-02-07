namespace MarathonSkills2016
{
    partial class YpravlenieBegynami
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
            this.DistanceText = new System.Windows.Forms.ComboBox();
            this.Distance = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.Button();
            this.text3 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.StatusText = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.Label();
            this.SortText = new System.Windows.Forms.ComboBox();
            this.Sort = new System.Windows.Forms.Label();
            this.CSV = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.Button();
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
            this.TopPanel.TabIndex = 5;
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
            this.ButtonPanel.TabIndex = 6;
            // 
            // DistanceText
            // 
            this.DistanceText.FormattingEnabled = true;
            this.DistanceText.Location = new System.Drawing.Point(121, 185);
            this.DistanceText.Name = "DistanceText";
            this.DistanceText.Size = new System.Drawing.Size(301, 24);
            this.DistanceText.TabIndex = 43;
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Distance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Distance.Location = new System.Drawing.Point(32, 184);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(83, 22);
            this.Distance.TabIndex = 42;
            this.Distance.Text = "Дистанция:";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text1.Location = new System.Drawing.Point(391, 83);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(214, 29);
            this.text1.TabIndex = 44;
            this.text1.Text = "Управление бегунами";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(906, 185);
            this.dataGridView1.TabIndex = 45;
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(424, 215);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(132, 50);
            this.Update.TabIndex = 46;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text3.Location = new System.Drawing.Point(809, 129);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(66, 22);
            this.text3.TabIndex = 47;
            this.text3.Text = "Загрузка";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text2.Location = new System.Drawing.Point(172, 129);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(181, 22);
            this.text2.TabIndex = 48;
            this.text2.Text = "Сортировка и фильтрация";
            // 
            // StatusText
            // 
            this.StatusText.FormattingEnabled = true;
            this.StatusText.Location = new System.Drawing.Point(121, 154);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(301, 24);
            this.StatusText.TabIndex = 50;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Status.Location = new System.Drawing.Point(59, 153);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(56, 22);
            this.Status.TabIndex = 49;
            this.Status.Text = "Статус:";
            // 
            // SortText
            // 
            this.SortText.FormattingEnabled = true;
            this.SortText.Location = new System.Drawing.Point(121, 215);
            this.SortText.Name = "SortText";
            this.SortText.Size = new System.Drawing.Size(301, 24);
            this.SortText.TabIndex = 52;
            // 
            // Sort
            // 
            this.Sort.AutoSize = true;
            this.Sort.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Sort.Location = new System.Drawing.Point(19, 215);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(96, 22);
            this.Sort.TabIndex = 51;
            this.Sort.Text = "Сортировать:";
            // 
            // CSV
            // 
            this.CSV.BackColor = System.Drawing.Color.White;
            this.CSV.Location = new System.Drawing.Point(715, 156);
            this.CSV.Name = "CSV";
            this.CSV.Size = new System.Drawing.Size(246, 50);
            this.CSV.TabIndex = 53;
            this.CSV.Text = "Детальный информация (CSV)";
            this.CSV.UseVisualStyleBackColor = false;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(715, 212);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(246, 50);
            this.Email.TabIndex = 54;
            this.Email.Text = "E-mail список";
            this.Email.UseVisualStyleBackColor = false;
            // 
            // Timer_of_start
            // 
            this.Timer_of_start.AutoSize = true;
            this.Timer_of_start.Location = new System.Drawing.Point(384, 40);
            this.Timer_of_start.Name = "Timer_of_start";
            this.Timer_of_start.Size = new System.Drawing.Size(38, 17);
            this.Timer_of_start.TabIndex = 55;
            this.Timer_of_start.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // YpravlenieBegynami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 551);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.CSV);
            this.Controls.Add(this.SortText);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.DistanceText);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "YpravlenieBegynami";
            this.Text = "YpravlenieBegynami";
            this.Load += new System.EventHandler(this.YpravlenieBegynami_Load);
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
        private System.Windows.Forms.ComboBox DistanceText;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.ComboBox StatusText;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox SortText;
        private System.Windows.Forms.Label Sort;
        private System.Windows.Forms.Button CSV;
        private System.Windows.Forms.Button Email;
        private System.Windows.Forms.Label Timer_of_start;
        private System.Windows.Forms.Timer timer1;
    }
}