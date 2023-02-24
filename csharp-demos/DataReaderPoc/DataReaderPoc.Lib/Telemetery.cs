using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataReaderPoc.Lib
{
    public class Telemetery : ITelemetery
    {
        public async Task<IDataReader> GetMoviesList(IDbCommand sqlCommand)
        {
            return await ((SqlCommand)sqlCommand).ExecuteReaderAsync();
        }
    }
}
