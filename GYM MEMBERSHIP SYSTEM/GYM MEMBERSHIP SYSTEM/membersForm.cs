using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GYM_MEMBERSHIP_SYSTEM
{
    public partial class membersForm : Form
    {
        bool sidebarExopand; // sidebar
        bool addCollapsed; // addbar
        bool transferCollapsed; // transferbar
        bool deleteCollapsed; // deletebar
        bool renewalCollapsed; // renewalbar
        bool cancelyesExopand; // savedbar
        bool yesbutton=false;
        bool cancelbutton=false;
        public membersForm()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e) // sayfayı kapat
        {
            this.Close();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e) //sidebartimer bar hareketleri
        {
            if(sidebarExopand)
            {
                sidebar.Width -= 10;
                cancelyes.Width=MinimumSize.Width;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExopand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExopand= true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text=="Name")
            {
                textBox1.ForeColor = Color.White;
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text =="")
            {
                textBox1.ForeColor= Color.Gray;
                textBox1.Text = "Name";
            }
        }

        private void addTimer_Tick(object sender, EventArgs e) // addTimer bar hareketleri
        {
            if(addCollapsed)
            {
                addContainer.Height += 10;
                if(addContainer.Height == addContainer.MaximumSize.Height)
                {
                    addCollapsed = false;
                    addTimer.Stop();
                }
            }
            else
            {
                addContainer.Height -= 10;
                if(addContainer.Height == addContainer.MinimumSize.Height )
                {
                    addCollapsed= true;
                    addTimer.Stop();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addTimer.Start();
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
            if(radioButton3.Checked)
            {
                textBox7.Text = "270";
            }
            textBox10.ForeColor = Color.CornflowerBlue;
            textBox10.Text = "Normal";

        }

        private void button4_Click(object sender, EventArgs e) // transfer button
        {
            transferTimer.Start();
        }

        private void transferTimer_Tick(object sender, EventArgs e) // transferTimer bar hareketleri
        {
            if (transferCollapsed)
            {
                transferContainer.Height += 10;
                if (transferContainer.Height == transferContainer.MaximumSize.Height)
                {
                    transferCollapsed = false;
                    transferTimer.Stop();
                }
            }
            else
            {
                transferContainer.Height -= 10;
                if (transferContainer.Height == transferContainer.MinimumSize.Height)
                {
                    transferCollapsed = true;
                    transferTimer.Stop();
                }
            }
        }

        private void sidebar_Paint(object sender, PaintEventArgs e) // nul
        {
        }

        private void deleteContainer_Tick(object sender, EventArgs e) // deleteTimer bar hareketleri
        {
            if (deleteCollapsed)
            {
                deleteContainer.Height += 10;
                if (deleteContainer.Height == deleteContainer.MaximumSize.Height)
                {
                    deleteCollapsed = false;
                    deleteTimer.Stop();
                }
            }
            else
            {
                deleteContainer.Height -= 10;
                if (deleteContainer.Height == deleteContainer.MinimumSize.Height)
                {
                    deleteCollapsed = true;
                    deleteTimer.Stop();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e) // delete button
        {
            deleteTimer.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // null
        {
        }

        private void textBox2_MouseEnter(object sender, EventArgs e) // null
        {
        }

        private void textBox2_MouseLeave(object sender, EventArgs e) // null
        {
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Name DATA 1")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Name DATA 1";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "New member's name";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "New member's name")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.White;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Name DATA";
                textBox5.ForeColor = Color.Gray;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Name DATA")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.White;
            }
        }

        private void renewalTimer_Tick(object sender, EventArgs e) // renewalTimer bar hareketleri
        {
            if (renewalCollapsed)
            {
                renewalContainer.Height += 10;
                if (renewalContainer.Height == renewalContainer.MaximumSize.Height)
                {
                    renewalCollapsed = false;
                    renewalTimer.Stop();
                }
            }
            else
            {
                renewalContainer.Height -= 10;
                if (renewalContainer.Height == renewalContainer.MinimumSize.Height)
                {
                    renewalCollapsed = true;
                    renewalTimer.Stop();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            renewalTimer.Start();
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "DATA or NAME";
                textBox6.ForeColor = Color.Gray;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if(textBox6.Text=="DATA or NAME")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.White;
            }
        }
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        private void musterigetir() // DATAGRİDVİEW İLE ÜYELERİ GÖRÜNTÜLEME
        {
            baglanti = new SqlConnection(@"Data Source=DESKTOP-EPF9A99\SQLEXPRESS;Initial Catalog=gymm;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM gymmMembers",baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void membersForm_Load(object sender, EventArgs e) // FORMLOAD
        {
            musterigetir();
            cancelyes.Width = MinimumSize.Width;
        }

        private void button3_Click(object sender, EventArgs e) // UPLOAD BUTTON
        {
            musterigetir();
            pictureBox6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) // ADD BUTTON
        {
            if (textBox10.Text != "Premium" && textBox10.Text != "Normal" && textBox10.Text != "Low")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox1.Text == "Name DATA" || textBox7.Text == "How many days" || textBox10.Text == "Type")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sorgu = "INSERT INTO gymmMembers(Name,RemainingTime,Type) VALUES (@Name,@RemainingTime,@Type)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Name", textBox1.Text); // Name yi nereden alayım=buradan al
                komut.Parameters.AddWithValue("@RemainingTime", textBox7.Text); // Zamanı i nereden alayım=buradan al
                komut.Parameters.AddWithValue("@Type", textBox10.Text); // ÜYELİK TİPİ
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                pictureBox2.Visible = true;
                label2.Visible = true;
                picture2timer.Start();
                textBox1.Clear();
                textBox7.Clear();
                textBox10.Clear();
                addTimer.Start();
                sidebarTimer.Start();
                pictureBox6.Visible= true;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e) // null
        {
            if (radioButton3.Checked)
            {
                textBox7.Text = "365";
            }
            textBox10.ForeColor = Color.OrangeRed;
            textBox10.Text = "Low";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.ForeColor = Color.White;
            textBox7.Text = "90";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.ForeColor = Color.White;
            textBox7.Text = "180";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton4.Checked)
            {
                textBox7.ForeColor = Color.White;
                textBox7.Text = "270";
            }
            else
            {
                textBox7.ForeColor = Color.White;
                textBox7.Text = "365";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox7.Text = "365";
            }
            textBox10.ForeColor =Color.LightGreen ;
            textBox10.Text = "Premium";
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "How many days")
            {
                textBox7.ForeColor = Color.White;
                textBox7.Text = "";
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.ForeColor = Color.Gray;
                textBox7.Text = "How many days";
            }
        }

        private void button11_Click(object sender, EventArgs e) // SEARCH BUTTON
        {
            string aramaKelimesi = textBox6.Text;

            if (!string.IsNullOrEmpty(aramaKelimesi))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().Contains(aramaKelimesi))
                        {
                            // Eşleşen hücreyi seçin ve DataGridView'ı bu hücreye kaydırın.
                            cell.Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                            return; // İlk eşleşmeyi bulduğumuzda işlemi sonlandırın.
                        }
                    }
                }

                MessageBox.Show("No matches found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Enter the member's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button7_Click(object sender, EventArgs e) // DELETE MEMBER BUTTON
        {
            if (textBox5.Text == "Name DATA" || !int.TryParse(textBox5.Text, out int result))
            {
                MessageBox.Show("Enter the member's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cancelyesTimer.Start();
            }
        }

        private void button6_Click(object sender, EventArgs e) // UPDATE BUTTON CHANGED MEMBER
        {
            if (textBox4.Text=="Name DATA" || textBox8.Text=="How many days" || textBox9.Text=="Type")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sorgu = "UPDATE gymmMembers SET RemainingTime=@RemainingTime, Type=@Type WHERE DATA=@DATA";
                komut=new SqlCommand(sorgu,baglanti);
                komut.Parameters.AddWithValue("DATA",Convert.ToInt32(textBox4.Text));
                komut.Parameters.AddWithValue("RemainingTime",textBox8.Text);
                komut.Parameters.AddWithValue("Type", textBox9.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                musterigetir();
                textBox4.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                label7.Visible = true;
                pictureBox2.Visible = true;
                picture2timer.Start();
                sidebarTimer.Start();
                renewalTimer.Start();
                pictureBox6.Visible = true;
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.ForeColor = Color.Gray;
                textBox9.Text = "Type";
            }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Type")
            {
                textBox9.ForeColor = Color.White;
                textBox9.Text = "";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.ForeColor = Color.Gray;
                textBox4.Text = "Name DATA";
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Name DATA")
            {
                textBox4.ForeColor = Color.White;
                textBox4.Text = "";
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.ForeColor = Color.Gray;
                textBox8.Text = "How many days";
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "How many days")
            {
                textBox8.ForeColor = Color.White;
                textBox8.Text = "";
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                textBox10.ForeColor = Color.Gray;
                textBox10.Text = "Type";
            }
        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            if (textBox10.Text == "Type")
            {
                textBox10.ForeColor = Color.White;
                textBox10.Text = "";
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton10.Checked)
            {
                textBox8.Text = "365";
            }
            textBox9.ForeColor = Color.OrangeRed;
            textBox9.Text = "Low";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                radioButton10.Text = "+9 months";
            }
            else
            {
                radioButton10.Text = "+12 months";
            }
            if (radioButton10.Checked)
            {
                textBox8.Text = "270";
            }
            textBox9.ForeColor = Color.CornflowerBlue;
            textBox9.Text = "Normal";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                textBox8.Text = "365";
            }
            textBox9.ForeColor = Color.LightGreen;
            textBox9.Text = "Premium";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.ForeColor = Color.White;
            textBox8.Text = "90";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.ForeColor = Color.White;
            textBox8.Text = "180";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if(!radioButton7.Checked)
            {
                textBox8.ForeColor = Color.White;
                textBox8.Text = "365";
            }
            else
            {
                textBox8.ForeColor = Color.White;
                textBox8.Text = "270";
            }
        }

        private void picture2timer_Tick(object sender, EventArgs e)
        {
            label2.Visible = false;
            pictureBox2.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            picture2timer.Stop();
        }

        private void savedpanelbar_Paint(object sender, PaintEventArgs e) // null
        {
        }

        private void savedbartimer_Tick(object sender, EventArgs e) // null
        {
        }

        private void button12_Click(object sender, EventArgs e) // null
        {
        }

        private void button12_Click_1(object sender, EventArgs e) // null
        {
        }

        private void cancelyesTimer_Tick(object sender, EventArgs e) //cancel or yes bar hareketleri
        {
            if (cancelyesExopand)
            {
                if (cancelyesExopand)
                {
                    cancelyes.Width -= 10;
                    if (cancelyes.Width == cancelyes.MinimumSize.Width)
                    {
                        cancelyesExopand = false;
                        cancelyesTimer.Stop();
                    }
                }
            }
            else
            {
                cancelyes.Width += 10;
                if (cancelyes.Width == cancelyes.MaximumSize.Width)
                {
                    cancelyesExopand = true;
                    cancelyesTimer.Stop();
                }
            }
        }

        private void button12_Click_2(object sender, EventArgs e)
        {
            cancelyesTimer.Start();
        }

        private void button14_Click(object sender, EventArgs e) // cancelbutton
        {
            cancelyesTimer.Stop();
            textBox5.Text = "";
            cancelyes.Width=MinimumSize.Width;
            deleteTimer.Start();
            sidebarTimer.Start();
        }

        private void button13_Click(object sender, EventArgs e) // yesbutton
        {
            string sorgu = "DELETE FROM gymmMembers WHERE DATA=@DATA";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@DATA", Convert.ToInt32(textBox5.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            musterigetir();
            cancelyes.Width = cancelyes.MinimumSize.Width;
            cancelyesTimer.Stop();
            textBox5.Text = "";
            cancelyes.Width = MinimumSize.Width;
            picture2timer.Start();
            label4.Visible = true;
            pictureBox2.Visible =true;
            deleteTimer.Start();
            sidebarTimer.Start();
            pictureBox6.Visible = true;
        }

        private void timercancel_Tick(object sender, EventArgs e) // null
        {
        }

        private void label3_Click(object sender, EventArgs e) // null
        {
        }

        private void button2_Click(object sender, EventArgs e) // changed button
        {
            int value1;
            if(!int.TryParse(textBox2.Text, out value1))
            {
                MessageBox.Show("Do not enter values\nother than the IDs\nof the members.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Mevcut müşterinin RemainingTime ve Type değerlerini al
                string sorguSelect = "SELECT RemainingTime, Type FROM gymmMembers WHERE DATA = @DATA";
                komut = new SqlCommand(sorguSelect, baglanti);
                komut.Parameters.AddWithValue("@DATA", textBox2.Text); // Mevcut müşterinin adını kullanıyoruz

                baglanti.Open();
                SqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    string remainingTime = reader.GetString(0); // Mevcut müşterinin RemainingTime değeri
                    string typeValue = reader.GetString(1); // Mevcut müşterinin Type değeri

                    reader.Close();

                    // Yeni müşterinin adını al
                    string yeniMusteriAdi = textBox3.Text;

                    // Yeni müşteriyi eklemek için INSERT işlemi
                    string sorguInsert = "INSERT INTO gymmMembers (Name, RemainingTime, Type) VALUES (@Name, @RemainingTime, @Type)";
                    komut = new SqlCommand(sorguInsert, baglanti);
                    komut.Parameters.AddWithValue("@Name", yeniMusteriAdi); // Yeni müşterinin adı
                    komut.Parameters.AddWithValue("@RemainingTime", remainingTime); // Mevcut müşterinin RemainingTime değeri
                    komut.Parameters.AddWithValue("@Type", typeValue); // Mevcut müşterinin Type değeri

                    komut.ExecuteNonQuery();

                    // Mevcut müşteriyi silmek için DELETE işlemi
                    string sorguDelete = "DELETE FROM gymmMembers WHERE DATA = @DATA";
                    SqlCommand komutDelete = new SqlCommand(sorguDelete, baglanti);
                    komutDelete.Parameters.AddWithValue("@DATA", textBox2.Text); // Mevcut müşterinin datası

                    komutDelete.ExecuteNonQuery();
                    label6.Visible = true;
                    pictureBox2.Visible = true;
                    picture2timer.Start();
                    pictureBox6.Visible = true;
                }
                else
                {
                    // Mevcut müşteri bulunamadı veya veriler alınamadı
                    MessageBox.Show("Mevcut müşteri bulunamadı veya veriler alınamadı.");
                }
                musterigetir();
                baglanti.Close();
                textBox2.Text = "";
                textBox3.Text = "";
                transferTimer.Start();
                sidebarTimer.Start();
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e) // null
        {
        }

        private void sidebar_Move(object sender, EventArgs e)
        {
        }

        private void sidebar_MouseEnter(object sender, EventArgs e) // mouse imlecini gördüğünde...
        {
        }

        private void sidebar_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void menuButton_MouseLeave(object sender, EventArgs e)
        {
        }

        private void menuButton_MouseEnter(object sender, EventArgs e)
        {
        }

        private void renewalContainer_MouseEnter(object sender, EventArgs e)
        {
        }

        private void renewalContainer_MouseLeave(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e) // null
        {
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
        }

        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
        }

        private void groupBox3_Enter(object sender, EventArgs e) // null
        {
        }
        private void button12_Click_3(object sender, EventArgs e) // null
        {
        }
    }
}
