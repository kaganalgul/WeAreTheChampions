
namespace WeAreTheChampions
{
    partial class YeniKarsilasmaEkle
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
            this.cbo1TakimEkle = new System.Windows.Forms.ComboBox();
            this.cbo2TakimEkle = new System.Windows.Forms.ComboBox();
            this.btnYeniKarsilasmaEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpKarsilasmaEkleTarih = new System.Windows.Forms.DateTimePicker();
            this.btnYeniKarsilasmaEkleIptal = new System.Windows.Forms.Button();
            this.dtpKarsilasmaEkleSaat = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbo1TakimEkle
            // 
            this.cbo1TakimEkle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo1TakimEkle.FormattingEnabled = true;
            this.cbo1TakimEkle.Location = new System.Drawing.Point(9, 31);
            this.cbo1TakimEkle.Name = "cbo1TakimEkle";
            this.cbo1TakimEkle.Size = new System.Drawing.Size(176, 28);
            this.cbo1TakimEkle.TabIndex = 0;
            // 
            // cbo2TakimEkle
            // 
            this.cbo2TakimEkle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo2TakimEkle.FormattingEnabled = true;
            this.cbo2TakimEkle.Location = new System.Drawing.Point(191, 31);
            this.cbo2TakimEkle.Name = "cbo2TakimEkle";
            this.cbo2TakimEkle.Size = new System.Drawing.Size(176, 28);
            this.cbo2TakimEkle.TabIndex = 1;
            // 
            // btnYeniKarsilasmaEkle
            // 
            this.btnYeniKarsilasmaEkle.Location = new System.Drawing.Point(9, 97);
            this.btnYeniKarsilasmaEkle.Name = "btnYeniKarsilasmaEkle";
            this.btnYeniKarsilasmaEkle.Size = new System.Drawing.Size(260, 30);
            this.btnYeniKarsilasmaEkle.TabIndex = 2;
            this.btnYeniKarsilasmaEkle.Text = "Yeni Karşılaşma Ekle";
            this.btnYeniKarsilasmaEkle.UseVisualStyleBackColor = true;
            this.btnYeniKarsilasmaEkle.Click += new System.EventHandler(this.btnYeniKarsilasmaEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Birinci Takım :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "İkinci Takım :";
            // 
            // dtpKarsilasmaEkleTarih
            // 
            this.dtpKarsilasmaEkleTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKarsilasmaEkleTarih.Location = new System.Drawing.Point(9, 65);
            this.dtpKarsilasmaEkleTarih.Name = "dtpKarsilasmaEkleTarih";
            this.dtpKarsilasmaEkleTarih.Size = new System.Drawing.Size(176, 26);
            this.dtpKarsilasmaEkleTarih.TabIndex = 5;
            // 
            // btnYeniKarsilasmaEkleIptal
            // 
            this.btnYeniKarsilasmaEkleIptal.Location = new System.Drawing.Point(275, 97);
            this.btnYeniKarsilasmaEkleIptal.Name = "btnYeniKarsilasmaEkleIptal";
            this.btnYeniKarsilasmaEkleIptal.Size = new System.Drawing.Size(92, 30);
            this.btnYeniKarsilasmaEkleIptal.TabIndex = 6;
            this.btnYeniKarsilasmaEkleIptal.Text = "İptal";
            this.btnYeniKarsilasmaEkleIptal.UseVisualStyleBackColor = true;
            this.btnYeniKarsilasmaEkleIptal.Click += new System.EventHandler(this.btnYeniKarsilasmaEkleIptal_Click);
            // 
            // dtpKarsilasmaEkleSaat
            // 
            this.dtpKarsilasmaEkleSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpKarsilasmaEkleSaat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpKarsilasmaEkleSaat.Location = new System.Drawing.Point(191, 65);
            this.dtpKarsilasmaEkleSaat.Name = "dtpKarsilasmaEkleSaat";
            this.dtpKarsilasmaEkleSaat.Size = new System.Drawing.Size(176, 26);
            this.dtpKarsilasmaEkleSaat.TabIndex = 12;
            // 
            // YeniKarsilasmaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 136);
            this.Controls.Add(this.dtpKarsilasmaEkleSaat);
            this.Controls.Add(this.btnYeniKarsilasmaEkleIptal);
            this.Controls.Add(this.dtpKarsilasmaEkleTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYeniKarsilasmaEkle);
            this.Controls.Add(this.cbo2TakimEkle);
            this.Controls.Add(this.cbo1TakimEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "YeniKarsilasmaEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KarsilasmaEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo1TakimEkle;
        private System.Windows.Forms.ComboBox cbo2TakimEkle;
        private System.Windows.Forms.Button btnYeniKarsilasmaEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpKarsilasmaEkleTarih;
        private System.Windows.Forms.Button btnYeniKarsilasmaEkleIptal;
        private System.Windows.Forms.DateTimePicker dtpKarsilasmaEkleSaat;
    }
}