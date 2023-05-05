using Loja_Virtual_MVC.Data;
using Loja_Virtual_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Loja_Virtual_MVC.Controllers
{
	public class AdminController : Controller
	{
		private readonly ILogger<AdminController> _logger;
		private readonly BancoDeDadosContext _bancoContext;

		public AdminController(ILogger<AdminController> logger, BancoDeDadosContext bancoContext)
		{
			_logger = logger;
			_bancoContext = bancoContext;
		}

		// Actions para exibir os dados nas Views:

		public IActionResult Index()
		{
			var produtos = _bancoContext.Produtos.ToList();
			return View(produtos);
		}

		public IActionResult AdicionarProduto()
		{
			return View();
		}

		public IActionResult EditarProduto(int id)
		{
			var produto = _bancoContext.Produtos.FirstOrDefault(p => p.Id == id);
			return View(produto);
		}

		public IActionResult DeletarProduto(int? id)
		{
			var produto = _bancoContext.Produtos.Find(id);
			return View(produto);
		}

		// Actions para administrar o Banco De Dados:

		[HttpPost]
		public IActionResult AdicionarProduto(ProdutoModel produto)
		{
			_bancoContext.Add(produto);
			_bancoContext.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpPost]
		public IActionResult EditarProduto(int id, ProdutoModel produto)
		{
			_bancoContext.Update(produto);
			_bancoContext.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpPost]
		public IActionResult ConfirmDelete(int id)
		{
			var produto = _bancoContext.Produtos.Find(id);
			if (produto != null)
			{
				_bancoContext.Produtos.Remove(produto);
			}
			_bancoContext.SaveChanges();
			return RedirectToAction("Index");
		}

		// -----

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}