
namespace WeAreTheChampions.Forms
{
    partial class RengiDuzenle
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
            this.txtRenkAdiDuzenle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYesilDuzenle = new System.Windows.Forms.TextBox();
            this.txtMaviDuzenle = new System.Windows.Forms.TextBox();
            this.txtKirmiziDuzenle = new System.Windows.Forms.TextBox();
            this.btnRengiDuzenle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRenkAdiDuzenle
            // 
            this.txtRenkAdiDuzenle.Location = new System.Drawing.Point(108, 107);
            this.txtRenkAdiDuzenle.Name = "txtRenkAdiDuzenle";
            this.txtRenkAdiDuzenle.Size = new System.Drawing.Size(100, 26);
            this.txtRenkAdiDuzenle.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Renk Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mavi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Yeşil :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kırmızı :";
            // 
            // txtYesilDuzenle
            // 
            this.txtYesilDuzenle.Location = new System.Drawing.Point(108, 44);
            this.txtYesilDuzenle.Name = "txtYesilDuzenle";
            this.txtYesilDuzenle.Size = new System.Drawing.Size(100, 26);
            this.txtYesilDuzenle.TabIndex = 14;
            // 
            // txtMaviDuzenle
            // 
            this.txtMaviDuzenle.Location = new System.Drawing.Point(108, 76);
            this.txtMaviDuzenle.Name = "txtMaviDuzenle";
            this.txtMaviDuzenle.Size = new System.Drawing.Size(100, 26);
            this.txtMaviDuzenle.TabIndex = 13;
            // 
            // txtKirmiziDuzenle
            // 
            this.txtKirmiziDuzenle.Location = new System.Drawing.Point(108, 12);
            this.txtKirmiziDuzenle.Name = "txtKirmiziDuzenle";
            this.txtKirmiziDuzenle.Size = new System.Drawing.Size(100, 26);
            this.txtKirmiziDuzenle.TabIndex = 12;
            // 
            // btnRengiDuzenle
            // 
            this.btnRengiDuzenle.Location = new System.Drawing.Point(12, 142);
            this.btnRengiDuzenle.Name = "btnRengiDuzenle";
            this.btnRengiDuzenle.Size = new System.Drawing.Size(196, 31);
            this.btnRengiDuzenle.TabIndex = 20;
            this.btnRengiDuzenle.Text = "Rengi Düzenle";
            this.btnRengiDuzenle.UseVisualStyleBackColor = true;
            this.btnRengiDuzenle.Click += new System.EventHandler(this.btnRengiDuzenle_Click);
            // 
            // RengiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 194);
            this.Controls.Add(this.btnRengiDuzenle);
            this.Controls.Add(this.txtRenkAdiDuzenle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYesilDuzenle);
            this.Controls.Add(this.txtMaviDuzenle);
            this.Controls.Add(this.txtKirmiziDuzenle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RengiDuzenle";
            this.Text = "RengiDuzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRenkAdiDuzenle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYesilDuzenle;
        private System.Windows.Forms.TextBox txtMaviDuzenle;
        private System.Windows.Forms.TextBox txtKirmiziDuzenle;
        private System.Windows.Forms.Button btnRengiDuzenle;
    }
}