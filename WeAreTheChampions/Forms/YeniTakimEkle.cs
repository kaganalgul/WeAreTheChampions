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
            chkListRenkler.DataSource = _db.Colors.Select(x => new TeamColorDTO() { ColorId = x.Id, ColorName = x.ColorName }).ToList();
            chkListRenkler.DisplayMember = "ColorName";
            chkListRenkler.ValueMember = "Id";

        }

        private void btnYeniTakimEkle_Click(object sender, EventArgs e)
        {
            if (_db.Teams.Any(x => x.TeamName.Equals(txtTakimIsmi.Text)))
            {
                MessageBox.Show("Bu takım daha önce kaydedilmiş");
                return;
            }

            if (chkListRenkler.CheckedItems.Count == 0)
            {
                _db.Teams.Add(new Team() { TeamName = txtTakimIsmi.Text });
                _db.SaveChanges();
                Close();
            }

            else
            {
                _db.Teams.Add(new Team() { TeamName = txtTakimIsmi.Text, TeamColors = teamColorsList });
                _db.SaveChanges();
                Close();
            }
        }

        private void btnYeniTakimEkleIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkListRenkler_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeamColorDTO teamColorDTO = (TeamColorDTO)chkListRenkler.SelectedItem;
            TeamColor teamColor = _db.TeamColors.FirstOrDefault(x => x.ColorId.Equals(teamColorDTO.ColorId));
            teamColorsList.Add(teamColor);
            if (chkListRenkler.CheckedItems.Count != 0)
            {
                _db.TeamColors.Add(teamColor);
            }
        }
    }
}
