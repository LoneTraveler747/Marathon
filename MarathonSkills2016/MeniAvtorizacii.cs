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
    public partial class MeniAvtorizacii : Form
    {
        DateTime DateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public MeniAvtorizacii()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProvercaDannix zakaz = new ProvercaDannix();
            zakaz.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "a.adkin@dayrep.net" && textBox2.Text == "jwZh2x@p")
            {
                MenuBegyna zakaz = new MenuBegyna();
                zakaz.Show();
                this.Hide();
            }
            else if (textBox1.Text == "a.aldrich@gmail.com" && textBox2.Text == "9ApEdKdo")
            {
                MenuKoordinacii zakaz = new MenuKoordinacii();
                zakaz.Show();
                this.Hide();
            }
            else if (textBox1.Text == "a.allison@gmail.com" && textBox2.Text == "OPuDrw9O")
            {
                MenuAdministracii zakaz = new MenuAdministracii();
                zakaz.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин/пароль");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProvercaDannix zakaz = new ProvercaDannix();
            zakaz.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            Timer_of_start.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }
    }
}
