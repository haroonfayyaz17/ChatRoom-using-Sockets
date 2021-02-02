using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoomClient
{
    class SQL_Conn
    {
        public SqlConnection con;
        public SQL_Conn()
        {
            con=new SqlConnection(@"Data Source=HAROONGABAENVY\MSSQLSERVER1;Initial Catalog=P2P;Integrated Security=True;multipleactiveresultsets=true");
        }
    }
}
