using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.TestScripts
{
    [TestClass]
    [TestCategory("DynamicDataAndDataSource")]
    public class DynamicDataAndDataSource
    {
    

        [TestMethod]
        [DynamicData(nameof(Names),DynamicDataSourceType.Method)]
        public void DynamicData(string state, string capital)
        {
            Console.WriteLine($"states -->{state} and capital-->{capital}");
        }
        public static IEnumerable<object[]> Names() 
        {
            String path = "G:\\TYSS\\C#\\States_Capitals.xlsx";
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(path);
            var sheet=spreadsheet.Workbook.Worksheets["Sheet1"];
            int row=sheet.UsedRangeRowMax;
            int column=sheet.UsedRangeColumnMax;

            for(int i=1; i<=row; i++) {
                string state=sheet.Cell(i, 0).ToString();
               string capital= sheet.Cell(i,1).ToString();
                yield return new object[] { state,capital };
            }



        }

    }
}
