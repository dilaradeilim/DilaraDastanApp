using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DilaraDastanApp
{
    public partial class FrmAyakkabiBul : Form
    {
        SqlConnection cn = null;
        public FrmAyakkabiBul()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            using (cn = new SqlConnection(@"Data Source=localhost; Integrated Security=true; Initial Catalog=AyakkabiDB"))
            {
                using (SqlCommand cmd = new SqlCommand("Select AyakkabiId,Marka,Numara,Barkod from tblAyakkabi where Barkod=@Barkod", cn))
                {
                    SqlParameter[] p =
                        { new SqlParameter("@Barkod", txtBarkodNo.Text.Trim())};
                    cmd.Parameters.AddRange(p);
                    if (cn != null && cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                    }

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Form1 frm = (Form1)Application.OpenForms["Form1"];
                        frm.txtMarka.Text = dr["Marka"].ToString();
                        frm.txtNumara.Text = dr["Numara"].ToString();
                        frm.txtBarkod.Text = dr["Barkod"].ToString();
                        frm.ayakkabiid = Convert.ToInt32(dr["AyakkabiId"]);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Ürün Bulunamadı!");
                    }
                    dr.Close();


                }
            }
        }
    }
}
