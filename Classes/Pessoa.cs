using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class Pessoa
    {
        #region CONSTRUTOR

        /// <summary>
        /// Construtor para Pessoa
        /// </summary>
        /// <param name="email">email da Pessoa</param>
        /// <param name="nome">nome da Pessoa</param>
        /// <param name="password">password da Pessoa</param>
        /// <param name="numeroTelemovel">numero Telemovel da Pessoa</param>
        public Pessoa(string email, string nome, string password, int numeroTelemovel)
        {
            this.Email = email;
            this.Nome = nome;
            this.Password = password;
            this.NumeroTelemovel = numeroTelemovel;
        }

        #endregion


        #region ESTADO

        /// <summary>
        /// Email de Pessoa
        /// </summary>
        private string Email { get; set; }

        /// <summary>
        /// Nome de Pessoa
        /// </summary>
        private string Nome { get; set; }

        /// <summary>
        /// Password de Pessoa
        /// </summary>
        private String Password { get; set; }

        /// <summary>
        /// Numero Telemovel de Pessoa
        /// </summary>
        private int NumeroTelemovel { get; set; }

        #endregion
    }
}