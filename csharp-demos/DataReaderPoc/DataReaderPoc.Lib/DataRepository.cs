using DataReaderPoc.Data;
using System.Data;
using System.Data.SqlClient;

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
                command.CommandText = "SELECT Id, Title, InTheaters FROM Movies;";

                return command.ExecuteReader();
            }
            finally
            {
                // Close the connection if that's how we got it
                // if (originalState == ConnectionState.Closed)
                //    connection.Close();
            }
        }

        public IEnumerable<Movie> GetAllMovies(IDbConnection connection)
        {
            IList<Movie> movies = new List<Movie>();

            ConnectionState originalState = connection.State;
            if (originalState != ConnectionState.Open)
                connection.Open();
            try
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = "SELECT Id, Title, InTheaters FROM Movies;";

                SqlDataReader reader =  (SqlDataReader)command.ExecuteReader();
                while (reader.Read())
                {
                    movies.Add(new Movie { Id= reader.GetInt32("id"), Title = reader.GetString("title"), InTheaters = reader.GetBoolean("inTheaters") });
                }
            }
            finally
            {
                // Close the connection if that's how we got it
                // if (originalState == ConnectionState.Closed)
                //    connection.Close();
            }

            return movies;
        }

    }

}