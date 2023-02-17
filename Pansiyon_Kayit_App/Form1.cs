using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace Pansiyon_Kayit_App
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Host=localhost; port=5432; Database=AngaraHotelDataBase; username=postgres; password=12345");
        NpgsqlCommand command;
        NpgsqlDataReader reader;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try 
            {
                baglanti.Open();
                command = new NpgsqlCommand();
                command.Connection = baglanti;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from logindatabase where kullaniciad=@kullaniciadi AND sifre=@sifresi";
                NpgsqlParameter parameter1 = new NpgsqlParameter("kullaniciadi", txtKullanici.Text.Trim());
                NpgsqlParameter parameter2 = new NpgsqlParameter("sifresi", txtSifre.Text.Trim());
                command.Parameters.Add(parameter1);
                command.Parameters.Add(parameter2);

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    if (dt.Rows.Count>0)
                    {
                        command = new NpgsqlCommand();
                        command.Connection = baglanti;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "update logindatabase set onayla='1'";
                        command.ExecuteNonQuery();
                        baglanti.Close();

                        AnaSayfaForm anaSayfaForm = new AnaSayfaForm();
                        anaSayfaForm.Show();
                        this.Close();
                    }
                    
                }
                //command.Dispose();
                
            }
            catch (Exception)
            {             
                MessageBox.Show("Hatalý Giriþ");
                baglanti.Close();
            }

        }
    }
}