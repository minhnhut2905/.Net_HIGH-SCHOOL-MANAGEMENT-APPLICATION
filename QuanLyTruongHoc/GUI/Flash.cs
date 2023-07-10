using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Flash : Form
    {
        public Flash()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            loading.Width += 4;
            if (loading.Width >= 600)
            {
                timer.Stop();
                frmChinh main = new frmChinh();
                main.Show();
                this.Hide();
            }
        }

        private void Flash_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
