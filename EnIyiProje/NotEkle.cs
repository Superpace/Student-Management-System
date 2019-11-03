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
    public partial class NotEkle : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-HU9OABO; Initial Catalog = School; Integrated Security = True");
        int courseid;
        public NotEkle()
        {
            InitializeComponent();
        }

        private void NotEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'schoolDataSet1.Courses' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.coursesTableAdapter.Fill(this.schoolDataSet1.Courses);
            // TODO: Bu kod satırı 'schoolDataSet1.Students' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.studentsTableAdapter.Fill(this.schoolDataSet1.Students);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ogr_idTB.Text.Equals("") || notTB.Text.Equals("") || aciklamaRTB.Text.Equals("") || string.IsNullOrEmpty(kursCB.Text))
            {
                MessageBox.Show("Boş Alanlar Var !", "!?",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                connection.Open();
                SqlCommand command = new SqlCommand("insert into Scores (ogr_id,score,course_id,aciklama) values (@s1,@s2,@s3,@s4)", connection);
                SqlCommand commandGetID = new SqlCommand("select * from Courses where kurs_adi='" + kursCB.Text + "'", connection);
                SqlDataReader oku = commandGetID.ExecuteReader();

                while (oku.Read())
                {
                    Console.WriteLine(oku[0].ToString());
                    courseid = Convert.ToInt32(oku[0].ToString());
                }

                command.Parameters.AddWithValue("@s1", Convert.ToInt32(ogr_idTB.Text));
                command.Parameters.AddWithValue("@s2", Convert.ToInt32(notTB.Text));
                command.Parameters.AddWithValue("@s3", courseid);
                command.Parameters.AddWithValue("@s4", aciklamaRTB.Text);
                oku.Close();
                commandGetID.ExecuteNonQuery();
                command.ExecuteNonQuery();


                MessageBox.Show("KAYIT BAŞARILI");
                connection.Close();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Console.WriteLine(index + "");
            ogr_idTB.Text = index + "";
        }
    }
}
