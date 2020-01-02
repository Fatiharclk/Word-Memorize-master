using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WordMemorization
{
    public class SqlBaglantisi
    {
       public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=YAKUP\SQLEXPRESS;Initial Catalog=WordMemorization;Integrated Security=True");
            baglan.Open();
            
            return baglan;
        } 
    }
}
