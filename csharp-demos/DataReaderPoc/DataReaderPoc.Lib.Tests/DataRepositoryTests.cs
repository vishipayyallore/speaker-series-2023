using Moq;
using System.Data;
using System.Data.SqlClient;

namespace DataReaderPoc.Lib.Tests
{
    public class DataRepositoryTests
    {
        private readonly DataRepository _dataRepository = new();
        // private readonly DbDataRepository _dbDataRepository = new();
        private readonly Mock<IDbConnection> _connectionMock = new();
        private readonly Mock<IDbCommand> _commandMock = new();

        [Fact]
        public void When_GetServerVersion_Returns_Rows()
        {
            var sqlVersion = "Microsoft SQL Server 2019 (RTM-CU12) (KB5004524) - 15.0.4153.1 (X64)";

            _connectionMock.Setup(x => x.CreateCommand()).Returns(_commandMock.Object);
            _commandMock.Setup(x => x.ExecuteScalar()).Returns(sqlVersion);

            var sqlVersionReturned = _dataRepository.GetServerVersion(_connectionMock.Object);
            Assert.Equal(sqlVersion, sqlVersionReturned);
        }

        [Fact]
        public void When_Db_GetMoviesList_Returns_Rows()
        {
            DataTable MoviesList = GetDummyMoviesList();

            DataSet dataSet = new();
            dataSet.Tables.Add(MoviesList);

            // _dbDataRepository = new();
            Mock<SqlConnection> _connectionMock = new();
            Mock<SqlCommand> _commandMock = new();

            //_connectionMock.Setup(x => x.CreateCommand()).Returns(_commandMock.Object);
            //_commandMock.Setup(x => x.ExecuteReader()).Returns(dataSet.CreateDataReader());

            //var rowsReturned = _dbDataRepository.GetMoviesList(_connectionMock.Object);
            //Assert.Equal(3, rowsReturned.FieldCount);
        }

        [Fact]
        public void When_GetMoviesList_Returns_Rows()
        {
            DataTable MoviesList = GetDummyMoviesList();

            DataSet dataSet = new();
            dataSet.Tables.Add(MoviesList);

            _connectionMock.Setup(x => x.CreateCommand()).Returns(_commandMock.Object);
            _commandMock.Setup(x => x.ExecuteReader()).Returns(dataSet.CreateDataReader());

            var rowsReturned = _dataRepository.GetMoviesList(_connectionMock.Object);
            Assert.Equal(3, rowsReturned.FieldCount);
        }

        [Fact]
        public void When_GetAllMovies_Returns_Rows()
        {
            DataTable MoviesList = GetDummyMoviesList();

            DataSet dataSet = new();
            dataSet.Tables.Add(MoviesList);

            _connectionMock.Setup(x => x.CreateCommand()).Returns(_commandMock.Object);
            _commandMock.Setup(x => x.ExecuteReader()).Returns(dataSet.CreateDataReader());

            var movies = _dataRepository.GetAllMovies(_connectionMock.Object);

            Assert.True(movies.Any());
            Assert.Equal(2, movies.Count());
        }

        private static DataTable GetDummyMoviesList()
        {
            DataTable MoviesList = new("MoviesDetails");

            //to create the column and schema
            MoviesList.Columns.Add(new DataColumn("Id", typeof(Int32)));
            MoviesList.Columns.Add(new DataColumn("Title", typeof(string)));
            MoviesList.Columns.Add(new DataColumn("InTheaters", typeof(bool)));

            //to add the Data rows into the MoviesDetails table
            MoviesList.Rows.Add(1001, "Movie 1", true);
            MoviesList.Rows.Add(1002, "Movie 2", false);

            return MoviesList;
        }
    }
}