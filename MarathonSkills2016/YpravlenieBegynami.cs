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
    public partial class YpravlenieBegynami : Form
    {
        string connectionString = @"Data Source=DESKTOP-0KCH38C\CH_A_A;Initial Catalog=Marathon Skills 2016;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        DateTime DateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);

        public YpravlenieBegynami()
        {
            InitializeComponent();
        }

        public void LoadSotrudniks()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT [dbo].[User].[RoleId], Email, FirstName, LastName FROM [dbo].[User]", connection);
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

        public void LoadDoljnost1()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM [dbo].[User]", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                StatusText.DataSource = ds.Tables[0];
                StatusText.DisplayMember = "RoleId";
                StatusText.ValueMember = "RoleId";
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

        public void LoadDoljnost2()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM [dbo].[User]", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                DistanceText.DataSource = ds.Tables[0];
                DistanceText.DisplayMember = "Email";
                DistanceText.ValueMember = "Email";
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

        public void LoadDoljnost3()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM [dbo].[User]", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                SortText.DataSource = ds.Tables[0];
                SortText.DisplayMember = "FirstName";
                SortText.ValueMember = "FirstName";
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
            MenuKoordinacii zakaz = new MenuKoordinacii();
            zakaz.Show();
            this.Hide();
        }

        private void YpravlenieBegynami_Load(object sender, EventArgs e)
        {
            LoadSotrudniks();
            LoadDoljnost1();
            LoadDoljnost2();
            LoadDoljnost3();
        }

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            Timer_of_start.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }
    }
}
