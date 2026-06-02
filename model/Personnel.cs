using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe contenant les informations d'un personnel
    /// </summary>
    public class Personnel
    {

        public int Idpersonnel { get; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public Service Service { get; set; }

        /// <summary>
        /// Constructeur de la classe Personnel
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idservice"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, Service idservice)
        {
            Idpersonnel = idpersonnel;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
            Mail = mail;
            Service = idservice;
        }
    }
}
