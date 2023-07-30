using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.BaseClass;

namespace TestingProject.GenericUtility
{
    [TestClass]
    [TestCategory("ExcelUtility")]
    public class ExcelUtility : ActiTime
    {
        public String GetDataFromExcel(String sheet, int row, int col)
        {
            string path = "G:\\TYSS\\C#\\ActiTimeLogin.xlsx";

            Spreadsheet spreadsheet = new Spreadsheet();

            spreadsheet.LoadFromFile(path);

            String data= spreadsheet.Workbook.Worksheets.ByName(sheet).Cell(row, col).ToString();

            return data;
        }
    }
}
