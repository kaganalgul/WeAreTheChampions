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
            cbo1TakimDuzenle.DataSource = _db.Teams.Select(x => new TeamDTO() { TeamName = x.TeamName }).ToList();
            cbo2TakimDuzenle.DataSource = _db.Teams.Select(x => new TeamDTO() { TeamName = x.TeamName }).ToList();
        }

        private void btnDuzenlemeEkraniIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKarsilasmaDuzenle_Click(object sender, EventArgs e)
        {
            int score1 = (int)nud1KarsilasmaDuzenle.Value;
            int score2 = (int)nud2KarsilasmaDuzenle.Value;

            int team1 = cbo1TakimDuzenle.SelectedIndex;
            int team2 = cbo2TakimDuzenle.SelectedIndex;

            if (team1 == team2)
            {
                MessageBox.Show("Lütfen farklı takımlar seçin.");
                return;
            }

            //if (_db.Matches.Any(x => x.MatchTime == dtpTarihDuzenle.Value && x.Team1 == cbo1TakimDuzenle.SelectedItem && x.Team2 == cbo2TakimDuzenle.SelectedItem && x.Score1 == nud1KarsilasmaDuzenle.Value && x.Score2 == nud2KarsilasmaDuzenle.Value))
            //{
            //    MessageBox.Show("Bu karşılaşma daha önce kaydedilmiş.");
            //    return;
            //}

            Match match = _db.Matches.FirstOrDefault(x => x.Id.Equals(_matchDTO.Id));
            match.MatchTime = new DateTime(dtpTarihDuzenle.Value.Year, dtpTarihDuzenle.Value.Month, dtpTarihDuzenle.Value.Day, dtpSaatDuzenle.Value.Hour, dtpSaatDuzenle.Value.Minute, dtpSaatDuzenle.Value.Second);
            match.Score1 = (int)nud1KarsilasmaDuzenle.Value;
            match.Score2 = (int)nud2KarsilasmaDuzenle.Value;
            match.Team1Id = cbo1TakimDuzenle.SelectedIndex + 1;
            match.Team2Id = cbo2TakimDuzenle.SelectedIndex + 1;

            MessageBox.Show("Karşılaşma başarıyla düzenlenlenip kaydedilmiştir.");

            _db.SaveChanges();

            Close();
        }
    }
}
