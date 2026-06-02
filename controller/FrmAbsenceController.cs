using MediaTek86.dal;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.controller
{
    public class FrmAbsenceController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly PersonnelAccess personnelAccess;
        /// <summary>
        /// objet d'accès aux opérations possible sur Absences
        /// </summary>
        private readonly AbsenceAccess absenceAccess;

        /// <summary>
        /// objet d'accès aux opérations possibles sur Motif
        /// </summary>
        private readonly MotifAccess motifAccess;

        public FrmAbsenceController()
        {
            personnelAccess = new PersonnelAccess();
            absenceAccess = new AbsenceAccess();
            motifAccess = new MotifAccess();
        }

        public List<Absence> GetLesAbsences(Personnel personnel)
        {
            return absenceAccess.GetLesAbsences(personnel.Idpersonnel);
        }

        public void UpdateAbsences()
        {
            absenceAccess.
        }

        /// <summary>
        /// Récupère et retourne les infos des motifs
        /// </summary>
        /// <returns></returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }


    }
}
