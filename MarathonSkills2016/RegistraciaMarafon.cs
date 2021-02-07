using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarathonSkills2016
{
    public partial class RegistraciaMarafon : Form
    {
        string connectionString = @"Data Source=DESKTOP-0KCH38C\CH_A_A;Initial Catalog=Marathon Skills 2016;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        DateTime DateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        int a;
        public RegistraciaMarafon()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MenuBegyna zakaz = new MenuBegyna();
            zakaz.Show();
            this.Hide();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            RegistraciaBegyna zakaz = new RegistraciaBegyna();
            zakaz.Show();
            this.Hide();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MenuBegyna zakaz = new MenuBegyna();
            zakaz.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            Timer_of_start.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt16(Money.Text);
            a = a + 0;
            Money.Text = a.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt16(Money.Text);
            a = a + 20;
            Money.Text = a.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt16(Money.Text);
            a = a + 45;
            Money.Text = a.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt16(Money.Text);
            a = a + 145;
            Money.Text = a.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt16(Money.Text);
            a = a + 75;
            Money.Text = a.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt16(Money.Text);
            a = a + 20;
            Money.Text = a.ToString();
        }
    }
}
