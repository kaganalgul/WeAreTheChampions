
namespace WeAreTheChampions
{
    partial class KarsilasmaDuzenlemeEkrani
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
            this.dtpTarihDuzenle = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKarsilasmaDuzenle = new System.Windows.Forms.Button();
            this.cbo2TakimDuzenle = new System.Windows.Forms.ComboBox();
            this.cbo1TakimDuzenle = new System.Windows.Forms.ComboBox();
            this.btnDuzenlemeEkraniIptal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nud1KarsilasmaDuzenle = new System.Windows.Forms.NumericUpDown();
            this.nud2KarsilasmaDuzenle = new System.Windows.Forms.NumericUpDown();
            this.dtpSaatDuzenle = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nud1KarsilasmaDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2KarsilasmaDuzenle)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTarihDuzenle
            // 
            this.dtpTarihDuzenle.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarihDuzenle.Location = new System.Drawing.Point(9, 118);
            this.dtpTarihDuzenle.Name = "dtpTarihDuzenle";
            this.dtpTarihDuzenle.Size = new System.Drawing.Size(176, 26);
            this.dtpTarihDuzenle.TabIndex = 11;
            this.dtpTarihDuzenle.Value = new System.DateTime(2021, 10, 25, 23, 43, 12, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "İkinci Takım :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Birinci Takım :";
            // 
            // btnKarsilasmaDuzenle
            // 
            this.btnKarsilasmaDuzenle.Location = new System.Drawing.Point(8, 150);
            this.btnKarsilasmaDuzenle.Name = "btnKarsilasmaDuzenle";
            this.btnKarsilasmaDuzenle.Size = new System.Drawing.Size(260, 30);
            this.btnKarsilasmaDuzenle.TabIndex = 8;
            this.btnKarsilasmaDuzenle.Text = "Karşılaşmayı Düzenle";
            this.btnKarsilasmaDuzenle.UseVisualStyleBackColor = true;
            this.btnKarsilasmaDuzenle.Click += new System.EventHandler(this.btnKarsilasmaDuzenle_Click);
            // 
            // cbo2TakimDuzenle
            // 
            this.cbo2TakimDuzenle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo2TakimDuzenle.FormattingEnabled = true;
            this.cbo2TakimDuzenle.Location = new System.Drawing.Point(191, 31);
            this.cbo2TakimDuzenle.Name = "cbo2TakimDuzenle";
            this.cbo2TakimDuzenle.Size = new System.Drawing.Size(176, 28);
            this.cbo2TakimDuzenle.TabIndex = 7;
            // 
            // cbo1TakimDuzenle
            // 
            this.cbo1TakimDuzenle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo1TakimDuzenle.FormattingEnabled = true;
            this.cbo1TakimDuzenle.Location = new System.Drawing.Point(9, 31);
            this.cbo1TakimDuzenle.Name = "cbo1TakimDuzenle";
            this.cbo1TakimDuzenle.Size = new System.Drawing.Size(176, 28);
            this.cbo1TakimDuzenle.TabIndex = 6;
            // 
            // btnDuzenlemeEkraniIptal
            // 
            this.btnDuzenlemeEkraniIptal.Location = new System.Drawing.Point(275, 150);
            this.btnDuzenlemeEkraniIptal.Name = "btnDuzenlemeEkraniIptal";
            this.btnDuzenlemeEkraniIptal.Size = new System.Drawing.Size(92, 30);
            this.btnDuzenlemeEkraniIptal.TabIndex = 12;
            this.btnDuzenlemeEkraniIptal.Text = "İptal";
            this.btnDuzenlemeEkraniIptal.UseVisualStyleBackColor = true;
            this.btnDuzenlemeEkraniIptal.Click += new System.EventHandler(this.btnDuzenlemeEkraniIptal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Skor :";
            // 
            // nud1KarsilasmaDuzenle
            // 
            this.nud1KarsilasmaDuzenle.Location = new System.Drawing.Point(9, 86);
            this.nud1KarsilasmaDuzenle.Name = "nud1KarsilasmaDuzenle";
            this.nud1KarsilasmaDuzenle.Size = new System.Drawing.Size(176, 26);
            this.nud1KarsilasmaDuzenle.TabIndex = 16;
            // 
            // nud2KarsilasmaDuzenle
            // 
            this.nud2KarsilasmaDuzenle.Location = new System.Drawing.Point(190, 86);
            this.nud2KarsilasmaDuzenle.Name = "nud2KarsilasmaDuzenle";
            this.nud2KarsilasmaDuzenle.Size = new System.Drawing.Size(176, 26);
            this.nud2KarsilasmaDuzenle.TabIndex = 17;
            // 
            // dtpSaatDuzenle
            // 
            this.dtpSaatDuzenle.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaatDuzenle.Location = new System.Drawing.Point(190, 118);
            this.dtpSaatDuzenle.Name = "dtpSaatDuzenle";
            this.dtpSaatDuzenle.Size = new System.Drawing.Size(176, 26);
            this.dtpSaatDuzenle.TabIndex = 18;
            // 
            // KarsilasmaDuzenlemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 188);
            this.Controls.Add(this.dtpSaatDuzenle);
            this.Controls.Add(this.nud2KarsilasmaDuzenle);
            this.Controls.Add(this.nud1KarsilasmaDuzenle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDuzenlemeEkraniIptal);
            this.Controls.Add(this.dtpTarihDuzenle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKarsilasmaDuzenle);
            this.Controls.Add(this.cbo2TakimDuzenle);
            this.Controls.Add(this.cbo1TakimDuzenle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "KarsilasmaDuzenlemeEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DüzenlemeEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.nud1KarsilasmaDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2KarsilasmaDuzenle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTarihDuzenle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKarsilasmaDuzenle;
        private System.Windows.Forms.ComboBox cbo2TakimDuzenle;
        private System.Windows.Forms.ComboBox cbo1TakimDuzenle;
        private System.Windows.Forms.Button btnDuzenlemeEkraniIptal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud1KarsilasmaDuzenle;
        private System.Windows.Forms.NumericUpDown nud2KarsilasmaDuzenle;
        private System.Windows.Forms.DateTimePicker dtpSaatDuzenle;
    }
}