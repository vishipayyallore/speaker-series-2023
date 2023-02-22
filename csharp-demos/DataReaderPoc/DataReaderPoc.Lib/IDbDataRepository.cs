using System.Data;
using System.Data.Common;

namespace DataReaderPoc.Lib
{
    public interface IDbDataRepository
    {
        Task<IDataReader> GetMoviesList(IDbConnection connection);
    }


}