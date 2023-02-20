using System.Data;
using System.Data.SqlClient;

namespace DataReaderPoc.Lib.Tests
{
    public class SqlConnectionWrapper : ISqlConnection
    {
        private readonly SqlConnection _connection;

        public SqlConnectionWrapper(SqlConnection connection)
        {
            _connection = connection;
        }

        public string ConnectionString
        {
            get => _connection.ConnectionString;
            set => _connection.ConnectionString = value;
        }

        public int ConnectionTimeout => _connection.ConnectionTimeout;

        public string Database => _connection.Database;

        public ConnectionState State => _connection.State;

        public IDbTransaction BeginTransaction() => _connection.BeginTransaction();

        public IDbTransaction BeginTransaction(IsolationLevel il) => _connection.BeginTransaction(il);

        public void ChangeDatabase(string databaseName) => _connection.ChangeDatabase(databaseName);

        public void Close() => _connection.Close();

        public IDbCommand CreateCommand() => _connection.CreateCommand();

        public void Dispose() => _connection.Dispose();

        public void Open() => _connection.Open();
    }

}