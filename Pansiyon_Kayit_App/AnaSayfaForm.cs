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
    public partial class AnaSayfaForm : Form
    {
        public AnaSayfaForm()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Host=localhost; port=5432; Database=AngaraHotelDataBase; username=postgres; password=12345");
        NpgsqlCommand command;
        NpgsqlDataReader reader;
        public string deger ="0";
        private void AnaSayfaForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            command = new NpgsqlCommand();
            command.Connection = baglanti;
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from logindatabase"; // where onayla like '1'";

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                deger = reader["onayla"].ToString();
                if (deger == "0")
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button8.Enabled = false;
                    btnMaas.Enabled = false;
                    btnStok.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button8.Enabled = true;
                    btnMaas.Enabled = true;
                    btnStok.Enabled = true;
                }
            }
            baglanti.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogn= new AdminLogin();
            adminLogn.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YeniMusteriForm yeniMusteriForm = new YeniMusteriForm();
            yeniMusteriForm.Show();
            //this.Hide();
        }
        public bool girildi=false;
        private void button3_Click(object sender, EventArgs e)
        {
            OdalarForm odalarForm = new OdalarForm();
            if (girildi == false)
            {
                odalarForm.Show();
                girildi = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriListeleForm musteriListeleForm = new MusteriListeleForm();
            musteriListeleForm.Show();
           // this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Angara Hotel Kayıt Uygulaması / 2023 ANKARA");
        }

        
        
       
        private void button8_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            command = new NpgsqlCommand();
            command.Connection = baglanti;
            command.CommandType = CommandType.Text;
            command.CommandText = "update logindatabase set onayla='0'";
            command.ExecuteNonQuery();
            baglanti.Close();
            //this.Close();
            Application.Exit();
            //this.Refresh();
        }

        private void btnMaas_Click(object sender, EventArgs e)
        {
            GelirGiderForm gelirGider = new GelirGiderForm();
            gelirGider.Show();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            StokKontrolForm stok = new StokKontrolForm();
            stok.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MusteriMesajForm musteriMesajForm   = new MusteriMesajForm();
            musteriMesajForm.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O kadar şey yaptım bunu da yapması basit o yüzden böyle kalsın :)");
        }
    }
}
