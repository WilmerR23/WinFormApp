using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WilmerRentCarWF.Utilities
{
    public class TableHandler
    {
        public static void HandleClick(object sender, DataGridViewCellEventArgs e, DataGridView dataGridView, Action<DataGridViewRow> CallBack)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) CallBack(dataGridView.Rows[e.RowIndex]);
        }
    }
}
