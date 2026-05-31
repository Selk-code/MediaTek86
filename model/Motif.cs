using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    public class Motif
    {

        public int Idmotif {  get; }
        public string libelle { get; }


        /// <summary>
        /// Constructeur de la classe Motif
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.Idmotif = idmotif;
            this.libelle = libelle;
        }

        /// <summary>
        /// Redéfini l'information à afficher du motif (le libellé)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.libelle;
        }
    }
}
