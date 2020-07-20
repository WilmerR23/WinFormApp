using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WilmerRentCarWF.Utilities;

namespace WilmerRentCarWF
{
    public partial class TipoVehiculoUC : UserControl
    {
        public TipoVehiculoUC()
        {
            InitializeComponent();

            // Create a new row first as it will include the columns you've created at design-time.

            int rowId = dataGridView1.Rows.Add();

            // Grab the new row!
            DataGridViewRow row = dataGridView1.Rows[rowId];

            // Add the data
            row.Cells["Numero"].Value = "Value1";
            row.Cells["Nombre"].Value = "Value2";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TableHandler.HandleClick(sender,e, dataGridView1, (val) => {
                this.button1.Text = "Actualizar";
                this.textBox1.Text = val.Cells["Nombre"].Value.ToString();
            });

            
        }
    }
}
