namespace EnIyiProje
{
    partial class KurslariYazdir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KurslariYazdir));
            this.schoolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kursadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kurssaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaylibilgiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.schoolDataSet1 = new EnIyiProje.SchoolDataSet1();
            this.coursesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new EnIyiProje.SchoolDataSet1TableAdapters.CoursesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kursadiDataGridViewTextBoxColumn,
            this.kurssaatiDataGridViewTextBoxColumn,
            this.detaylibilgiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coursesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(571, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 314.7208F;
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 55;
            // 
            // kursadiDataGridViewTextBoxColumn
            // 
            this.kursadiDataGridViewTextBoxColumn.DataPropertyName = "kurs_adi";
            this.kursadiDataGridViewTextBoxColumn.FillWeight = 28.42639F;
            this.kursadiDataGridViewTextBoxColumn.HeaderText = "KURS ADI";
            this.kursadiDataGridViewTextBoxColumn.Name = "kursadiDataGridViewTextBoxColumn";
            this.kursadiDataGridViewTextBoxColumn.ReadOnly = true;
            this.kursadiDataGridViewTextBoxColumn.Width = 150;
            // 
            // kurssaatiDataGridViewTextBoxColumn
            // 
            this.kurssaatiDataGridViewTextBoxColumn.DataPropertyName = "kurs_saati";
            this.kurssaatiDataGridViewTextBoxColumn.FillWeight = 28.42639F;
            this.kurssaatiDataGridViewTextBoxColumn.HeaderText = "KURS SAATİ";
            this.kurssaatiDataGridViewTextBoxColumn.Name = "kurssaatiDataGridViewTextBoxColumn";
            this.kurssaatiDataGridViewTextBoxColumn.ReadOnly = true;
            this.kurssaatiDataGridViewTextBoxColumn.Width = 70;
            // 
            // detaylibilgiDataGridViewTextBoxColumn
            // 
            this.detaylibilgiDataGridViewTextBoxColumn.DataPropertyName = "detayli_bilgi";
            this.detaylibilgiDataGridViewTextBoxColumn.FillWeight = 28.42639F;
            this.detaylibilgiDataGridViewTextBoxColumn.HeaderText = "DETAYLI BİLGİ";
            this.detaylibilgiDataGridViewTextBoxColumn.Name = "detaylibilgiDataGridViewTextBoxColumn";
            this.detaylibilgiDataGridViewTextBoxColumn.ReadOnly = true;
            this.detaylibilgiDataGridViewTextBoxColumn.Width = 250;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.schoolBindingSource;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(571, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "TXT FORMATINDA KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "SchoolDataSet1";
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource1
            // 
            this.coursesBindingSource1.DataMember = "Courses";
            this.coursesBindingSource1.DataSource = this.schoolDataSet1;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // KurslariYazdir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(595, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KurslariYazdir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kursları Yazdır";
            this.Load += new System.EventHandler(this.KurslariYazdir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource schoolDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource schoolBindingSource;
        private System.Windows.Forms.BindingSource schoolDataSetBindingSource1;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kursadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kurssaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaylibilgiDataGridViewTextBoxColumn;
        private SchoolDataSet1 schoolDataSet1;
        private System.Windows.Forms.BindingSource coursesBindingSource1;
        private SchoolDataSet1TableAdapters.CoursesTableAdapter coursesTableAdapter;
    }
}