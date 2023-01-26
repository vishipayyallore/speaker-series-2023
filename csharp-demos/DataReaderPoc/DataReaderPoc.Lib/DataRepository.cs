using System.Data;

namespace DataReaderPoc.Lib
{
    public class DataRepository : IDataRepository
    {
        public string GetServerVersion(IDbConnection connection)
        {
            // Ensure that the connection is opened (otherwise executing the command will fail)
            ConnectionState originalState = connection.State;
            if (originalState != ConnectionState.Open)
                connection.Open();
            try
            {
                // Create a command to get the server version
                // NOTE: The query's syntax is SQL Server specific
                IDbCommand command = connection.CreateCommand();
                command.CommandText = "SELECT @@version";

                return (string)command.ExecuteScalar()!;
            }
            finally
            {
                // Close the connection if that's how we got it
                if (originalState == ConnectionState.Closed)
                    connection.Close();
            }
        }

        public IDataReader GetMoviesList(IDbConnection connection)
        {
            ConnectionState originalState = connection.State;
            if (originalState != ConnectionState.Open)
                connection.Open();
            try
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Movies;";

                return command.ExecuteReader();
            }
            finally
            {
                // Close the connection if that's how we got it
                // if (originalState == ConnectionState.Closed)
                //    connection.Close();
            }
        }

    }

}