namespace MarathonSkills2016
{
    partial class RegistraciaBegyna
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Marathon = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.text3 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
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
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text3.Location = new System.Drawing.Point(389, 185);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(244, 22);
            this.text3.TabIndex = 11;
            this.text3.Text = "С вами свяжутся по поводу оплаты.";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text2.Location = new System.Drawing.Point(255, 140);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(480, 22);
            this.text2.TabIndex = 10;
            this.text2.Text = "Спасибо за вашу регистрацию в качестве бегуна в Marathon Skills 2016!";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.text1.Location = new System.Drawing.Point(263, 83);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(462, 29);
            this.text1.TabIndex = 9;
            this.text1.Text = "Спасибо за вашу регистрацию в качестве бегуна!";
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.Color.White;
            this.Ok.Location = new System.Drawing.Point(453, 237);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(132, 50);
            this.Ok.TabIndex = 34;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // RegistraciaBegyna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 551);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.TopPanel);
            this.Name = "RegistraciaBegyna";
            this.Text = "RegistraciaBegyna";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label Marathon;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Button Ok;
    }
}