using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Areas.Control.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Control/Home/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Control/Home/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Control/Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Control/Home/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Control/Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Control/Home/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Control/Home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Control/Home/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult UEditor()
        {
            return View();
        }

        public ActionResult OnlineRead()
        {
            ////string p = Request.QueryString["FilePath"];
            //string p = "demo.doc";
            //string filePath = Server.MapPath("~/temp/" + p);
            //Response.ClearContent();
            //Response.ClearHeaders();
            //string FilePost = filePath.Substring(filePath.Length - 3).ToLower();
            //switch (FilePost)
            //{
            //    case "pdf":
            //        Response.ContentType = "application/PDF";
            //        break;
            //    case "doc":
            //        Response.ContentType = "application/msword";
            //        break;
            //    default:
            //        Response.Write("<script>alert('该文件格式不能进行在线阅读！'");
            //        break;
            //}
            //Response.WriteFile(filePath);
            //Response.Flush();
            //Response.Close();
            ////return View();

            string p = "demo.doc";
            String fs_filename = Server.MapPath("~/temp/" + p);
            String fs_convertedfilename = Server.MapPath("~/temp/") + "demo" + ".swf";

            Print2Flash3.Server2 p2fServer = new Print2Flash3.Server2();
            //p2fServer.DefaultBatchProcessingOptions.BeforePrintingTimeout = 120000;//改成两分钟
            //p2fServer.ConvertFile(fs_filename, fs_convertedfilename, null, p2fServer.DefaultBatchProcessingOptions, null);//调用转化主程序
            p2fServer.ConvertFile(fs_filename, fs_convertedfilename, null, null, null);

            //int interfaceOptions = 0;
            //for (int i = 0; i < cblDocOptions.Items.Count; i++)
            //    if (cblDocOptions.Items[i].Selected)
            //        interfaceOptions |= Int32.Parse(cblDocOptions.Items[i].Value);
            //Print2Flash3.Server2 p2fServer = new Print2Flash3.Server2();
            //p2fServer.DefaultProfile.InterfaceOptions = interfaceOptions;
            //p2fServer.DefaultProfile.ProtectionOptions = (int)Print2Flash3.PROTECTION_OPTION.PROTENAPI;
            //p2fServer.ConvertFile(fs_filename, fs_convertedfilename, null, null, null); 

            return View();
        }

        public ActionResult wdDatePicker()
        {
            return View();
        }
    }
}
