using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GYM_MEMBERSHIP_SYSTEM.settingsForm;

namespace GYM_MEMBERSHIP_SYSTEM
{
    public partial class pricelistForm : Form
    {
        public settingsForm settings;
        public pricelistForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e) // null
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e) //NULL
        {
        }

        public void button26_Click(object sender, EventArgs e) //ayarlar formu açılış
        {
            settings = new settingsForm();
            settings.Owner = this;
            settings.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e) // null
        {
        }
        bool sidebar2Exopand;
        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebar2timer.Start();
        }

        private void sidebar2timer_Tick(object sender, EventArgs e) // settings bar hareketleri
        {
            if (sidebar2Exopand)
            {
                sidebar2.Width -= 10;
                if (sidebar2.Width == sidebar2.MinimumSize.Width)
                {
                    sidebar2Exopand = false;
                    sidebar2timer.Stop();
                }
            }
            else
            {
                sidebar2.Width += 10;
                if (sidebar2.Width == sidebar2.MaximumSize.Width)
                {
                    sidebar2Exopand = true;
                    sidebar2timer.Stop();
                }
            }
        }
        bool updateCollapsed;
        private void updateContainer_Tick(object sender, EventArgs e) // updatimer bar hareketleri
        {
            if (updateCollapsed)
            {
                updateContainer.Height += 10;
                if (updateContainer.Height == updateContainer.MaximumSize.Height)
                {
                    updateCollapsed = false;
                    updateTimer.Stop();
                }
            }
            else
            {
                updateContainer.Height -= 10;
                if (updateContainer.Height == updateContainer.MinimumSize.Height)
                {
                    updateCollapsed = true;
                    updateTimer.Stop();
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            updateTimer.Start();
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e) // NULL
        {
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e) // NULL
        {
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton4.Checked)
            {
                radioButton3.Text = "9 months";
            }
            else
            {
                radioButton3.Text = "12 months";
            }
        }

        private void button20_Click(object sender, EventArgs e) // updatePRICE button
        {
            if (maskedTextBox1.Text == "" || !(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked) || !(radioButton4.Checked || radioButton5.Checked || radioButton6.Checked))
            {
                pictureBox2.Visible = true;
                MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pictureBox2.Visible = false;
                if(radioButton6.Checked && radioButton1.Checked)
                {
                    label10.Text = maskedTextBox1.Text+" $";
                }
                else if (radioButton6.Checked && radioButton2.Checked)
                {
                    label11.Text = maskedTextBox1.Text + " $";
                }
                else if (radioButton6.Checked && radioButton3.Checked)
                {
                    label12.Text = maskedTextBox1.Text + " $";
                }
                else if (radioButton4.Checked && radioButton1.Checked)
                {
                    label13.Text = maskedTextBox1.Text + " $";
                }
                else if (radioButton4.Checked && radioButton2.Checked)
                {
                    label14.Text = maskedTextBox1.Text + " $";
                }
                else if (radioButton4.Checked && radioButton3.Checked)
                {
                    label15.Text = maskedTextBox1.Text + " $";
                }
                else if (radioButton5.Checked && radioButton1.Checked)
                {
                    label18.Text = maskedTextBox1.Text + " $";
                }
                else if (radioButton5.Checked && radioButton2.Checked)
                {
                    label17.Text = maskedTextBox1.Text + " $";
                }
                else if (radioButton5.Checked && radioButton3.Checked)
                {
                    label16.Text = maskedTextBox1.Text + " $";
                }
                maskedTextBox1.Text="";
                updateTimer.Start();
                sidebar2timer.Start();
            }
            if (label15.Text == "999 $")
            {
                progressBar1.Value = 85;
                label21.ForeColor = Color.Red;
                label21.Text = "Expensive\n   price";
                updateTimer.Start();
                sidebar2timer.Start();
            }
            else if (label15.Text=="100 $")
            {
                progressBar1.Value=25;
                label21.ForeColor = Color.Khaki;
                label21.Text = "Price too\n    low";
                updateTimer.Start();
                sidebar2timer.Start();
            }
            else if (label15.Text=="400 $")
            {
                progressBar1.Value = 50;
                label21.ForeColor = Color.DodgerBlue;
                label21.ForeColor = Color.DodgerBlue;
                label21.ForeColor = Color.DodgerBlue;
                label21.ForeColor = Color.DodgerBlue;
                label21.Text = "Price range\n   normal";
                updateTimer.Start();
                sidebar2timer.Start();
            }
        }
        private void pricelistForm_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
        }
    }
}
