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
    public partial class OyuncuDuzenle : Form
    {
        readonly DatabaseContext _db;
        readonly PlayerDTO _playerDTO;
        public OyuncuDuzenle(DatabaseContext db, PlayerDTO playerDTO)
        {
            _playerDTO = playerDTO;
            _db = db;
            InitializeComponent();
            cboOyuncuDuzenleTakim.ValueMember = "Id";
            cboOyuncuDuzenleTakim.DisplayMember = "TeamName";
            cboOyuncuDuzenleTakim.DataSource = _db.Teams.Select(x => new TeamDTO() { TeamName = x.TeamName }).ToList();
        }

        private void btnOyuncuDuzenleOnay_Click(object sender, EventArgs e)
        {
            Player player = _db.Players.FirstOrDefault(x => x.Id.Equals(_playerDTO.Id));
            TeamDTO teamDTO = (TeamDTO)cboOyuncuDuzenleTakim.SelectedItem;
            Team team = _db.Teams.FirstOrDefault(x => x.TeamName.Equals(teamDTO.TeamName));

            player.PlayerName = txtOyuncuDuzenleIsim.Text;
            player.Team = team;

            _db.SaveChanges();
            Close();
        }

        private void btnYeniOyuncuEkleIptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
