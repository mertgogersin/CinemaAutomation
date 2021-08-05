using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class Form2 : Form
    {
        public Form2(MusteriManagement _musteriManagement)
        {
            InitializeComponent();
            this.musteriManagement = _musteriManagement;
            musteriler = new List<Musteri>();
            
        }
        MusteriManagement musteriManagement;
        Musteri musteri;
        List<Musteri> musteriler;
        private void Form2_Load(object sender, EventArgs e)
        {
            musteri = musteriManagement.GetMusteriBySeatNumber(Convert.ToInt32(this.Text));
            if(musteri!=null)
            {
                txtAdSoyad.Text = musteri.AdSoyad;
                mtxtKimlikNo.Text = musteri.TcKimlik.ToString();
                if (musteri.Cinsiyet == Cinsiyet.Erkek)
                {
                    rbErkek.Checked = true;
                }
                else if (musteri.Cinsiyet == Cinsiyet.Kadin)
                {
                    rbKadin.Checked = true;
                }
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
          
            if(musteri==null)
            {
                musteri = new Musteri();
                musteri.Id = Convert.ToInt32(this.Text);
                musteri.AdSoyad = txtAdSoyad.Text;
                musteri.TcKimlik = Convert.ToInt64(mtxtKimlikNo.Text);
                if(rbErkek.Checked==true)
                {
                    musteri.Cinsiyet = Cinsiyet.Erkek;
                }
                else if(rbKadin.Checked==true)
                {
                    musteri.Cinsiyet = Cinsiyet.Kadin;
                }

                musteriManagement.AddMusteri(musteri);
                this.Close();
            }
            else
            {
                musteriManagement.UpdateMusteri(musteri, txtAdSoyad.Text, mtxtKimlikNo.Text);
                MessageBox.Show("Rezervasyonunuz güncellenmiştir.");               
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            if(musteri!=null)
            {
                DialogResult dr = MessageBox.Show("Kaydı silmek ister misiniz?","Bilgi",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if(dr==DialogResult.Yes)
                {
                    musteriler = musteriManagement.GetMusteriler();
                    musteriManagement.DeleteMusteri(musteri);
                    MessageBox.Show("Kayıt başarıyla silindi.");
                    ClearControl.ClearControls(this);
                }
            }
            else
            {
                this.Close();
            }          
        }
    }
}
