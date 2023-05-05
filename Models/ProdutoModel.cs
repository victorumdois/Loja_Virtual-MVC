using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Loja_Virtual_MVC.Models
{
	public class ProdutoModel
	{
		public int Id { get; set; }

		[Required]
		[MaxLength(100)]
		public string Nome { get; set; }

		[Required]
		[MaxLength(300)]
		public string Descricao { get; set; }

		[Required]
		public double Preco { get; set; }

		[Required]
		public int Quantidade { get; set; }

		public string Imagem1 { get; set; }
		public string Imagem2 { get; set; }
		public string Imagem3 { get; set; }
	}
}