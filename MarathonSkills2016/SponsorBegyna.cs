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
    public partial class SponsorBegyna : Form
    {
        string connectionString = @"Data Source=DESKTOP-0KCH38C\CH_A_A;Initial Catalog=Marathon Skills 2016;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        DateTime DateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        int a;
        
        public SponsorBegyna()
        {
            InitializeComponent();
        }

        public void LoadDoljnost1()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM [dbo].[User]", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                RunnerText.DataSource = ds.Tables[0];
                RunnerText.DisplayMember = "LastName";
                RunnerText.ValueMember = "LastName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 zakaz = new Form1();
            zakaz.Show();
            this.Hide();
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(SponsorMoney.Text);
            if (a>0 && NameText.Text != "" && RunnerText.Text != "" && MapText.Text != "" && CardNumberText.Text != "")
            {
                PodtverjenieSponssorstva zakaz = new PodtverjenieSponssorstva();
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
            Form1 zakaz = new Form1();
            zakaz.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            Timer_of_start.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void SponsorBegyna_Load(object sender, EventArgs e)
        {
            LoadDoljnost1();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(SponsorMoney.Text);
            a = a - 10;
            SponsorMoney.Text = a.ToString();
            Money.Text = a.ToString();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(SponsorMoney.Text);
            a = a + 10;
            SponsorMoney.Text = a.ToString();
            Money.Text = a.ToString();
        }
    }
}
