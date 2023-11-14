using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Pedido
    {
        public Pedido()
        {

            /// <param name="id">Identificador único do pedido.</param>
            /// <param name="cliente">Cliente que fez o pedido.</param>
            /// <param name="dataPedido">Data do pedido.</param>
            /// <param name="status">Status do pedido.</param>
            public Pedido(int id, Pessoa pessoa, DateTime dataPedido, string status)
            {
                Id = id;
                Pessoa = pessoa;
                DataPedido = dataPedido;
                Status = status;
                Itens = new List<ItemPedido>();


            }
            
        }
    }
}
