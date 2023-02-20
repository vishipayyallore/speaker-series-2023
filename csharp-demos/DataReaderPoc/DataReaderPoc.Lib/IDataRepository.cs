using DataReaderPoc.Data;
using System.Data;

namespace DataReaderPoc.Lib
{
    public interface IDataRepository
    {
        string GetServerVersion(IDbConnection connection);

        IDataReader GetMoviesList(IDbConnection connection);

        IEnumerable<Movie> GetAllMovies(IDbConnection connection);
    }

}