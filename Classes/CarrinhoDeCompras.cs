using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classes
{
    public class CarrinhoDeCompras
    {
        private List<Produto> itens = new List<Produto>();

        /// <summary>
        /// Adiciona um produto ao carrinho.
        /// </summary>
        /// <param name="produto">Produto a ser adicionado.</param>
        public void AdicionarProduto(Produto produto)
        {           
            itens.Add(produto);
        }

        /// <summary>
        /// Exibe os itens no carrinho.
        /// </summary>
        public void ExibirCarrinho()
        {
            foreach (var produto in itens)
            {
                Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco} euros");
            }
        }
    }
}
