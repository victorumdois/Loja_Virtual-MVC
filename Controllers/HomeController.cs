using Loja_Virtual_MVC.Data;
using Loja_Virtual_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Loja_Virtual_MVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly BancoDeDadosContext _bancoContext;
		public HomeController(ILogger<HomeController> logger, BancoDeDadosContext bancoContext)
		{
			_logger = logger;
			_bancoContext = bancoContext;
		}

        // ----- AREA PARA EXIBIR INFORMACOES EM VIEWS:

        public IActionResult Index()
		{
			var produtos = _bancoContext.Produtos;
			return View(produtos.ToList());
		}

		public IActionResult Produto(int id)
		{
            var produto = _bancoContext.Produtos.FirstOrDefault(p => p.Id == id);
            return View(produto);
        }

        // -----

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}