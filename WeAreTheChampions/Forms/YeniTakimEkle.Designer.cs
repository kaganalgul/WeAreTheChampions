
namespace WeAreTheChampions
{
    partial class YeniTakimEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTakimIsmi = new System.Windows.Forms.TextBox();
            this.btnYeniTakimEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYeniTakimEkleIptal = new System.Windows.Forms.Button();
            this.chkListRenkler = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Takım İsmi :";
            // 
            // txtTakimIsmi
            // 
            this.txtTakimIsmi.Location = new System.Drawing.Point(17, 32);
            this.txtTakimIsmi.Name = "txtTakimIsmi";
            this.txtTakimIsmi.Size = new System.Drawing.Size(336, 26);
            this.txtTakimIsmi.TabIndex = 1;
            // 
            // btnYeniTakimEkle
            // 
            this.btnYeniTakimEkle.Location = new System.Drawing.Point(17, 348);
            this.btnYeniTakimEkle.Name = "btnYeniTakimEkle";
            this.btnYeniTakimEkle.Size = new System.Drawing.Size(213, 30);
            this.btnYeniTakimEkle.TabIndex = 2;
            this.btnYeniTakimEkle.Text = "Yeni Takım Ekle";
            this.btnYeniTakimEkle.UseVisualStyleBackColor = true;
            this.btnYeniTakimEkle.Click += new System.EventHandler(this.btnYeniTakimEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Takım Rengi :";
            // 
            // btnYeniTakimEkleIptal
            // 
            this.btnYeniTakimEkleIptal.Location = new System.Drawing.Point(236, 348);
            this.btnYeniTakimEkleIptal.Name = "btnYeniTakimEkleIptal";
            this.btnYeniTakimEkleIptal.Size = new System.Drawing.Size(117, 30);
            this.btnYeniTakimEkleIptal.TabIndex = 5;
            this.btnYeniTakimEkleIptal.Text = "İptal";
            this.btnYeniTakimEkleIptal.UseVisualStyleBackColor = true;
            this.btnYeniTakimEkleIptal.Click += new System.EventHandler(this.btnYeniTakimEkleIptal_Click);
            // 
            // chkListRenkler
            // 
            this.chkListRenkler.FormattingEnabled = true;
            this.chkListRenkler.Location = new System.Drawing.Point(18, 103);
            this.chkListRenkler.Name = "chkListRenkler";
            this.chkListRenkler.Size = new System.Drawing.Size(335, 235);
            this.chkListRenkler.TabIndex = 8;
            // 
            // YeniTakimEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 393);
            this.Controls.Add(this.chkListRenkler);
            this.Controls.Add(this.btnYeniTakimEkleIptal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnYeniTakimEkle);
            this.Controls.Add(this.txtTakimIsmi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "YeniTakimEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YeniTakimEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTakimIsmi;
        private System.Windows.Forms.Button btnYeniTakimEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYeniTakimEkleIptal;
        private System.Windows.Forms.CheckedListBox chkListRenkler;
    }
}