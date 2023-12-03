using GYM_MEMBERSHIP_SYSTEM.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_MEMBERSHIP_SYSTEM
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }
        private void button10_Click(object sender, EventArgs e) // null
        {
        }

        public void button3_Click(object sender, EventArgs e) // update button
        {
        }














        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        bool move;
        int mousex;
        int mousey;
        private void settingsForm_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mousex = e.X;
            mousey = e.Y;
        }

        private void settingsForm_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void settingsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(move)
            {
                this.SetDesktopLocation(MousePosition.X - mousex, MousePosition.Y - mousey);
            }
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) // NULL
        {
        }
    }
}
