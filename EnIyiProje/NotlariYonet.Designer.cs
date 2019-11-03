namespace EnIyiProje
{
    partial class NotlariYonet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotlariYonet));
            this.aciklamaRTB = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.notTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kursCB = new System.Windows.Forms.ComboBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet1 = new EnIyiProje.SchoolDataSet1();
            this.ogr_idTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ekle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_ort = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_ogrG = new System.Windows.Forms.Button();
            this.button_kursG = new System.Windows.Forms.Button();
            this.coursesTableAdapter = new EnIyiProje.SchoolDataSet1TableAdapters.CoursesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // aciklamaRTB
            // 
            this.aciklamaRTB.Location = new System.Drawing.Point(164, 203);
            this.aciklamaRTB.Name = "aciklamaRTB";
            this.aciklamaRTB.Size = new System.Drawing.Size(194, 131);
            this.aciklamaRTB.TabIndex = 16;
            this.aciklamaRTB.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(78, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Açıklama";
            // 
            // notTB
            // 
            this.notTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notTB.Location = new System.Drawing.Point(165, 154);
            this.notTB.Name = "notTB";
            this.notTB.Size = new System.Drawing.Size(80, 26);
            this.notTB.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(112, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Notu";
            // 
            // kursCB
            // 
            this.kursCB.DataSource = this.coursesBindingSource;
            this.kursCB.DisplayMember = "kurs_adi";
            this.kursCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kursCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kursCB.FormattingEnabled = true;
            this.kursCB.Location = new System.Drawing.Point(165, 108);
            this.kursCB.Name = "kursCB";
            this.kursCB.Size = new System.Drawing.Size(193, 24);
            this.kursCB.TabIndex = 12;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.schoolDataSet1;
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "SchoolDataSet1";
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogr_idTB
            // 
            this.ogr_idTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogr_idTB.Location = new System.Drawing.Point(165, 58);
            this.ogr_idTB.Name = "ogr_idTB";
            this.ogr_idTB.Size = new System.Drawing.Size(81, 26);
            this.ogr_idTB.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(54, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kursu Seçin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(64, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Öğrenci ID";
            // 
            // button_ekle
            // 
            this.button_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ekle.Location = new System.Drawing.Point(160, 355);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(86, 48);
            this.button_ekle.TabIndex = 17;
            this.button_ekle.Text = "Ekle";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_sil
            // 
            this.button_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sil.Location = new System.Drawing.Point(272, 355);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(86, 48);
            this.button_sil.TabIndex = 18;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_ort
            // 
            this.button_ort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ort.Location = new System.Drawing.Point(159, 409);
            this.button_ort.Name = "button_ort";
            this.button_ort.Size = new System.Drawing.Size(199, 48);
            this.button_ort.TabIndex = 19;
            this.button_ort.Text = "NOT ORTALAMALARI";
            this.button_ort.UseVisualStyleBackColor = true;
            this.button_ort.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(404, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(540, 396);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // button_ogrG
            // 
            this.button_ogrG.Location = new System.Drawing.Point(404, 24);
            this.button_ogrG.Name = "button_ogrG";
            this.button_ogrG.Size = new System.Drawing.Size(170, 31);
            this.button_ogrG.TabIndex = 21;
            this.button_ogrG.Text = "Öğrencileri Göster";
            this.button_ogrG.UseVisualStyleBackColor = true;
            this.button_ogrG.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_kursG
            // 
            this.button_kursG.Location = new System.Drawing.Point(774, 24);
            this.button_kursG.Name = "button_kursG";
            this.button_kursG.Size = new System.Drawing.Size(170, 31);
            this.button_kursG.TabIndex = 22;
            this.button_kursG.Text = "Kursları Göster";
            this.button_kursG.UseVisualStyleBackColor = true;
            this.button_kursG.Click += new System.EventHandler(this.button5_Click);
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // NotlariYonet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(968, 523);
            this.Controls.Add(this.button_kursG);
            this.Controls.Add(this.button_ogrG);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_ort);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.aciklamaRTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.notTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kursCB);
            this.Controls.Add(this.ogr_idTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotlariYonet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notları Yönet";
            this.Load += new System.EventHandler(this.NotlariYonet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox aciklamaRTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox notTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox kursCB;
        private System.Windows.Forms.TextBox ogr_idTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_ort;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_ogrG;
        private System.Windows.Forms.Button button_kursG;
        private SchoolDataSet1 schoolDataSet1;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private SchoolDataSet1TableAdapters.CoursesTableAdapter coursesTableAdapter;
    }
}