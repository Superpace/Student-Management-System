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
    public partial class KursSil : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-HU9OABO; Initial Catalog = School; Integrated Security = True");
        public KursSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idTB.Text.Equals(""))
            {
                MessageBox.Show("Lütfen id kısmını giriniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand komutsil = new SqlCommand("Delete from Courses where id = '" + idTB.Text + "'", connection);
                komutsil.ExecuteNonQuery();
                MessageBox.Show("Silme işlemi başarıyla gerçekleşti");
                connection.Close();
            }
        }

        private void KursSil_Load(object sender, EventArgs e)
        {

        }
       
    }
}
