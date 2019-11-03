using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace EnIyiProje
{
    public partial class GirisEkrani : Form
    {
        AnaSayfa anaSayfa = new AnaSayfa();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();

        public GirisEkrani()
        {
            InitializeComponent();
            connection.ConnectionString = "Data Source=DESKTOP-HU9OABO;Initial Catalog=School;Integrated Security=True";
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select * from Giris";
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                if(usernameTB.Text.Equals(dr["username"]) && passwordTB.Text.Equals(dr["pass"]))
                {
                    connection.Close();
                    this.Hide();
                    //MessageBox.Show("Giriş Başarılı");
                    anaSayfa.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Şifre veya Kullanıcı Adı");
                    usernameTB.Clear();
                    passwordTB.Clear();
                }
            }
            connection.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
        }
    }
}
