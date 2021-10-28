
namespace WeAreTheChampions
{
    partial class YeniOyuncuEkle
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
            this.txtOyuncuIsim = new System.Windows.Forms.TextBox();
            this.cboOyuncuEkleTakim = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYeniOyuncuEkle = new System.Windows.Forms.Button();
            this.btnYeniOyuncuEkleIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Isim:";
            // 
            // txtOyuncuIsim
            // 
            this.txtOyuncuIsim.Location = new System.Drawing.Point(10, 32);
            this.txtOyuncuIsim.Name = "txtOyuncuIsim";
            this.txtOyuncuIsim.Size = new System.Drawing.Size(325, 26);
            this.txtOyuncuIsim.TabIndex = 2;
            // 
            // cboOyuncuEkleTakim
            // 
            this.cboOyuncuEkleTakim.FormattingEnabled = true;
            this.cboOyuncuEkleTakim.Location = new System.Drawing.Point(78, 69);
            this.cboOyuncuEkleTakim.Name = "cboOyuncuEkleTakim";
            this.cboOyuncuEkleTakim.Size = new System.Drawing.Size(261, 28);
            this.cboOyuncuEkleTakim.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Takım :";
            // 
            // btnYeniOyuncuEkle
            // 
            this.btnYeniOyuncuEkle.Location = new System.Drawing.Point(10, 103);
            this.btnYeniOyuncuEkle.Name = "btnYeniOyuncuEkle";
            this.btnYeniOyuncuEkle.Size = new System.Drawing.Size(220, 36);
            this.btnYeniOyuncuEkle.TabIndex = 6;
            this.btnYeniOyuncuEkle.Text = "Yeni Oyuncu Ekle";
            this.btnYeniOyuncuEkle.UseVisualStyleBackColor = true;
            this.btnYeniOyuncuEkle.Click += new System.EventHandler(this.btnYeniOyuncuEkle_Click);
            // 
            // btnYeniOyuncuEkleIptal
            // 
            this.btnYeniOyuncuEkleIptal.Location = new System.Drawing.Point(236, 103);
            this.btnYeniOyuncuEkleIptal.Name = "btnYeniOyuncuEkleIptal";
            this.btnYeniOyuncuEkleIptal.Size = new System.Drawing.Size(103, 36);
            this.btnYeniOyuncuEkleIptal.TabIndex = 7;
            this.btnYeniOyuncuEkleIptal.Text = "İptal";
            this.btnYeniOyuncuEkleIptal.UseVisualStyleBackColor = true;
            this.btnYeniOyuncuEkleIptal.Click += new System.EventHandler(this.btnYeniOyuncuEkleIptal_Click);
            // 
            // YeniOyuncuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 146);
            this.Controls.Add(this.btnYeniOyuncuEkleIptal);
            this.Controls.Add(this.btnYeniOyuncuEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboOyuncuEkleTakim);
            this.Controls.Add(this.txtOyuncuIsim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "YeniOyuncuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OyuncuEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOyuncuIsim;
        private System.Windows.Forms.ComboBox cboOyuncuEkleTakim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYeniOyuncuEkle;
        private System.Windows.Forms.Button btnYeniOyuncuEkleIptal;
    }
}