using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Pagamento
    {
        #region CONSTRUTORES

        /// <summary>
        /// Construtor da classe Pagamento.
        /// </summary>
        public Pagamento()
        {
            // Inicializações necessárias...
        }

        /// <summary>
        /// Construtor da classe Pagamento com parâmetros.
        /// </summary>
        /// <param name="id">Identificador único do pagamento.</param>
        /// <param name="pedido">Pedido associado ao pagamento.</param>
        /// <param name="metodoPagamento">Método de pagamento.</param>
        /// <param name="valor">Valor do pagamento.</param>
        /// <param name="dataPagamento">Data do pagamento.</param>
        public Pagamento(int id, Pedido pedido, float metodoPagamento, float valor, DateTime dataPagamento)
        {
            Id = id;  // Aqui está o problema, pois a propriedade "Id" não foi declarada na classe Pagamento.
            Pedido = pedido;
            MetodoPagamento = metodoPagamento;
            Valor = valor;
            DataPagamento = dataPagamento;
        }

        #endregion

        #region ESTADO

        // Adicione a propriedade "Id" ao estado da classe Pagamento.
        public int Id { get; set; }
        public float MetodoPagamento { get; set; }
        public int DataPagamento { get; set; }
        public float Valor { get; set; }

        

        // Outras propriedades...

        #endregion
    }

}
