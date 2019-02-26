using SiteDoZero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SiteDoZero.Controllers
{
    public class ProdutosController:Controller
    {
        public ActionResult Index()
        {
            var produtos = new List<Produto>() {
                new Produto(){Id=1, Nome= "Picanha", Preço= 70.5M, Qtde=150, Tipo="Alimento" },
                new Produto(){Id=2, Nome= "Pasta de Dente", Preço= 5.5M, Qtde=250, Tipo="Higiene" },
                new Produto(){Id=1, Nome= "Desinfetante", Preço= 8.5M, Qtde=450, Tipo="Limpeza" },
            };

            return View(produtos);
        }
    }
}
