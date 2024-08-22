using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İKV_yetenek_agaci
{
    public partial class envanter : UserControl
    {
        public envanter()
        {
            InitializeComponent();
            
        }
        int max_plus = 895;
        double crit_plus = 6.530;
        int hp_plus = 574;
        int element_dmg_plus = 448;
        int e_def_plus = 29;

        int hp = 0;
        int max = 0;
        double def = 0;
        double crit = 1.001;
        int e_def=0;
        int sav = 0;
        int element_dmg = 0;

        bool d = false;

        int eld = 0;
        int ckt= 0;
        int pant= 0;
        int ayak = 0;
        int zirh= 0;
        int silah = 0;

        string model1="Oğuz Kağan";
        string model2 = "Yıldız Alevi";
        string model3 = "Afrikalı Scipio";

        string g;
        string c;
        string p;
        string a;
        string ee;
        string z;
        string s;
        private void envanter_Load(object sender, EventArgs e)
        {
            label2.Text = $"Gözlük: \nCeket: \nPantalon: \nEldiven: \nAyakkabı: \nZırh:  \nSilah:  ";
            label30.Text = $"  {g}\n  {c}\n  {p}\n  {ee}\n  {a}\n  {z}\n  {s}";
            label1.Text = $"Karakter\nSağlık= {hp}\nSavunma= {sav}\nZırh= %{def}\nMaximum Hasar= {max}\nElement Direnci= {e_def}\nKritik Şansı= %{crit}\nHasar(Element)= {element_dmg}";
            
        }

        private void yapıştırToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible) { }
            else
            {
                if (eld == 1)
                {
                    max = max - max_plus;
                    crit = crit - crit_plus;
                    def = def - 10;
                }
                else if (eld == 2)
                {
                    element_dmg = element_dmg - element_dmg_plus;
                    crit = crit - crit_plus;
                    def = def - 10;
                }
                else if (eld == 3)
                {
                    hp = hp - hp_plus;
                    e_def = e_def - e_def_plus;
                    def = def - 10;

                }
            }
            ee = " ";
            envanter_Load(this, EventArgs.Empty);
            panel1.Show();
           
            panel1.BringToFront();
            button1.BringToFront();
           
            button1.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\black.png");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            max = max + max_plus;
            crit = crit +crit_plus;
            def = def  + 10;
            eld = 1;
            ee = model1;
            envanter_Load(this, EventArgs.Empty);
            panel1.Hide();
          
            button1.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\eld.png");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            crit = crit + crit_plus;
            element_dmg = element_dmg + element_dmg_plus;
            def = def + 10;
            eld = 2;
            ee = model2;
            envanter_Load(this, EventArgs.Empty);
            panel1.Hide();
          
            button1.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\eld.png");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            hp = hp + hp_plus;
            e_def = e_def + e_def_plus;
            def = def + 10;
            eld = 3;
            ee = model3;
            envanter_Load(this, EventArgs.Empty);
            panel1.Hide();
        
            button1.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\eld.png");
        }

        private void label20_Click(object sender, EventArgs e)
        {
            max = max + max_plus;
            crit = crit + crit_plus;
            def = def + 10;
            ckt = 1;
            c = model1;
            envanter_Load(this, EventArgs.Empty);
            panel6.Hide();
           
            button2.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\ckt.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel6.Visible) { }
            else
            {
                if (ckt == 1)
                {
                    max = max - max_plus;
                    crit = crit - crit_plus;
                    def = def - 10;
                }
                else if (ckt == 2)
                {
                    element_dmg = element_dmg - element_dmg_plus;
                    crit = crit - crit_plus;
                    def = def - 10;
                }
                else if (ckt == 3)
                {
                    hp = hp - hp_plus;
                    e_def = e_def - e_def_plus;
                    def = def - 10;
                }
            }
            c = " ";
            envanter_Load(this, EventArgs.Empty);
            panel6.Show();
            panel6.BringToFront();
            button2.BringToFront();
     
            button2.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\black.png");
        }

        private void label19_Click(object sender, EventArgs e)
        {

            crit = crit + crit_plus;
            element_dmg = element_dmg + element_dmg_plus;
            def = def + 10;
            ckt = 2;
            c = model2;
            envanter_Load(this, EventArgs.Empty);
            panel6.Hide();
           
            button2.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\ckt.png");
        }

        private void label18_Click(object sender, EventArgs e)
        {
            hp = hp + hp_plus;
            e_def = e_def + e_def_plus;
            def = def + 10;
            ckt = 3;
            c = model3;
            envanter_Load(this, EventArgs.Empty);
            panel6.Hide();
        
            button2.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\ckt.png");
        }

        private void label23_Click(object sender, EventArgs e)
        {
            max = max + max_plus;
            crit = crit + crit_plus;
            def = def + 10;
            pant = 1;
            p = model1;
            envanter_Load(this, EventArgs.Empty);
            panel7.Hide();
           
            button4.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\pant.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panel7.Visible) { }
            else
            {
                if (pant == 1)
                {
                    max = max - max_plus;
                    crit = crit - crit_plus;
                    def = def - 10;
                }
                else if (pant == 2)
                {
                    element_dmg = element_dmg - element_dmg_plus;
                    crit = crit - crit_plus;
                    def = def - 10;
                }
                else if (pant == 3)
                {
                    hp = hp - hp_plus;
                    e_def = e_def - e_def_plus;
                    def = def - 10;
                }
            }
            p = " ";
            envanter_Load(this, EventArgs.Empty);
            panel7.Show();
            panel7.BringToFront();
            button4.BringToFront();
         
            button4.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\black.png");
        }

        private void label22_Click(object sender, EventArgs e)
        {

            crit = crit + crit_plus;
            element_dmg = element_dmg + element_dmg_plus;
            def = def + 10;
            pant = 2;
            p = model2;
            envanter_Load(this, EventArgs.Empty);
            panel7.Hide();
            
            button4.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\pant.png");
        }

        private void label21_Click(object sender, EventArgs e)
        {
            hp = hp + hp_plus;
            e_def = e_def + e_def_plus;
            def = def + 10;
            pant = 3;
            p = model3;
            envanter_Load(this, EventArgs.Empty);
            panel7.Hide();
            
            button4.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\pant.png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panel8.Visible) { }
            else
            {
                if (ayak == 1)
                {
                    max = max - max_plus;
                    crit = crit - crit_plus;
                    def = def - 10;
                }
                else if (ayak == 2)
                {
                    element_dmg = element_dmg - element_dmg_plus;
                    crit = crit - crit_plus;
                    def = def - 10;
                }
                else if (ayak == 3)
                {
                    hp = hp - hp_plus;
                    e_def = e_def - e_def_plus;
                    def = def - 10;
                }
            }
            a = " ";
            envanter_Load(this, EventArgs.Empty);
            panel8.Show();
            panel8.BringToFront();
            button5.BringToFront();
         
            button5.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\black.png");
        }

        private void label26_Click(object sender, EventArgs e)
        {
            max = max + max_plus;
            crit = crit + crit_plus;
            def = def + 10;
            ayak = 1;
            a = model1;
            envanter_Load(this, EventArgs.Empty);
            panel8.Hide();
           
            button5.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\ayak.png");
        }

        private void label25_Click(object sender, EventArgs e)
        {

            crit = crit + crit_plus;
            element_dmg = element_dmg + element_dmg_plus;
            def = def + 10;
            ayak = 2;
            a = model2;
            envanter_Load(this, EventArgs.Empty);
            panel8.Hide();
            
            button5.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\ayak.png");
        }

        private void label24_Click(object sender, EventArgs e)
        {
            hp = hp + hp_plus;
            e_def = e_def + e_def_plus;
            def = def + 10;
            ayak = 3;
            a = model3;
            envanter_Load(this, EventArgs.Empty);
            panel8.Hide();
           
            button5.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\ayak.png");
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void envanter_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Hide();
                eld = 0;
            }
            if (panel6.Visible)
            {
                panel6.Hide();
                ckt = 0;
            }
            if (panel7.Visible)
            {
                panel7.Hide();
                pant = 0;
            }
            if (panel8.Visible)
            {
                panel8.Hide();
                ayak = 0;
            }
            if (panel9.Visible)
            {
                panel9.Hide();
                zirh = 0;
            }

            if (panel10.Visible)
            {
                panel10.Hide();
                silah = 0;
            }






        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Hide();
                eld = 0;
            }
            if (panel6.Visible)
            {
                panel6.Hide();
                ckt = 0;
            }
            if (panel7.Visible)
            {
                panel7.Hide();
                pant = 0;
            }
            if (panel8.Visible)
            {
                panel8.Hide();
                ayak = 0;
            }
            if (panel9.Visible)
            {
                panel9.Hide();
                zirh = 0;
            }
            if (panel10.Visible)
            {
                panel10.Hide();
                silah = 0;
            }

        }

        private void label29_Click(object sender, EventArgs e)
        {
            max = max + max_plus;
            crit = crit + crit_plus;
            def = def + 10;
            zirh = 1;
            z = model1;
            envanter_Load(this, EventArgs.Empty);
            panel9.Hide();
           
            button3.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\zirh.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel9.Visible) { }
            else
            {
                if (zirh == 1)
                {
                    max = max - max_plus;
                    crit = crit - crit_plus;
                    def = def - 10;
                }
                else if (zirh == 2)
                {
                    element_dmg = element_dmg - element_dmg_plus;
                    crit = crit - crit_plus;
                    def = def - 10;
                }
                else if (zirh == 3)
                {
                    hp = hp - hp_plus;
                    e_def = e_def - e_def_plus;
                    def = def - 10;
                }
            }
            z = " ";
            envanter_Load(this, EventArgs.Empty);
            panel9.Show();
            panel9.BringToFront();
            button3.BringToFront();

            button3.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\black.png");
        }

        private void label28_Click(object sender, EventArgs e)
        {

            crit = crit + crit_plus;
            element_dmg = element_dmg + element_dmg_plus;
            def = def + 10;
            zirh = 2;
            z = model2;
            envanter_Load(this, EventArgs.Empty);
            panel9.Hide();
          
            button3.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\zirh.png");
        }

        private void label27_Click(object sender, EventArgs e)
        {
            hp = hp + hp_plus;
            e_def = e_def + e_def_plus;
            def = def + 10;
            zirh = 3;
            z = model3;
            envanter_Load(this, EventArgs.Empty);
            panel9.Hide();
           
            button3.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\zirh.png");
            
        }

      

        private void button6_Click(object sender, EventArgs e)
        {
            if (panel10.Visible) { }
            else
            {
                if (silah == 1)
                {
                    max = max - max_plus;
                    crit = crit - crit_plus;
                   
                }
                else if (silah == 2)
                {
                    element_dmg = element_dmg - element_dmg_plus;
                    crit = crit - crit_plus;
                   
                }
                else if (silah == 3)
                {
                    hp = hp - hp_plus;
                    e_def = e_def - e_def_plus;
                  
                }
                if (silah == 4)
                {
                    max = max - max_plus - max_plus;
                    crit = crit - crit_plus - crit_plus;

                }
                else if (silah == 5)
                {
                    element_dmg = element_dmg - element_dmg_plus - element_dmg_plus;
                    crit = crit - crit_plus - crit_plus;

                }
                else if (silah == 6)
                {
                    hp = hp -hp_plus- hp_plus;
                    e_def = e_def - e_def_plus - e_def_plus;

                }
            }
            s = " ";
            envanter_Load(this, EventArgs.Empty);
            panel10.Show();
            panel10.BringToFront();
            button6.BringToFront();

            button6.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\black.png");
        }
        private void label33_Click(object sender, EventArgs e)
        {
            max = max + max_plus;
            crit = crit + crit_plus;

            silah = 1;
            s = model1;
            envanter_Load(this, EventArgs.Empty);
            panel10.Hide();

            button6.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\balta.png");
        }
        private void label34_Click(object sender, EventArgs e)
        {
            max = max+max_plus + max_plus;
            crit = crit + crit_plus + crit_plus;
          
           silah = 4;
            s = model1+"*";
            envanter_Load(this, EventArgs.Empty);
            panel10.Hide();

            button6.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\balta.png");
        }

        private void label31_Click(object sender, EventArgs e)
        {
            hp = hp + hp_plus;
            e_def = e_def + e_def_plus;
        
            silah = 3;
            s = model3;
            envanter_Load(this, EventArgs.Empty);
            panel10.Hide();

            button6.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\balta.png");
        }
        private void label35_Click(object sender, EventArgs e)
        {
            hp = hp + hp_plus + hp_plus;
            e_def = e_def + e_def_plus + e_def_plus;

            silah = 6;
            s = model3+"*";
            envanter_Load(this, EventArgs.Empty);
            panel10.Hide();

            button6.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\balta.png");
        }
       

        private void label32_Click(object sender, EventArgs e)
        {
            crit = crit + crit_plus;
            element_dmg = element_dmg + element_dmg_plus;

            silah = 2;
            s = model2;
            envanter_Load(this, EventArgs.Empty);
            panel10.Hide();

            button6.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\balta.png");
        }
        private void label36_Click(object sender, EventArgs e)
        {
            crit = crit + crit_plus + crit_plus;
            element_dmg = element_dmg + element_dmg_plus + element_dmg_plus;
   
            silah = 5;
            s = model2+"*";
            envanter_Load(this, EventArgs.Empty);
            panel10.Hide();

            button6.Image = Image.FromFile(@"C:\Users\mastarichy\source\repos\İKV_yetenek_agaci\İKV_yetenek_agaci\Resources\balta.png");
        }

    }
}
