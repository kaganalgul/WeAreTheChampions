using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Data;
using WeAreTheChampions.DTOs;
using WeAreTheChampions.Enums;
using WeAreTheChampions.Forms;
using WeAreTheChampions.Models;
using WeAreTheChampions.Utils;

namespace WeAreTheChampions
{
    public partial class Home : Form
    {
        readonly DatabaseContext db = new DatabaseContext();
        public Home()
        {
            InitializeComponent();
            KarsilasmaListele();
            OyuncuListele();
            RenkListele();
            TakimListele();
        }

        private void TakimListele()
        {
            cboOyuncuListeleTakim.DisplayMember = "TeamName";
            cboOyuncuListeleTakim.ValueMember = "Id";
            List<TeamDTO> takimlar = db.Teams.Select(x => new TeamDTO() { TeamName = x.TeamName }).ToList();
            takimlar.Insert(0, new TeamDTO() { TeamName = "Takımlar" });
            cboOyuncuListeleTakim.DataSource = takimlar;
            dgvTakimlar.DataSource = db.Teams.Select(x => new TeamDTO() { Id = x.Id, TeamName = x.TeamName }).ToList();
        }

        // Kullanıcının veri ile direk bağlantısını engellemek için veriyi aktarmayı sağlayan ve kontrol eden DTO classları oluşturulup listeleme yapılırken bunlar kullanılmıştır. Bu classlar aynı zamanda kullanıcıya kullanacağı verilerin admin kontrolünden geçmesini sağlamaktadır.
        private void RenkListele()
        {
            dgvRenkler.DataSource = db.Colors.Select(x => new ColorDTO() { Id = x.Id, ColorName = x.ColorName, Blue = x.Blue, Red = x.Red, Green = x.Green }).ToList();
        }

        private void OyuncuListele()
        {
            dgvOyuncular.DataSource = db.Players.Select(x => new PlayerDTO() { Id = x.Id, PlayerName = x.PlayerName, TeamName = x.Team.TeamName }).ToList();
        }

        private void KarsilasmaListele()
        {   
            dgvKarsilasmalar.DataSource = db.Matches.Select(x => new MatchDTO() { Team1Isim = x.Team1.TeamName, Team2Isim = x.Team2.TeamName, Id = x.Id, MatchTime = x.MatchTime , Score1 = x.Score1, Score2 = x.Score2, Result = x.Result }).ToList();            
        }

        private void btnKarsilasmaEkraniAc_Click(object sender, EventArgs e)
        {
            YeniKarsilasmaEkle yeniKarsilasmaEkle = new YeniKarsilasmaEkle(db);
            yeniKarsilasmaEkle.ShowDialog();
            KarsilasmaListele();
        }

        private void btnDuzenlemeEkraniAc_Click(object sender, EventArgs e)
        {
            MatchDTO matchDTO = new MatchDTO();
            matchDTO = (MatchDTO)dgvKarsilasmalar.SelectedRows[0].DataBoundItem;            
            KarsilasmaDuzenlemeEkrani karsilasmaDuzenlemeEkrani = new KarsilasmaDuzenlemeEkrani(db, matchDTO);
            karsilasmaDuzenlemeEkrani.FormDuzenle(dgvKarsilasmalar); //Listeden öğe seçilip seçilmediği extension method ile kontrol edilmiştir.
            KarsilasmaListele();
        }

        private void btnOyuncuEklemeEkraniAc_Click(object sender, EventArgs e)
        {
            YeniOyuncuEkle yeniOyuncuEkle = new YeniOyuncuEkle(db);
            yeniOyuncuEkle.ShowDialog();
            OyuncuListele();
        }

        private void btnYeniTakimEklemeEkraniAc_Click(object sender, EventArgs e)
        {
            YeniTakimEkle yeniTakimEkle = new YeniTakimEkle(db);
            yeniTakimEkle.ShowDialog();
            TakimListele();
        }

        private void btnTakımDuzenleEkraniAc_Click(object sender, EventArgs e)
        {
            TakimDuzenle takimDuzenle = new TakimDuzenle(db);
            takimDuzenle.FormDuzenle(dgvTakimlar); //Listeden öğe seçilip seçilmediği extension method ile kontrol edilmiştir.
        }

        private void btnOyuncuDuzenle_Click(object sender, EventArgs e)
        {
            PlayerDTO playerDTO = (PlayerDTO)dgvOyuncular.SelectedRows[0].DataBoundItem;
            OyuncuDuzenle oyuncuDuzenle = new OyuncuDuzenle(db, playerDTO);
            oyuncuDuzenle.FormDuzenle(dgvOyuncular); //Listeden öğe seçilip seçilmediği extension method ile kontrol edilmiştir.
            OyuncuListele();
        }

        private void btnRengiDuzenleEkraniAc_Click(object sender, EventArgs e)
        {
            ColorDTO colorDTO = (ColorDTO)dgvRenkler.SelectedRows[0].DataBoundItem;
            RengiDuzenle rengiDuzenle = new RengiDuzenle(db, colorDTO);
            rengiDuzenle.FormDuzenle(dgvRenkler); //Listeden öğe seçilip seçilmediği extension method ile kontrol edilmiştir.
            RenkListele();
        }

        private void btnSeciliyiSil_Click(object sender, EventArgs e)
        {
            if (dgvKarsilasmalar.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("Seçili karşılaşmayı silmek istediğinize emin misiniz?", "Karşılaşmayı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;
                KarsilasmaSil();
            }
            KarsilasmaListele();
        }

        private void KarsilasmaSil()
        {
            MatchDTO matchDTO = (MatchDTO)dgvKarsilasmalar.SelectedRows[0].DataBoundItem;
            Match match = db.Matches.FirstOrDefault(x => x.Id.Equals(matchDTO.Id));

            db.Matches.Remove(match);

            db.SaveChanges();
        }

        private void cboOyuncuListeleTakim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOyuncuListeleTakim.SelectedIndex == 0)
            {
                OyuncuListele();
            }
            else
            {
                TeamDTO teamDTO = (TeamDTO)cboOyuncuListeleTakim.SelectedItem;
                var list = db.Players.Select(y => new PlayerDTO()
                {
                    Id = y.Id,
                    PlayerName = y.PlayerName,
                    TeamId = y.TeamId,
                    TeamName = y.Team.TeamName
                }).Where(x => x.TeamName == teamDTO.TeamName).ToList();
                dgvOyuncular.DataSource = list;
            }
        }

        private void btnOyuncuSil_Click(object sender, EventArgs e)
        {           
            if (dgvOyuncular.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("Seçili oyuncuyu silmek istediğinize emin misiniz?", "Oyuncuyu Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;
                PlayerDTO playerDTO = (PlayerDTO)dgvOyuncular.SelectedRows[0].DataBoundItem;
                Player player = db.Players.FirstOrDefault(x => x.Id.Equals(playerDTO.Id));
                db.Players.Remove(player);
                db.SaveChanges();
                OyuncuListele();
            }
        }

        private void btnRenkEkle_Click(object sender, EventArgs e)
        {
            db.Colors.Add(new Models.Color() { ColorName = txtRenkAdi.Text, Blue = Convert.ToInt32(txtMavi.Text), Green = Convert.ToInt32(txtYesil.Text), Red = Convert.ToInt32(txtKirmizi.Text) });     
            db.SaveChanges();
            RenkListele();
        }

        private void btnRengiSil_Click(object sender, EventArgs e)
        {
            if (dgvRenkler.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("Seçili rengi silmek istediğinize emin misiniz?", "Rengi Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;
                ColorDTO colorDTO = (ColorDTO)dgvRenkler.SelectedRows[0].DataBoundItem;
                Models.Color color = db.Colors.FirstOrDefault(x => x.Id.Equals(colorDTO.Id));
                db.Colors.Remove(color);
                db.SaveChanges();
                RenkListele();
            }
        }

        private void btnTakimSil_Click(object sender, EventArgs e)
        {
            if (dgvTakimlar.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("Seçili takımı silmek istediğinize emin misiniz?", "Takımı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;

                TeamDTO teamDTO = (TeamDTO)dgvTakimlar.SelectedRows[0].DataBoundItem;
                Team team = db.Teams.FirstOrDefault(x => x.Id.Equals(teamDTO.Id));

                db.Teams.Remove(team);
                db.SaveChanges();
                KarsilasmaListele();
                TakimListele();
            }
        }
    }
}
