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
using WeAreTheChampions.Models;

namespace WeAreTheChampions
{
    public partial class KarsilasmaDuzenlemeEkrani : Form
    {
        readonly DatabaseContext _db;
        readonly MatchDTO _matchDTO;

        public KarsilasmaDuzenlemeEkrani(DatabaseContext db, MatchDTO matchDTO)
        {
            _matchDTO = matchDTO;
            _db = db;
            InitializeComponent();
            cbo1TakimDuzenle.DisplayMember = "TeamName";
            cbo1TakimDuzenle.ValueMember = "Id";
            cbo2TakimDuzenle.DisplayMember = "TeamName";
            cbo2TakimDuzenle.ValueMember = "Id";
            Listele();
        }

        private void Listele()
        {
            cbo1TakimDuzenle.DataSource = _db.Teams.Select(x => new TeamDTO() { Id = x.Id ,TeamName = x.TeamName }).ToList();
            cbo2TakimDuzenle.DataSource = _db.Teams.Select(x => new TeamDTO() { Id = x.Id ,TeamName = x.TeamName }).ToList();
        }

        private void btnDuzenlemeEkraniIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKarsilasmaDuzenle_Click(object sender, EventArgs e)
        {
            int score1 = (int)nud1KarsilasmaDuzenle.Value;
            int score2 = (int)nud2KarsilasmaDuzenle.Value;

            int team1 = (int)cbo1TakimDuzenle.SelectedValue;
            int team2 = (int)cbo2TakimDuzenle.SelectedValue;

            if (team1 == team2)
            {
                MessageBox.Show("Lütfen farklı takımlar seçin.");
                return;
            }

            if (score1 > score2)
            {
                MacEkle(EnumClass.Result.Team1Kazandi);
            }
            else if (score1 < score2)
            {
                MacEkle(EnumClass.Result.Team2Kazandi);
            }
            else if (score1 == score2)
            {
                MacEkle(EnumClass.Result.Berabere);
            }
        }

        private void MacEkle(EnumClass.Result result)
        {
            Match match = _db.Matches.FirstOrDefault(x => x.Id.Equals(_matchDTO.Id));
            match.MatchTime = new DateTime(dtpTarihDuzenle.Value.Year, dtpTarihDuzenle.Value.Month, dtpTarihDuzenle.Value.Day, dtpSaatDuzenle.Value.Hour, dtpSaatDuzenle.Value.Minute, dtpSaatDuzenle.Value.Second);
            match.Score1 = (int)nud1KarsilasmaDuzenle.Value;
            match.Score2 = (int)nud2KarsilasmaDuzenle.Value;
            match.Team1Id = (int)cbo1TakimDuzenle.SelectedValue;
            match.Team2Id = (int)cbo2TakimDuzenle.SelectedValue;
            match.Result = result;
            MessageBox.Show("Karşılaşma başarıyla düzenlenlenip kaydedilmiştir.");

            _db.SaveChanges();

            Close();
        }
    }
}
