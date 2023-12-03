using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_MEMBERSHIP_SYSTEM
{
    public partial class xmasForm : Form
    {
        public xmasForm()
        {
            InitializeComponent();
            
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xmasForm_Load(object sender, EventArgs e) // null
        {
            xmasTimer.Start();
        }

        private void xmasTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
            xmasTimer.Stop();
        }
    }
}
