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
    public partial class Form1 : Form
    {
        DateTime DateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void Runner_Click(object sender, EventArgs e)
        {
            ProvercaDannix zakaz = new ProvercaDannix();
            zakaz.Show();
            this.Hide();
        }

        private void Sponsor_Click(object sender, EventArgs e)
        {
            SponsorBegyna zakaz = new SponsorBegyna();
            zakaz.Show();
            this.Hide();
        }

        private void Event_Click(object sender, EventArgs e)
        {
            Podrobnanformacia zakaz = new Podrobnanformacia();
            zakaz.Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            MeniAvtorizacii zakaz = new MeniAvtorizacii();
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
