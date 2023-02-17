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
    public partial class MusteriListeleForm : Form
    {
        public MusteriListeleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGoster();
            //DataGrideCek();
        }

        private void VerileriGoster()
        {
            listView1.Items.Clear();
            NpgsqlConnection baglanti = new NpgsqlConnection("Host=localhost; port=5432; Database=AngaraHotelDataBase; username=postgres; password=12345");
            baglanti.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = baglanti;
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from musteritable";
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["musteriid"].ToString();
                listViewItem.SubItems.Add(reader["cinsiyet"].ToString());
                listViewItem.SubItems.Add(reader["adi"].ToString());
                listViewItem.SubItems.Add(reader["soyadi"].ToString());
                listViewItem.SubItems.Add(reader["telefon"].ToString());
                listViewItem.SubItems.Add(reader["mail"].ToString());
                listViewItem.SubItems.Add(reader["tc"].ToString());
                listViewItem.SubItems.Add(reader["odano"].ToString());
                listViewItem.SubItems.Add(reader["ucret"].ToString());
                listViewItem.SubItems.Add(reader["giristarihi"].ToString());
                listViewItem.SubItems.Add(reader["cikistarihi"].ToString());
                listViewItem.SubItems.Add(reader["yemek"].ToString());
                listViewItem.SubItems.Add(reader["havuz"].ToString());
                listViewItem.SubItems.Add(reader["masaj"].ToString());

                listView1.Items.Add(listViewItem);
            }
            baglanti.Close();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Host=localhost; port=5432; Database=AngaraHotelDataBase; username=postgres; password=12345");
        NpgsqlCommand komut;
        private void DataGrideCek()
        {
            try
            {
                //NpgsqlConnection baglanti = new NpgsqlConnection("Host=localhost; port=5432; Database=AngaraHotelDataBase; username=postgres; password=12345");
                baglanti.Open();
                //NpgsqlCommand command = new NpgsqlCommand();
                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;
                komut.CommandText = "select * from musteritable";
                NpgsqlDataReader dr = komut.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                }
                komut.Dispose();
                komut.Clone();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        int id = 0;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            comboBoxCinsiyet.SelectedItem = listView1.SelectedItems[0].SubItems[1].Text;
            txtMusteriAdi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtMusteriSoyadi.Text = listView1.SelectedItems[0].SubItems[3].Text;
            maskedTelno.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMusteriMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtTCno.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;

            string yemek = listView1.SelectedItems[0].SubItems[11].Text;
            string havuz = listView1.SelectedItems[0].SubItems[12].Text;
            string masaj = listView1.SelectedItems[0].SubItems[13].Text;
            if (yemek == "True")
                checkBoxYemek.Checked = true;
            if (havuz == "True")
                checkBoxHavuz.Checked = true;
            if (masaj == "True")
                checkBoxMasaj.Checked = true;
            
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new NpgsqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText = "delete from musteritable where musteriid=("+id+")"; // tablomuzdaki musteriid'nin seçili olduğu endeksi siliyoruz
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            comboBoxCinsiyet.Text= string.Empty;
            txtMusteriAdi.Text = string.Empty;
            txtMusteriSoyadi.Text = string.Empty;
            txtTCno.Text = string.Empty;
            maskedTelno.Text = string.Empty;
            txtMusteriMail.Text = string.Empty;           
            txtOdaNo.Text = string.Empty;
            txtUcret.Text = "";
            dtpGirisTarihi.Text = string.Empty;
            dtpCikisTarihi.Text = string.Empty;
            checkBoxYemek.Checked = false;
            checkBoxHavuz.Checked = false;
            checkBoxMasaj.Checked = false;
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new NpgsqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText = "update musteritable set cinsiyet='" + comboBoxCinsiyet.SelectedItem + "', adi='" + txtMusteriAdi.Text + "',soyadi='" + txtMusteriSoyadi.Text + "',telefon='" + maskedTelno.Text + "',mail='" + txtMusteriMail.Text + "',tc='" + txtTCno.Text + "',odano='" + txtOdaNo.Text + "',ucret='" + txtUcret.Text + "',giristarihi='" + dtpGirisTarihi.Value + "',cikistarihi='" + dtpCikisTarihi.Value + "',yemek='" + checkBoxYemek.Checked + "',havuz='" + checkBoxHavuz.Checked + "',masaj='" + checkBoxMasaj.Checked + "' where musteriid=" + id + ""; 
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            NpgsqlConnection baglanti = new NpgsqlConnection("Host=localhost; port=5432; Database=AngaraHotelDataBase; username=postgres; password=12345");
            baglanti.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = baglanti;
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from musteritable where tc like '%" + txtAra.Text + "%'";
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["musteriid"].ToString();
                listViewItem.SubItems.Add(reader["cinsiyet"].ToString());
                listViewItem.SubItems.Add(reader["adi"].ToString());
                listViewItem.SubItems.Add(reader["soyadi"].ToString());
                listViewItem.SubItems.Add(reader["telefon"].ToString());
                listViewItem.SubItems.Add(reader["mail"].ToString());
                listViewItem.SubItems.Add(reader["tc"].ToString());
                listViewItem.SubItems.Add(reader["odano"].ToString());
                listViewItem.SubItems.Add(reader["ucret"].ToString());
                listViewItem.SubItems.Add(reader["giristarihi"].ToString());
                listViewItem.SubItems.Add(reader["cikistarihi"].ToString());
                listViewItem.SubItems.Add(reader["yemek"].ToString());
                listViewItem.SubItems.Add(reader["havuz"].ToString());
                listViewItem.SubItems.Add(reader["masaj"].ToString());

                listView1.Items.Add(listViewItem);
            }
            baglanti.Close();
        }
    }
}
