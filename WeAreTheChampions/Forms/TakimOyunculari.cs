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
    public partial class TakimOyunculari : Form
    {
        readonly DatabaseContext _db;
        public TakimOyunculari(DatabaseContext db)
        {
            _db = db;
            InitializeComponent();
        }
    }
}
