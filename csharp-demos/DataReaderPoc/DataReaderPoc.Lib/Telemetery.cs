using System.Data.Common;
using System.Data.SqlClient;

namespace DataReaderPoc.Lib
{
    public class Telemetery : ITelemetery
    {
        public async Task<DbDataReader> GetMoviesList(SqlCommand sqlCommand)
        {
            return await sqlCommand.ExecuteReaderAsync();
        }
    }
}
