using IBM.Data.DB2.iSeries;

using System;


namespace ACUtils
{
    public class ConnectionWrapper : IDisposable
    {
        public readonly iDB2Connection Connection;
        private bool _closeOnDispose;
        public ConnectionWrapper(iDB2Connection connection, bool closeOnDispose = true)
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
