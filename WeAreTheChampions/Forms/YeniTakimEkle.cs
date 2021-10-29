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

        public YeniTakimEkle(DatabaseContext db)
        {
            _db = db;
            InitializeComponent();
            chkTakimEkleRenk.DataSource = _db.Colors.Select(x => new ColorDTO() { Id = x.Id, ColorName = x.ColorName }).ToList();
            chkTakimEkleRenk.DisplayMember = "ColorName";
            chkTakimEkleRenk.ValueMember = "Id";
        }

        private void btnYeniTakimEkle_Click(object sender, EventArgs e)
        {
            if (chkTakimEkleRenk.CheckedItems.Count == 0)
            {
                _db.Teams.Add(new Team()
                {
                    TeamName = txtTakimIsmi.Text,
                });
                _db.SaveChanges();
                Close();
            }
            else
            {
                List<TeamColor> teamColorList = new List<TeamColor>();
                for (int i = 0; i < chkTakimEkleRenk.CheckedItems.Count; i++)
                {
                    teamColorList.Add(new TeamColor() { ColorId = ((ColorDTO)chkTakimEkleRenk.CheckedItems[i]).Id });
                }

                _db.Teams.Add(new Team()
                {
                    TeamName = txtTakimIsmi.Text,
                    TeamColors = teamColorList
                });
                _db.SaveChanges();
                Close();
            }
        }

        private void btnYeniTakimEkleIptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
