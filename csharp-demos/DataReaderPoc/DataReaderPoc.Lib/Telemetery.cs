using System.Data;
using System.Data.Common;

namespace DataReaderPoc.Lib
{
    public class Telemetery : ITelemetery
    {
        public async Task<IDataReader> GetMoviesList(IDbCommand sqlCommand)
        {
            return await ((DbCommand)sqlCommand).ExecuteReaderAsync();
        }
    }
}
