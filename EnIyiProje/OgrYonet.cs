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
    public partial class OgrYonet : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-HU9OABO; Initial Catalog = School; Integrated Security = True");
        string imglocation = "";
        byte[] images = null;
        DataSet ds = new DataSet();
        public OgrYonet()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void OgrYonet_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'schoolDataSet1.Students' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.studentsTableAdapter1.Fill(this.schoolDataSet1.Students);
            String sql = "SELECT id,first_name,last_name,birth_date,phone,adress,student_image,gender FROM Students";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            connection.Open();
            dataadapter.Fill(ds);
            connection.Close();
            dataGridView.DataSource = ds.Tables[0];
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.dataGridViewImageColumn.DefaultCellStyle.NullValue = Properties.Resources.avatar_default;
            toplamyaz();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG files(*.png)|*.png|JPG files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox.ImageLocation = imglocation;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            idTB.Text = "";
            isimTB.Text = "";
            soyisimTB.Text = "";
            dateTimePicker.Value = DateTime.Now;
            phoneTB.Text = "";
            adresRTB.Text = "";
            pictureBox.Image = Properties.Resources.avatar_default;
            tümünüGöster();
            toplamyaz();
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            Ekle();
            this.studentsTableAdapter1.Fill(this.schoolDataSet1.Students);
            dataGridView.Refresh();
            dataGridView.Update();
        }
        public void Ekle()
        {
            if (isimTB.Text.Equals("") || soyisimTB.Text.Equals("") || (!erkekRB.Checked && !kadinRB.Checked) || phoneTB.Text.Equals("") || adresRTB.Text.Equals(""))
            {
                MessageBox.Show("Boş Alanlar Var !", "!?",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (DateTime.Now.Year - dateTimePicker.Value.Year > 12)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("insert into Students (first_name,last_name,birth_date,gender,phone,adress) values (@s1,@s2,@s3,@s4,@s5,@s6)", connection);
                    command.Parameters.AddWithValue("@s1", isimTB.Text);
                    command.Parameters.AddWithValue("@s2", soyisimTB.Text);
                    command.Parameters.AddWithValue("@s3", dateTimePicker.Value);

                    if (erkekRB.Checked)
                    {
                        command.Parameters.AddWithValue("@s4", "Erkek");
                    }
                    else if (kadinRB.Checked)
                    {
                        command.Parameters.AddWithValue("@s4", "Kadın");
                    }
                    command.Parameters.AddWithValue("@s5", phoneTB.Text);
                    command.Parameters.AddWithValue("@s6", adresRTB.Text);
                    if (!imglocation.Equals(""))
                    {
                        command.CommandText = "insert into Students (first_name,last_name,birth_date,gender,phone,adress,student_image) values (@s1,@s2,@s3,@s4,@s5,@s6,@s7)";
                        insertImage();
                        command.Parameters.AddWithValue("@s7", images);
                    }
                    command.ExecuteNonQuery();

                    MessageBox.Show("KAYIT BAŞARILI", "",
                    MessageBoxButtons.OK);
                    this.studentsTableAdapter1.Fill(this.schoolDataSet1.Students);
                    dataGridView.Update();
                    dataGridView.Refresh();
                    connection.Close();
                    tümünüGöster();
                    toplamyaz();
                }
                else
                {
                    MessageBox.Show("Büyü de gel", "DETECT",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void insertImage()
        {

            FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            images = br.ReadBytes((int)stream.Length);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            Console.WriteLine(index+"");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Students where id = '" + index + "'", connection);
            SqlDataReader oku = command.ExecuteReader();
            while (oku.Read())
            {
                idTB.Text = oku[0].ToString();
                isimTB.Text = oku[1].ToString();
                soyisimTB.Text = oku[2].ToString();
                dateTimePicker.Value = (DateTime)oku[3];
                phoneTB.Text = oku[4].ToString();
                adresRTB.Text = oku[5].ToString();

                if (!Convert.IsDBNull(oku[6]))
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])oku[6];
                    MemoryStream mem = new MemoryStream(data);
                    pictureBox.Image = Image.FromStream(mem);
                }
                else
                {
                    pictureBox.Image = Properties.Resources.avatar_default;
                }
                if (oku[7].ToString().Equals("Erkek"))
                {
                    erkekRB.Checked = true;
                }
                else
                {
                    kadinRB.Checked = true;
                }
            }
            connection.Close();
        }

        private void button_duzenle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTB.Text);
            if (isimTB.Text.Equals("") || soyisimTB.Text.Equals("") || (!erkekRB.Checked && !kadinRB.Checked) || phoneTB.Text.Equals("") || adresRTB.Text.Equals(""))
            {
                MessageBox.Show("Boş Alanlar Var !", "!?",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (DateTime.Now.Year - dateTimePicker.Value.Year > 12)
                {
                    connection.Open();
                    SqlCommand komutguncelle = new SqlCommand("update Students set first_name=@s1,last_name=@s2,birth_date=@s3,phone=@s4,adress=@s5,gender=@s6 where id = '" + id + "'", connection);
                    komutguncelle.Parameters.AddWithValue("@s1", isimTB.Text);
                    komutguncelle.Parameters.AddWithValue("@s2", soyisimTB.Text);
                    komutguncelle.Parameters.AddWithValue("@s3", dateTimePicker.Value);
                    komutguncelle.Parameters.AddWithValue("@s4", phoneTB.Text);
                    komutguncelle.Parameters.AddWithValue("@s5", adresRTB.Text);

                    if (erkekRB.Checked)
                    {
                        komutguncelle.Parameters.AddWithValue("@s6", "Erkek");
                    }
                    else if (kadinRB.Checked)
                    {
                        komutguncelle.Parameters.AddWithValue("@s6", "Kadın");
                    }
                    if (!imglocation.Equals(""))
                    {
                        komutguncelle.CommandText = "update Students set first_name=@s1,last_name=@s2,birth_date=@s3,phone=@s4,adress=@s5,gender=@s6,student_image=@s7 where id = '" + id + "'";
                        insertImage();
                        komutguncelle.Parameters.AddWithValue("@s7", images);
                    }
                    komutguncelle.ExecuteNonQuery();
                    MessageBox.Show("Başarı ile düzenlendi !");
                }
                else
                {
                    MessageBox.Show("Öğrenci 12 yaşından büyük olmalı", "DETECT",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            connection.Close();
            tümünüGöster();
            toplamyaz();
        }

        private void button_indir_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "Kaydet";
            if (idTB.Text.Equals(""))
            {
                saveFileDialog.FileName = "student_image";
            }
            else
            {
                saveFileDialog.FileName = "student_image_"+idTB.Text;
            }
            saveFileDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|All files(*.*)|*.*";
            saveFileDialog.ShowDialog();
            
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox.Image.Save(saveFileDialog.FileName);
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            if (idTB.Text.Equals(""))
            {
                MessageBox.Show("Lütfen silinecek kullanıcıyı seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand komutsil = new SqlCommand("Delete from Students where id = '" + idTB.Text + "'", connection);
                komutsil.ExecuteNonQuery();
                this.studentsTableAdapter1.Fill(this.schoolDataSet1.Students);
                MessageBox.Show("Silme işlemi başarıyla gerçekleşti");
                connection.Close();
                tümünüGöster();
                toplamyaz();
            }
        }

        private void button_ara_Click(object sender, EventArgs e)
        {
            connection.Open();

            string value = searchTB.Text.ToString();
            SqlCommand sqlCommand = new SqlCommand("Select * from Students where first_name like '%" + value + "%' or last_name like '%" + value + "%' or adress like '%" + value + "%'", connection);
            sqlCommand.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView.DataSource = dt;

            connection.Close();
            toplamyaz();

        }
        public void toplamyaz()
        {
            toplamTXT.Text = "TOPLAM OGRENCİ : " + dataGridView.Rows.Count;
        }
        public void tümünüGöster()
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from Students", connection);
            sqlCommand.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView.DataSource = dt;
            connection.Close();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
