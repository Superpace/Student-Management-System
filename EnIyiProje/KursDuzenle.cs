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
using System.IO;



namespace EnIyiProje
{
    public partial class KursDuzenle : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-HU9OABO; Initial Catalog = School; Integrated Security = True");
         

        public KursDuzenle()
        {
            InitializeComponent();
        }

        private void KursDuzenle_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select kurs_adi from Courses ", connection);
            SqlDataReader oku = command.ExecuteReader();
            while (oku.Read())
            {
                isimCB.Items.Add(oku[0].ToString());
            }
            connection.Close();
            oku.Close();
        }

        private void isimCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select kurs_adi,kurs_saati,detayli_bilgi from Courses where kurs_adi='"+isimCB.SelectedItem.ToString()+"'", connection);
            SqlDataReader oku = command.ExecuteReader();
            while (oku.Read())
            {
                kisimTB.Text = oku[0].ToString();
                saatNum.Value = Convert.ToInt32(oku[1].ToString());
                detayRTB.Text = oku[2].ToString();
            }
            connection.Close();
        }

        private void button_duzenle_Click(object sender, EventArgs e)
        {
            if(kisimTB.Text==""|| saatNum.Value == 0 || detayRTB.Text == "")
            {
                MessageBox.Show("Boş Alanlar Var !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { 
            string isim = isimCB.SelectedItem.ToString();
            connection.Open();
            SqlCommand command = new SqlCommand("update Courses set kurs_adi=@s1,kurs_saati=@s2,detayli_bilgi=@s3 where kurs_adi = '" + isim + "'", connection);
            command.Parameters.AddWithValue("@s1", kisimTB.Text);
            command.Parameters.AddWithValue("@s2", saatNum.Value);
            command.Parameters.AddWithValue("@s3", detayRTB.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Düzenleme işlemi başarıyla gerçekleşti");
            connection.Close();
            }
        }
    }
}
