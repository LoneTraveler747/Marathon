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
    public partial class YpravlenieVolonterami : Form
    {
        string connectionString = @"Data Source=DESKTOP-0KCH38C\CH_A_A;Initial Catalog=Marathon Skills 2016;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        DateTime DateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);

        public YpravlenieVolonterami()
        {
            InitializeComponent();
        }

        public void LoadSotrudniks()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT [dbo].[Volunteer].[VolunteerId], FirstName, LastName, CountryCode, Gender FROM [dbo].[Volunteer]", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
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
            MenuAdministracii zakaz = new MenuAdministracii();
            zakaz.Show();
            this.Hide();
        }

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void Loading_Click(object sender, EventArgs e)
        {
            ZagryzkaVolonturov zakaz = new ZagryzkaVolonturov();
            zakaz.Show();
            this.Hide();
        }

        private void YpravlenieVolonterami_Load(object sender, EventArgs e)
        {
            LoadSotrudniks();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            Timer_of_start.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }
    }
}
