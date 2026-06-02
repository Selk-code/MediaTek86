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
    /// Contrôleur de la fenêtre d'authentification
    /// </summary>
    public class FrmAuthentificationController
    {

        /// <summary>
        /// Objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly PersonnelAccess personnelAccess;

        /// <summary>
        /// Constructeur récupérant l'accès aux données
        /// </summary>
        public FrmAuthentificationController()
        {
            personnelAccess = new PersonnelAccess();
        }

        /// <summary>
        /// Méthode vérifiant la connexion du responsable
        /// </summary>
        /// <param name="responsable">objet contenant les informations de connexion du reponsable</param>
        /// <returns> true si les informations sont valides</returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            return personnelAccess.ControleAuthentification(responsable);
        }
    }
}
