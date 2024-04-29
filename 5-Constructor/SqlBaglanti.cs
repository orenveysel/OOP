using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _5_Constructor
{
    //Singleton Dizayn Pattern
    public class SqlBaglanti
    {
        static SqlConnection baglanti;
        private SqlBaglanti()
        {

        }

        public static SqlConnection BaglantiVer()
        {
            if (baglanti == null)
            {
                baglanti = new SqlConnection();
            }

            return baglanti;

        }
    }
}
