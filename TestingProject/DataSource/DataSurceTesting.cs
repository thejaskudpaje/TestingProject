using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.DataSource
{
    [TestClass]
    public class DataSurceTesting
    {
        public static TestContext testContext;
       const string csvPath = "C:\\Users\\Admin\\source\\MyRepos\\TestingProject\\TestingProject\\DataSource\\CSVData.csv";
      const  string excelPath = "C:\\Users\\Admin\\source\\MyRepos\\TestingProject\\TestingProject\\DataSource\\CSVDataInEXCEL.xlsx";

        [ClassInitialize]
        public static void ClassInit(TestContext contxt)
        {
            testContext=contxt;
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
        }

        [TestMethod]
        [TestCategory("Data source")]
        [Owner("Thejas")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",csvPath,"csvData#csv",DataAccessMethod.Sequential)]
        public void DataSource_Test01()
        {
            string number = testContext.DataRow["number"].ToString();
            string state = testContext.DataRow["State"].ToString();
            string capital= testContext.DataRow["Capital"].ToString();

        /*    string number = testContext.DataRow[0].ToString();
            string state = testContext.DataRow[1].ToString();
            string capital = testContext.DataRow[2].ToString();*/

            Console.WriteLine($"slno--> {number},state-->{state},capital-->{capital} ");
        }

        [TestMethod]
        [TestCategory("Data source")]
        [Owner("Thejas")]
        [DataSource("System.Data.OleDb","Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelPath +";Extended Properties=Excel 12.0", 
                    "Login$", DataAccessMethod.Sequential)]
        public void DataSurce_Test02() {
            string number = testContext.DataRow["number"].ToString();
            string state = testContext.DataRow["State"].ToString();
            string capital = testContext.DataRow["Capital"].ToString();

            Console.WriteLine($"slno--> {number},state-->{state},capital-->{capital} ");
        }

    }
}
