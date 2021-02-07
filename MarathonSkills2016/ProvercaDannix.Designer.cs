namespace MarathonSkills2016
{
    partial class ProvercaDannix
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
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.Button();
            this.NewMember = new System.Windows.Forms.Button();
            this.OldMember = new System.Windows.Forms.Button();
            this.Timer_of_start = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
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
            this.TopPanel.TabIndex = 8;
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
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BottomPanel.Controls.Add(this.Timer_of_start);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 485);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(982, 66);
            this.BottomPanel.TabIndex = 9;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(841, 436);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(129, 43);
            this.Login.TabIndex = 12;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            // 
            // NewMember
            // 
            this.NewMember.BackColor = System.Drawing.Color.White;
            this.NewMember.Location = new System.Drawing.Point(341, 289);
            this.NewMember.Name = "NewMember";
            this.NewMember.Size = new System.Drawing.Size(301, 60);
            this.NewMember.TabIndex = 11;
            this.NewMember.Text = "Я новый участник";
            this.NewMember.UseVisualStyleBackColor = false;
            this.NewMember.Click += new System.EventHandler(this.NewMember_Click);
            // 
            // OldMember
            // 
            this.OldMember.BackColor = System.Drawing.Color.White;
            this.OldMember.Location = new System.Drawing.Point(342, 189);
            this.OldMember.Name = "OldMember";
            this.OldMember.Size = new System.Drawing.Size(301, 60);
            this.OldMember.TabIndex = 10;
            this.OldMember.Text = "Я участвовал ранее";
            this.OldMember.UseVisualStyleBackColor = false;
            this.OldMember.Click += new System.EventHandler(this.OldMember_Click);
            // 
            // Timer_of_start
            // 
            this.Timer_of_start.AutoSize = true;
            this.Timer_of_start.Location = new System.Drawing.Point(384, 40);
            this.Timer_of_start.Name = "Timer_of_start";
            this.Timer_of_start.Size = new System.Drawing.Size(38, 17);
            this.Timer_of_start.TabIndex = 13;
            this.Timer_of_start.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProvercaDannix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 551);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.NewMember);
            this.Controls.Add(this.OldMember);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "ProvercaDannix";
            this.Text = "ProvercaDannix";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label Marathon;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button NewMember;
        private System.Windows.Forms.Button OldMember;
        private System.Windows.Forms.Label Timer_of_start;
        private System.Windows.Forms.Timer timer1;
    }
}