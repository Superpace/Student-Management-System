using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnIyiProje
{
    public partial class OgrListele : Form
    {
        public OgrListele()
        {
            InitializeComponent();
        }

        private void OgrListele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'schoolDataSet1.Students' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.studentsTableAdapter.Fill(this.schoolDataSet1.Students);
            
            this.dataGridViewImageColumn1.DefaultCellStyle.NullValue = Properties.Resources.avatar_default;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.schoolDataSet1.Students);
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            OgrGuncelleSil ogrform = new OgrGuncelleSil(index);
            ogrform.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
