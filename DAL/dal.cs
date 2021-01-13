using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class dal
    {
        private SqlConnection baglanti = null;

        public int ExecuteNonQuery(string cmd1, SqlParameter[] p = null)
        {
            try
            {
                using (baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(cmd1, baglanti))
                    {
                        if (p != null)
                        {
                            cmd.Parameters.AddRange(p);
                        }
                        if (baglanti != null && baglanti.State != System.Data.ConnectionState.Open)
                        {
                            baglanti.Open();
                        }
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }               
    }
}
