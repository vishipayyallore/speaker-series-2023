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

        public async Task<IDataReader> GetMoviesList(IDbConnection connection)
        {
            ConnectionState originalState = connection.State;
            if (originalState != ConnectionState.Open)
            {
                connection.Open();
            }

            try
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = "SELECT Id, Title, InTheaters FROM Movies;";

                var output = await _telemetery.GetMoviesList(command);
                return output;
            }
            catch (Exception error)
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