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
using WeAreTheChampions.Models;

namespace WeAreTheChampions
{
    public partial class YeniOyuncuEkle : Form
    {
        readonly DatabaseContext _db;
        public YeniOyuncuEkle(DatabaseContext db)
        {
            _db = db;
            InitializeComponent();
            cboOyuncuEkleTakim.ValueMember = "Id";
            cboOyuncuEkleTakim.DisplayMember = "TeamName";
            cboOyuncuEkleTakim.DataSource = _db.Teams.Select(x => new TeamDTO() { Id = x.Id, TeamName = x.TeamName }).ToList();
        }

        private void btnYeniOyuncuEkleIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYeniOyuncuEkle_Click(object sender, EventArgs e)
        {
            if (_db.Players.Any(x => x.PlayerName == txtOyuncuIsim.Text && x.TeamId == (int)cboOyuncuEkleTakim.SelectedValue))
            {
                MessageBox.Show("Bu oyuncu daha önce kaydedilmiş.");
            }
            else
            {
                TeamDTO teamDTO = (TeamDTO)cboOyuncuEkleTakim.SelectedItem;
                Team team = _db.Teams.FirstOrDefault(x => x.Id.Equals(teamDTO.Id));
                _db.Players.Add(new Player()
                {
                    PlayerName = txtOyuncuIsim.Text,
                    TeamId = (int)cboOyuncuEkleTakim.SelectedValue,
                    Team = team
                });

                _db.SaveChanges();
                Close();
            }
            
        }
    }
}
