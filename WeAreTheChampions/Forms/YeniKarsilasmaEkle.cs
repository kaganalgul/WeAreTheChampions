﻿using System;
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
    public partial class YeniKarsilasmaEkle : Form
    {
        readonly DatabaseContext _db;

        public YeniKarsilasmaEkle(DatabaseContext db)
        {
            _db = db;
            InitializeComponent();
            cbo1TakimEkle.DisplayMember = "TeamName";
            cbo1TakimEkle.ValueMember = "Id";
            cbo2TakimEkle.DisplayMember = "TeamName";
            cbo2TakimEkle.ValueMember = "Id";
            Listele();
        }

        private void Listele()
        {
            cbo1TakimEkle.DataSource = _db.Teams.Select(x => new TeamDTO() { Id = x.Id ,TeamName = x.TeamName }).ToList();
            cbo2TakimEkle.DataSource = _db.Teams.Select(x => new TeamDTO() { Id = x.Id ,TeamName = x.TeamName }).ToList();
        }

        private void btnYeniKarsilasmaEkleIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnYeniKarsilasmaEkle_Click(object sender, EventArgs e)
        {
            int score1 = (int)nud1KarsilasmaEkle.Value;
            int score2 = (int)nud2KarsilasmaEkle.Value;

            int team1index = (int)cbo1TakimEkle.SelectedValue;
            int team2index = (int)cbo2TakimEkle.SelectedValue;            

            if (team1index == team2index)
            {
                MessageBox.Show("Lütfen farklı takımlar seçin.");
                return;
            }

            TeamDTO cbo1DTO = (TeamDTO)cbo1TakimEkle.SelectedItem;
            TeamDTO cbo2DTO = (TeamDTO)cbo2TakimEkle.SelectedItem;

            Team cbo1Team = _db.Teams.FirstOrDefault(x => x.Id.Equals(cbo1DTO.Id));
            Team cbo2Team = _db.Teams.FirstOrDefault(x => x.Id.Equals(cbo2DTO.Id));
            // GS-FB 29  19:00
            // GS  29 1900 maçı varmı 
            // FB  29 1900
            if (_db.Matches.Any(x => x.Team1.Id == cbo1Team.Id && x.Team2.Id == cbo2Team.Id ))
            {
                MessageBox.Show("Bu karşılaşma daha önce kaydedilmiş.");
                return;
            }

            TeamDTO teamDTO1 = (TeamDTO)cbo1TakimEkle.SelectedItem;
            Team team1 = _db.Teams.FirstOrDefault(x => x.Id.Equals(teamDTO1.Id));

            TeamDTO teamDTO2 = (TeamDTO)cbo2TakimEkle.SelectedItem;
            Team team2 = _db.Teams.FirstOrDefault(x => x.Id.Equals(teamDTO2.Id));
           
            if (score1 > score2)
            {
                _db.Matches.Add(new Match() { Team1 = team1, Team2 = team2, Team1Id = cbo1TakimEkle.SelectedIndex + 1, Team2Id = cbo2TakimEkle.SelectedIndex + 1, Score2 = Convert.ToInt32(nud2KarsilasmaEkle.Value), MatchTime = new DateTime(dtpKarsilasmaEkleTarih.Value.Year, dtpKarsilasmaEkleTarih.Value.Month, dtpKarsilasmaEkleTarih.Value.Day, dtpKarsilasmaEkleSaat.Value.Hour, dtpKarsilasmaEkleSaat.Value.Minute, dtpKarsilasmaEkleSaat.Value.Second), Result = EnumClass.Result.Team1Kazandi });
            }
            else if (score1 < score2)
            {
                _db.Matches.Add(new Match() { Team1 = team1, Team2 = team2, Team1Id = cbo1TakimEkle.SelectedIndex + 1, Team2Id = cbo2TakimEkle.SelectedIndex + 1, Score1 = Convert.ToInt32(nud1KarsilasmaEkle.Value), Score2 = Convert.ToInt32(nud2KarsilasmaEkle.Value), MatchTime = new DateTime(dtpKarsilasmaEkleTarih.Value.Year, dtpKarsilasmaEkleTarih.Value.Month, dtpKarsilasmaEkleTarih.Value.Day, dtpKarsilasmaEkleSaat.Value.Hour, dtpKarsilasmaEkleSaat.Value.Minute, dtpKarsilasmaEkleSaat.Value.Second), Result = EnumClass.Result.Team2Kazandi });
            }
            else if ( score1 == score2 )
            {
                _db.Matches.Add(new Match() { Team1 = team1, Team2 = team2, Team1Id = cbo1TakimEkle.SelectedIndex + 1, Team2Id = cbo2TakimEkle.SelectedIndex + 1, Score1 = Convert.ToInt32(nud1KarsilasmaEkle.Value), Score2 = Convert.ToInt32(nud2KarsilasmaEkle.Value), MatchTime = new DateTime(dtpKarsilasmaEkleTarih.Value.Year, dtpKarsilasmaEkleTarih.Value.Month, dtpKarsilasmaEkleTarih.Value.Day, dtpKarsilasmaEkleSaat.Value.Hour, dtpKarsilasmaEkleSaat.Value.Minute, dtpKarsilasmaEkleSaat.Value.Second), Result = EnumClass.Result.Berabere });
            }

            MessageBox.Show("Karşılaşma başarıyla kaydolmuştur.");

            _db.SaveChanges();

            Close();
        }
    }
}
