using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using SapphireHR.Business.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Integrations
{
    public class DataSheetService
    {
        IConfiguration _config;
        public DataSheetService(IConfiguration config)
        {
            _config = config;

        }
        public object Import(IFormFile file, int sheetCount, Func<List<ISheet>, BaseModel> callback)
        {
            if (file.Length > 0)
            {
                string sFileExtension = Path.GetExtension(file.FileName).ToLower();
                List<ISheet> sheets = new List<ISheet>();
                using (var stream = file.OpenReadStream())
                {
                    file.CopyTo(stream);
                    stream.Position = 0;
                    for (int i = 0; i < sheetCount; i++)
                    {
                        ISheet sheet;
                        if (sFileExtension == ".xls")
                        {
                            HSSFWorkbook hssfwb = new HSSFWorkbook(stream); //This will read the Excel 97-2000 formats  
                            sheet = hssfwb.GetSheetAt(i); //get first sheet from workbook  
                        }
                        else
                        {
                            XSSFWorkbook hssfwb = new XSSFWorkbook(stream); //This will read 2007 Excel format  
                            sheet = hssfwb.GetSheetAt(0); //get first sheet from workbook   
                        }
                        sheets.Add(sheet);
                    }

                    return callback(sheets);
                }
            }
            return null;
        }
    
        public async Task<MemoryStream> Export(string fileName)
        {
            string sWebRootFolder = _config.GetSection("FileSystem")["ExportFolder"];
            string sFileName = fileName;
            FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));
            var memory = new MemoryStream();
            using (var fs = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook;
                workbook = new XSSFWorkbook();
                ISheet excelSheet = workbook.CreateSheet("employee");
                IRow row = excelSheet.CreateRow(0);
                row.CreateCell(0).SetCellValue("EmployeeId");
                row.CreateCell(1).SetCellValue("EmployeeName");
                row.CreateCell(2).SetCellValue("Age");
                row.CreateCell(3).SetCellValue("Sex");
                row.CreateCell(4).SetCellValue("Designation");
                row = excelSheet.CreateRow(1);
                row.CreateCell(0).SetCellValue(1);
                row.CreateCell(1).SetCellValue("Jack Supreu");
                row.CreateCell(2).SetCellValue(45);
                row.CreateCell(3).SetCellValue("Male");
                row.CreateCell(4).SetCellValue("Solution Architect");
                row = excelSheet.CreateRow(2);
                row.CreateCell(0).SetCellValue(2);
                row.CreateCell(1).SetCellValue("Steve khan");

                row.CreateCell(2).SetCellValue(33);
                row.CreateCell(3).SetCellValue("Male");
                row.CreateCell(4).SetCellValue("Software Engineer");

                row = excelSheet.CreateRow(3);
                row.CreateCell(0).SetCellValue(3);
                row.CreateCell(1).SetCellValue("Romi gill");
                row.CreateCell(2).SetCellValue(25);
                row.CreateCell(3).SetCellValue("FeMale");
                row.CreateCell(4).SetCellValue("Junior Consultant");

                row = excelSheet.CreateRow(4);
                row.CreateCell(0).SetCellValue(4);
                row.CreateCell(1).SetCellValue("Hider Ali");
                row.CreateCell(2).SetCellValue(34);
                row.CreateCell(3).SetCellValue("Male");
                row.CreateCell(4).SetCellValue("Accountant");

                row = excelSheet.CreateRow(5);
                row.CreateCell(0).SetCellValue(5);
                row.CreateCell(1).SetCellValue("Mathew");
                row.CreateCell(2).SetCellValue(48);
                row.CreateCell(3).SetCellValue("Male");
                row.CreateCell(4).SetCellValue("Human Resource");

                workbook.Write(fs);
            }
            using (var stream = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            //return File(memory, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", sFileName);
            return memory;
        }
    }
}
