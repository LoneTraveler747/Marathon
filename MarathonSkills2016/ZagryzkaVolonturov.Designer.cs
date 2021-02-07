namespace MarathonSkills2016
{
    partial class ZagryzkaVolonturov
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
            this.View = new System.Windows.Forms.Button();
            this.FileText = new System.Windows.Forms.TextBox();
            this.File = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
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
            this.TopPanel.TabIndex = 3;
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
            this.ButtonPanel.TabIndex = 4;
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text1.Location = new System.Drawing.Point(387, 83);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(203, 29);
            this.text1.TabIndex = 6;
            this.text1.Text = "Загрузка волонтёров";
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.White;
            this.View.Location = new System.Drawing.Point(584, 114);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(100, 23);
            this.View.TabIndex = 38;
            this.View.Text = "Просмотр...";
            this.View.UseVisualStyleBackColor = false;
            // 
            // FileText
            // 
            this.FileText.Location = new System.Drawing.Point(383, 115);
            this.FileText.Name = "FileText";
            this.FileText.Size = new System.Drawing.Size(195, 22);
            this.FileText.TabIndex = 37;
            // 
            // File
            // 
            this.File.AutoSize = true;
            this.File.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.File.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.File.Location = new System.Drawing.Point(217, 115);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(160, 22);
            this.File.TabIndex = 36;
            this.File.Text = "CSV файл волонтёров:";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(503, 183);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(132, 50);
            this.Cancel.TabIndex = 43;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Load
            // 
            this.Load.BackColor = System.Drawing.Color.White;
            this.Load.Location = new System.Drawing.Point(350, 183);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(132, 50);
            this.Load.TabIndex = 42;
            this.Load.Text = "Загрузить";
            this.Load.UseVisualStyleBackColor = false;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Timer_of_start
            // 
            this.Timer_of_start.AutoSize = true;
            this.Timer_of_start.Location = new System.Drawing.Point(384, 40);
            this.Timer_of_start.Name = "Timer_of_start";
            this.Timer_of_start.Size = new System.Drawing.Size(38, 17);
            this.Timer_of_start.TabIndex = 44;
            this.Timer_of_start.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ZagryzkaVolonturov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 551);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.View);
            this.Controls.Add(this.FileText);
            this.Controls.Add(this.File);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "ZagryzkaVolonturov";
            this.Text = "ZagryzkaVolonturov";
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
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.TextBox FileText;
        private System.Windows.Forms.Label File;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Label Timer_of_start;
        private System.Windows.Forms.Timer timer1;
    }
}