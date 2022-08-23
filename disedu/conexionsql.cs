using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace disedu
{
    public class conexionsql
    {
        static string conexionstring = "server = JAEGER; database = Usuarios;" +
            "integrated security = true";
        SqlConnection conn = new SqlConnection(conexionstring);

        public int consultalogin(string usuario, string contrasena)
        {
            int count;
            conn.Open();
            string Query = "Select Count (*) From Users where Usuario = '" + usuario + "'" +
                "and Contrasena = '" + contrasena + "'";

            SqlCommand cmd = new SqlCommand(Query, conn);
            count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();
            return count;
        }
    }
}
