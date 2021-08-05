using SinemaOtomasyonu.Repositories;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            jsonManagement = new JsonManagement();         
            rezervasyonSayisi = new RezervasyonSayisiManagement();
            
        }
        MusteriManagement musteriManagement;
        JsonManagement jsonManagement;
        RezervasyonSayisiManagement rezervasyonSayisi;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            jsonManagement.DeserializeMusteriler();
            musteriManagement = new MusteriManagement(jsonManagement.GetDeserializedMusteriler());
            for (int i = 1; i <= 60; i++)
            {

                Button btn = new Button();
                btn.Width = 50;
                btn.Height = 50;
                btn.Tag = true;
                btn.Text = i.ToString();
                DoluKoltukCheck(btn);
                btn.Click += KoltukClick;
                flowLayoutPanel1.Controls.Add(btn);
                if (i == 8)
                {
                    flowLayoutPanel1.SetFlowBreak(btn, true);

                }
                if (i == 20)
                {
                    flowLayoutPanel1.SetFlowBreak(btn, true);
                    for (int j = 1; j <= 2; j++) //Boşlukları koymak için boş label atadım
                    {
                        Label lblBosluk = new Label();
                        lblBosluk.AutoSize = false;
                        lblBosluk.Width = 50;
                        lblBosluk.Height = 50;
                        lblBosluk.Text = string.Empty;
                        flowLayoutPanel1.Controls.Add(lblBosluk);
                    }
                }
                if (i == 28)
                {
                    flowLayoutPanel1.SetFlowBreak(btn, true);
                }
                if (i == 40)
                {
                    flowLayoutPanel1.SetFlowBreak(btn, true);
                    for (int j = 1; j <= 2; j++)    //Boşlukları koymak için boş label atadım
                    {
                        Label lblBosluk = new Label();
                        lblBosluk.AutoSize = false;
                        lblBosluk.Width = 50;
                        lblBosluk.Height = 50;
                        lblBosluk.Text = string.Empty;
                        flowLayoutPanel1.Controls.Add(lblBosluk);
                    }
                }
                if (i == 48)
                {
                    flowLayoutPanel1.SetFlowBreak(btn, true);
                }


                
            }
        }

        private void KoltukClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Form2 frm2 = new Form2(musteriManagement);
            frm2.Text = btn.Text;
            frm2.ShowDialog();
            DoluKoltukCheck(btn);
        }

        private void DoluKoltukCheck(Button btn)
        {
            Musteri musteri = musteriManagement.GetMusteriBySeatNumber(Convert.ToInt32(btn.Text));
            if (musteri != null)
            {
                btn.BackColor = Color.Blue;
            }
            else
            {
                btn.BackColor = Color.White;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            jsonManagement.SerializeMusteriler();
        }

        private void btnSeyirciSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Toplam kayit sayisi : {rezervasyonSayisi.ToplamKayit(musteriManagement.GetMusteriler())}");
        }

        private void btnKadinErkekSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Toplam Erkek Sayısı : {rezervasyonSayisi.ToplamErkekSayisi(musteriManagement.GetMusteriler())}\nToplam Kadın Sayısı : {rezervasyonSayisi.ToplamKadinSayisi(musteriManagement.GetMusteriler())}");
        }

       
    }
}
