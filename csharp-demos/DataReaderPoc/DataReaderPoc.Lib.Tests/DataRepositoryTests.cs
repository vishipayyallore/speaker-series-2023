using Moq;
using System.Data;

namespace DataReaderPoc.Lib.Tests
{
    public class DataRepositoryTests
    {
        private readonly DataRepository _dataRepository = new();
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
        public void When_GetMoviesList_Returns_Rows()
        {
            DataTable EmployeeDetails = new("EmployeeDetails");
            //to create the column and schema
            DataColumn EmployeeID = new("EmpID", typeof(Int32));
            EmployeeDetails.Columns.Add(EmployeeID);
            DataColumn EmployeeName = new("EmpName", typeof(string));
            EmployeeDetails.Columns.Add(EmployeeName);
            DataColumn EmployeeMobile = new("EmpMobile", typeof(string));
            EmployeeDetails.Columns.Add(EmployeeMobile);

            //to add the Data rows into the EmployeeDetails table
            EmployeeDetails.Rows.Add(1001, "Andrew", "9000322579");
            EmployeeDetails.Rows.Add(1002, "Briddan", "9081223457");

            //to create the object for DataSet
            DataSet dataSet = new();
            //Adding DataTables into DataSet
            dataSet.Tables.Add(EmployeeDetails);

            _connectionMock.Setup(x => x.CreateCommand()).Returns(_commandMock.Object);
            _commandMock.Setup(x => x.ExecuteReader()).Returns(dataSet.CreateDataReader());

            var rowsReturned = _dataRepository.GetMoviesList(_connectionMock.Object);
            // Assert.Equal(sqlVersion, sqlVersionReturned);
        }
    }
}