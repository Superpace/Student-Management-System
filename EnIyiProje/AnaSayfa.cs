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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void kurslarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void öĞRENCİEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrEkle ogrform = new OgrEkle();
            ogrform.ShowDialog();
        }

        private void öĞRENCİLİSTESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrListele ogrform = new OgrListele();
            ogrform.ShowDialog();
        }

        private void iSTATİSTİKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrIstatistik ogrform = new OgrIstatistik();
            ogrform.ShowDialog();
        }

        private void dÜZENLESİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrGuncelleSil ogrform = new OgrGuncelleSil();
            ogrform.ShowDialog();
        }

        private void yÖNETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrYonet ogrform = new OgrYonet();
            ogrform.ShowDialog();
        }

        private void yAZDIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrPrint ogrform = new OgrPrint();
            ogrform.ShowDialog();
        }

        private void öğrencilerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kURSEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KursEkle ogrform = new KursEkle();
            ogrform.ShowDialog();
        }

        private void kURSSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KursSil ogrform = new KursSil();
            ogrform.ShowDialog();
        }

        private void kURSDÜZENLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KursDuzenle ogrform = new KursDuzenle();
            ogrform.ShowDialog();
        }

        private void kURSLARIYÖNETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KurslariYonet ogrform = new KurslariYonet();
            ogrform.ShowDialog();
        }

        private void yAZDIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KurslariYazdir ogrform = new KurslariYazdir();
            ogrform.ShowDialog();
        }

        private void nOTEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotEkle ogrform = new NotEkle();
            ogrform.ShowDialog();
        }

        private void nOTSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotuSil ogrform = new NotuSil();
            ogrform.ShowDialog();
        }

        private void nOTLARIYÖNETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotlariYonet ogrform = new NotlariYonet();
            ogrform.ShowDialog();
        }

        private void kURSLARINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotOrt ogrform = new NotOrt();
            ogrform.ShowDialog();
        }

        private void yAZDIRToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NotYazdir ogrform = new NotYazdir();
            ogrform.ShowDialog();
        }
    }
}
