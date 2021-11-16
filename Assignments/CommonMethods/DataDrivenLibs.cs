//using ExcelDataReader;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignments.CommonMethods
//{
//    class DataDrivenLibs
//    {
//        public static DataTable ExcelToDataTable(string fileName)
//        {
//            FileStream file = File.Open(fileName, FileMode.Open, FileAccess.Read);
//            IExcelDataReader excelDataReader = ExcelReaderFactory.CreateOpenXmlReader(file);
//            //excelDataReader.isFirstRowAsColumnNames = true;
//            //DataSet result = excelDataReader.AsDataSet();
//            //DataTableCollection table = result.Tables;
//            //DataTable resultTable = table["sheet1"];
//            DataTable resultTable = excelDataReader.GetSchemaTable();
//            return resultTable;
//        }
//    }
     
//    public static void Po

//    static List<DataCollection> dataCol = new List<DataCollection>();
//    public static string ReadData(int rowNumber, string columnName)
//    {
//        try
//        {
//            string data = (from colData in dataCol
//                           where colData.ColName == columnName && colData.rowNumber == rowNumber
//                           select colData.colValue).SingleOrDefault();
//            return data.ToString();
//        }
//        catch(Exception e)
//        {
//            return null;
//        }
//    }

//    public class DataCollection
//    {
//        public int rowNumber { get; set; }
//        public string columnName { get; set; }
//        public string columnValue { get; set; }

//    }
//}
