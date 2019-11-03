using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnIyiProje
{
    public partial class OgrPrint : Form
    {
        DataSet ds = new DataSet();
        DataView dv;
        public OgrPrint()
        {
            InitializeComponent();
        }

        private void OgrPrint_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'schoolDataSet1.Students' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.studentsTableAdapter.Fill(this.schoolDataSet1.Students);
            //////////////////////////////////////////////
            SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-HU9OABO; Initial Catalog = School; Integrated Security = True");
            String sql = "SELECT id,first_name,last_name,birth_date,phone,adress,student_image,gender FROM Students";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            connection.Open();
            dataadapter.Fill(ds);
            connection.Close();
            dataGridView1.DataSource = ds.Tables[0];
            ///////////////////////////////////////////
            this.dataGridViewImageColumn1.DefaultCellStyle.NullValue = Properties.Resources.avatar_default;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void writeFileFromDGW()
        {
            TextWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Ogrenciler.txt");
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j == 1)
                    {
                        continue;
                    }
                    writer.Write("\t"+dataGridView1.Rows[i].Cells[j].Value.ToString()+"\t"+"|");
                }
                writer.WriteLine("");
                writer.WriteLine("-------------------------------------------------------------------------------");
            }
            writer.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (erkekRB.Checked)
            {
                dv = new DataView(ds.Tables[0], "gender = 'Erkek' ", "gender Desc", DataViewRowState.CurrentRows);
                dataGridView1.DataSource = dv;
            }
            else if (kadinRB.Checked)
            {
                dv = new DataView(ds.Tables[0], "gender = 'Kadın' ", "gender Desc", DataViewRowState.CurrentRows);
                dataGridView1.DataSource = dv;
            }
            else if (hepsiRB.Checked)
            {
                dv = new DataView(ds.Tables[0]);
                dataGridView1.DataSource = dv;
            }
            if (olurRB.Checked)
            {
                DateTime start = dateTimePicker1.Value.Date;
                DateTime end = dateTimePicker2.Value.Date;
                dv = new DataView(ds.Tables[0], "birth_date>='" + start + "' AND birth_date <= '" + end + "'", "birth_date Desc", DataViewRowState.CurrentRows);
                if (erkekRB.Checked)
                {
                    dv = new DataView(ds.Tables[0], "gender = 'Erkek' AND birth_date>='" + start + "' AND birth_date <= '" + end + "'", "birth_date Desc", DataViewRowState.CurrentRows);
                }
                else if (kadinRB.Checked)
                {
                    dv = new DataView(ds.Tables[0], "gender = 'Kadın' AND birth_date>='" + start + "' AND birth_date <= '" + end + "'", "birth_date Desc", DataViewRowState.CurrentRows);
                }
                else if (hepsiRB.Checked)
                {
                    dv = new DataView(ds.Tables[0], "birth_date>='" + start + "' AND birth_date <= '" + end + "'", "birth_date Desc", DataViewRowState.CurrentRows);
                }

                dataGridView1.DataSource = dv;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeFileFromDGW();
            MessageBox.Show("Ogrenciler.txt Belgelerime kaydedildi");
        }

        private void olurRB_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void kalsinRB_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
