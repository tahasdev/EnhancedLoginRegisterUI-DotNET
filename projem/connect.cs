using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace projem
{
    internal class connect
    {
        public void mysqlConnect()
        {
            /**/
        }

        internal async Task<bool> DB()
        {
            return await Task.Run(() =>
            {
                try
                {
                    using (var c = new MySqlConnection(config.baglanti))
                    {
                        c.Open();
                        return true;

                    }
                }
                catch
                {
                    return false;
                }
            });
        }


        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -

        // Veritabani baglantisi islemleri
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(config.baglanti);
        }

        public static DbResult q(string query)  // q: query
        {
            var conn = GetConnection();

            try
            {
                conn.Open();
            }
            catch //(MySqlException ex)
            {
                // Hata mesajı verilebilir:
                // enter.Instance.ShowForm(new connection());
                connection.Instance.tekrardene();
            }
            var cmd = new MySqlCommand(query, conn);
            return new DbResult(conn, cmd);
        }

        // Disposable yapı ile daha sade yapı, güvenli kaynak yönetimi.

        internal class DbResult : IDisposable
        {
            public MySqlConnection cn { get; }
            public MySqlCommand cd { get; }

            public DbResult(MySqlConnection connection, MySqlCommand command)
            {
                cn = connection;
                cd = command;
            }

            public void Dispose()
            {
                cd?.Dispose();
                if (cn?.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn?.Dispose();
            }
        }


        /* // DBResult'un eski hali:
         * 
        internal class DbResult
        {
            public MySqlConnection cn { get; }
            public MySqlCommand cd { get; }

            public DbResult(MySqlConnection connection, MySqlCommand command)
            {
                cn = connection;
                cd = command;
            }
        }
        */
    }
}
