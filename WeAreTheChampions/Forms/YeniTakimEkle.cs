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
            cboTakimRenk.DataSource = _db.Colors.Select(x => new ColorDTO() { Id = x.Id, ColorName = x.ColorName, Red = x.Red, Green = x.Green, Blue = x.Blue }).ToList();
            cboTakimRenk.DisplayMember = "ColorName";
            cboTakimRenk.ValueMember = "Id";
        }

        private void btnYeniTakimEkle_Click(object sender, EventArgs e)
        {
            if (_db.Teams.Any(x => x.TeamName.Equals(txtTakimIsmi.Text)))
            {
                MessageBox.Show("Bu takım daha önce kaydedilmiş");
                return;
            }
            Models.Color color = (Models.Color)cboTakimRenk.SelectedItem;
            _db.Teams.Add(new Team() { TeamName = txtTakimIsmi.Text});
            _db.SaveChanges();
            Close();
        }
        
        private void btnYeniTakimEkleIptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
