using DataReaderPoc.Lib;
using System.Data;
using System.Data.SqlClient;

IDbConnection connection;
IDataRepository dataRepository = new DataRepository();

// First use a SqlClient connection
connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=MoviesAPI;Trusted_Connection=True;MultipleActiveResultSets=True");
Console.WriteLine("SqlClient\r\n{0}", dataRepository.GetServerVersion(connection));

var moviesList = dataRepository.GetAllMovies(connection);
foreach(var movie in moviesList)
{
    Console.WriteLine($"{movie.Id} - {movie.Title} - {movie.InTheaters}");
}

IDataReader dataReader = dataRepository.GetMoviesList(connection);
//Call Read before accessing data.
while (dataReader.Read())
{
    ReadSingleRow((IDataRecord)dataReader);
}

static void ReadSingleRow(IDataRecord dataRecord)
{
    Console.WriteLine(String.Format("{0}, {1}", dataRecord[0], dataRecord[1]));
}

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