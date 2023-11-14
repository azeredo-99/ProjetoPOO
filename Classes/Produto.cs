using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Classes
{

    #region TEST
    class Program
    {
        static void Main()
        {
            // Criar um produto com ID 1, chamado "Camisola SL Benfica" e custa 26 euros
            Produto meuProduto = new Produto(1, "Camisola SL Benfica", 26);
            

            // Exibir informações sobre o produto
            Console.WriteLine($"ID: {meuProduto.Id}");
            Console.WriteLine($"Nome: {meuProduto.Nome}");
            Console.WriteLine($"Preço: {meuProduto.Preco} euros");
        }
    }
    #endregion

    public class Produto
    {
        #region Construtores

        /// <summary>
        /// Construtor com parâmetros para inicializar as propriedades do produto.
        /// </summary>
        /// <param name="id">ID do produto.</param>
        /// <param name="nome">Nome do produto.</param>
        /// <param name="preco">Preço do produto.</param>
        public Produto(int id, string nome, float preco)
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
            // Pode inicializar outras propriedades ou realizar outras operações necessárias.
        }

        #endregion

        #region ESTADO

        /// <summary>
        /// ID do produto.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do produto.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Preço do produto.
        /// </summary>
        public float Preco { get; set; }

        #endregion
    }
}
