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
    public partial class MenuAdministracii : Form
    {
        DateTime DateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public MenuAdministracii()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 zakaz = new Form1();
            zakaz.Show();
            this.Hide();
        }

        private void User_Click(object sender, EventArgs e)
        {
            YpravleniePolzovatelami zakaz = new YpravleniePolzovatelami();
            zakaz.Show();
            this.Hide();
        }

        private void Volunteer_Click(object sender, EventArgs e)
        {
            YpravlenieVolonterami zakaz = new YpravlenieVolonterami();
            zakaz.Show();
            this.Hide();
        }

        private void Organization_Click(object sender, EventArgs e)
        {
            YpravlenieBlagotvoritelnimiOrganizaciami zakaz = new YpravlenieBlagotvoritelnimiOrganizaciami();
            zakaz.Show();
            this.Hide();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            Inventar zakaz = new Inventar();
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
