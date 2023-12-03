using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GYM_MEMBERSHIP_SYSTEM
{
    public partial class messageForm : Form
    {
        public messageForm()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) // null
        {
        }

        private void richTextBox2_Move(object sender, EventArgs e) // null
        {

        }

        private void richTextBox2_Leave(object sender, EventArgs e) // null
        {
        }

        private void richTextBox2_Enter(object sender, EventArgs e) // null
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(richTextBox1.Text=="")
            {
                MessageBox.Show("ERROR!!!");
            }
            else
            {
                pictureBox1.Visible = true;
                richTextBox1.Text = "";
                picture1Timer.Start();
                button1.Visible = false;
                label1.ForeColor = Color.Lime;
                label1.Text = "Sent successfully.";
                label2.Visible = false;
                pictureBox3.Visible = false;
            }
        }

        private void picture1Timer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible=false;
            button1.Visible=true;
            picture1Timer.Stop();
            label1.Text = "Your message box\n       is empty";
            label1.ForeColor = Color.White;
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "Write your message here...")
            {
                richTextBox1.Text = "";
                richTextBox1.ForeColor = Color.White;
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Write your message here...";
                richTextBox1.ForeColor = Color.White;
            }
        }
    }
}
