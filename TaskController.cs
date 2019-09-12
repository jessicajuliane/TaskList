using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskList.Models;
using WebApplication1.App_Data;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var conexao = new Conexion();
            conexao.AdicionarTask(task);
            return RedirectToAction(nameof(Index));
            return View();
        }

        public ActionResult ViewTask(Tasks task)
        {
            if (ModelState.IsValid)
            {
                var conexao = new Conexion();
                conexao.ListarTasks(task);
                return RedirectToAction(nameof(Index));
            }
            else {
                return View(task);
            }

            
        }
        
    }
}