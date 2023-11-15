namespace Classes
{

    #region TEST
    public class Program
    {
        static void Main()
        {
            // Criar um produto com ID 1, chamado "Camisola SL Benfica" e custa 26 euros
            Produto Produto1 = new Produto(1, "Camisola SL Benfica", 26);


            // Exibir informações sobre o produto
            Console.WriteLine($"ID: {Produto1.Id}");
            Console.WriteLine($"Nome: {Produto1.Nome}");
            Console.WriteLine($"Preço: {Produto1.Preco} euros\n");


            // Criar um produto com ID 2, chamado "Camisola FC Porto" e custa 26 euros
            Produto Produto2 = new Produto(2, "Camisola FC Porto", 26);


            // Exibir informações sobre o produto
            Console.WriteLine($"ID: {Produto2.Id}");
            Console.WriteLine($"Nome: {Produto2.Nome}");
            Console.WriteLine($"Preço: {Produto2.Preco} euros");
        }
    }
}
#endregion 
