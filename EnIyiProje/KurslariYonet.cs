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
    public partial class KurslariYonet : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public KurslariYonet()
        {
            InitializeComponent();
        }

        private void KurslariYonet_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'schoolDataSet1.Courses' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.coursesTableAdapter.Fill(this.schoolDataSet1.Courses);
            connection.ConnectionString = "Data Source=DESKTOP-HU9OABO;Initial Catalog=School;Integrated Security=True";
            toplamyaz();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if (kisimTB.Text.Equals(listBox.GetItemText(listBox.Items[i])))
                {
                    MessageBox.Show("Bu isme sahip bir kurs var");
                    return;
                }
            }
            
                if (detayRTB.Text.Equals("") || saatNumeric.Value == 0)
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

                    MessageBox.Show("KAYIT BAŞARILI");
                    connection.Close();
                    this.coursesTableAdapter.Fill(this.schoolDataSet1.Courses);
                    listBox.Refresh();
                    listBox.Update();
                    toplamyaz();
                }
        }
        private void button_duzenle_Click(object sender, EventArgs e)
        {
            if (kisimTB.Text.Equals("")||detayRTB.Text.Equals("") || saatNumeric.Value == 0)
            {
                MessageBox.Show("Doldurmadığınız Alanlar Var !", "!?",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string id = idTB.Text.ToString();
                connection.Open();
                SqlCommand command = new SqlCommand("update Courses set kurs_adi=@s1,kurs_saati=@s2,detayli_bilgi=@s3 where id = '" + id + "'", connection);
                command.Parameters.AddWithValue("@s1", kisimTB.Text);
                command.Parameters.AddWithValue("@s2", saatNumeric.Value);
                command.Parameters.AddWithValue("@s3", detayRTB.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Düzenleme işlemi başarıyla gerçekleşti");
                connection.Close();
                this.coursesTableAdapter.Fill(this.schoolDataSet1.Courses);
                listBox.Refresh();
                listBox.Update();
                toplamyaz();
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kursadi = listBox.GetItemText(listBox.SelectedItem);

            connection.Open();
            SqlCommand command = new SqlCommand("select * from Courses where kurs_adi = '" + kursadi + "'", connection);
            SqlDataReader oku = command.ExecuteReader();
            while (oku.Read())
            {
                idTB.Text = oku[0].ToString();
                kisimTB.Text = oku[1].ToString();
                saatNumeric.Value = Convert.ToInt32(oku[2].ToString());
                detayRTB.Text = oku[3].ToString();
            }
            connection.Close();
        }

        private void listBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        private void button_i_Click(object sender, EventArgs e)
        {
            
            if (listBox.SelectedIndex+1== listBox.Items.Count) listBox.SelectedIndex = 0;
            else listBox.SelectedIndex = listBox.SelectedIndex + 1;
        }

        private void button_g_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex - 1 == -1) listBox.SelectedIndex = listBox.Items.Count - 1;
            else listBox.SelectedIndex = listBox.SelectedIndex - 1;
        }

        private void button_x2i_Click(object sender, EventArgs e)
        {
            listBox.SelectedIndex = listBox.Items.Count-1;
        }

        private void button_x2g_Click(object sender, EventArgs e)
        {
            listBox.SelectedIndex = 0;

        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            if (idTB.Text.Equals(""))
            {
                MessageBox.Show("Lütfen silmek istediğiniz kursu seçiniz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand komutsil = new SqlCommand("Delete from Courses where id = '" + idTB.Text + "'", connection);
                komutsil.ExecuteNonQuery();
                MessageBox.Show("Silme işlemi başarıyla gerçekleşti");
                connection.Close();
                this.coursesTableAdapter.Fill(this.schoolDataSet1.Courses);
                listBox.Refresh();
                listBox.Update();
                toplamyaz();
            }
        }
        public void toplamyaz()
        {
            toplamTXT.Text = "TOPLAM KURS : " + listBox.Items.Count;
        }
    }
}
