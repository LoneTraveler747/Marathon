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
    public partial class BMIKalkylitor : Form
    {
        int a=0,c;
        double d,b;
        DateTime DateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);

        public BMIKalkylitor()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Podrobnanformacia zakaz = new Podrobnanformacia();
            zakaz.Show();
            this.Hide();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Podrobnanformacia zakaz = new Podrobnanformacia();
            zakaz.Show();
            this.Hide();
        }

        private void Male_Click(object sender, EventArgs e)
        {
            a = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            Timer_of_start.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void Female_Click(object sender, EventArgs e)
        {
            a = 1;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double c = Convert.ToInt32(HeightText.Text);
                double d = Convert.ToInt32(WeightText.Text);
                b = d / ((c / 100) * (c / 100));
                if (b < 18)
                {
                    text2.Text = "Недостаточный";
                }
                else if (18 <= b && b < 25)
                {
                    text2.Text = "Здоровый";
                }
                else if (25 <= b && b < 30)
                {
                    text2.Text = "Избыточный";
                }
                else if (b >= 30)
                {
                    text2.Text = "Ожирение";
                }
                else
                {
                    MessageBox.Show("Ошибка в подсчёте");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка в подсчёте");
            }
           
        }
    }
}
