using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace TestingProject.ODBCPrograms
{
    [TestClass]
    [TestCategory("ODBC")]
    public class OBBCConnectionBasic
    {
        OdbcConnection connection;
        [TestMethod]
        public void Connecting_ODBC_Test()
        {
            string connection_string = "Driver={MySQL ODBC 8.1 Unicode Driver};Server=rmgtestingserver:3333;Database=projects;User=root@%;Password=root";
            string query = "select * from project";
            connection = new OdbcConnection(connection_string);
            connection.Open();
            OdbcCommand command = new OdbcCommand(query, connection);
            var tables = command.ExecuteReader();
            Console.WriteLine(tables.Read());

           while (tables.Read())
            {
                Console.WriteLine(tables[0].ToString() + "    " + tables[1].ToString() + "    " + tables[2].ToString() + "    " + tables[3].ToString());

            }
            connection.Close();

        }
    }
}
