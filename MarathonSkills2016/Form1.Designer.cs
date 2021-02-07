namespace MarathonSkills2016
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Runner = new System.Windows.Forms.Button();
            this.Sponsor = new System.Windows.Forms.Button();
            this.Event = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.Timer_of_start = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 175);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(364, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Среда21 октября2021";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(406, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Москва,Россия";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(334, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marathon Skills 2021";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.Timer_of_start);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 50);
            this.panel2.TabIndex = 1;
            // 
            // Runner
            // 
            this.Runner.BackColor = System.Drawing.Color.White;
            this.Runner.Location = new System.Drawing.Point(342, 205);
            this.Runner.Name = "Runner";
            this.Runner.Size = new System.Drawing.Size(301, 60);
            this.Runner.TabIndex = 2;
            this.Runner.Text = "Я хочу стать бегуном";
            this.Runner.UseVisualStyleBackColor = false;
            this.Runner.Click += new System.EventHandler(this.Runner_Click);
            // 
            // Sponsor
            // 
            this.Sponsor.BackColor = System.Drawing.Color.White;
            this.Sponsor.Location = new System.Drawing.Point(342, 305);
            this.Sponsor.Name = "Sponsor";
            this.Sponsor.Size = new System.Drawing.Size(301, 60);
            this.Sponsor.TabIndex = 3;
            this.Sponsor.Text = "Я хочу стать спонсором бегуна";
            this.Sponsor.UseVisualStyleBackColor = false;
            this.Sponsor.Click += new System.EventHandler(this.Sponsor_Click);
            // 
            // Event
            // 
            this.Event.BackColor = System.Drawing.Color.White;
            this.Event.Location = new System.Drawing.Point(342, 408);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(301, 60);
            this.Event.TabIndex = 4;
            this.Event.Text = "Я хочу знать больше о событии";
            this.Event.UseVisualStyleBackColor = false;
            this.Event.Click += new System.EventHandler(this.Event_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(841, 452);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(129, 43);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Timer_of_start
            // 
            this.Timer_of_start.AutoSize = true;
            this.Timer_of_start.Location = new System.Drawing.Point(366, 24);
            this.Timer_of_start.Name = "Timer_of_start";
            this.Timer_of_start.Size = new System.Drawing.Size(38, 17);
            this.Timer_of_start.TabIndex = 0;
            this.Timer_of_start.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 551);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Event);
            this.Controls.Add(this.Sponsor);
            this.Controls.Add(this.Runner);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Runner;
        private System.Windows.Forms.Button Sponsor;
        private System.Windows.Forms.Button Event;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label Timer_of_start;
        private System.Windows.Forms.Timer timer1;
    }
}

