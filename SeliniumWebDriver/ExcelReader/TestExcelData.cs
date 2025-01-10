using ExcelDataReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.ExcelReader
{
    [TestClass]
    public class TestExcelData
    {
        [TestMethod]
        
        public void TestReadExcel()
        {
            //FileStream stream = new FileStream(@"C:\Naveen\DataExcel.xlsx", FileMode.Open, FileAccess.Read);
            //IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);
            //DataTable data = reader.AsDataSet().Tables["Bugzilla"];
            //for (int i = 0; i < data.Rows.Count; i++)
            //{
            //    var col = data.Rows[i];
            //    for (int j = 0; j < col.ItemArray.Length; j++)
            //    {
            //        Console.Write("Data : {0}", col.ItemArray[j]);
            //    }
            //    Console.WriteLine();
            //}
            string xlpath = @"C:\Naveen\DataExcel.xlsx";
            Console.WriteLine(ExcelReaderHelper.GetCellData(xlpath, "Bugzill", 0, 0));
            Console.WriteLine(ExcelReaderHelper.GetCellData(xlpath, "Bugzill", 0, 1));
           

        }
    }
}
