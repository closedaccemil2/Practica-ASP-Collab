using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica_ASP_Collab.Models;
using System.IO;
using ExcelDataReader;
using System.Data;

namespace Practica_ASP_Collab.Controllers
{
    public class XLSController : Controller
    {
        // GET: XLS

        public ActionResult Index()
        {
            return View();
        }


         [HttpPost]
         [ValidateAntiForgeryToken]
        public ActionResult Index(HttpPostedFileBase xls)
        {
            if (ModelState.IsValid)
            {

                if (xls != null && xls.ContentLength > 0)
                {
                    Stream st = xls.InputStream;
                    IExcelDataReader reader = null;

                    if (xls.FileName.EndsWith(".xls"))
                    {

                        reader = ExcelReaderFactory.CreateBinaryReader(st);
                    } else if (xls.FileName.EndsWith(".xlsx"))
                    {
                        reader = ExcelReaderFactory.CreateOpenXmlReader(st);
                    }
                    else
                    {
                        ModelState.AddModelError("File", "Este formato no es aceptado.");
                        return View();
                    }                                    

                    var conf = new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true
                        }
                    };

                    DataSet resultado = reader.AsDataSet();
                    reader.Close();
                    return View(resultado.Tables[0]);                    

                }
                else
                {
                        ModelState.AddModelError("File", "Suba un archivo.");
                }
            }

            return View();
        }

    }
   
}