namespace MarathonSkills2016
{
    partial class MenuAdministracii
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
            this.Volunteer = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Inventory = new System.Windows.Forms.Button();
            this.Organization = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 7;
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
            this.panel2.TabIndex = 8;
            // 
            // Volunteer
            // 
            this.Volunteer.BackColor = System.Drawing.Color.White;
            this.Volunteer.Location = new System.Drawing.Point(498, 127);
            this.Volunteer.Name = "Volunteer";
            this.Volunteer.Size = new System.Drawing.Size(301, 60);
            this.Volunteer.TabIndex = 17;
            this.Volunteer.Text = "Волонтёры";
            this.Volunteer.UseVisualStyleBackColor = false;
            this.Volunteer.Click += new System.EventHandler(this.Volunteer_Click);
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.White;
            this.User.Location = new System.Drawing.Point(171, 127);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(301, 60);
            this.User.TabIndex = 16;
            this.User.Text = "Пользовтелиа";
            this.User.UseVisualStyleBackColor = false;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(388, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Меню Администратора";
            // 
            // Inventory
            // 
            this.Inventory.BackColor = System.Drawing.Color.White;
            this.Inventory.Location = new System.Drawing.Point(498, 209);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(301, 60);
            this.Inventory.TabIndex = 19;
            this.Inventory.Text = "Инвентарь";
            this.Inventory.UseVisualStyleBackColor = false;
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // Organization
            // 
            this.Organization.BackColor = System.Drawing.Color.White;
            this.Organization.Location = new System.Drawing.Point(171, 209);
            this.Organization.Name = "Organization";
            this.Organization.Size = new System.Drawing.Size(301, 60);
            this.Organization.TabIndex = 18;
            this.Organization.Text = "Благотворительные организации";
            this.Organization.UseVisualStyleBackColor = false;
            this.Organization.Click += new System.EventHandler(this.Organization_Click);
            // 
            // Timer_of_start
            // 
            this.Timer_of_start.AutoSize = true;
            this.Timer_of_start.Location = new System.Drawing.Point(384, 40);
            this.Timer_of_start.Name = "Timer_of_start";
            this.Timer_of_start.Size = new System.Drawing.Size(38, 17);
            this.Timer_of_start.TabIndex = 20;
            this.Timer_of_start.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuAdministracii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 551);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.Organization);
            this.Controls.Add(this.Volunteer);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MenuAdministracii";
            this.Text = "MenuAdministracii";
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
        private System.Windows.Forms.Button Volunteer;
        private System.Windows.Forms.Button User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Inventory;
        private System.Windows.Forms.Button Organization;
        private System.Windows.Forms.Label Timer_of_start;
        private System.Windows.Forms.Timer timer1;
    }
}