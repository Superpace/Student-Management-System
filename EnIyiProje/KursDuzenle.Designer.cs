namespace EnIyiProje
{
    partial class KursDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KursDuzenle));
            this.isimCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kisimTB = new System.Windows.Forms.TextBox();
            this.saatNum = new System.Windows.Forms.NumericUpDown();
            this.detayRTB = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_duzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.saatNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // isimCB
            // 
            this.isimCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isimCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimCB.FormattingEnabled = true;
            this.isimCB.Location = new System.Drawing.Point(193, 75);
            this.isimCB.Name = "isimCB";
            this.isimCB.Size = new System.Drawing.Size(219, 28);
            this.isimCB.TabIndex = 0;
            this.isimCB.SelectedIndexChanged += new System.EventHandler(this.isimCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(36, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Düzenlenecek Kurs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kursun İsmi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kursun Saat Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(63, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Detaylı Bilgi";
            // 
            // kisimTB
            // 
            this.kisimTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kisimTB.Location = new System.Drawing.Point(163, 35);
            this.kisimTB.Name = "kisimTB";
            this.kisimTB.Size = new System.Drawing.Size(208, 26);
            this.kisimTB.TabIndex = 5;
            // 
            // saatNum
            // 
            this.saatNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saatNum.Location = new System.Drawing.Point(163, 80);
            this.saatNum.Name = "saatNum";
            this.saatNum.Size = new System.Drawing.Size(79, 26);
            this.saatNum.TabIndex = 6;
            this.saatNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // detayRTB
            // 
            this.detayRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.detayRTB.Location = new System.Drawing.Point(163, 129);
            this.detayRTB.Name = "detayRTB";
            this.detayRTB.Size = new System.Drawing.Size(208, 163);
            this.detayRTB.TabIndex = 7;
            this.detayRTB.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.detayRTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.saatNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.kisimTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(30, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 313);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button_duzenle
            // 
            this.button_duzenle.Location = new System.Drawing.Point(157, 501);
            this.button_duzenle.Name = "button_duzenle";
            this.button_duzenle.Size = new System.Drawing.Size(129, 60);
            this.button_duzenle.TabIndex = 9;
            this.button_duzenle.Text = "DÜZENLE";
            this.button_duzenle.UseVisualStyleBackColor = true;
            this.button_duzenle.Click += new System.EventHandler(this.button_duzenle_Click);
            // 
            // KursDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(453, 583);
            this.Controls.Add(this.button_duzenle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isimCB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KursDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kursları Düzenle";
            this.Load += new System.EventHandler(this.KursDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saatNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox isimCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kisimTB;
        private System.Windows.Forms.NumericUpDown saatNum;
        private System.Windows.Forms.RichTextBox detayRTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_duzenle;
    }
}