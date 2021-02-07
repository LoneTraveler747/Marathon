using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarathonSkills2016
{
    public partial class MenuBegyna : Form
    {
        DateTime DateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public MenuBegyna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 zakaz = new Form1();
            zakaz.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistraciaMarafon zakaz = new RegistraciaMarafon();
            zakaz.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rezyltat zakaz = new Rezyltat();
            zakaz.Show();
            this.Hide();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            RedactirovaniaProfila zakaz = new RedactirovaniaProfila();
            zakaz.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MoiSponsori zakaz = new MoiSponsori();
            zakaz.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Контакты  " + 
                "Телефон: +55 111 9988 7766  " +
                "Email: coordinators@marathonskills.org  ");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            Timer_of_start.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }
    }
}
