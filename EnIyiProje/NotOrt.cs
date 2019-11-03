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
    public partial class NotOrt : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-HU9OABO; Initial Catalog = School; Integrated Security = True");

        public NotOrt()
        {
            InitializeComponent();
        }

        private void NotOrt_Load(object sender, EventArgs e)
        {
            
            connection.Open();
            SqlCommand command = new SqlCommand("select kurs_adi as 'Kurs Adı',AVG(score) as 'Ortalama' from Courses,Scores  where Courses.id = Scores.course_id  group by kurs_adi", connection);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }
    }
}
