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

namespace WeAreTheChampions
{
    public partial class TakimDuzenle : Form
    {
        readonly DatabaseContext _db;

        public TakimDuzenle(DatabaseContext db)
        {
            _db = db;
            InitializeComponent();
        }
    }
}
