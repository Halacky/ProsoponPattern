using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace πρόσωπον
{
    public class ExcelHandler
    {
        /// <summary>
        /// Метод для парсинга екселя
        /// </summary>
        /// <returns> Словарь из названия больницы и зарплат врачей в этой больницы </returns>
        public Dictionary<string, List<int>> GetExc(string path)
        {
            var salary = new Dictionary<string, List<int>>();
            using (var package = new ExcelPackage(new FileInfo(path)))
            {
                try
                {
                    ExcelWorksheet workSheet = package.Workbook.Worksheets[0];
                    var start = workSheet.Dimension.Start;
                    var end = workSheet.Dimension.End;
                    for (int row = start.Row; row <= end.Row; row++)
                    {

                        var salarysArr = new List<int>();
                        for (int col = start.Column + 1; col <= end.Column; col++)
                        {
                            var cellValue = workSheet.Cells[row, col].Text;

                            if (cellValue.Trim().Length == 0) break;
                            salarysArr.Add(int.Parse(cellValue));
                        }
                        if (workSheet.Cells[row, 1].Text.Contains("hospital"))
                            salary[workSheet.Cells[row, 1].Text] = salarysArr;
                        else
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return salary;
        }

    }
}
