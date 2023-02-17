using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Kayit_App
{
    public partial class YeniMusteriForm : Form
    {
        public YeniMusteriForm()
        {
            InitializeComponent();
        }

        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = btnOda101.Text;
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = btnOda102.Text;
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = btnOda103.Text;
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = btnOda104.Text;
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = btnOda105.Text;
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = btnOda106.Text;
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = btnOda107.Text;
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = btnOda108.Text;
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = btnOda109.Text;
        }

        private void btnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir");
        }

        private void btnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar dolu odaları gösterir");
        }

        private int Ucret = 0;
        private int GunlukUcret = 50;

        private int YemekUcreti = 200;
        private int HavuzUcreti = 500;
        private int MasajUcreti = 300;


        private float ToplamUcret = 0;
        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            DateTime kucukTarih = Convert.ToDateTime(dtpGirisTarihi.Text);
            DateTime buyukTarih = Convert.ToDateTime(dtpCikisTarihi.Text);
            TimeSpan Sonuc = buyukTarih - kucukTarih;
            lblGun.Text = Sonuc.TotalDays.ToString();

            
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            ToplamUcret = 0;
            Ucret = Convert.ToInt32(lblGun.Text) * GunlukUcret;
            ToplamUcret = ToplamUcret + Ucret;
            MusteriNeisterHesapla();
            txtUcret.Text = ToplamUcret.ToString();
            //MusteriYonet musteriYonet = new MusteriYonet();
            //musteriYonet.Hesapla(ToplamUcret);
            
        }

        private void MusteriNeisterHesapla()
        {
            if (checkBoxYemek.Checked)
                ToplamUcret = ToplamUcret + YemekUcreti;         
            if (checkBoxHavuz.Checked)
                ToplamUcret = ToplamUcret + HavuzUcreti;
            if (checkBoxMasaj.Checked)
                ToplamUcret = ToplamUcret + MasajUcreti;
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Host=localhost; port=5432; Database=AngaraHotelDataBase; username=postgres; password=12345");
        NpgsqlCommand command;
        NpgsqlDataReader reader;
        public string deger2;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            /*select * from musteritable; ** listele 
            ALTER SEQUENCE musteritable_musteriid_seq RESTART WITH 1; /* id no sıfırlama ** */
            try
            {
                baglanti = new NpgsqlConnection("Host=localhost; port=5432; Database=AngaraHotelDataBase; username=postgres; password=12345");
                baglanti.Open();
                //NpgsqlCommand command = new NpgsqlCommand();
                //command.Connection = baglanti;
                //command.CommandType = CommandType.Text;
                //command.CommandText = "select into musteritable (Cinsiyet, Musteriid, Adi, Soyadi,Telefon,Mail, TC, OdaNO, Ucret, GirisTarihi, CikisTarihi, Yemek, Havuz, Masaj) values ('" + comboBoxCinsiyet.Text + "','" + 2 + "','" + txtMusteriAdi + "','" + txtMusteriSoyadi + "','" + maskedTelno.Text + "','" + txtMusteriMail + "','" + txtTCno + "','" + txtOdaNo + "','" + txtUcret + "','" + dtpGirisTarihi.Text + "','" + dtpCikisTarihi + "','" + checkBoxYemek.Checked + "','" + checkBoxHavuz.Checked + "','" + checkBoxMasaj.Checked + "')";
                string sorgu = "insert into musteritable (cinsiyet, adi, soyadi,telefon,mail, tc, odano, ucret, giristarihi, cikistarihi, yemek, havuz, masaj) values ('" + comboBoxCinsiyet.SelectedItem + "','" + txtMusteriAdi.Text + "','" + txtMusteriSoyadi.Text + "','" + maskedTelno.Text + "','" + txtMusteriMail.Text + "','" + txtTCno.Text + "','" + txtOdaNo.Text + "','" + txtUcret.Text + "','" + dtpGirisTarihi.Value + "','" + dtpCikisTarihi.Value + "','" + checkBoxYemek.Checked + "','" + checkBoxHavuz.Checked + "','" + checkBoxMasaj.Checked + "')";
                Npgsql.NpgsqlCommand da = new Npgsql.NpgsqlCommand(sorgu,baglanti);
                da.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kaydedildi");

                //NpgsqlDataReader dr = command.ExecuteReader();
                //if (dr.HasRows)
                //{

                //    MessageBox.Show("kayitVar");

                //    DataTable dt = new DataTable();
                //    dt.Load(dr);
                //    dataGridView1.DataSource = dt;
                //}
                //command.Dispose();
                //command.Clone();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //this.Controls.Clear();
            //this.InitializeComponent();
            this.Refresh();
        }
        List<string> list = new List<string>();
        private void YeniMusteriForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            command = new NpgsqlCommand();
            command.Connection = baglanti;
            command.CommandType = CommandType.Text;
            
            for (int i = 101; i < 110; i++)
            {
                command.CommandText = "select * from musteritable where odano like '%" + i + "%'";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    deger2 = reader["adi"].ToString() + reader["soyadi"].ToString();
                    if (deger2 != null)
                    {
                        RenkAyarla(i);
                    }
                }

                list.Add(deger2);
                deger2 = "";
                reader.Close();
            }
            baglanti.Close();
        }
        public int sayi;
        public void RenkAyarla(int gelenSayi)
        {
            sayi = gelenSayi;
            switch (sayi)
            {
                case 101: btnOda101.BackColor = Color.Red; btnOda101.Enabled = false; break;
                case 102: btnOda102.BackColor = Color.Red; btnOda102.Enabled = false; break;
                case 103: btnOda103.BackColor = Color.Red; btnOda103.Enabled = false; break;
                case 104: btnOda104.BackColor = Color.Red; btnOda104.Enabled = false; break;
                case 105: btnOda105.BackColor = Color.Red; btnOda105.Enabled = false; break;
                case 106: btnOda106.BackColor = Color.Red; btnOda106.Enabled = false; break;
                case 107: btnOda107.BackColor = Color.Red; btnOda107.Enabled = false; break;
                case 108: btnOda108.BackColor = Color.Red; btnOda108.Enabled = false; break;
                case 109: btnOda109.BackColor = Color.Red; btnOda109.Enabled = false; break;
            }

        }
    }
}
