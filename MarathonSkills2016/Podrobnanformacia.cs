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
    public partial class Podrobnanformacia : Form
    {
        DateTime DateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public Podrobnanformacia()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 zakaz = new Form1();
            zakaz.Show();
            this.Hide();
        }

        private void Marathon_Click(object sender, EventArgs e)
        {
            InformaciaMarafona zakaz = new InformaciaMarafona();
            zakaz.Show();
            this.Hide();
        }

        private void Time_Click(object sender, EventArgs e)
        {
            NaskolkoDolgiMarafon zakaz = new NaskolkoDolgiMarafon();
            zakaz.Show();
            this.Hide();
        }

        private void Rezult_Click(object sender, EventArgs e)
        {
            RezyltatiPredudychixGonok zakaz = new RezyltatiPredudychixGonok();
            zakaz.Show();
            this.Hide();
        }

        private void List_Click(object sender, EventArgs e)
        {
            SpisokBlagotvoritelnuxOrg zakaz = new SpisokBlagotvoritelnuxOrg();
            zakaz.Show();
            this.Hide();
        }

        private void BMI_Click(object sender, EventArgs e)
        {
            BMIKalkylitor zakaz = new BMIKalkylitor();
            zakaz.Show();
            this.Hide();
        }

        private void BMR_Click(object sender, EventArgs e)
        {
            BMRKalkylator zakaz = new BMRKalkylator();
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
