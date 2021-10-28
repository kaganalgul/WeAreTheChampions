
namespace WeAreTheChampions
{
    partial class TakimDuzenle
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
            this.btnYeniTakimEkleIptal = new System.Windows.Forms.Button();
            this.cboTakimRenkDuzenle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTakimDuzenle = new System.Windows.Forms.Button();
            this.txtTakimIsmiDuzenle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYeniTakimEkleIptal
            // 
            this.btnYeniTakimEkleIptal.Location = new System.Drawing.Point(231, 114);
            this.btnYeniTakimEkleIptal.Name = "btnYeniTakimEkleIptal";
            this.btnYeniTakimEkleIptal.Size = new System.Drawing.Size(117, 30);
            this.btnYeniTakimEkleIptal.TabIndex = 11;
            this.btnYeniTakimEkleIptal.Text = "İptal";
            this.btnYeniTakimEkleIptal.UseVisualStyleBackColor = true;
            // 
            // cboTakimRenkDuzenle
            // 
            this.cboTakimRenkDuzenle.FormattingEnabled = true;
            this.cboTakimRenkDuzenle.Location = new System.Drawing.Point(12, 80);
            this.cboTakimRenkDuzenle.Name = "cboTakimRenkDuzenle";
            this.cboTakimRenkDuzenle.Size = new System.Drawing.Size(336, 28);
            this.cboTakimRenkDuzenle.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Takım Rengi :";
            // 
            // btnTakimDuzenle
            // 
            this.btnTakimDuzenle.Location = new System.Drawing.Point(12, 114);
            this.btnTakimDuzenle.Name = "btnTakimDuzenle";
            this.btnTakimDuzenle.Size = new System.Drawing.Size(213, 30);
            this.btnTakimDuzenle.TabIndex = 8;
            this.btnTakimDuzenle.Text = "Takımı Düzenle";
            this.btnTakimDuzenle.UseVisualStyleBackColor = true;
            // 
            // txtTakimIsmiDuzenle
            // 
            this.txtTakimIsmiDuzenle.Location = new System.Drawing.Point(12, 28);
            this.txtTakimIsmiDuzenle.Name = "txtTakimIsmiDuzenle";
            this.txtTakimIsmiDuzenle.Size = new System.Drawing.Size(336, 26);
            this.txtTakimIsmiDuzenle.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Takım İsmi :";
            // 
            // TakimDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 151);
            this.Controls.Add(this.btnYeniTakimEkleIptal);
            this.Controls.Add(this.cboTakimRenkDuzenle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTakimDuzenle);
            this.Controls.Add(this.txtTakimIsmiDuzenle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "TakimDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TakimDuzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeniTakimEkleIptal;
        private System.Windows.Forms.ComboBox cboTakimRenkDuzenle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTakimDuzenle;
        private System.Windows.Forms.TextBox txtTakimIsmiDuzenle;
        private System.Windows.Forms.Label label1;
    }
}