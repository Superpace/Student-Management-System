namespace EnIyiProje
{
    partial class KurslariYonet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KurslariYonet));
            this.label1 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kisimTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saatNumeric = new System.Windows.Forms.NumericUpDown();
            this.detayRTB = new System.Windows.Forms.RichTextBox();
            this.button_x2g = new System.Windows.Forms.Button();
            this.button_g = new System.Windows.Forms.Button();
            this.button_i = new System.Windows.Forms.Button();
            this.button_x2i = new System.Windows.Forms.Button();
            this.button_ekle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_duzenle = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet1 = new EnIyiProje.SchoolDataSet1();
            this.toplamTXT = new System.Windows.Forms.Label();
            this.coursesTableAdapter = new EnIyiProje.SchoolDataSet1TableAdapters.CoursesTableAdapter();
            this.coursesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.saatNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(111, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idTB.Location = new System.Drawing.Point(146, 55);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(54, 26);
            this.idTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(63, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kurs İsmi";
            // 
            // kisimTB
            // 
            this.kisimTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kisimTB.Location = new System.Drawing.Point(146, 99);
            this.kisimTB.Name = "kisimTB";
            this.kisimTB.Size = new System.Drawing.Size(186, 26);
            this.kisimTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(55, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kurs Saati";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Detaylı Açıklama";
            // 
            // saatNumeric
            // 
            this.saatNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saatNumeric.Location = new System.Drawing.Point(146, 144);
            this.saatNumeric.Name = "saatNumeric";
            this.saatNumeric.Size = new System.Drawing.Size(54, 26);
            this.saatNumeric.TabIndex = 7;
            // 
            // detayRTB
            // 
            this.detayRTB.Location = new System.Drawing.Point(143, 191);
            this.detayRTB.Name = "detayRTB";
            this.detayRTB.Size = new System.Drawing.Size(189, 133);
            this.detayRTB.TabIndex = 8;
            this.detayRTB.Text = "";
            // 
            // button_x2g
            // 
            this.button_x2g.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_x2g.Location = new System.Drawing.Point(778, 51);
            this.button_x2g.Name = "button_x2g";
            this.button_x2g.Size = new System.Drawing.Size(71, 46);
            this.button_x2g.TabIndex = 9;
            this.button_x2g.Text = "︽";
            this.button_x2g.UseVisualStyleBackColor = true;
            this.button_x2g.Click += new System.EventHandler(this.button_x2g_Click);
            // 
            // button_g
            // 
            this.button_g.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_g.Location = new System.Drawing.Point(778, 103);
            this.button_g.Name = "button_g";
            this.button_g.Size = new System.Drawing.Size(71, 46);
            this.button_g.TabIndex = 10;
            this.button_g.Text = "︿";
            this.button_g.UseVisualStyleBackColor = true;
            this.button_g.Click += new System.EventHandler(this.button_g_Click);
            // 
            // button_i
            // 
            this.button_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_i.Location = new System.Drawing.Point(778, 282);
            this.button_i.Name = "button_i";
            this.button_i.Size = new System.Drawing.Size(71, 46);
            this.button_i.TabIndex = 11;
            this.button_i.Text = "﹀";
            this.button_i.UseVisualStyleBackColor = true;
            this.button_i.Click += new System.EventHandler(this.button_i_Click);
            // 
            // button_x2i
            // 
            this.button_x2i.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_x2i.Location = new System.Drawing.Point(778, 334);
            this.button_x2i.Name = "button_x2i";
            this.button_x2i.Size = new System.Drawing.Size(71, 46);
            this.button_x2i.TabIndex = 12;
            this.button_x2i.Text = "︾";
            this.button_x2i.UseVisualStyleBackColor = true;
            this.button_x2i.Click += new System.EventHandler(this.button_x2i_Click);
            // 
            // button_ekle
            // 
            this.button_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ekle.Location = new System.Drawing.Point(6, 19);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(75, 42);
            this.button_ekle.TabIndex = 13;
            this.button_ekle.Text = "EKLE";
            this.button_ekle.UseVisualStyleBackColor = false;
            this.button_ekle.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_sil);
            this.groupBox1.Controls.Add(this.button_duzenle);
            this.groupBox1.Controls.Add(this.button_ekle);
            this.groupBox1.Location = new System.Drawing.Point(48, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 74);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // button_sil
            // 
            this.button_sil.BackColor = System.Drawing.Color.Red;
            this.button_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sil.Location = new System.Drawing.Point(203, 19);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(75, 42);
            this.button_sil.TabIndex = 15;
            this.button_sil.Text = "SİL";
            this.button_sil.UseVisualStyleBackColor = false;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_duzenle
            // 
            this.button_duzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_duzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_duzenle.Location = new System.Drawing.Point(104, 19);
            this.button_duzenle.Name = "button_duzenle";
            this.button_duzenle.Size = new System.Drawing.Size(75, 42);
            this.button_duzenle.TabIndex = 14;
            this.button_duzenle.Text = "DÜZENLE";
            this.button_duzenle.UseVisualStyleBackColor = false;
            this.button_duzenle.Click += new System.EventHandler(this.button_duzenle_Click);
            // 
            // listBox
            // 
            this.listBox.DataSource = this.coursesBindingSource1;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(471, 51);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(301, 329);
            this.listBox.TabIndex = 15;
            this.listBox.ValueMember = "kurs_adi";
            this.listBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseClick);
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
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
            // toplamTXT
            // 
            this.toplamTXT.AutoSize = true;
            this.toplamTXT.BackColor = System.Drawing.Color.DimGray;
            this.toplamTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamTXT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toplamTXT.Location = new System.Drawing.Point(589, 383);
            this.toplamTXT.Name = "toplamTXT";
            this.toplamTXT.Size = new System.Drawing.Size(183, 25);
            this.toplamTXT.TabIndex = 16;
            this.toplamTXT.Text = "TOPLAM KURS : 0";
            this.toplamTXT.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // coursesBindingSource1
            // 
            this.coursesBindingSource1.DataMember = "Courses";
            this.coursesBindingSource1.DataSource = this.schoolDataSet1;
            // 
            // KurslariYonet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(866, 476);
            this.Controls.Add(this.toplamTXT);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_x2i);
            this.Controls.Add(this.button_i);
            this.Controls.Add(this.button_g);
            this.Controls.Add(this.button_x2g);
            this.Controls.Add(this.detayRTB);
            this.Controls.Add(this.saatNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kisimTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KurslariYonet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kursları Yönet";
            this.Load += new System.EventHandler(this.KurslariYonet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saatNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kisimTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown saatNumeric;
        private System.Windows.Forms.RichTextBox detayRTB;
        private System.Windows.Forms.Button button_x2g;
        private System.Windows.Forms.Button button_g;
        private System.Windows.Forms.Button button_i;
        private System.Windows.Forms.Button button_x2i;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_duzenle;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label toplamTXT;
        private SchoolDataSet1 schoolDataSet1;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private SchoolDataSet1TableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.BindingSource coursesBindingSource1;
    }
}