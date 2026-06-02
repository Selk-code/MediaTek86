using MediaTek86.dal;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.controller
{
    /// <summary>
    /// Contrôleur de FrmAbsence
    /// </summary>
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

        /// <summary>
        /// Constructeur récupérant les accès aux données
        /// </summary>
        public FrmAbsenceController()
        {
            personnelAccess = new PersonnelAccess();
            absenceAccess = new AbsenceAccess();
            motifAccess = new MotifAccess();
        }

        /// <summary>
        /// Récupère et retourne les infos des absences
        /// </summary>
        /// <param name="personnel"></param>
        /// <returns></returns>
        public List<Absence> GetLesAbsences(Personnel personnel)
        {
            return absenceAccess.GetLesAbsences(personnel.Idpersonnel);
        }

        /// <summary>
        /// Ajout d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public void AddAbsence(Absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }
        
        /// <summary>
        /// Suppression d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }
        /// <summary>
        /// Modification d'une absence
        /// </summary>
        /// <param name="absence">Objet absence contenant les nouvelles informations</param>
        /// <param name="ancienneDateDebut">Objet contenant la date de début originale de l'absence afin d'identifier la ligne à modifier dans la base de données</param>
        public void UpdateAbsences(Absence absence, DateTime ancienneDateDebut)
        {
            absenceAccess.UpdateAbsence(absence, ancienneDateDebut);
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
