using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Validação.Models;

namespace Validação.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa();

            return View();
        }
        [HttpPost]
        public ActionResult Index(Pessoa pessoa) {


            if (ModelState.IsValid)
            {

                return View("Resultado", pessoa);
            }
            return View("Pessoa");

        }
        public ActionResult Resultado(Pessoa pessoa) {
            return View(pessoa);
        }
    }
}
