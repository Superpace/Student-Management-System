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
    public partial class OgrEkle : Form
    {
        string imglocation = "";
        byte[] images = null;
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-HU9OABO; Initial Catalog = School; Integrated Security = True");
        public OgrEkle()
        {
            InitializeComponent();
        }

        private void OgrEkle_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        public void Ekle()
        {
            if (nameTB.Text.Equals("") || soyadiTB.Text.Equals("") || (!erkekRB.Checked && !kadinRB.Checked) || phoneTB.Text.Equals("") || adressTB.Text.Equals(""))
            {
                MessageBox.Show("Boş Alanlar Var !", "!?",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (DateTime.Now.Year - dateTimePicker1.Value.Year > 12)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("insert into Students (first_name,last_name,birth_date,gender,phone,adress) values (@s1,@s2,@s3,@s4,@s5,@s6)", connection);
                    command.Parameters.AddWithValue("@s1", nameTB.Text);
                    command.Parameters.AddWithValue("@s2", soyadiTB.Text);
                    command.Parameters.AddWithValue("@s3", dateTimePicker1.Value);

                    if (erkekRB.Checked)
                    {
                        command.Parameters.AddWithValue("@s4", "Erkek");
                    }
                    else if (kadinRB.Checked)
                    {
                        command.Parameters.AddWithValue("@s4", "Kadın");
                    }
                    command.Parameters.AddWithValue("@s5", phoneTB.Text);
                    command.Parameters.AddWithValue("@s6", adressTB.Text);
                    if (!imglocation.Equals(""))
                    {
                        command.CommandText = "insert into Students (first_name,last_name,birth_date,gender,phone,adress,student_image) values (@s1,@s2,@s3,@s4,@s5,@s6,@s7)";
                        insertImage();
                        command.Parameters.AddWithValue("@s7", images);
                    }
                    command.ExecuteNonQuery();

                    MessageBox.Show("KAYIT BAŞARILI", "",
                    MessageBoxButtons.OK);
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Büyü de gel", "DETECT",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG files(*.png)|*.png|JPG files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();

                Console.WriteLine(imglocation);
                pictureBox1.ImageLocation = imglocation;
            }
        }
        public void insertImage()
        {
            
            FileStream stream = new FileStream(imglocation,FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            images = br.ReadBytes((int)stream.Length);
        }

        private void kadinRB_CheckedChanged(object sender, EventArgs e)
        {

        }
        
    }
}
