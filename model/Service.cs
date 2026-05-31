using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    public class Service
    {
        public int Idservice { get; }
        public string Nom { get; }


        /// <summary>
        /// Constructeur de la classe Service
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom) 
        {
            this.Idservice = idservice;
            this.Nom = nom;
        }


        /// <summary>
        /// Redéfini l'information à afficher du service (le nom)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Nom;
        }

    }
}
