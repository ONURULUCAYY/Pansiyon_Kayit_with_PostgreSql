using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Kayit_App
{
    public partial class GelirGiderForm : Form
    {
        public GelirGiderForm()
        {
            InitializeComponent();
        }

        Npgsql.NpgsqlConnection baglanti;
        NpgsqlCommand baglantiCommand;
        NpgsqlDataReader reader;
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti = new NpgsqlConnection("Host=localhost; port=5432; Database=AngaraHotelDataBase; username=postgres; password=12345");
            baglanti.Open();
            baglantiCommand = new NpgsqlCommand();
            baglantiCommand.Connection = baglanti;
            baglantiCommand.CommandType = CommandType.Text;
            baglantiCommand.CommandText = "select SUM(ucret) as toplam from musteritable"; // where onayla like '1'";
            reader = baglantiCommand.ExecuteReader();

            while (reader.Read())
            {
                KasaToplam = Convert.ToInt32(reader["toplam"].ToString()) ;
                lblKasaToplam.Text = KasaToplam.ToString();
            }
            baglanti.Close();

            personelSayisi = Convert.ToInt32(textBox1.Text);
            personelMaas = (personelSayisi * asgariucret);
            lblPersonelMaas.Text = personelMaas.ToString();

            TOPLAMKarZarar = KasaToplam - (alinanUrunToplami + personelMaas);
            lblSonuc.Text = TOPLAMKarZarar.ToString();
            
        }
        private int alinanUrunToplami = 0;
        private float asgariucret = 8500;
        private int personelSayisi;
        private float personelMaas;
        private float TOPLAMKarZarar;
        private float KasaToplam;
        private void GelirGiderForm_Load(object sender, EventArgs e)
        {
            
            baglanti = new NpgsqlConnection("Host=localhost; port=5432; Database=AngaraHotelDataBase; username=postgres; password=12345");
            baglanti.Open();
            baglantiCommand = new NpgsqlCommand();
            baglantiCommand.Connection = baglanti;
            baglantiCommand.CommandType = CommandType.Text;
            baglantiCommand.CommandText = "select SUM(gida),SUM(alkolluicecekler),SUM(alkolsuzicecekler),SUM(atistirmaliklar),SUM(eturunleri),SUM(tavukurunleri) as toplam from stoktakiler"; // where onayla like '1'";
            reader = baglantiCommand.ExecuteReader();

            while (reader.Read())
            {
                alinanUrunToplami += Convert.ToInt32(reader[0].ToString());
                alinanUrunToplami += Convert.ToInt32(reader[1].ToString());
                alinanUrunToplami += Convert.ToInt32(reader[2].ToString());
                alinanUrunToplami += Convert.ToInt32(reader[3].ToString());
                alinanUrunToplami += Convert.ToInt32(reader[4].ToString());
                alinanUrunToplami += Convert.ToInt32(reader[5].ToString());
                lblAlınanUrunler.Text = alinanUrunToplami.ToString();
            }
            baglanti.Close();
            
            
        }
    }
}
