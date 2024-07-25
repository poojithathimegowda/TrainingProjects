
using System;
using System.IO;
using OfficeOpenXml;

namespace ExcelPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the file path to save the Excel file
            string filePath = @"C:\Users\ranji\source\repos\poojithathimegowda\TrainingProjects\ExcelFile.xlsx";
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // Create a new Excel package
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Add a new worksheet
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Add some data to the worksheet
                worksheet.Cells[1, 1].Value = "Hello";
                worksheet.Cells[1, 2].Value = "World";
                worksheet.Cells[2, 1].Value = "This";
                worksheet.Cells[2, 2].Value = "is";
                worksheet.Cells[3, 1].Value = "EPPlus";
                worksheet.Cells[3, 2].Value = "Library";

                // Save the Excel file
                FileInfo fileInfo = new FileInfo(filePath);
                excelPackage.SaveAs(fileInfo);

                Console.WriteLine("Excel file created successfully!");
            }
        }
    }
}
