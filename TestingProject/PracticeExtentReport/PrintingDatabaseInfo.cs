using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.PracticeExtentReport
{
    [TestClass]
    public class PrintingDatabaseInfo
    {
        OdbcConnection connection;
        [ClassInitialize]
        public static void Extent_Report_Init(TestContext tc )
        {

        }

        [TestMethod]
        public void Get_Database_data()
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
        [ClassCleanup]
        public static void Ext_Report_clean()
        {

        }

    }
}
