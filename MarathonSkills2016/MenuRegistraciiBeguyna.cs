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
    public partial class MenuRegistraciiBeguyna : Form
    {
        string connectionString = @"Data Source=DESKTOP-0KCH38C\CH_A_A;Initial Catalog=Marathon Skills 2016;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        DateTime DateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);

        public MenuRegistraciiBeguyna()
        {
            InitializeComponent();
        }

        public void LoadDoljnost1()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM [dbo].[Gender]", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                GenderText.DataSource = ds.Tables[0];
                GenderText.DisplayMember = "Gender";
                GenderText.ValueMember = "Gender";
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
                dataAdapter = new SqlDataAdapter("SELECT * FROM [dbo].[Country]", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                CountryText.DataSource = ds.Tables[0];
                CountryText.DisplayMember = "CountryName";
                CountryText.ValueMember = "CountryName";
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
            ProvercaDannix zakaz = new ProvercaDannix();
            zakaz.Show();
            this.Hide();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            if(EmailText.Text == "" && PasswordText.Text == PasswordText2.Text && NameText.Text == "" && SurnameText.Text == "")
            {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand($"INSERT INTO [dbo].[User] (Email, Password, FirstName, LastName, RoleId) VALUES ('{EmailText.Text}','{PasswordText.Text}','{NameText.Text}','{SurnameText.Text}','{label1.Text}')", connection);
                    cmd.ExecuteNonQuery();
                    MenuBegyna zakaz = new MenuBegyna();
                    zakaz.Show();
                    this.Hide();
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
            else
            {
                MessageBox.Show("Ошибка");
            }
           
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ProvercaDannix zakaz = new ProvercaDannix();
            zakaz.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            Timer_of_start.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void MenuRegistraciiBeguyna_Load(object sender, EventArgs e)
        {
            LoadDoljnost1();
            LoadDoljnost2();
        }
    }
}
