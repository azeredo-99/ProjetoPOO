using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    public class Avaliacao
    {
        private int field;

        public event EventHandler Event;

        public Avaliacao()
        {
            throw new System.NotImplementedException();
        }

        #region ESTADO

        /// <summary>
        /// Identificador único da avaliação.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Produto associado à avaliação.
        /// </summary>
        public Produto Produto { get; set; }

        /// <summary>
        /// Cliente que fez a avaliação.
        /// </summary>
        public Cliente Cliente { get; set; }

        /// <summary>
        /// Classificação da avaliação, de 1 a 5 estrelas).
        /// </summary>
        public int Classificacao { get; set; }

        /// <summary>
        /// Comentário associado à avaliação.
        /// </summary>
        public string Comentario { get; set; }

        /// <summary>
        /// Email associado à avaliação.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Data da avaliação.
        /// </summary>
        public DateTime Data { get; set; }

        #endregion 

        public void Method()
        {
            throw new System.NotImplementedException();
        }

    }
}