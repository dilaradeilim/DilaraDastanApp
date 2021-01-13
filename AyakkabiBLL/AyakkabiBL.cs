using AyakkabiApp.Model;
using DAL;
using System;
using System.Data.SqlClient;

namespace AyakkabiBLL
{
    public class AyakkabiBL
    {
        public bool UrunEkle(Ayakkabi ayk)
        {
            try
            {
                if (ayk == null)
                {
                    throw new NullReferenceException("Ayakkabı referansı null geldi");
                }
                SqlParameter[] p =
                {
                    new SqlParameter("@Marka", ayk.Marka),
                    new SqlParameter("@Numara", ayk.Numara),
                    new SqlParameter("@Barkod", ayk.Barkod),
                };

                Helper hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into tblAyakkabi values(@Marka,@Numara,@Barkod)", p) > 0;

            }
            catch (Exception)
            {

                throw;
            }
        }
        
    }
}
