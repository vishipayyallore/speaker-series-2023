using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataReaderPoc.Lib
{
    public interface IDbDataRepository
    {
        Task<DbDataReader> GetMoviesList(IDbConnection connection);
    }


}