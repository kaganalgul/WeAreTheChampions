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

namespace WeAreTheChampions.Forms
{
    public partial class RengiDuzenle : Form
    {
        readonly DatabaseContext _db;
        readonly ColorDTO _colorDTO;
        public RengiDuzenle(DatabaseContext db, ColorDTO colorDTO)
        {
            _colorDTO = colorDTO;
            _db = db;
            InitializeComponent();
        }

        private void btnRengiDuzenle_Click(object sender, EventArgs e)
        {            
            Models.Color color = _db.Colors.FirstOrDefault(x => x.Id.Equals(_colorDTO.Id));

            color.ColorName = txtRenkAdiDuzenle.Text;
            color.Blue = int.Parse(txtMaviDuzenle.Text);
            color.Green = int.Parse(txtYesilDuzenle.Text);
            color.Red = int.Parse(txtKirmiziDuzenle.Text);

            _db.SaveChanges();
            Close();
        }
    }
}
