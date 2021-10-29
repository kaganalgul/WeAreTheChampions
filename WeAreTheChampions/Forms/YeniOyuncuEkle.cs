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
            cboOyuncuEkleTakim.Enabled = false;
        }

        private void btnYeniOyuncuEkleIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnYeniOyuncuEkle_Click(object sender, EventArgs e)
        {
            TeamDTO teamDTO = (TeamDTO)cboOyuncuEkleTakim.SelectedItem;
            Team team = _db.Teams.FirstOrDefault(x => x.Id.Equals(teamDTO.Id));

            // Eklenen oyununcunun takımının belli olup olmadığı check box ile kontrol edilir.

            if (chkTakimVar.Checked == true)
            {
                _db.Players.Add(new Player()
                {
                    PlayerName = txtOyuncuIsim.Text,
                    Team = team
                });
            }
            else
            {
                _db.Players.Add(new Player()
                {
                    PlayerName = txtOyuncuIsim.Text,
                });
            }
            _db.SaveChanges();

            Close();
        }
        private void chkTakimVar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTakimVar.Checked == true)
            {
                cboOyuncuEkleTakim.Enabled = true;
            }
            else
            {
                cboOyuncuEkleTakim.Enabled = false;
            }
        }
    }
}
