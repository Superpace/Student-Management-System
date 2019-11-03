namespace EnIyiProje
{
    partial class KursEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KursEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kisimTB = new System.Windows.Forms.TextBox();
            this.saatNumeric = new System.Windows.Forms.NumericUpDown();
            this.detayRTB = new System.Windows.Forms.RichTextBox();
            this.button_ekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.saatNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurs İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(42, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saat Sayısı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(42, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detaylı Bilgi";
            // 
            // kisimTB
            // 
            this.kisimTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kisimTB.Location = new System.Drawing.Point(152, 95);
            this.kisimTB.Name = "kisimTB";
            this.kisimTB.Size = new System.Drawing.Size(210, 26);
            this.kisimTB.TabIndex = 3;
            // 
            // saatNumeric
            // 
            this.saatNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saatNumeric.Location = new System.Drawing.Point(152, 148);
            this.saatNumeric.Name = "saatNumeric";
            this.saatNumeric.Size = new System.Drawing.Size(62, 26);
            this.saatNumeric.TabIndex = 4;
            this.saatNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // detayRTB
            // 
            this.detayRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.detayRTB.Location = new System.Drawing.Point(152, 205);
            this.detayRTB.Name = "detayRTB";
            this.detayRTB.Size = new System.Drawing.Size(210, 162);
            this.detayRTB.TabIndex = 5;
            this.detayRTB.Text = "";
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(163, 393);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(114, 49);
            this.button_ekle.TabIndex = 6;
            this.button_ekle.Text = "EKLE";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // KursEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(448, 466);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.detayRTB);
            this.Controls.Add(this.saatNumeric);
            this.Controls.Add(this.kisimTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KursEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurs Ekle";
            this.Load += new System.EventHandler(this.KursEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saatNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kisimTB;
        private System.Windows.Forms.NumericUpDown saatNumeric;
        private System.Windows.Forms.RichTextBox detayRTB;
        private System.Windows.Forms.Button button_ekle;
    }
}