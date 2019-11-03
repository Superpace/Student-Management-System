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
    public partial class OgrGuncelleSil : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-HU9OABO; Initial Catalog = School; Integrated Security = True");
        string imglocation = "";
        byte[] images = null;
        int id;
        public OgrGuncelleSil()
        {
            InitializeComponent();
        }

        private void OgrGuncelleSil_Load(object sender, EventArgs e)
        {
            photo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(idTB.Text);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Students where id = '"+idTB.Text+"'", connection);
            SqlDataReader oku = command.ExecuteReader();
            while (oku.Read())
            {
                isimTB.Text = oku[1].ToString();
                soyisimTB.Text = oku[2].ToString();
                dateTimePicker1.Value = (DateTime) oku[3];
                phoneTB.Text = oku[4].ToString();
                AdresTB.Text = oku[5].ToString();
                
                if (!Convert.IsDBNull(oku[6]))
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])oku[6];
                    MemoryStream mem = new MemoryStream(data);
                    photo.Image = Image.FromStream(mem);
                }
                else
                {
                    photo.Image = Properties.Resources.avatar_default;
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
        public OgrGuncelleSil(int index)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Students where id = '" + index + "'", connection);
            SqlDataReader oku = command.ExecuteReader();
            while (oku.Read())
            {
                idTB.Text = oku[0].ToString();
                isimTB.Text = oku[1].ToString();
                soyisimTB.Text = oku[2].ToString();
                dateTimePicker1.Value = (DateTime)oku[3];
                phoneTB.Text = oku[4].ToString();
                AdresTB.Text = oku[5].ToString();

                if (!Convert.IsDBNull(oku[6]))
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])oku[6];
                    MemoryStream mem = new MemoryStream(data);
                    photo.Image = Image.FromStream(mem);
                }
                else
                {
                    photo.Image = Properties.Resources.avatar_default;
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
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idTB.Text.Equals(""))
            {
                MessageBox.Show("Lütfen id kısmını giriniz!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand komutsil = new SqlCommand("Delete from Students where id = '" + idTB.Text + "'", connection);
                komutsil.ExecuteNonQuery();
                MessageBox.Show("Silme işlemi başarıyla gerçekleşti");
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idTB.Text.Equals("")||isimTB.Text.Equals("") || soyisimTB.Text.Equals("") || (!erkekRB.Checked && !kadinRB.Checked) || phoneTB.Text.Equals("") || AdresTB.Text.Equals(""))
            {
                MessageBox.Show("Boş Alanlar Var !", "!?",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (DateTime.Now.Year - dateTimePicker1.Value.Year > 12)
                {
                    connection.Open();
                    SqlCommand komutguncelle = new SqlCommand("update Students set first_name=@s1,last_name=@s2,birth_date=@s3,phone=@s4,adress=@s5,gender=@s6 where id = '"+id+"'", connection);
                    komutguncelle.Parameters.AddWithValue("@s1", isimTB.Text);
                    komutguncelle.Parameters.AddWithValue("@s2", soyisimTB.Text);
                    komutguncelle.Parameters.AddWithValue("@s3", dateTimePicker1.Value);
                    komutguncelle.Parameters.AddWithValue("@s4", phoneTB.Text);
                    komutguncelle.Parameters.AddWithValue("@s5", AdresTB.Text);
                    
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
                }
                else
                {
                    MessageBox.Show("Öğrenci 12 yaşından büyük olmalı", "DETECT",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            connection.Close();
        }

        private void photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG files(*.png)|*.png|JPG files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                photo.ImageLocation = imglocation;
            }
        }
        private void insertImage()
        {

            FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            images = br.ReadBytes((int)stream.Length);
        }
    }
}
