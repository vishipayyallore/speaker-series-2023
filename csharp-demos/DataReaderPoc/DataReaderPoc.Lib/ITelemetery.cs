using System.Data.Common;
using System.Data.SqlClient;

namespace DataReaderPoc.Lib
{
    public interface ITelemetery
    {
        Task<DbDataReader> GetMoviesList(SqlCommand sqlCommand);
    }
}
