using AyakkabiApp.Model;
using AyakkabiBLL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DilaraDastanApp
{
    public partial class Form1 : Form
    {
        SqlConnection cn = null;
        public int ayakkabiid = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                AyakkabiBL abl = new AyakkabiBL();
                bool sonuc = abl.UrunEkle(new Ayakkabi(txtMarka.Text.Trim(), txtNumara.Text.Trim(), txtBarkod.Text.Trim()));

                if (sonuc)
                {
                    MessageBox.Show("İşlem Başarılı");
                    Temizle();
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız. Tekrar deneyiniz");
                }
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu Barkod Kodu daha önceden kullanılmış");
                        break;

                    case 1225:
                        MessageBox.Show("Veri Tabanı Bağlantısı Kurulamadı.Lütfen tekrar dneyiniz");
                        break;

                    default:
                        break;

                }
                throw;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Sistem Hatası");

            }
            catch (Exception)
            {
                //throw;
                MessageBox.Show("Bir Hata Oluştu");

            }

        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            FrmAyakkabiBul frm = new FrmAyakkabiBul();
            frm.ShowDialog();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Update tblAyakkabi set Marka=@Marka,Numara=@Numara, Barkod=@Barkod where AyakkabiId=@AyakkabiId", cn)
)
                {
                    SqlParameter[] p =
                        { new SqlParameter("@Marka", txtMarka.Text.Trim()),
                        new SqlParameter("@Numara", txtNumara.Text.Trim()),
                        new SqlParameter("@Barkod", txtBarkod.Text.Trim()),
                        new SqlParameter("@AyakkabiId",ayakkabiid) };
                    cmd.Parameters.AddRange(p);
                    if (cn != null && cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                    }

                    int sonuc = cmd.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("İşlem Başarılı");
                        Temizle();

                    }
                    else
                    {
                        MessageBox.Show("İşlem Başarısız");
                    }

                }

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (ayakkabiid == 0)
            {
                MessageBox.Show("Önce Ayakkabı Seçmelisiniz");
            }
            else
            {
                DialogResult cvp = MessageBox.Show("Urunu silmek istediğinizden emin misiniz?", "Kayıt Silme onayı", MessageBoxButtons.YesNo);
                if (cvp == DialogResult.Yes)
                {
                    using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))//garbage collectorün  karışmadığı kaynakları burada yazabiliyoruz
                    {
                        using (SqlCommand cmd = new SqlCommand("Delete from tblAyakkabi where AyakkabiId=@AyakkabiId", cn))
                        {
                            SqlParameter[] p = { new SqlParameter("@AyakkabiId", ayakkabiid) };
                            cmd.Parameters.AddRange(p);
                            if (cn != null && cn.State != ConnectionState.Open)
                            {
                                cn.Open();
                            }

                            int sonuc = cmd.ExecuteNonQuery();
                            if (sonuc > 0)
                            {
                                MessageBox.Show("İşlem Başarılı");
                                Temizle();
                            }
                            else
                            {
                                MessageBox.Show("işlem Başarısız");
                            }

                        }
                    }
                }

                else
                {
                    MessageBox.Show("Urun silme işlemi iptal edildi");
                }
            }
        }
        void Temizle()
        {
            txtMarka.Text = string.Empty;
            txtNumara.Text = string.Empty;
            txtBarkod.Text = string.Empty;
            ayakkabiid = 0;
        }

    }
}


