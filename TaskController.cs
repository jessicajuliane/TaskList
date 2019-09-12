using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskList.Controllers
{
    public class TaskController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Deletar(int taskId)
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Adicionar()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ListarTasks()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BuscarPorId(int taskId)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}