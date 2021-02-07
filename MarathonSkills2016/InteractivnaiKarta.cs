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
    public partial class InteractivnaiKarta : Form
    {
        public InteractivnaiKarta()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Стойка организаторов");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Бег на 5км");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Бег на 21км");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Бег на 42км");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Стойка с энергетическими батончиками");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Медицинский пункт");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Туалет");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Туалет");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Стойка с напитками");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            InformaciaMarafona zakaz = new InformaciaMarafona();
            zakaz.Show();
            this.Hide();
        }
    }
}
