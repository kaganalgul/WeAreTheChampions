
namespace WeAreTheChampions
{
    partial class Home
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.takimlar = new System.Windows.Forms.TabPage();
            this.btnSeciliyiSil = new System.Windows.Forms.Button();
            this.btnKarsilasmaEkraniAc = new System.Windows.Forms.Button();
            this.btnDuzenlemeEkraniAc = new System.Windows.Forms.Button();
            this.dgvKarsilasmalar = new System.Windows.Forms.DataGridView();
            this.renkler = new System.Windows.Forms.TabPage();
            this.btnRengiDuzenleEkraniAc = new System.Windows.Forms.Button();
            this.btnRengiSil = new System.Windows.Forms.Button();
            this.txtRenkAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvRenkler = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYesil = new System.Windows.Forms.TextBox();
            this.txtMavi = new System.Windows.Forms.TextBox();
            this.txtKirmizi = new System.Windows.Forms.TextBox();
            this.btnRenkEkle = new System.Windows.Forms.Button();
            this.oyuncular = new System.Windows.Forms.TabPage();
            this.btnOyuncuDuzenle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboOyuncuListeleTakim = new System.Windows.Forms.ComboBox();
            this.btnOyuncuSil = new System.Windows.Forms.Button();
            this.btnOyuncuEklemeEkraniAc = new System.Windows.Forms.Button();
            this.dgvOyuncular = new System.Windows.Forms.DataGridView();
            this.tabTakimlar = new System.Windows.Forms.TabPage();
            this.btnTakimOyunculari = new System.Windows.Forms.Button();
            this.btnTakimDuzenleEkraniAc = new System.Windows.Forms.Button();
            this.btnYeniTakimEklemeEkraniAc = new System.Windows.Forms.Button();
            this.dgvTakimlar = new System.Windows.Forms.DataGridView();
            this.btnTakimSil = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.takimlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarsilasmalar)).BeginInit();
            this.renkler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenkler)).BeginInit();
            this.oyuncular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyuncular)).BeginInit();
            this.tabTakimlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakimlar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.takimlar);
            this.tabControl1.Controls.Add(this.renkler);
            this.tabControl1.Controls.Add(this.oyuncular);
            this.tabControl1.Controls.Add(this.tabTakimlar);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // takimlar
            // 
            this.takimlar.Controls.Add(this.btnSeciliyiSil);
            this.takimlar.Controls.Add(this.btnKarsilasmaEkraniAc);
            this.takimlar.Controls.Add(this.btnDuzenlemeEkraniAc);
            this.takimlar.Controls.Add(this.dgvKarsilasmalar);
            this.takimlar.Location = new System.Drawing.Point(4, 29);
            this.takimlar.Name = "takimlar";
            this.takimlar.Padding = new System.Windows.Forms.Padding(3);
            this.takimlar.Size = new System.Drawing.Size(849, 450);
            this.takimlar.TabIndex = 0;
            this.takimlar.Text = "Karşılaşmalar";
            this.takimlar.UseVisualStyleBackColor = true;
            // 
            // btnSeciliyiSil
            // 
            this.btnSeciliyiSil.Location = new System.Drawing.Point(175, 385);
            this.btnSeciliyiSil.Name = "btnSeciliyiSil";
            this.btnSeciliyiSil.Size = new System.Drawing.Size(166, 59);
            this.btnSeciliyiSil.TabIndex = 3;
            this.btnSeciliyiSil.Text = "Seçiliyi Sil";
            this.btnSeciliyiSil.UseVisualStyleBackColor = true;
            this.btnSeciliyiSil.Click += new System.EventHandler(this.btnSeciliyiSil_Click);
            // 
            // btnKarsilasmaEkraniAc
            // 
            this.btnKarsilasmaEkraniAc.Location = new System.Drawing.Point(347, 385);
            this.btnKarsilasmaEkraniAc.Name = "btnKarsilasmaEkraniAc";
            this.btnKarsilasmaEkraniAc.Size = new System.Drawing.Size(188, 59);
            this.btnKarsilasmaEkraniAc.TabIndex = 2;
            this.btnKarsilasmaEkraniAc.Text = "Yeni Karşılaşma Ekle";
            this.btnKarsilasmaEkraniAc.UseVisualStyleBackColor = true;
            this.btnKarsilasmaEkraniAc.Click += new System.EventHandler(this.btnKarsilasmaEkraniAc_Click);
            // 
            // btnDuzenlemeEkraniAc
            // 
            this.btnDuzenlemeEkraniAc.Location = new System.Drawing.Point(6, 385);
            this.btnDuzenlemeEkraniAc.Name = "btnDuzenlemeEkraniAc";
            this.btnDuzenlemeEkraniAc.Size = new System.Drawing.Size(163, 60);
            this.btnDuzenlemeEkraniAc.TabIndex = 1;
            this.btnDuzenlemeEkraniAc.Text = "Seçiliyi Düzenle";
            this.btnDuzenlemeEkraniAc.UseVisualStyleBackColor = true;
            this.btnDuzenlemeEkraniAc.Click += new System.EventHandler(this.btnDuzenlemeEkraniAc_Click);
            // 
            // dgvKarsilasmalar
            // 
            this.dgvKarsilasmalar.AllowUserToAddRows = false;
            this.dgvKarsilasmalar.AllowUserToDeleteRows = false;
            this.dgvKarsilasmalar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvKarsilasmalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKarsilasmalar.Location = new System.Drawing.Point(6, 7);
            this.dgvKarsilasmalar.MultiSelect = false;
            this.dgvKarsilasmalar.Name = "dgvKarsilasmalar";
            this.dgvKarsilasmalar.ReadOnly = true;
            this.dgvKarsilasmalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKarsilasmalar.Size = new System.Drawing.Size(837, 373);
            this.dgvKarsilasmalar.TabIndex = 0;
            // 
            // renkler
            // 
            this.renkler.Controls.Add(this.btnRengiDuzenleEkraniAc);
            this.renkler.Controls.Add(this.btnRengiSil);
            this.renkler.Controls.Add(this.txtRenkAdi);
            this.renkler.Controls.Add(this.label5);
            this.renkler.Controls.Add(this.dgvRenkler);
            this.renkler.Controls.Add(this.label3);
            this.renkler.Controls.Add(this.label2);
            this.renkler.Controls.Add(this.label1);
            this.renkler.Controls.Add(this.txtYesil);
            this.renkler.Controls.Add(this.txtMavi);
            this.renkler.Controls.Add(this.txtKirmizi);
            this.renkler.Controls.Add(this.btnRenkEkle);
            this.renkler.Location = new System.Drawing.Point(4, 29);
            this.renkler.Name = "renkler";
            this.renkler.Padding = new System.Windows.Forms.Padding(3);
            this.renkler.Size = new System.Drawing.Size(849, 450);
            this.renkler.TabIndex = 1;
            this.renkler.Text = "Renkler";
            this.renkler.UseVisualStyleBackColor = true;
            // 
            // btnRengiDuzenleEkraniAc
            // 
            this.btnRengiDuzenleEkraniAc.Location = new System.Drawing.Point(10, 173);
            this.btnRengiDuzenleEkraniAc.Name = "btnRengiDuzenleEkraniAc";
            this.btnRengiDuzenleEkraniAc.Size = new System.Drawing.Size(199, 33);
            this.btnRengiDuzenleEkraniAc.TabIndex = 13;
            this.btnRengiDuzenleEkraniAc.Text = "Rengi Duzenle";
            this.btnRengiDuzenleEkraniAc.UseVisualStyleBackColor = true;
            this.btnRengiDuzenleEkraniAc.Click += new System.EventHandler(this.btnRengiDuzenleEkraniAc_Click);
            // 
            // btnRengiSil
            // 
            this.btnRengiSil.Location = new System.Drawing.Point(10, 212);
            this.btnRengiSil.Name = "btnRengiSil";
            this.btnRengiSil.Size = new System.Drawing.Size(199, 34);
            this.btnRengiSil.TabIndex = 12;
            this.btnRengiSil.Text = "Rengi Sil";
            this.btnRengiSil.UseVisualStyleBackColor = true;
            this.btnRengiSil.Click += new System.EventHandler(this.btnRengiSil_Click);
            // 
            // txtRenkAdi
            // 
            this.txtRenkAdi.Location = new System.Drawing.Point(109, 101);
            this.txtRenkAdi.Name = "txtRenkAdi";
            this.txtRenkAdi.Size = new System.Drawing.Size(100, 26);
            this.txtRenkAdi.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Renk Adı :";
            // 
            // dgvRenkler
            // 
            this.dgvRenkler.AllowUserToAddRows = false;
            this.dgvRenkler.AllowUserToDeleteRows = false;
            this.dgvRenkler.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRenkler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRenkler.Location = new System.Drawing.Point(215, 6);
            this.dgvRenkler.MultiSelect = false;
            this.dgvRenkler.Name = "dgvRenkler";
            this.dgvRenkler.ReadOnly = true;
            this.dgvRenkler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRenkler.Size = new System.Drawing.Size(628, 438);
            this.dgvRenkler.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mavi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yeşil :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kırmızı :";
            // 
            // txtYesil
            // 
            this.txtYesil.Location = new System.Drawing.Point(109, 38);
            this.txtYesil.Name = "txtYesil";
            this.txtYesil.Size = new System.Drawing.Size(100, 26);
            this.txtYesil.TabIndex = 3;
            // 
            // txtMavi
            // 
            this.txtMavi.Location = new System.Drawing.Point(109, 70);
            this.txtMavi.Name = "txtMavi";
            this.txtMavi.Size = new System.Drawing.Size(100, 26);
            this.txtMavi.TabIndex = 2;
            // 
            // txtKirmizi
            // 
            this.txtKirmizi.Location = new System.Drawing.Point(109, 6);
            this.txtKirmizi.Name = "txtKirmizi";
            this.txtKirmizi.Size = new System.Drawing.Size(100, 26);
            this.txtKirmizi.TabIndex = 1;
            // 
            // btnRenkEkle
            // 
            this.btnRenkEkle.Location = new System.Drawing.Point(10, 133);
            this.btnRenkEkle.Name = "btnRenkEkle";
            this.btnRenkEkle.Size = new System.Drawing.Size(199, 34);
            this.btnRenkEkle.TabIndex = 0;
            this.btnRenkEkle.Text = "Renk Ekle";
            this.btnRenkEkle.UseVisualStyleBackColor = true;
            this.btnRenkEkle.Click += new System.EventHandler(this.btnRenkEkle_Click);
            // 
            // oyuncular
            // 
            this.oyuncular.Controls.Add(this.btnOyuncuDuzenle);
            this.oyuncular.Controls.Add(this.label4);
            this.oyuncular.Controls.Add(this.cboOyuncuListeleTakim);
            this.oyuncular.Controls.Add(this.btnOyuncuSil);
            this.oyuncular.Controls.Add(this.btnOyuncuEklemeEkraniAc);
            this.oyuncular.Controls.Add(this.dgvOyuncular);
            this.oyuncular.Location = new System.Drawing.Point(4, 29);
            this.oyuncular.Name = "oyuncular";
            this.oyuncular.Padding = new System.Windows.Forms.Padding(3);
            this.oyuncular.Size = new System.Drawing.Size(849, 450);
            this.oyuncular.TabIndex = 2;
            this.oyuncular.Text = "Oyuncular";
            this.oyuncular.UseVisualStyleBackColor = true;
            // 
            // btnOyuncuDuzenle
            // 
            this.btnOyuncuDuzenle.Location = new System.Drawing.Point(189, 399);
            this.btnOyuncuDuzenle.Name = "btnOyuncuDuzenle";
            this.btnOyuncuDuzenle.Size = new System.Drawing.Size(214, 45);
            this.btnOyuncuDuzenle.TabIndex = 5;
            this.btnOyuncuDuzenle.Text = "Oyuncu Duzenle";
            this.btnOyuncuDuzenle.UseVisualStyleBackColor = true;
            this.btnOyuncuDuzenle.Click += new System.EventHandler(this.btnOyuncuDuzenle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Takım Adı :";
            // 
            // cboOyuncuListeleTakim
            // 
            this.cboOyuncuListeleTakim.FormattingEnabled = true;
            this.cboOyuncuListeleTakim.Location = new System.Drawing.Point(109, 6);
            this.cboOyuncuListeleTakim.Name = "cboOyuncuListeleTakim";
            this.cboOyuncuListeleTakim.Size = new System.Drawing.Size(175, 28);
            this.cboOyuncuListeleTakim.TabIndex = 3;
            this.cboOyuncuListeleTakim.SelectedIndexChanged += new System.EventHandler(this.cboOyuncuListeleTakim_SelectedIndexChanged);
            // 
            // btnOyuncuSil
            // 
            this.btnOyuncuSil.Location = new System.Drawing.Point(409, 399);
            this.btnOyuncuSil.Name = "btnOyuncuSil";
            this.btnOyuncuSil.Size = new System.Drawing.Size(214, 45);
            this.btnOyuncuSil.TabIndex = 2;
            this.btnOyuncuSil.Text = "Oyuncu Sil";
            this.btnOyuncuSil.UseVisualStyleBackColor = true;
            this.btnOyuncuSil.Click += new System.EventHandler(this.btnOyuncuSil_Click);
            // 
            // btnOyuncuEklemeEkraniAc
            // 
            this.btnOyuncuEklemeEkraniAc.Location = new System.Drawing.Point(629, 399);
            this.btnOyuncuEklemeEkraniAc.Name = "btnOyuncuEklemeEkraniAc";
            this.btnOyuncuEklemeEkraniAc.Size = new System.Drawing.Size(214, 45);
            this.btnOyuncuEklemeEkraniAc.TabIndex = 1;
            this.btnOyuncuEklemeEkraniAc.Text = "Yeni Oyuncu Ekle";
            this.btnOyuncuEklemeEkraniAc.UseVisualStyleBackColor = true;
            this.btnOyuncuEklemeEkraniAc.Click += new System.EventHandler(this.btnOyuncuEklemeEkraniAc_Click);
            // 
            // dgvOyuncular
            // 
            this.dgvOyuncular.AllowUserToAddRows = false;
            this.dgvOyuncular.AllowUserToDeleteRows = false;
            this.dgvOyuncular.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOyuncular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOyuncular.Location = new System.Drawing.Point(6, 40);
            this.dgvOyuncular.MultiSelect = false;
            this.dgvOyuncular.Name = "dgvOyuncular";
            this.dgvOyuncular.ReadOnly = true;
            this.dgvOyuncular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOyuncular.Size = new System.Drawing.Size(837, 356);
            this.dgvOyuncular.TabIndex = 0;
            // 
            // tabTakimlar
            // 
            this.tabTakimlar.Controls.Add(this.btnTakimSil);
            this.tabTakimlar.Controls.Add(this.btnTakimOyunculari);
            this.tabTakimlar.Controls.Add(this.btnTakimDuzenleEkraniAc);
            this.tabTakimlar.Controls.Add(this.btnYeniTakimEklemeEkraniAc);
            this.tabTakimlar.Controls.Add(this.dgvTakimlar);
            this.tabTakimlar.Location = new System.Drawing.Point(4, 29);
            this.tabTakimlar.Name = "tabTakimlar";
            this.tabTakimlar.Padding = new System.Windows.Forms.Padding(3);
            this.tabTakimlar.Size = new System.Drawing.Size(849, 450);
            this.tabTakimlar.TabIndex = 3;
            this.tabTakimlar.Text = "Takımlar";
            this.tabTakimlar.UseVisualStyleBackColor = true;
            // 
            // btnTakimOyunculari
            // 
            this.btnTakimOyunculari.Location = new System.Drawing.Point(201, 401);
            this.btnTakimOyunculari.Name = "btnTakimOyunculari";
            this.btnTakimOyunculari.Size = new System.Drawing.Size(210, 45);
            this.btnTakimOyunculari.TabIndex = 7;
            this.btnTakimOyunculari.Text = "Takım Oyuncuları";
            this.btnTakimOyunculari.UseVisualStyleBackColor = true;
            this.btnTakimOyunculari.Click += new System.EventHandler(this.btnTakimOyunculari_Click);
            // 
            // btnTakimDuzenleEkraniAc
            // 
            this.btnTakimDuzenleEkraniAc.Location = new System.Drawing.Point(417, 401);
            this.btnTakimDuzenleEkraniAc.Name = "btnTakimDuzenleEkraniAc";
            this.btnTakimDuzenleEkraniAc.Size = new System.Drawing.Size(210, 45);
            this.btnTakimDuzenleEkraniAc.TabIndex = 6;
            this.btnTakimDuzenleEkraniAc.Text = "Takımı Düzenle";
            this.btnTakimDuzenleEkraniAc.UseVisualStyleBackColor = true;
            this.btnTakimDuzenleEkraniAc.Click += new System.EventHandler(this.btnTakımDuzenleEkraniAc_Click);
            // 
            // btnYeniTakimEklemeEkraniAc
            // 
            this.btnYeniTakimEklemeEkraniAc.Location = new System.Drawing.Point(633, 401);
            this.btnYeniTakimEklemeEkraniAc.Name = "btnYeniTakimEklemeEkraniAc";
            this.btnYeniTakimEklemeEkraniAc.Size = new System.Drawing.Size(210, 45);
            this.btnYeniTakimEklemeEkraniAc.TabIndex = 5;
            this.btnYeniTakimEklemeEkraniAc.Text = "Yeni Takım Ekle";
            this.btnYeniTakimEklemeEkraniAc.UseVisualStyleBackColor = true;
            this.btnYeniTakimEklemeEkraniAc.Click += new System.EventHandler(this.btnYeniTakimEklemeEkraniAc_Click);
            // 
            // dgvTakimlar
            // 
            this.dgvTakimlar.AllowUserToAddRows = false;
            this.dgvTakimlar.AllowUserToDeleteRows = false;
            this.dgvTakimlar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTakimlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakimlar.Location = new System.Drawing.Point(6, 6);
            this.dgvTakimlar.MultiSelect = false;
            this.dgvTakimlar.Name = "dgvTakimlar";
            this.dgvTakimlar.ReadOnly = true;
            this.dgvTakimlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTakimlar.Size = new System.Drawing.Size(837, 390);
            this.dgvTakimlar.TabIndex = 0;
            // 
            // btnTakimSil
            // 
            this.btnTakimSil.Location = new System.Drawing.Point(6, 401);
            this.btnTakimSil.Name = "btnTakimSil";
            this.btnTakimSil.Size = new System.Drawing.Size(189, 45);
            this.btnTakimSil.TabIndex = 8;
            this.btnTakimSil.Text = "Takım Sil";
            this.btnTakimSil.UseVisualStyleBackColor = true;
            this.btnTakimSil.Click += new System.EventHandler(this.btnTakimSil_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 507);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "We Are The Champions 1.0";
            this.tabControl1.ResumeLayout(false);
            this.takimlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarsilasmalar)).EndInit();
            this.renkler.ResumeLayout(false);
            this.renkler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenkler)).EndInit();
            this.oyuncular.ResumeLayout(false);
            this.oyuncular.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyuncular)).EndInit();
            this.tabTakimlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakimlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage takimlar;
        private System.Windows.Forms.TabPage renkler;
        private System.Windows.Forms.TabPage oyuncular;
        private System.Windows.Forms.DataGridView dgvKarsilasmalar;
        private System.Windows.Forms.DataGridView dgvRenkler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYesil;
        private System.Windows.Forms.TextBox txtMavi;
        private System.Windows.Forms.TextBox txtKirmizi;
        private System.Windows.Forms.Button btnRenkEkle;
        private System.Windows.Forms.Button btnSeciliyiSil;
        private System.Windows.Forms.Button btnKarsilasmaEkraniAc;
        private System.Windows.Forms.Button btnDuzenlemeEkraniAc;
        private System.Windows.Forms.TabPage tabTakimlar;
        private System.Windows.Forms.Button btnYeniTakimEklemeEkraniAc;
        private System.Windows.Forms.DataGridView dgvTakimlar;
        private System.Windows.Forms.Button btnOyuncuEklemeEkraniAc;
        private System.Windows.Forms.DataGridView dgvOyuncular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRenkAdi;
        private System.Windows.Forms.Button btnTakimDuzenleEkraniAc;
        private System.Windows.Forms.Button btnTakimOyunculari;
        private System.Windows.Forms.Button btnOyuncuSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboOyuncuListeleTakim;
        private System.Windows.Forms.Button btnOyuncuDuzenle;
        private System.Windows.Forms.Button btnRengiDuzenleEkraniAc;
        private System.Windows.Forms.Button btnRengiSil;
        private System.Windows.Forms.Button btnTakimSil;
    }
}

