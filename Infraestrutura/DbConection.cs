using System.Data.SqlClient;
using System.Configuration;

namespace Infraestrutura
{
    public class DbConection
    {
        private static SqlConnection sqlConnection;
        private static string connectioString = ConfigurationManager.ConnectionStrings["connectionStrings"].ConnectionString;

        public static SqlConnection DbConnection()
        {
            sqlConnection = new SqlConnection(connectioString);
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
