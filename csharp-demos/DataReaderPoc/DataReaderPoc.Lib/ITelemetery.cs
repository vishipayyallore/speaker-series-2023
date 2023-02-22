using System.Data;
using System.Data.Common;

namespace DataReaderPoc.Lib
{
    public interface ITelemetery
    {
        Task<IDataReader> GetMoviesList(IDbCommand sqlCommand);
    }
}
