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

namespace EnIyiProje
{
    public partial class KursEkle : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-HU9OABO; Initial Catalog = School; Integrated Security = True");
        public KursEkle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KursEkle_Load(object sender, EventArgs e)
        {

        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            if (kisimTB.Text.Equals("") || detayRTB.Text.Equals("") || saatNumeric.Value == 0)
            {
                MessageBox.Show("Doldurmadığınız Alanlar Var !", "!?",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into Courses (kurs_adi,kurs_saati,detayli_bilgi) values (@s1,@s2,@s3)", connection);
                command.Parameters.AddWithValue("@s1", kisimTB.Text);
                command.Parameters.AddWithValue("@s2", saatNumeric.Value);
                command.Parameters.AddWithValue("@s3", detayRTB.Text);
                command.ExecuteNonQuery();

                MessageBox.Show("KAYIT BAŞARILI", "",
                MessageBoxButtons.OK);
                connection.Close();
            }
        }
    }
}
