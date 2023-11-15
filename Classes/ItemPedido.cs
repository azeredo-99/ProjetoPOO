namespace Classes
{
    public class ItemPedido
    {
        #region Construtor

        /// <summary>
        /// Construtor da classe ItemPedido.
        /// </summary>
        /// <param name="produto">Produto do item.</param>
        /// <param name="quantidade">Quantidade do produto no pedido.</param>
        public ItemPedido(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        #endregion

        #region Estado

        public Produto Produto { get; private set; }
        public int Quantidade { get; set; }

        #endregion
    }
}
