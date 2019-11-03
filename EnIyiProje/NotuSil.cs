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
    public partial class NotuSil : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-HU9OABO; Initial Catalog = School; Integrated Security = True");
        int? indexOgr,indexCourse;

        public NotuSil()
        {
            InitializeComponent();
        }

        private void NotuSil_Load(object sender, EventArgs e)
        {
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
            if (indexOgr != null)
            {
                connection.Open();
                SqlCommand komutsil = new SqlCommand("Delete from Scores where ogr_id = '" + indexOgr + "' and course_id = '"+indexCourse+"'", connection);
                komutsil.ExecuteNonQuery();
                MessageBox.Show("Silme işlemi başarıyla gerçekleşti");
                connection.Close();
                NotuSil_Load(null, null);
            }
            else
            {
                MessageBox.Show("Lütfen ilk sütundan silmek istediğiniz notu seçiniz!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexOgr = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            indexCourse = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            Console.WriteLine(indexOgr + "");
            Console.WriteLine(indexCourse + "");
            
        }
    }
}
