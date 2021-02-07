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
    public partial class BMRKalkylator : Form
    {
        int a = 0, c;
        double d, b, s;
        double z, x, h, g, f;
        DateTime DateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            Timer_of_start.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void information_Click(object sender, EventArgs e)
        {
            MessageBox.Show("СИДЯЧИЙ ОБРАЗ 	НЕТ РАБОТЫ ИЛИ РАБОТА ЗА СТОЛОМ             Маленькая активность Мало физических работы или занятия спортом 1 - 3 раза в неделю                                     " +
                "                             СРЕДНЯЯ АКТИВНОСТЬ УМЕРЕННАЯ ФИЗИЧЕСКАЯ РАБОТА ИЛИ ЗАНЯТИЯ СПОРТОМ 3 - 5 ДНЕЙ В НЕДЕЛЮ Сильная активность  Сильные физическая нагрузка или занятия спортом 6 - 7 дней в неделю Максимальная активность Сильная ежедневная физическая нагрузка или спорт и физическая работа");
        }

        public BMRKalkylator()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Podrobnanformacia zakaz = new Podrobnanformacia();
            zakaz.Show();
            this.Hide();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double c = Convert.ToInt32(HeightText.Text);
                double d = Convert.ToInt32(WeightText.Text);
                double s = Convert.ToInt32(WeightText.Text);
                if (a <= 1)
                {
                    b = 66.0 + (13.7 * c) + (5.0 * d) + (6.8 * s);
                    z = b * 1.2;
                    x = b * 1.375;
                    h = b * 1.55;
                    g = b * 1.725;
                    f = b * 1.9;

                    BMR.Text = b.ToString();
                    CaloriesText1.Text = z.ToString();
                    CaloriesText2.Text = x.ToString();
                    CaloriesText3.Text = h.ToString();
                    CaloriesText4.Text = g.ToString();
                    CaloriesText5.Text = f.ToString();
                }
                else if (a >= 2)
                {
                    b = 655 + (9.6 * c) + (1.8 * d) + (4.7 * s);
                    z = b * 1.2;
                    x = b * 1.375;
                    h = b * 1.55;
                    g = b * 1.725;
                    f = b * 1.9;

                    BMR.Text = b.ToString();
                    CaloriesText1.Text = z.ToString();
                    CaloriesText2.Text = x.ToString();
                    CaloriesText3.Text = h.ToString();
                    CaloriesText4.Text = g.ToString();
                    CaloriesText5.Text = f.ToString();
                }
                else
                {
                    MessageBox.Show("Выберете пол");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка в вводе");
            }
           
        }

        private void Male_Click(object sender, EventArgs e)
        {
            a = 1;
        }

        private void Female_Click(object sender, EventArgs e)
        {
            a = 2;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Podrobnanformacia zakaz = new Podrobnanformacia();
            zakaz.Show();
            this.Hide();
        }
    }
}
