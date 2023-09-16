using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Web;
namespace adminpanel
{
    public class database
    {
       
       
        public static SqlDataAdapter da;
        public static SqlDataReader dr;
        public static DataSet ds;
        public static DataTable dt;
        private static string baglanti = "Data Source=.;Initial Catalog=alisveris;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(baglanti);
        public static SqlCommand cmd = new SqlCommand("", con);
        public  static void OpenConnection()
         {
          try
            {
               if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch(Exception ex)
            {
                //Reponse.Write("Hata Oluştur" + ex.Message);
            }

         }

        public static void CloseConnection()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                ////HttpResponse.Write("Hata Oluştur" + ex.Message);
            }

        }

    }
}