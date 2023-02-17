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
    public partial class StokKontrolForm : Form
    {
        public StokKontrolForm()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Host=localhost; port=5432; Database=AngaraHotelDataBase; username=postgres; password=12345");
        NpgsqlCommand command;
        NpgsqlDataReader reader;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            command = new NpgsqlCommand();
            command.Connection = baglanti;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into stoktakiler(gida,alkolluicecekler,alkolsuzicecekler,atistirmaliklar,eturunleri,tavukurunleri) values ('"+txtGida.Text +"','"+txtAlkol.Text+"','"+txtIcecekler.Text+"','"+txtAtistir.Text+"','"+txtEt.Text+"','"+txtTavuk.Text+"')"; 
            command.ExecuteNonQuery();
            baglanti.Close();
            Veriler();

        }

        private void Veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            command = new NpgsqlCommand();
            command.Connection = baglanti;
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from stoktakiler"; // where onayla like '1'";
            reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["gida"].ToString();
                ekle.SubItems.Add(reader["alkolluicecekler"].ToString());
                ekle.SubItems.Add(reader["alkolsuzicecekler"].ToString());
                ekle.SubItems.Add(reader["atistirmaliklar"].ToString());
                ekle.SubItems.Add(reader["eturunleri"].ToString());
                ekle.SubItems.Add(reader["tavukurunleri"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void StokKontrolForm_Load(object sender, EventArgs e)
        {
            Veriler();
        }
    }
}
