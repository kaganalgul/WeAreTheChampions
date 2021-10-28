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
            chkListRenkler.DataSource = _db.Colors.ToList();
            chkListRenkler.DisplayMember = "ColorName";
            chkListRenkler.ValueMember = "Id";

            
            
            //cboTakimRenk.DisplayMember = "ColorName";
            //cboTakimRenk.ValueMember = "Id";
            
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
                List<TeamColor> teamColorsList = new List<TeamColor>();                
                for (int i = 0; i < chkListRenkler.CheckedItems.Count; i++)
                {
                    _db.TeamColors.Add(new TeamColor() { ColorId = chkListRenkler.CheckedIndices[i], Team = new Team() { TeamName = txtTakimIsmi.Text } });
                }
                _db.Teams.Add(new Team() { TeamName = txtTakimIsmi.Text, TeamColors = teamColorsList });
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
