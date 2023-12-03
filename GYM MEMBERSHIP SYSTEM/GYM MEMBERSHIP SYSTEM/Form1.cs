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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e) // uygulamadan çıkış
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // pricelist tıklandığında
        {
            pricelistForm pricelist = new pricelistForm();
            pricelist.Show();
        }

        private void button1_Click(object sender, EventArgs e) // members tıklandığında
        {
            membersForm members = new membersForm();
            members.Show();
        }
        private bool messageFormIsOpen = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (!messageFormIsOpen)
            {
                // Mesaj formunu aç.
                messageForm messageForm = new messageForm();
                messageForm.FormClosed += (s, args) => messageFormIsOpen = false; // Form kapatıldığında flag'i güncelle.
                messageForm.Show();

                // Mesaj formunun açık olduğunu işaretle.
                messageFormIsOpen = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xmasForm xmas= new xmasForm();
            xmas.Show();
        }

        private void timerUpload_Tick(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = true;
            pictureBox6.Visible = false;
            pictureBox12.Visible = false;
            pictureBox4.Visible = false;
            pictureBox18.Visible = false;
            pictureBox11.Visible = false;
            pictureBox17.Visible = false;
            pictureBox9.Visible = false;
            pictureBox16.Visible = false;
            pictureBox15.Visible = false;
            pictureBox8.Visible = false;
            pictureBox5.Visible = false;
            pictureBox20.Visible = false;
            pictureBox7.Visible = false;
            pictureBox10.Visible = false;
            pictureBox14.Visible = false;
            pictureBox13.Visible = false;
            pictureBox19.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            button5.Visible = false;
            pictureBox6.Visible = true;
            pictureBox12.Visible = true;
            pictureBox4.Visible = true;
            pictureBox18.Visible = true;
            pictureBox11.Visible = true;
            pictureBox17.Visible = true;
            pictureBox9.Visible = true;
            pictureBox16.Visible = true;
            pictureBox15.Visible = true;
            pictureBox8.Visible = true;
            pictureBox5.Visible = true;
            pictureBox20.Visible = true;
            pictureBox7.Visible = true;
            pictureBox10.Visible = true;
            pictureBox14.Visible = true;
            pictureBox13.Visible = true;
            pictureBox19.Visible = true;
        }
    }
}
