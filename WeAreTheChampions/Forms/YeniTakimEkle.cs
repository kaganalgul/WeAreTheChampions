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
    public partial class YeniTakimEkle : Form
    {
        readonly DatabaseContext _db;
        List<TeamColor> teamColorsList = new List<TeamColor>();

        public YeniTakimEkle(DatabaseContext db)
        {
            _db = db;
            InitializeComponent();
            cboTakimEkleRenk.DataSource = _db.Colors.Select(x => new TeamColorDTO() { ColorId = x.Id, ColorName = x.ColorName }).ToList();
            cboTakimEkleRenk.DisplayMember = "ColorName";
            cboTakimEkleRenk.ValueMember = "Id";
            cboTakimEkleRenk.Enabled = false;
        }

        private void btnYeniTakimEkle_Click(object sender, EventArgs e)
        {            
            if (_db.Teams.Any(x => x.TeamName.Equals(txtTakimIsmi.Text)))
            {
                MessageBox.Show("Bu takım daha önce kaydedilmiş");
                return;
            }

            if (cboTakimEkleRenk.Enabled == true)
            {
                TeamColorDTO teamColorDTO = (TeamColorDTO)cboTakimEkleRenk.SelectedItem;
                TeamColor teamColor = _db.TeamColors.FirstOrDefault(x => x.ColorId.Equals(teamColorDTO.Id));
                List<TeamColor> teamColors = new List<TeamColor>();
                teamColors.Add(teamColor);
                _db.Teams.Add(new Team() { TeamName = txtTakimIsmi.Text, TeamColors = teamColors });
                _db.SaveChanges();
            }

            else
            {
                _db.Teams.Add(new Team() { TeamName = txtTakimIsmi.Text });
                _db.SaveChanges();
            }

            Close();
        }

        private void btnYeniTakimEkleIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkTakimRengiVar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTakimRengiVar.Checked == true)
            {
                cboTakimEkleRenk.Enabled = true;
            }
            else
            {
                cboTakimEkleRenk.Enabled = false;
            }
        }
    }
}
