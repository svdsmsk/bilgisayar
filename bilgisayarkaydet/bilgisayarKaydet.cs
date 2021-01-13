using DAL;
using Models;
using System;
using System.Data.SqlClient;

namespace bilgisayarkaydet
{
    public class bilgisayarKaydet
    {
        public bool kaydet(models mdl)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@RAM", mdl.PcRAM), new SqlParameter("@HDD", mdl.PcHDD), new SqlParameter("@PSUWATT", mdl.PcPSUWATT), new SqlParameter("@EKRANKARTI", mdl.PcEKRANKARTI), new SqlParameter("@ANAKART", mdl.PcANAKART) };
                dal dl = new dal();
                return dl.ExecuteNonQuery("Insert into bilgisayar values(@RAM, @HDD, @PSUWATT, @EKRANKARTI, @ANAKART)", p) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
