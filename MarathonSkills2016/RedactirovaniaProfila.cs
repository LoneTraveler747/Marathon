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
    public partial class RedactirovaniaProfila : Form
    {
        DateTime DateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public RedactirovaniaProfila()
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
            if (EmailText.Text == "" && PasswordText.Text == PasswordText2.Text && NameText.Text == "" && SurnameText.Text == "")
            {
                MenuBegyna zakaz = new MenuBegyna();
                zakaz.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
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
    }
}
