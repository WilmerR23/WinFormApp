using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WilmerRentCarWF
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var btnName = ((Button)sender).Name;
            UserControl uC = (UserControl)Activator.CreateInstance(Type.GetType(string.Format("{0}.{1}", "WilmerRentCarWF", btnName)));
            uC.AutoScroll = true;
            uC.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(uC);
            uC.Show();
        }
    }
}
