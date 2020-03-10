using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Cinema_Demo
{
    public class DbProvider
    {
        private string connectionString;
        protected SqlConnection connection;

        public DbProvider()
        {
            //Получение строки подключения
            connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            //Создание подключения
            connection = new SqlConnection(connectionString);
        }
    }
}
