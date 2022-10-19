using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyAdmin.Data.DataSource
{
    class Connection
    {
        public static SqlConnection DataCon { get; set; }
        public static string NAME { get; set; }
        /// <summary>
        /// Use SQL Server Authentication
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="dbName"></param>
        public static void ConnectionDB(string ip, string userName, string password, string dbName)
        {
            //Standard Security
            NAME = userName;
            string connectionString = $"Server={ip};Database={dbName};User Id={userName};Password = {password};";
            try
            {
                DataCon = new SqlConnection(connectionString);
                DataCon.Open();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Use for Window Authentication
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="dbName"></param>
        public static void ConnectionDB(string ip, string dbName)
        {
            //Trusted Connection
            string connectionString = $"Server={ip};Database={dbName};Trusted_Connection=True;";
            try
            {
                DataCon = new SqlConnection(connectionString);
                DataCon.Open();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
