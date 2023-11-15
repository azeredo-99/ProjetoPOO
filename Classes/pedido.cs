using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes

{
    public class Pedido
    {
        #region CONSTRUTORES

        /// <param name="id">Identificador único do pedido.</param>
        /// <param name="cliente">Cliente que fez o pedido.</param>
        /// <param name="dataPedido">Data do pedido.</param>
        /// <param name="status">Status do pedido.</param>
        public Pedido(int id, Cliente cliente, DateTime dataPedido, float status)
        {
            Id = id;
            Cliente = cliente;
            DataPedido = dataPedido;
            Status = status;
            Itens = new List<ItemPedido>();
        }

        #endregion

        #region ESTADO
      
        public int Id { get; set; }
        public Cliente Cliente { get; private set; }
        public float Status { get; set; }
        public List<ItemPedido> Itens { get; private set; }
        public DateTime DataPedido { get; set; }
        public float Valor { get; set; }
    }
}
#endregion