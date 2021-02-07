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
    public partial class SpisokBlagotvoritelnuxOrg : Form
    {
        string connectionString = @"Data Source=DESKTOP-0KCH38C\CH_A_A;Initial Catalog=Marathon Skills 2016;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        DateTime DateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public SpisokBlagotvoritelnuxOrg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Podrobnanformacia zakaz = new Podrobnanformacia();
            zakaz.Show();
            this.Hide();
        }


        private void SpisokBlagotvoritelnuxOrg_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Charity", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                UserControl1[] user = new UserControl1[ds.Tables[0].Rows.Count];
                for (int i = 0; i < user.Length; i++)
                {
                    user[i] = new UserControl1();
                    user[i].MyProperty = ds.Tables[0].Rows[i][1].ToString();
                    user[i].MyPropert = ds.Tables[0].Rows[i][2].ToString();
                    user[i].MyPropertyy = Bitmap.FromFile(@"C:\Users\Александр\Desktop\учебная практика\2 часть практики\Ресурсы\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\" + ds.Tables[0].Rows[i][3].ToString());
                    flowLayoutPanel1.Controls.Add(user[i]);
                }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            Timer_of_start.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }
    }
}
