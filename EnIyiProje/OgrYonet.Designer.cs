namespace EnIyiProje
{
    partial class OgrYonet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrYonet));
            this.label1 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isimTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.soyisimTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kadinRB = new System.Windows.Forms.RadioButton();
            this.erkekRB = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adresRTB = new System.Windows.Forms.RichTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_yukle = new System.Windows.Forms.Button();
            this.button_indir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.button_ara = new System.Windows.Forms.Button();
            this.button_ekle = new System.Windows.Forms.Button();
            this.button_duzenle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_sifirla = new System.Windows.Forms.Button();
            this.toplamTXT = new System.Windows.Forms.Label();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet1 = new EnIyiProje.SchoolDataSet1();
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.studentsTableAdapter1 = new EnIyiProje.SchoolDataSet1TableAdapters.StudentsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(92, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // idTB
            // 
            this.idTB.Enabled = false;
            this.idTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idTB.Location = new System.Drawing.Point(126, 149);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(89, 26);
            this.idTB.TabIndex = 1;
            this.idTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(78, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "İsim";
            // 
            // isimTB
            // 
            this.isimTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimTB.Location = new System.Drawing.Point(126, 190);
            this.isimTB.Name = "isimTB";
            this.isimTB.Size = new System.Drawing.Size(214, 26);
            this.isimTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(50, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyisim";
            // 
            // soyisimTB
            // 
            this.soyisimTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyisimTB.Location = new System.Drawing.Point(126, 232);
            this.soyisimTB.Name = "soyisimTB";
            this.soyisimTB.Size = new System.Drawing.Size(214, 26);
            this.soyisimTB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(5, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doğum Günü";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker.Location = new System.Drawing.Point(128, 276);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(210, 23);
            this.dateTimePicker.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(48, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cinsiyet";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kadinRB);
            this.groupBox1.Controls.Add(this.erkekRB);
            this.groupBox1.Location = new System.Drawing.Point(129, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 52);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // kadinRB
            // 
            this.kadinRB.AutoSize = true;
            this.kadinRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kadinRB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kadinRB.Location = new System.Drawing.Point(119, 16);
            this.kadinRB.Name = "kadinRB";
            this.kadinRB.Size = new System.Drawing.Size(67, 21);
            this.kadinRB.TabIndex = 1;
            this.kadinRB.TabStop = true;
            this.kadinRB.Text = "Kadın";
            this.kadinRB.UseVisualStyleBackColor = true;
            // 
            // erkekRB
            // 
            this.erkekRB.AutoSize = true;
            this.erkekRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.erkekRB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.erkekRB.Location = new System.Drawing.Point(28, 16);
            this.erkekRB.Name = "erkekRB";
            this.erkekRB.Size = new System.Drawing.Size(67, 21);
            this.erkekRB.TabIndex = 0;
            this.erkekRB.TabStop = true;
            this.erkekRB.Text = "Erkek";
            this.erkekRB.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(51, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefon";
            // 
            // phoneTB
            // 
            this.phoneTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneTB.Location = new System.Drawing.Point(128, 385);
            this.phoneTB.MaxLength = 11;
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(211, 26);
            this.phoneTB.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(64, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Adres";
            // 
            // adresRTB
            // 
            this.adresRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adresRTB.Location = new System.Drawing.Point(129, 435);
            this.adresRTB.MaxLength = 100;
            this.adresRTB.Name = "adresRTB";
            this.adresRTB.Size = new System.Drawing.Size(210, 103);
            this.adresRTB.TabIndex = 13;
            this.adresRTB.Text = "";
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Image = global::EnIyiProje.Properties.Resources.avatar_default;
            this.pictureBox.Location = new System.Drawing.Point(43, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(128, 119);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // button_yukle
            // 
            this.button_yukle.Location = new System.Drawing.Point(182, 12);
            this.button_yukle.Name = "button_yukle";
            this.button_yukle.Size = new System.Drawing.Size(158, 46);
            this.button_yukle.TabIndex = 15;
            this.button_yukle.Text = "YÜKLE";
            this.button_yukle.UseVisualStyleBackColor = true;
            this.button_yukle.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_indir
            // 
            this.button_indir.Location = new System.Drawing.Point(182, 85);
            this.button_indir.Name = "button_indir";
            this.button_indir.Size = new System.Drawing.Size(158, 46);
            this.button_indir.TabIndex = 16;
            this.button_indir.Text = "İNDİR";
            this.button_indir.UseVisualStyleBackColor = true;
            this.button_indir.Click += new System.EventHandler(this.button_indir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(493, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "DEĞERE GÖRE ARA : ";
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchTB.Location = new System.Drawing.Point(698, 20);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(221, 26);
            this.searchTB.TabIndex = 19;
            // 
            // button_ara
            // 
            this.button_ara.Location = new System.Drawing.Point(925, 20);
            this.button_ara.Name = "button_ara";
            this.button_ara.Size = new System.Drawing.Size(93, 26);
            this.button_ara.TabIndex = 20;
            this.button_ara.Text = "ARA";
            this.button_ara.UseVisualStyleBackColor = true;
            this.button_ara.Click += new System.EventHandler(this.button_ara_Click);
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(622, 551);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(95, 38);
            this.button_ekle.TabIndex = 21;
            this.button_ekle.Text = "EKLE";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // button_duzenle
            // 
            this.button_duzenle.Location = new System.Drawing.Point(723, 551);
            this.button_duzenle.Name = "button_duzenle";
            this.button_duzenle.Size = new System.Drawing.Size(95, 38);
            this.button_duzenle.TabIndex = 22;
            this.button_duzenle.Text = "DÜZENLE";
            this.button_duzenle.UseVisualStyleBackColor = true;
            this.button_duzenle.Click += new System.EventHandler(this.button_duzenle_Click);
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(824, 551);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(95, 38);
            this.button_sil.TabIndex = 23;
            this.button_sil.Text = "SİL";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_sifirla
            // 
            this.button_sifirla.Location = new System.Drawing.Point(923, 551);
            this.button_sifirla.Name = "button_sifirla";
            this.button_sifirla.Size = new System.Drawing.Size(95, 38);
            this.button_sifirla.TabIndex = 24;
            this.button_sifirla.Text = "SIFIRLA";
            this.button_sifirla.UseVisualStyleBackColor = true;
            this.button_sifirla.Click += new System.EventHandler(this.button7_Click);
            // 
            // toplamTXT
            // 
            this.toplamTXT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toplamTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamTXT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toplamTXT.Location = new System.Drawing.Point(824, 462);
            this.toplamTXT.Name = "toplamTXT";
            this.toplamTXT.Size = new System.Drawing.Size(194, 48);
            this.toplamTXT.TabIndex = 25;
            this.toplamTXT.Text = "Toplam Sonuç : ";
            this.toplamTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView.DataSource = this.studentsBindingSource2;
            this.dataGridView.Location = new System.Drawing.Point(363, 52);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 100;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(655, 407);
            this.dataGridView.TabIndex = 26;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewImageColumn
            // 
            this.dataGridViewImageColumn.DataPropertyName = "student_image";
            this.dataGridViewImageColumn.HeaderText = "Fotoğraf";
            this.dataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn.Name = "dataGridViewImageColumn";
            this.dataGridViewImageColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "İsim";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Soyisim";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "birth_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Doğum Tarihi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "adress";
            this.dataGridViewTextBoxColumn6.HeaderText = "Adres";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cinsiyet";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // studentsBindingSource2
            // 
            this.studentsBindingSource2.DataMember = "Students";
            this.studentsBindingSource2.DataSource = this.schoolDataSet1;
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "SchoolDataSet1";
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource1
            // 
            this.studentsBindingSource1.DataMember = "Students";
            this.studentsBindingSource1.DataSource = this.schoolDataSet1;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // studentsTableAdapter1
            // 
            this.studentsTableAdapter1.ClearBeforeFill = true;
            // 
            // OgrYonet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1030, 600);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toplamTXT);
            this.Controls.Add(this.button_sifirla);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_duzenle);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.button_ara);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_indir);
            this.Controls.Add(this.button_yukle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.adresRTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.soyisimTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isimTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrYonet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrencileri Yönet";
            this.Load += new System.EventHandler(this.OgrYonet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox isimTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soyisimTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton kadinRB;
        private System.Windows.Forms.RadioButton erkekRB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox adresRTB;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_yukle;
        private System.Windows.Forms.Button button_indir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button button_ara;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.Button button_duzenle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_sifirla;
        private System.Windows.Forms.Label toplamTXT;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private SchoolDataSet1 schoolDataSet1;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
        private SchoolDataSet1TableAdapters.StudentsTableAdapter studentsTableAdapter1;
        private System.Windows.Forms.BindingSource studentsBindingSource2;
    }
}