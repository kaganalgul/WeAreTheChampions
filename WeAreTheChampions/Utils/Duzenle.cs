using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeAreTheChampions.Utils
{
    public static class Duzenle
    {
        public static void FormDuzenle(this Form form, DataGridView dgv)
        {
            if (dgv.SelectedRows.Count == 1)
            {                
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Düzenlemek istediğiniz öğeyi seçin.");
            }
        }
    }
}
