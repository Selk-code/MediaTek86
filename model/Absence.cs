using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    public class Absence
    {

        /// <summary>
        /// Constructeur de la classe Absence
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>
        public Absence(Personnel idpersonnel, DateTime datedebut, DateTime datefin, Motif idmotif)
        {
            Idpersonnel = idpersonnel;
            Datedebut = datedebut;
            Datefin = datefin;
            Idmotif = idmotif;
        }

        public Personnel Idpersonnel { get; }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }
        
        public Motif Idmotif { get; }


       

    }
}
