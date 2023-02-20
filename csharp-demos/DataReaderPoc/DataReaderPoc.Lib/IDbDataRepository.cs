using System.Data.Common;
using System.Data.SqlClient;

namespace DataReaderPoc.Lib
{
    public interface IDbDataRepository
    {
        DbDataReader GetMoviesList(SqlConnection connection);
    }


}