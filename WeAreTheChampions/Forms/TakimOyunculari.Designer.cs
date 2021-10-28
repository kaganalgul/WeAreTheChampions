
namespace WeAreTheChampions
{
    partial class TakimOyunculari
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
            this.dgvTakimOyunculari = new System.Windows.Forms.DataGridView();
            this.btnTakimaOyuncuEkle = new System.Windows.Forms.Button();
            this.lblTakim = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTakimdanOyuncuSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakimOyunculari)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Takımının Oyuncuları :";
            // 
            // dgvTakimOyunculari
            // 
            this.dgvTakimOyunculari.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTakimOyunculari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakimOyunculari.Location = new System.Drawing.Point(12, 52);
            this.dgvTakimOyunculari.Name = "dgvTakimOyunculari";
            this.dgvTakimOyunculari.Size = new System.Drawing.Size(381, 359);
            this.dgvTakimOyunculari.TabIndex = 1;
            // 
            // btnTakimaOyuncuEkle
            // 
            this.btnTakimaOyuncuEkle.Location = new System.Drawing.Point(399, 87);
            this.btnTakimaOyuncuEkle.Name = "btnTakimaOyuncuEkle";
            this.btnTakimaOyuncuEkle.Size = new System.Drawing.Size(271, 28);
            this.btnTakimaOyuncuEkle.TabIndex = 2;
            this.btnTakimaOyuncuEkle.Text = "Takıma Oyuncu Ekle";
            this.btnTakimaOyuncuEkle.UseVisualStyleBackColor = true;
            // 
            // lblTakim
            // 
            this.lblTakim.AutoSize = true;
            this.lblTakim.Location = new System.Drawing.Point(8, 9);
            this.lblTakim.Name = "lblTakim";
            this.lblTakim.Size = new System.Drawing.Size(82, 20);
            this.lblTakim.TabIndex = 3;
            this.lblTakim.Text = "TakımAdı";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(399, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Oyuncu Seç :";
            // 
            // btnTakimdanOyuncuSil
            // 
            this.btnTakimdanOyuncuSil.Location = new System.Drawing.Point(399, 121);
            this.btnTakimdanOyuncuSil.Name = "btnTakimdanOyuncuSil";
            this.btnTakimdanOyuncuSil.Size = new System.Drawing.Size(271, 28);
            this.btnTakimdanOyuncuSil.TabIndex = 6;
            this.btnTakimdanOyuncuSil.Text = "Oyuncuyu Takımdan Sil";
            this.btnTakimdanOyuncuSil.UseVisualStyleBackColor = true;
            // 
            // TakimOyunculari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 423);
            this.Controls.Add(this.btnTakimdanOyuncuSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTakim);
            this.Controls.Add(this.btnTakimaOyuncuEkle);
            this.Controls.Add(this.dgvTakimOyunculari);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TakimOyunculari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TakimOyunculari";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakimOyunculari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTakimOyunculari;
        private System.Windows.Forms.Button btnTakimaOyuncuEkle;
        private System.Windows.Forms.Label lblTakim;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTakimdanOyuncuSil;
    }
}