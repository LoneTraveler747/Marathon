namespace MarathonSkills2016
{
    partial class YpravleniePolzovatelami
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
            this.Text1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.FilterText = new System.Windows.Forms.ComboBox();
            this.Filter = new System.Windows.Forms.Label();
            this.SortText = new System.Windows.Forms.ComboBox();
            this.Sort = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.TopPanel.TabIndex = 45;
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
            this.ButtonPanel.TabIndex = 46;
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Text1.Location = new System.Drawing.Point(358, 83);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(280, 29);
            this.Text1.TabIndex = 73;
            this.Text1.Text = "Управление пользователями";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(57, 132);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(132, 50);
            this.Add.TabIndex = 85;
            this.Add.Text = "+Добавление нового";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // FilterText
            // 
            this.FilterText.FormattingEnabled = true;
            this.FilterText.Location = new System.Drawing.Point(669, 132);
            this.FilterText.Name = "FilterText";
            this.FilterText.Size = new System.Drawing.Size(301, 24);
            this.FilterText.TabIndex = 93;
            // 
            // Filter
            // 
            this.Filter.AutoSize = true;
            this.Filter.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Filter.Location = new System.Drawing.Point(536, 134);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(127, 22);
            this.Filter.TabIndex = 92;
            this.Filter.Text = "Фильтр по ролям:";
            // 
            // SortText
            // 
            this.SortText.FormattingEnabled = true;
            this.SortText.Location = new System.Drawing.Point(669, 162);
            this.SortText.Name = "SortText";
            this.SortText.Size = new System.Drawing.Size(301, 24);
            this.SortText.TabIndex = 95;
            // 
            // Sort
            // 
            this.Sort.AutoSize = true;
            this.Sort.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Sort.Location = new System.Drawing.Point(547, 162);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(116, 22);
            this.Sort.TabIndex = 94;
            this.Sort.Text = "Сортировать по:";
            // 
            // SearchText
            // 
            this.SearchText.FormattingEnabled = true;
            this.SearchText.Location = new System.Drawing.Point(669, 192);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(301, 24);
            this.SearchText.TabIndex = 97;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Search.Location = new System.Drawing.Point(610, 194);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(53, 22);
            this.Search.TabIndex = 96;
            this.Search.Text = "Поиск:";
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(669, 222);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(132, 50);
            this.Update.TabIndex = 98;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 193);
            this.dataGridView1.TabIndex = 99;
            // 
            // Timer_of_start
            // 
            this.Timer_of_start.AutoSize = true;
            this.Timer_of_start.Location = new System.Drawing.Point(384, 40);
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
            // YpravleniePolzovatelami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 551);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SortText);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.FilterText);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "YpravleniePolzovatelami";
            this.Text = "YpravleniePolzovatelami";
            this.Load += new System.EventHandler(this.YpravleniePolzovatelami_Load);
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
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox FilterText;
        private System.Windows.Forms.Label Filter;
        private System.Windows.Forms.ComboBox SortText;
        private System.Windows.Forms.Label Sort;
        private System.Windows.Forms.ComboBox SearchText;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Timer_of_start;
        private System.Windows.Forms.Timer timer1;
    }
}