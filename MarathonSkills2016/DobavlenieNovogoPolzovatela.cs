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
    public partial class DobavlenieNovogoPolzovatela : Form
    {
        string connectionString = @"Data Source=DESKTOP-0KCH38C\CH_A_A;Initial Catalog=Marathon Skills 2016;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        DateTime DateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);

        public void LoadDoljnost1()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM [dbo].[User]", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                RoleText.DataSource = ds.Tables[0];
                RoleText.DisplayMember = "RoleId";
                RoleText.ValueMember = "RoleId";
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

        public DobavlenieNovogoPolzovatela()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            YpravleniePolzovatelami zakaz = new YpravleniePolzovatelami();
            zakaz.Show();
            this.Hide();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                cmd = new SqlCommand($"INSERT INTO [dbo].[User] (Email, FirstName,  LastName, RoleId, master_ID) VALUES ('{textBox1.Text}','{NameText.Text}','{SurnameText.Text}','{RoleText.SelectedValue}','{PasswordText.Text}')", connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            YpravleniePolzovatelami zakaz = new YpravleniePolzovatelami();
            zakaz.Show();
            this.Hide();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            YpravleniePolzovatelami zakaz = new YpravleniePolzovatelami();
            zakaz.Show();
            this.Hide();
        }

        private void DobavlenieNovogoPolzovatela_Load(object sender, EventArgs e)
        {
            LoadDoljnost1();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            Timer_of_start.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }
    }
    
}
