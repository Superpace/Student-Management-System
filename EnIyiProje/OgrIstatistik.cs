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
    public partial class OgrIstatistik : Form
    {
        int erkekCount, kadinCount;
        SqlConnection connection = new SqlConnection();
        public OgrIstatistik()
        {
            InitializeComponent();
            connection.ConnectionString = "Data Source=DESKTOP-HU9OABO;Initial Catalog=School;Integrated Security=True";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'schoolDataSet1.Students' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.studentsTableAdapter.Fill(this.schoolDataSet1.Students);
            connection.Open();
            chart1.Series[0]["PieLabelStyle"] = "Disabled";
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart1.ChartAreas[0].Area3DStyle.Inclination = 25;
            // TODO: Bu kod satırı 'schoolDataSet.Students' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            SqlCommand commandE = new SqlCommand("Select count(gender) from Students where gender='Erkek'", connection);
            SqlDataReader reader = commandE.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString());
                erkekCount = Convert.ToInt32(reader[0].ToString());
            }
            reader.Close();
            SqlCommand commandK = new SqlCommand("Select count(gender) from Students where gender='Kadın'", connection);
            reader = commandK.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString());
                kadinCount = Convert.ToInt32(reader[0].ToString());
            }
            chart1.Series["s1"].Points.AddXY("Erkek : "+erkekCount, erkekCount);
            chart1.Series["s1"].Points.AddXY("Kadın : "+kadinCount , kadinCount);
            labelTotal.Text = "Toplam Öğrenci Sayısı = " + (erkekCount + kadinCount);

        }



        private void ogrencilerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void chart_Click(object sender, EventArgs e)
        {

        }
    }
}
