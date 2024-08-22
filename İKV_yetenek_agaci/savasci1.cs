using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İKV_yetenek_agaci
{
    public partial class savasci1 : UserControl
    {
        private int previousValue = 0;
        public savasci1()
        {
       
            InitializeComponent();
            InitializeToolTips();
        }
        private void InitializeToolTips()
        {
            toolTip1 = new ToolTip();
            toolTip1.OwnerDraw = true; // ToolTip'in özel çizim yapmasını sağla
            toolTip1.Draw += new DrawToolTipEventHandler(toolTip1_Draw);
            toolTip1.Popup += new PopupEventHandler(toolTip1_Popup);
            // Label'lar için ToolTip ayarlayın
            toolTip1.SetToolTip(label1, "DEPAR\nSavaşçıların bir yerden bir yere daha hızlı hareket etmelerini sağlar.\n");
            
            toolTip1.SetToolTip(label2, "OFANSİF DÖVÜŞ\nSert vuruş ve Ağır vuruş yapabilmeyi sağlar.Defansif Dövüşme'yi kapatır.Zırhını %25 düşürür ve Maksimum zırh limitini %30 yapar.                    ");
            toolTip1.SetToolTip(label3, "SERT VURUŞ\n Zihni tutulmuş düşmanlara iki kat hasar verir.               ");
            toolTip1.SetToolTip(label4, "DEFANFİS DÖVÜŞ\nSakınma , Kışkırtma , Savaş Narası , Hedef Saptırma yapabilmeyi sağlar.Maksimum zırh limitini %70 yapar.                                                                          ");
            toolTip1.SetToolTip(label5, "KIŞKIRTMA\nYaratığın üzerinde, hiddet oluşturarak, yaratığı savaşçının üzerine çekmeyi sağlar.                                    ");
            toolTip1.SetToolTip(label6, "DİKKAT DAĞITMA\nrakibin saldırısı, savunması ve hareket hızını düşürmesini sağlar.                                                     ");
            toolTip1.SetToolTip(label7, "DURDURMA\n");
            toolTip1.SetToolTip(label8, "SAKINMA\n");
            toolTip1.SetToolTip(label9, "KANATMA\n");
            toolTip1.SetToolTip(label10, "SAVAŞ NARASI\n");
            toolTip1.SetToolTip(label11, "ZİHİN TOPLAMA\n");
            toolTip1.SetToolTip(label12, "SARSILMAZ\n");
            toolTip1.SetToolTip(label13, "SÜPÜRME VURUŞU\n");
            toolTip1.SetToolTip(label14, "HEDEF SAPTIRMA\ngrupta yüksek hasar verme veya çok fazla iyileştirme yapma yolu ile, hiddetleri üstüne çeken kişilere bu yeteneği kullanarak, o kişinin yarattığı hiddetin %60'ını kendi üzerine çeker.                                                                                                         ");
            toolTip1.SetToolTip(label15, "AĞIR VURUŞ\ndüşmanınıza yüksek hasar verirsiniz                                 ");
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            // Kalın yazı tipini oluştur
            Font boldFont = new Font(e.Font, FontStyle.Bold);
            // Arka planı ve kenarlıkları çiz
            e.DrawBackground();
            e.DrawBorder();
            // Metni kalın yazı tipinde çiz
            e.Graphics.DrawString(e.ToolTipText, boldFont, Brushes.Black, e.Bounds);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            // Tooltip'in boyutunu geniş bir alana ayarla
            string toolTipText = toolTip1.GetToolTip(e.AssociatedControl);
            using (Font boldFont = new Font(e.AssociatedControl.Font, FontStyle.Bold))
            {
                Size textSize = TextRenderer.MeasureText(toolTipText, boldFont, new Size(300, 0), TextFormatFlags.WordBreak);
                e.ToolTipSize = textSize;
            }
        }

        private void savasci1_Load(object sender, EventArgs e)
        {
            // Tüm label kontrollerinin MouseClick olayını aynı metoda yönlendirin
            foreach (Control control in this.Controls)
            {
                if (control is Label && control.Name.StartsWith("label"))
                {
                    control.MouseClick += new MouseEventHandler(Label_MouseClick);
                }
            }
        }


        private void Label_MouseClick(object sender, MouseEventArgs e)
        {
            Label clickedLabel = sender as Label;
            if ((clickedLabel.Name == "label4" || clickedLabel.Name == "label5" || clickedLabel.Name == "label6") && numericUpDown1.Value < 10)
            {
                
                return;
            }
            if ((clickedLabel.Name == "label7" || clickedLabel.Name == "label8" || clickedLabel.Name == "label9") && numericUpDown1.Value < 20)
            {

                return;
            }
            if ((clickedLabel.Name == "label10" || clickedLabel.Name == "label11" || clickedLabel.Name == "label12") && numericUpDown1.Value < 30)
            {

                return;
            }
            if ((clickedLabel.Name == "label13" || clickedLabel.Name == "label14" || clickedLabel.Name == "label15") && numericUpDown1.Value < 40)
            {

                return;
            }
            Label label = sender as Label;
            int currentValue = int.Parse(label.Text);
            int value = int.Parse(label17.Text);

            if (currentValue < 15 && value > 0 && e.Button == MouseButtons.Left)
            {
                currentValue++;
                value--;
            }
            else if (currentValue > 0 && e.Button == MouseButtons.Right)
            {
                currentValue--;
                value++;
            }            
            label.Text = currentValue.ToString();
            label17.Text = value.ToString();
            UpdateLabel19();
        }
        private void UpdateLabel19()
        {
            label19.Text = ""; // Önce label19'un içeriğini temizle           
                string skill_con="";                
                if (int.Parse(label1.Text) >= 1)
                {
                    double duration = 4.5+ double.Parse(label1.Text) / 2;
                    int speed = 50;
                    if(int.Parse(label1.Text) >= 5)
                    {
                        speed = 100;
                        if(int.Parse(label1.Text) >= 10)
                        {
                            speed = 150;
                        }
                    }
                    skill_con = skill_con + "\fDEPAR\n" + "Savaşçıların bir yerden bir yere daha hızlı\nhareket etmelerini sağlar. Ancak asıl amacı,\noyuncuya karşı oyuncu müsabakalarında\ndüşmanların yakınına ulaşımı hızlandırarak\nyakın dövüşe girmeyi sağlamaktır.\n\n";
                    skill_con = skill_con + $"Hareket hızı artışı: %{speed}\nEtki süresi: {duration}'sn\nBekleme süresi: 40'sn\n";
                }
            skill_con = skill_con + "---------------------------------------\n";
            if (int.Parse(label2.Text) >= 1)
                {
                    int dmg = 10;
                    dmg = dmg + (int.Parse(label2.Text) * 2);
                    skill_con = skill_con + "\fOFANSİf DÖVÜŞME\n" + "Sert vuruş ve Ağır vuruş yapabilmeyi sağlar.\nZırhını %25 düşürür\nMaksimum zırh limitini %30 yapar.\nEtki süresi sınırsızdır.\n\n";
                      if(int.Parse(label2.Text) == 15)
                      {
                        skill_con = skill_con + "Sert vuruş ve Ağır Vuruş'un hasarları\nsilaha bağlı olarak artar.\n";
                      }
                    skill_con = skill_con + $"Saldırı artışı: {dmg}\n";
                    skill_con = skill_con + $"Savunma düşüşü: -{dmg}\n";
                skill_con = skill_con + "---------------------------------------\n";
            }
                if (int.Parse(label3.Text) >= 1)
                {
                    int free = 0;
                int cd = 10;
                    if(int.Parse(label3.Text) >= 5)
                    {
                        free = 10;
                        if(int.Parse(label3.Text) >= 10)
                        {
                           cd = 5;
                           free = 5;
                        }
                    }
                    int dmg = 0;
                    dmg = dmg + (int.Parse(label3.Text) * 3);
                    skill_con = skill_con + "\fSERT VURUŞ\n" + "Zihni tutulmuş düşmanlara\niki kat hasar verir.\n\n";
                      if(int.Parse(label3.Text) >= 5)
                      {
                      skill_con = skill_con + $"Bedelsiz Yetenek Şansı: %{free}\n";
                      }
                    skill_con = skill_con + $"Sert vuruş hasarı: %{dmg}\n";
                    skill_con = skill_con + $"Bekleme Süresi: {cd}\n";
                skill_con = skill_con + "---------------------------------------\n";
            }
            if (int.Parse(label4.Text) >= 1)
            {
                int def = 10;
                def = def + (int.Parse(label4.Text) * 2);
                skill_con = skill_con + "\fDEFANSİf DÖVÜŞME\n" + "Ofansif Dövüşme'yi kapatır.Sakınma.\nMaksimum zırh limitini %70 yapar.\nEtki süresi sınırsızdır.\n\n";
                skill_con = skill_con + $"Artan Savunma: %{def}\n";
                if (int.Parse(label4.Text) == 15)
                {
                    skill_con = skill_con + "Kıyafetten gelen zırh bonusunun 1/4 katı kadar\nfiziksel saldırıdan hiç hasar almama ihtimali\n";
                }
                skill_con = skill_con + "---------------------------------------\n";
            }
            if (int.Parse(label5.Text) >= 1)
            {
                int hid = 0;
                double men = 0;
                int kk = 25;
                men = men + (int.Parse(label5.Text) * 1.25);
                hid = hid + (int.Parse(label5.Text) * 5);
                skill_con = skill_con + "\fKIŞKIRTMA\n" + "yaratığı savaşçının üzerine çeker\n\n";
                skill_con = skill_con + $"Hiddet miktarı: %{hid}\n";
                skill_con = skill_con + $"Menzil artışı: %{men}\n";
                if (int.Parse(label5.Text) >= 5)
                {
                    if(int.Parse(label5.Text) >= 10)
                    {
                        kk = 50;
                    }
                    skill_con = skill_con + $"Azaltılan kudret gereksinimi: %{kk}\n";
                }
               
                skill_con = skill_con + "---------------------------------------\n";
            }
            if (int.Parse(label6.Text) >= 1)
            {
                int def = 9;
                int duration = 10;
                double men= 0;
                int speed = 5;
                men = men + (int.Parse(label6.Text)*1.25);
                def = def + int.Parse(label6.Text);
                if (int.Parse(label6.Text) >= 10)
                {
                    def++;
                    if (int.Parse(label6.Text) >= 11)
                    {
                        def++;
                        if (int.Parse(label6.Text) >= 12)
                        {
                            def++;
                            if (int.Parse(label6.Text) >= 13)
                            {
                                def++;
                                if (int.Parse(label6.Text) >= 14)
                                {
                                    def++;
                                    if (int.Parse(label6.Text) >= 15)
                                    {
                                        def++;
                                    }
                                }
                            }
                        }
                    }
                   
                    
                }

                skill_con = skill_con + "\fDİKKAT DAĞITMA\n" + "\nSavaşçının, rakibin saldırısı, savunması ve hareket hızını düşürmesini sağlar.\n\n";
                
                skill_con = skill_con + $"Düşürülen savunma: -{def}\n";
                skill_con = skill_con + $"Düşürülen saldırı: -{def}\n";
                if (int.Parse(label6.Text) >= 5)
                {
                    duration = 15;
                    if (int.Parse(label6.Text) >= 10)
                    {
                        duration = 20;
                        speed = 15;
                        if (int.Parse(label6.Text) >= 15)
                        {
                            duration = 30;
                            speed = 25;
                        }
                    }
                    skill_con = skill_con + $"Hareket hızı azaltma: %{speed}\n";
                }
                skill_con = skill_con + $"Menzil artışı: %{men}\n";
                skill_con = skill_con + $"Etki süresi: {duration}'sn\n";
                
                
                skill_con = skill_con + "---------------------------------------\n";
            }
            //yetenek açıklamaları devamını buraya yaz

            label19.Text += skill_con;
            
              
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int currentValue = (int)numericUpDown1.Value; // Mevcut değeri al
            // Mevcut Label değerini al
            int support_value = int.Parse(label17.Text);
            support_value = support_value - 2;
                if (currentValue > previousValue)
                {
                    // Artırma işlemi
                    int newLabelValue = int.Parse(label17.Text) + 2;
                    label17.Text = newLabelValue.ToString();
                previousValue = currentValue; // Önceki değeri güncelle
            }
                else if (currentValue < previousValue)
                {
                     if (support_value <= -1)
                     {
                        MessageBox.Show("Mevcut Seviye Kullanılan Yetenek Puanını Aşıyor!");
                        numericUpDown1.Value = currentValue+1;
                     }
                     else
                     {
                             // Azaltma işlemi
                           int newLabelValue = int.Parse(label17.Text) - 2;
                          label17.Text = newLabelValue.ToString();
                    previousValue = currentValue; // Önceki değeri güncelle
                }
                
                }
                
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
       
        private void label1_MouseClick(object sender, MouseEventArgs e)
        {

            // Label'in mevcut değerini al
            //int currentValue = int.Parse(label1.Text);
            //int Value = int.Parse(label17.Text);
            //if(currentValue < 15 && Value > 0)
            //{
            //    if (e.Button == MouseButtons.Left)
            //    {
            //        // Sol tık ise artırma işlemi
            //        currentValue++;
            //        Value--;
            //    }
            //}
            //if(currentValue > 0)
            //{
            //    if (e.Button == MouseButtons.Right)
            //    {
            //        // Sağ tık ise azaltma işlemi
            //        currentValue--;
            //        Value++;
            //    }
            //}
            
           

            //// Yeni değeri Label'in Text özelliğine yaz
            //label1.Text = currentValue.ToString();
            //label17.Text = Value.ToString();
        }

        private void savasci1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label15_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int value = int.Parse(label17.Text);
            if (checkBox1.Checked == true) 
            {
                value = value + 5;
                label17.Text = value.ToString();
            }
            else if (checkBox1.Checked == false) 
            {
                
                value = value - 5;
                if(value < 0)
                {
                    checkBox1.Checked = true;
                    value = value + 5;
                    label17.Text = value.ToString();
                }
                else
                {
                    label17.Text = value.ToString();
                }
               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int total = 0;
            int load = int.Parse(label17.Text);
            // label1'den label15'e kadar olan labellerin değerlerini topla
            for (int i = 1; i <= 15; i++)
            {
                Label label = this.Controls["label" + i] as Label;
                if (label != null)
                {
                    int value;
                    if (int.TryParse(label.Text, out value))
                    {
                        total += value;
                        label.Text = "0"; // Label değerini 0'a indir
                    }
                }
            }
            total = total + load;
            label17.Text = total.ToString();
            label19.Text = "";
        }
    }
 }

