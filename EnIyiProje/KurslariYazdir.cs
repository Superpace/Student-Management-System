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
using System.IO;

namespace EnIyiProje
{
    public partial class KurslariYazdir : Form
    {
        //Belgelerime kayıt
        string dbFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Courses.txt";
        public KurslariYazdir()
        {
            InitializeComponent();
        }
        private void writeFileFromDB(string dbFile)
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = new SqlConnection(@"Data Source = DESKTOP-HU9OABO; Initial Catalog = School; Integrated Security = True");
            String sql = @"SELECT id, kurs_adi,kurs_saati,detayli_bilgi FROM Courses";
            comm.CommandText = sql;
            comm.Connection.Open();
            SqlDataReader sqlReader = comm.ExecuteReader();
            using (StreamWriter file = new StreamWriter(dbFile, false))
            {
                file.WriteLine("id" + " / " +"kurs_adi" + " / " + "kurs_saati" + " / " + "detayli_bilgi\n");
                while (sqlReader.Read())
                {
                    file.WriteLine(sqlReader["id"] + "\t" + "||" + "\t" + sqlReader["kurs_adi"] + "\t" + "||" + "\t" + sqlReader["kurs_saati"] + "\t" + "||" + "\t" +  sqlReader["detayli_bilgi"]);
                    file.WriteLine("--------------------------------------------------------------------");
                }
            }

            sqlReader.Close();
            comm.Connection.Close();
        }

        private void KurslariYazdir_Load(object sender, EventArgs e)
        {
            this.coursesTableAdapter.Fill(this.schoolDataSet1.Courses);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeFileFromDB(dbFile);
            MessageBox.Show("Courses.txt olarak Belgelerim klasörüne başarıyla kaydedildi");
        }
    }
}
