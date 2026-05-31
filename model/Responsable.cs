using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{

    /// <summary>
    /// Classe contenant les informations d'authentifications du responsable
    /// </summary>
    public class Responsable
    {

        public string login { get; }
        public string pwd { get; }

        /// <summary>
        /// Constructeur de la classe Responsable
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }
    }
}
