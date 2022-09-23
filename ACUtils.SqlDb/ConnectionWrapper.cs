using System;
using System.Data.SqlClient;

namespace ACUtils
{
    class ConnectionWrapper : IDisposable
    {
        public readonly SqlConnection Connection;
        private bool _closeOnDispose;
        public ConnectionWrapper(SqlConnection connection, bool closeOnDispose = true)
        {
            this.Connection = connection;
            _closeOnDispose = closeOnDispose;
        }

        public void Dispose()
        {
            if (_closeOnDispose)
            {
                if (Connection?.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
                Connection?.Dispose();
            }
        }
    }
}
