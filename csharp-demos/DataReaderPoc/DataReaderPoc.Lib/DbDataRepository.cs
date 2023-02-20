using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataReaderPoc.Lib
{
    public class DbDataRepository : IDbDataRepository
    {
        public DbDataReader GetMoviesList(SqlConnection connection)
        {
            ConnectionState originalState = connection.State;
            if (originalState != ConnectionState.Open)
                connection.Open();
            try
            {
                SqlCommand command = connection.CreateCommand();
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
    }

}