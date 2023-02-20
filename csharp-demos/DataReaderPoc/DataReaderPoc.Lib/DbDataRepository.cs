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

        public async Task<DbDataReader> GetMoviesList(IDbConnection connection)
        {
            ConnectionState originalState = connection.State;
            if (originalState != ConnectionState.Open)
                connection.Open();
            try
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = "SELECT Id, Title, InTheaters FROM Movies;";

                return await _telemetery.GetMoviesList((SqlCommand)command);
            }
            catch(Exception error)
            {
                var message = error.Message;
                throw;
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