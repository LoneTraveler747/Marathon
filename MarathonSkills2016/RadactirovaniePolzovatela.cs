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
    public partial class RadactirovaniePolzovatela : Form
    {
        DateTime DateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public RadactirovaniePolzovatela()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            Timer_of_start.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }
    }
}
