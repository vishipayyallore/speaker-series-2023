using DataReaderPoc.Data;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataReaderPoc.Lib
{
    public interface IDataRepository
    {
        string GetServerVersion(IDbConnection connection);

        IDataReader GetMoviesList(IDbConnection connection);

        IEnumerable<Movie> GetAllMovies(IDbConnection connection);
    }

    public interface IDbDataRepository
    {
        DbDataReader GetMoviesList(SqlConnection connection);
    }

    
}