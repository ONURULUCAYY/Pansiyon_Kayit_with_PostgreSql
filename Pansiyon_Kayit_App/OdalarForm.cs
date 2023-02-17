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
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pansiyon_Kayit_App
{
    public partial class OdalarForm : Form
    {
        public OdalarForm()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        NpgsqlConnection baglanti = new NpgsqlConnection("Host=localhost; port=5432; Database=AngaraHotelDataBase; username=postgres; password=12345");
        NpgsqlCommand command;
        NpgsqlDataReader reader;
        public string deger2;

        
        private void OdalarForm_Load(object sender, EventArgs e)
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
                //deger2 = "";
                reader.Close();
            }
           baglanti.Close();
            //MessageBox.Show(list[0].ToString() +" "+ list[1].ToString() +" "+ list[2].ToString() +" "+ list[3].ToString() +" "+ list[4].ToString() +" "+ list[7].ToString());
        }
        public int sayi;
        public void RenkAyarla(int gelenSayi)
        {       
            sayi = gelenSayi;
                switch (sayi)
                {
                    case 101: btnOda101.BackColor = Color.Red;  break;
                    case 102: btnOda102.BackColor = Color.Red;  break;
                    case 103: btnOda103.BackColor = Color.Red;  break;
                    case 104: btnOda104.BackColor = Color.Red;  break;
                    case 105: btnOda105.BackColor = Color.Red;  break;
                    case 106: btnOda106.BackColor = Color.Red;  break;
                    case 107: btnOda107.BackColor = Color.Red;  break;
                    case 108: btnOda108.BackColor = Color.Red;  break;
                    case 109: btnOda109.BackColor = Color.Red;  break;
                }
            
        }
        
        private void btnOda101_Click(object sender, EventArgs e)
        {
            btnOda101.Text = list[0].ToString();
            //MessageBox.Show(list[0].ToString());
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            btnOda102.Text = list[1].ToString();       
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            btnOda103.Text = list[2].ToString();
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            btnOda104.Text = list[3].ToString();
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            btnOda105.Text = list[4].ToString();
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            btnOda106.Text = list[5].ToString();
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            btnOda107.Text = list[6].ToString();
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            btnOda108.Text = list[7].ToString();
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            btnOda109.Text = list[8].ToString();
        }
    }
}
