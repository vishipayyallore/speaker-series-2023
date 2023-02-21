using DataReaderPoc.Lib;
using System.Data;
using System.Data.SqlClient;
using static System.Console;

IDbConnection connection;
IDataRepository dataRepository = new DataRepository();
IDbDataRepository dbDataRepository = new DbDataRepository(new Telemetery());

// First use a SqlClient connection
ForegroundColor = ConsoleColor.Green;
connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=MoviesAPI;Trusted_Connection=True;MultipleActiveResultSets=True");
WriteLine("SqlClient\r\n{0}", dataRepository.GetServerVersion(connection));

ForegroundColor = ConsoleColor.Blue;
var movies = await dbDataRepository.GetMoviesList((SqlConnection)connection);
while (movies.Read())
{
    WriteLine($"{movies.GetInt32(0)} | {movies.GetString(1)} | {movies.GetBoolean(2)}");
}

ForegroundColor = ConsoleColor.Cyan;
var moviesList = dataRepository.GetAllMovies(connection);
foreach (var movie in moviesList)
{
    WriteLine($"{movie.Id} - {movie.Title} - {movie.InTheaters}");
}

ForegroundColor = ConsoleColor.Yellow;
IDataReader dataReader = dataRepository.GetMoviesList(connection);
//Call Read before accessing data.
while (dataReader.Read())
{
    ReadSingleRow((IDataRecord)dataReader);
}

static void ReadSingleRow(IDataRecord dataRecord)
{
    WriteLine(String.Format("{0} - {1} - {2}", dataRecord[0], dataRecord[1], dataRecord[2]));
}
ResetColor();
ReadKey();




//static string GetServerVersion(IDbConnection connection)
//{
//    // Ensure that the connection is opened (otherwise executing the command will fail)
//    ConnectionState originalState = connection.State;
//    if (originalState != ConnectionState.Open)
//        connection.Open();
//    try
//    {
//        // Create a command to get the server version
//        // NOTE: The query's syntax is SQL Server specific
//        IDbCommand command = connection.CreateCommand();
//        command.CommandText = "SELECT @@version";
//        var sqlVersion = (string)command.ExecuteScalar();

//        string queryString = "SELECT * FROM Movies;";
//        command.CommandText = queryString;

//        IDataReader dataReader = command.ExecuteReader();

//        // Call Read before accessing data.
//        while (dataReader.Read())
//        {
//            ReadSingleRow((IDataRecord)dataReader);
//        }
//    }

//    finally
//    {
//        // Close the connection if that's how we got it
//        if (originalState == ConnectionState.Closed)
//            connection.Close();
//    }

//    return string.Empty;
//}

//static void ReadSingleRow(IDataRecord dataRecord)
//{
//    Console.WriteLine(String.Format("{0}, {1}", dataRecord[0], dataRecord[1]));
//}