using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Staff : Pessoa
{
    #region Construtor

    /// <summary>
    /// Construtor para Staff.
    /// </summary>
    /// <param name="email">Email do staff.</param>
    /// <param name="nome">Nome do staff.</param>
    /// <param name="password">Senha do staff.</param>
    /// <param name="numeroTelemovel">Número de Telemóvel do staff.</param>
    public Staff(string email, string nome, string password, int numeroTelemovel, int staffID)
        : base(email, nome, password, numeroTelemovel)
    {
        StaffID = staffID;
    }

    #endregion

    #region Estado

    public int StaffID { get; private set; }

    #endregion
}