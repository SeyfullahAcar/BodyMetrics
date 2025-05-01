using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace BodyMetrics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            liste.Items.Add("Adı: "+ad.Text);
            liste.Items.Add("Soyadı: "+soyad.Text);
            liste.Items.Add("Boyu: "+boy.Text);
            liste.Items.Add("Kilosu: "+kilo.Text);
            liste.Items.Add("Yaşı: "+yas.Text);
            liste.Items.Add("Cinsiyeti: "+cinsiyet.Text);
            BedenKitleIndeksi bdi = new BedenKitleIndeksi();
            string cinsiyetiNe = cinsiyet.SelectedItem.ToString();

            if (cinsiyetiNe.Equals("Kadın"))
            {
                bdi.kilosu = Convert.ToInt16(kilo.Text);
                bdi.yasi = Convert.ToInt16(yas.Text);
                bdi.boyu = Convert.ToInt16(boy.Text);
                double hesap = 655.1 + (9.56 * bdi.kilosu) + (1.85 * bdi.boyu)-(4.68 * bdi.yasi);
                

            

                if (hesap > 1400)
                {
                    liste.Items.Add("Bazal Metabolizma Hızı: "+hesap+ " ---> "+"Hızlı");
                }
                else if(hesap > 1000)
                {
                    liste.Items.Add("Bazal Metabolizma Hızı: " + hesap + " ---> " + "Normal");
                }
                else if (hesap > 0)
                {
                    liste.Items.Add("Bazal Metabolizma Hızı: " + hesap + " ---> " + "Yavaş");
                }
                

            }




            else  
            {
                bdi.kilosu = Convert.ToInt16(kilo.Text);
                bdi.yasi = Convert.ToInt16(yas.Text);
                bdi.boyu = Convert.ToInt16(boy.Text);
                double hesap = 66.5 + (13.75 * bdi.kilosu)+(5.03 * bdi.boyu)-(6.75 * bdi.yasi);

                if (hesap > 1600)
                {
                    liste.Items.Add("Bazal Metabolizma Hızı: " + hesap + " ---> " + "Hızlı");
                }
                else if (hesap > 1200)
                {
                    liste.Items.Add("Bazal Metabolizma Hızı: " + hesap + " ---> " + "Normal");
                }
                else if (hesap > 0)
                {
                    liste.Items.Add("Bazal Metabolizma Hızı: " + hesap + " ---> " + "Yavaş");
                }
            }

            
        }
    }
}
