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
    public partial class MusteriMesajForm : Form
    {
        public MusteriMesajForm()
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
            command.CommandText = "insert into musterimesajlari (adsoyad,mesaj) values('"+ textBox1.Text + "','" + richTextBox1.Text + "')";
            command.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
        }

        private void MusteriMesajForm_Load(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void VerileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            command = new NpgsqlCommand();
            command.Connection = baglanti;
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from musterimesajlari";
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["mesajid"].ToString();
                listViewItem.SubItems.Add(reader["adsoyad"].ToString());
                listViewItem.SubItems.Add(reader["mesaj"].ToString());

                listView1.Items.Add(listViewItem);
            }
            reader.Close();
            baglanti.Close();
        }
    }
}
