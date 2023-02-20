using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataReaderPoc.Lib
{
    public class DbDataRepository : IDbDataRepository
    {
        private readonly ITelemetery _telemetery;

        public DbDataRepository(ITelemetery telemetery)
        {
            _telemetery = telemetery ?? throw new ArgumentNullException(nameof(telemetery));
        }

        public async Task<DbDataReader> GetMoviesList(SqlConnection connection)
        {
            ConnectionState originalState = connection.State;
            if (originalState != ConnectionState.Open)
                connection.Open();
            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT Id, Title, InTheaters FROM Movies;";

                return await _telemetery.GetMoviesList(command);
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