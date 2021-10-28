
namespace WeAreTheChampions
{
    partial class OyuncuDuzenle
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
            this.btnYeniOyuncuEkleIptal = new System.Windows.Forms.Button();
            this.btnOyuncuDuzenleOnay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboOyuncuDuzenleTakim = new System.Windows.Forms.ComboBox();
            this.txtOyuncuDuzenleIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYeniOyuncuEkleIptal
            // 
            this.btnYeniOyuncuEkleIptal.Location = new System.Drawing.Point(236, 100);
            this.btnYeniOyuncuEkleIptal.Name = "btnYeniOyuncuEkleIptal";
            this.btnYeniOyuncuEkleIptal.Size = new System.Drawing.Size(103, 36);
            this.btnYeniOyuncuEkleIptal.TabIndex = 15;
            this.btnYeniOyuncuEkleIptal.Text = "İptal";
            this.btnYeniOyuncuEkleIptal.UseVisualStyleBackColor = true;
            this.btnYeniOyuncuEkleIptal.Click += new System.EventHandler(this.btnYeniOyuncuEkleIptal_Click);
            // 
            // btnOyuncuDuzenleOnay
            // 
            this.btnOyuncuDuzenleOnay.Location = new System.Drawing.Point(10, 100);
            this.btnOyuncuDuzenleOnay.Name = "btnOyuncuDuzenleOnay";
            this.btnOyuncuDuzenleOnay.Size = new System.Drawing.Size(220, 36);
            this.btnOyuncuDuzenleOnay.TabIndex = 14;
            this.btnOyuncuDuzenleOnay.Text = "Oyuncu Düzenle";
            this.btnOyuncuDuzenleOnay.UseVisualStyleBackColor = true;
            this.btnOyuncuDuzenleOnay.Click += new System.EventHandler(this.btnOyuncuDuzenleOnay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Takım :";
            // 
            // cboOyuncuDuzenleTakim
            // 
            this.cboOyuncuDuzenleTakim.FormattingEnabled = true;
            this.cboOyuncuDuzenleTakim.Location = new System.Drawing.Point(78, 66);
            this.cboOyuncuDuzenleTakim.Name = "cboOyuncuDuzenleTakim";
            this.cboOyuncuDuzenleTakim.Size = new System.Drawing.Size(261, 28);
            this.cboOyuncuDuzenleTakim.TabIndex = 12;
            // 
            // txtOyuncuDuzenleIsim
            // 
            this.txtOyuncuDuzenleIsim.Location = new System.Drawing.Point(10, 29);
            this.txtOyuncuDuzenleIsim.Name = "txtOyuncuDuzenleIsim";
            this.txtOyuncuDuzenleIsim.Size = new System.Drawing.Size(329, 26);
            this.txtOyuncuDuzenleIsim.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "İsim :";
            // 
            // OyuncuDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 145);
            this.Controls.Add(this.btnYeniOyuncuEkleIptal);
            this.Controls.Add(this.btnOyuncuDuzenleOnay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboOyuncuDuzenleTakim);
            this.Controls.Add(this.txtOyuncuDuzenleIsim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "OyuncuDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OyuncuDuzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeniOyuncuEkleIptal;
        private System.Windows.Forms.Button btnOyuncuDuzenleOnay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboOyuncuDuzenleTakim;
        private System.Windows.Forms.TextBox txtOyuncuDuzenleIsim;
        private System.Windows.Forms.Label label1;
    }
}