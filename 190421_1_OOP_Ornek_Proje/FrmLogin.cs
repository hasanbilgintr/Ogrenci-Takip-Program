using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190421_1_OOP_Ornek_Proje
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        OkulSabahDBEntities db = new OkulSabahDBEntities();

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1; //resin üstünde label yazı arka plan rengi olmasın diye
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
        }

    private void button1_Click(object sender, EventArgs e) //giriş butonu
        {
            //bool giris1 = db.Kullanicilar.Any(k => k.KullaniciAdi == textBoxKullaniciAdi.Text && k.KullaniciSifre == textBoxSifre.Text);
            Kullanicilar/*var da yazılabilir*/ giris2 = db.Kullanicilar.Where(k => k.KullaniciAdi == textBoxkuladi.Text && k.KullaniciSifre == textBoxsifre.Text).FirstOrDefault();

            if (giris2 != null)
            {
                FrmMenu frm_menu = new FrmMenu();
                frm_menu.labelkuladi.Text = giris2.KullaniciAdi;
                Hide();
                frm_menu.Show();
            }
            label3.Text = "Kullanıcı veya Şifre Yanlış";
        }

        private void button2_Click(object sender, EventArgs e) //direk girmesi için 
        {
            FrmMenu frm_menu = new FrmMenu();
            frm_menu.Show();
        }
    }
}
