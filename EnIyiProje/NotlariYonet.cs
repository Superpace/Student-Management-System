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
    public partial class NotlariYonet : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-HU9OABO; Initial Catalog = School; Integrated Security = True");
        int courseid;
        int? indexOgr, indexCourse;
        bool ogrenciAcik;
        public NotlariYonet()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NotOrt ortObje = new NotOrt();
            ortObje.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ogrenciAcik = true;
            connection.Open();
            SqlCommand command = new SqlCommand("select id,first_name,last_name,birth_date from Students", connection);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ogrenciAcik = false;
            connection.Open();
            SqlCommand command = new SqlCommand("select Students.id,first_name,last_name,Courses.id as 'kurs_id',kurs_adi,score from Courses,Scores,Students " +
                "where Students.id = Scores.ogr_id and Courses.id = Scores.course_id", connection);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            //////////////////////////////////////////////////

            SqlCommand commandEsitlik = new SqlCommand("select Students.id,Courses.id as 'kurs_id',score,kurs_adi from Courses,Scores,Students " +
                "where Students.id = Scores.ogr_id and Courses.id = Scores.course_id", connection);
            commandEsitlik.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commandEsitlik);
            adapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (ogr_idTB.Text == dt.Rows[i][0].ToString() && kursCB.Text == dt.Rows[i][3].ToString())
                {
                    MessageBox.Show("Bu not mevcut !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            ///////////////////////////////////////////////////

            if (ogr_idTB.Text.Equals("") || notTB.Text.Equals("") || aciklamaRTB.Text.Equals("") || string.IsNullOrEmpty(kursCB.Text))
            {
                MessageBox.Show("Boş Alanlar Var !", "!?",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
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
            }
            connection.Close();
        }

        private void NotlariYonet_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'schoolDataSet1.Courses' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.coursesTableAdapter.Fill(this.schoolDataSet1.Courses);

        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand commandCourseIndex = new SqlCommand("select Students.id,Courses.id,kurs_adi from Courses,Scores,Students " +
                "where Students.id = Scores.ogr_id and Courses.id = Scores.course_id", connection);
            commandCourseIndex.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commandCourseIndex);
            adapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (kursCB.Text == dt.Rows[i][2].ToString())
                {
                    indexCourse = Convert.ToInt32(dt.Rows[i][1].ToString());
                }
            }
            if (!ogr_idTB.Text.Equals("")) { 
                indexOgr = Convert.ToInt32(ogr_idTB.Text.ToString());
                SqlCommand komutsil = new SqlCommand("Delete from Scores where ogr_id = '" + indexOgr + "' and course_id = '" + indexCourse + "'", connection);
                komutsil.ExecuteNonQuery();
                MessageBox.Show("Silme işlemi başarıyla gerçekleşti");
                
        }
            
            else {
                MessageBox.Show("Lütfen silmek istediğiniz notu seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ogr_idTB.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (!ogrenciAcik)
            {
                kursCB.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                indexCourse = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            Console.WriteLine(indexOgr + "");
        }

    }
}