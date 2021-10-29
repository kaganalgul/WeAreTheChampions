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
    public partial class TakimDuzenle : Form
    {
        readonly DatabaseContext _db;
        readonly Team _team;

        public TakimDuzenle(DatabaseContext db, Team team)
        {
            _team = team;
            _db = db;
            InitializeComponent();
            chkTakimDuzenleRenk.DataSource = _db.Colors.Select(x => new ColorDTO() { Id = x.Id, ColorName = x.ColorName }).ToList();
            chkTakimDuzenleRenk.DisplayMember = "ColorName";
            chkTakimDuzenleRenk.ValueMember = "Id";
        }

        private void btnTakimDuzenle_Click(object sender, EventArgs e)
        {
            if (chkTakimDuzenleRenk.CheckedItems.Count == 0)
            {
                _team.TeamName = txtTakimIsmiDuzenle.Text;

                _db.SaveChanges();
                Close();
            }
            else
            {
                if (chkTakimDuzenleRenk.CheckedItems.Count == 0)
                {
                    for (int i = 0; i < _team.TeamColors.Count; i++)
                    {
                        _team.TeamColors.Remove((_team.TeamColors.ToList())[i]);
                    }
                }
                else
                {
                    List<TeamColor> teamColorList = new List<TeamColor>();
                    for (int i = 0; i < chkTakimDuzenleRenk.CheckedItems.Count; i++)
                    {
                        teamColorList.Add(new TeamColor() { ColorId = ((ColorDTO)chkTakimDuzenleRenk.CheckedItems[i]).Id });
                    }
                    for (int i = 0; i < _team.TeamColors.Count; i++)
                    {
                        _team.TeamColors.Remove((_team.TeamColors.ToList())[i]);
                    }
                    _team.TeamName = txtTakimIsmiDuzenle.Text;
                    _team.TeamColors = teamColorList;
                }
                
                _db.SaveChanges();
                Close();
            }
        }
    }
}
