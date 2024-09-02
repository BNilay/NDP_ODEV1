using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NDP_ODEV1


    //                                                  SAKARYA ÜNİVERSİTESİ 
    //                                         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
    //                                             BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
    //                                            NESNEYE DAYALI PROGRAMLAMA DERSİ
    //                                                      1.ÖDEV

    //ÖĞRENCİ NUMARASI: B231210376
    //ÖĞRENCİ ADI: BELKIS NİLAY 
    //ÖĞRENCİ SOYADI: YILMAZ
    //DERSİN ALINDIĞI GRUP: A
    
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosyaadi, dosyayolu;
        private void yeniDosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text)) 
            {
                MessageBox.Show("lütfen dosya adı girin");
                label1.Visible = true;
                textBox1.Visible = true;
                button1.Visible = true;
              
            }
            else
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    dosyayolu = folderBrowserDialog1.SelectedPath.ToString();


                    dosyaadi = textBox1.Text;

                    StreamWriter ws = File.CreateText(dosyayolu + "\\" + dosyaadi + ".txt");
                    ws.Close();
                    MessageBox.Show("Dosya başarıyla oluşturuldu.");
                }
            }

        }

        private void dosyaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Bir Dosya Seçiniz";
            openFileDialog1.FileName = "Dosya seç";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string satir = sr.ReadLine();
                while (satir != null)
                {
                    richTextBox1.Text += satir + Environment.NewLine;
                    satir = sr.ReadLine();
                }

            }
        }
        bool kaydedildi;
        private void dosyaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

            sw.WriteLine(richTextBox1.Text);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                kaydedildi = true;
            }
            else
            { kaydedildi = false; }

            sw.Close();

       
            
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kaydedildi==false)
            {

                MessageBox.Show("DOSYANIZI KAYDETMEDİNİZ");

            }
            else
            {
                Application.Exit();
            }

            

        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
           richTextBox1.Cut();
            MessageBox.Show("Seçilen kısım kesildi");
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           richTextBox1.Copy();
            MessageBox.Show("Seçilen kısım kopyalandı");
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.ForeColor;

            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
            MessageBox.Show("Seçilen kısım kesildi");
        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
            MessageBox.Show("Seçilen kısım kopyalandı");
        }

        private void yapıştırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void beyazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
            MessageBox.Show("Seçilen kısım kesildi");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
            MessageBox.Show("Seçilen kısım kopyalandı");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void arkaPlanRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.ForeColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyayolu = folderBrowserDialog1.SelectedPath.ToString();


                dosyaadi = textBox1.Text;

                StreamWriter ws = File.CreateText(dosyayolu + "\\" + dosyaadi + ".txt");
                ws.Close();
                MessageBox.Show("Dosya başarıyla oluşturuldu.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void yazıÇeşitleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.Font;

            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

      



    }
}
