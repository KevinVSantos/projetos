using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using validação2.Models;

namespace validação2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa();

            return View();
        }
        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            //if (string.IsNullOrEmpty(pessoa.Nome))
            //{
            //    ModelState.AddModelError("Nome","O campo nome é obrigatorio.");
            //}
            //if (pessoa.Senha != pessoa.ConfirmarSenha)
            //{
            //    ModelState.AddModelError("", "Senhas nao conferem");
            //}
            if (ModelState.IsValid)
            {

                return View("Resultados", pessoa);
            }
            return View();

        }
        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }
        public ActionResult LoginUnico(string login)
        {

            var bancoDeNomes = new Collection<string>
            {

                "kevin",
                "maria",
                "soso"
            };

            return Json(bancoDeNomes.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}
