using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    public class Cliente : Pessoa
    {
        #region Construtor

        /// <summary>
        /// Construtor para Cliente.
        /// </summary>
        /// <param name="email">Email do cliente.</param>
        /// <param name="nome">Nome do cliente.</param>
        /// <param name="password">Senha do cliente.</param>
        /// <param name="numeroTelemovel">Número de Telemóvel do cliente.</param>
        public Cliente(string email, string nome, string password, int numeroTelemovel)
            : base(email, nome, password, numeroTelemovel)
        { }

        #endregion

        #region Estado

        #endregion
    }
}

