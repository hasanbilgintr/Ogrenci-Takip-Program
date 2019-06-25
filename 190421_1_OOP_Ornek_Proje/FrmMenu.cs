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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        /*
         * Açılan herhangi bir formu container yapmak için properties penceresinden IsMDIContainer seçeneğini true yapmak gerekir
        * Burdaki amaç bir projeye bağlı olan bütün form ları tek formda göstermek 
        * Diğer formları menü formunu bir yapısı haline getirmek için MDiParent ile nesneyi this olrak ayarlamak gereklidir.
             */
        Form1 frmsin;
        private void SiniflarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmsin == null || frmsin.IsDisposed)
            {
                frmsin = new Form1(); //açılmasını istediğimiz formun formu nesne olarak tenımladık
                frmsin.MdiParent = this;// nesne değişken ismini MdiParent olarak tanımlamamızın sebebi artık her bu form açılmak istendiğinde menu formunun bir child ı olmsıd için MdiParent bu formda (this) açılmasını istedik.
                frmsin.Show(); //formun açılmasını için show kodunu yazdık
            }
        }

        BranslarForm frmbra;//Form nesnesini bu alanda tanımladık ki her çağrıldığında global değişkenden çağırsın. Bunu sebebi ise yeniden oluşturmasını istemiyoruz. Her yeniden oluşturulduğunda RAM de yük demektir.

        private void BranslarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmbra == null || frmbra.IsDisposed)//nesne formundnu açık olup olmadığ kontrol ediyoruz açık ise if e girmeyecek ve kapatılınca da yeniden tıkladndığında açılmasını isDisdosed açılmasını sağlarız
            { 
                //her açıldığında sağ üst köşesinden açılmasını sağlayın
                //bunuda her formun loadında belirttim
                frmbra = new BranslarForm();
                frmbra.MdiParent = this;
                frmbra.Show();
            }
        }

        frmBolumler frmbolum;

        private void BolumlertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmbolum == null || frmbolum.IsDisposed)
            {
                frmbolum = new frmBolumler();
                frmbolum.MdiParent = this;
                frmbolum.Show();
            }
        }

        formOgrenciler frmogr;

        private void OgrencilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmogr == null || frmogr.IsDisposed)
            {
                frmogr = new formOgrenciler();
                frmogr.MdiParent = this;
                frmogr.Show();
            }
        }

        HOgrencilerForm hfrmogr;

        private void HogrencilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hfrmogr==null || hfrmogr.IsDisposed)
            {
                hfrmogr = new HOgrencilerForm();
                hfrmogr.MdiParent = this;
                hfrmogr.Show(); 
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
