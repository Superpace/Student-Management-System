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
    public partial class NotYazdir : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-HU9OABO; Initial Catalog = School; Integrated Security = True");
        int courseid,ogrid;
        public NotYazdir()
        {
            InitializeComponent();
        }

        private void NotYazdir_Load(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.schoolDataSet1.Students);
            this.coursesTableAdapter.Fill(this.schoolDataSet1.Courses);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select Courses.id,kurs_adi from Courses",connection);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (listBox1.GetItemText(listBox1.SelectedItem) == dataTable.Rows[i][1].ToString())
                {
                    courseid = Convert.ToInt32(dataTable.Rows[i][0]);
                    Console.WriteLine(courseid+"");
                }
            }
            SqlCommand commandDataView = new SqlCommand("select Students.id,first_name,last_name,Courses.id as 'kurs_id',kurs_adi,score from Courses,Scores,Students " +
                "where Students.id = Scores.ogr_id and Courses.id = '"+courseid+ "' and Scores.course_id = '" + courseid + "'", connection);
            dataTable = new DataTable();
            adapter = new SqlDataAdapter(commandDataView);
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            connection.Open();
            ogrid = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            SqlCommand commandDataView = new SqlCommand("select Students.id as 'Ogrenci ID',first_name as 'İsim',last_name 'Soyadı',Courses.id as 'Kurs ID',kurs_adi as 'Kurs Adı',score as 'Not' " +
                "from Courses,Scores,Students where Students.id = Scores.ogr_id AND Scores.ogr_id = '" + ogrid + "' and " +
                "Scores.course_id=Courses.id", connection);
            commandDataView.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commandDataView);
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select Students.id as 'Ogrenci ID',first_name as 'İsim',last_name 'Soyadı',Courses.id as 'Kurs ID',kurs_adi as 'Kurs Adı',score as 'Not' " +
                "from Courses,Scores,Students where Students.id = Scores.ogr_id and Scores.course_id = Courses.id", connection);
            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Notlar.txt");
            writer.WriteLine("-------------------------------------------------------------------------------");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
                writer.WriteLine("-------------------------------------------------------------------------------");

            }
            MessageBox.Show("Notlar.txt olarak Belgelerim klasörüne başarıyla kaydedildi");
            writer.Close();
        }

        private void dataGridView2_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

        }
    }
}
