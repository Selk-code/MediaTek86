using MediaTek86.controller;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.view
{
    /// <summary>
    /// Fenêtre affichant les absences d'un personnel et leurs motifs
    /// </summary>
    public partial class FrmAbsences : Form
    {

        /// <summary>
        /// Objet gérant la liste des absences
        /// </summary>
        private BindingSource bdgAbsences = new BindingSource();

        /// <summary>
        /// Objet gérant la liste des motifs
        /// </summary>
        private BindingSource bdgMotifs = new BindingSource();

        /// <summary>
        /// Récupère le personnel sélectionné dans la fenêtre principale
        /// </summary>
        public Personnel personnelSelectionne {  get; set; }

        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FrmAbsenceController controller;

        /// <summary>
        /// Booléen vérifiant si une modification d'absence est en cours
        /// </summary>
        private Boolean enCoursDeModifAbs;

        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmAbsences()
        {
            InitializeComponent();
            Init();
            enCoursModifAbsences(false);
        }

        /// <summary>
        /// Création du controleur et remplissage de la liste des Motifs
        /// </summary>
        public void Init()
        {
            controller = new FrmAbsenceController();
            RemplirListeMotifs();
        }

        /// <summary>
        /// Affichage des absences
        /// </summary>
        private void RemplirListeAbsences()
        {

            List<Absence> lesAbsences = controller.GetLesAbsences(personnelSelectionne);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = false;

        
        }

        /// <summary>
        /// Modification de groupes accessibles selon si le responsable ajoute ou modifie un personnel
        /// </summary>
        /// <param name="modif"></param>
        private void enCoursModifAbsences(Boolean modif)
        {
            enCoursDeModifAbs = modif;
            grbAffichageAbsence.Enabled = !modif;

            if (modif)
            {
                grbAjoutAbsence.Text = "modifier une absence";
            }
            else
            {
                grbAjoutAbsence.Text = "ajouter un personnel";
               
            }
        }

        /// <summary>
        /// Affichage des motifs
        /// </summary>
        private void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cboMotif.DataSource = bdgMotifs;
        }
        
        /// <summary>
        /// Remplissage de la liste des absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAbsences_Load_1(object sender, EventArgs e)
        {
            RemplirListeAbsences();
            grbAffichageAbsence.Text = $"Absence(s) de {personnelSelectionne.Nom} {personnelSelectionne.Prenom}";
        }

        /// <summary>
        /// Annulation de l'operation en cours (modification ou ajout d'une absence)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulAbsence_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                enCoursModifAbsences(false);
            }
        }
        /// <summary>
        /// Enregistrement de la modification ou l'ajout d'une absence en évitant les chevauchements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregAbsence_Click(object sender, EventArgs e)
        {
            if (dtpDebut.Value.Date <= dtpFin.Value.Date)
            {
                Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];

                if (enCoursDeModifAbs)
                {
                    Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];

                    bool doublon = false;

                    foreach (Absence a in bdgAbsences.List)
                    {
                        if (a.Datedebut != absence.Datedebut) 
                        {
                            if (dtpDebut.Value.Date <= a.Datefin && dtpFin.Value.Date >= a.Datedebut)
                            {
                                doublon = true;
                                break;
                            }
                        }
                    }

                    if (doublon)
                    {
                        MessageBox.Show("Votre absence en chevauche une autre, veuillez choisir d'autres dates.", "Information");
                    }
                    else
                    {
                        DateTime ancienneDateDebut = absence.Datedebut;
                        absence.Datedebut = dtpDebut.Value.Date;
                        absence.Datefin = dtpFin.Value.Date;
                        absence.Motif = motif;
                        controller.UpdateAbsences(absence, ancienneDateDebut);
                    }
                    
                }
                else
                {
                    bool doublon = false;

                    foreach (Absence a in bdgAbsences.List)
                    {
                        if (dtpDebut.Value.Date <= a.Datefin && dtpFin.Value.Date >= a.Datedebut)
                        {
                            doublon = true;
                            break;
                        }
                    }

                    if (doublon)
                    {
                        MessageBox.Show("Votre absence en chevauche une autre, veuillez choisir d'autres dates.", "Information");
                    }
                    else
                    {
                        Absence absence = new Absence(personnelSelectionne.Idpersonnel, dtpDebut.Value.Date, dtpFin.Value.Date, motif);
                        controller.AddAbsence(absence);
                    }
                    
                }
                RemplirListeAbsences();
                enCoursModifAbsences(false);
            }
            else
            {
                MessageBox.Show("La date de début ne peut être postérieure à la date de fin de l'absence, veuillez choisir d'autres dates.", "Information");
            }
        }

        /// <summary>
        /// Modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0) 
            {
                enCoursModifAbsences(true);
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                dtpDebut.Value = absence.Datedebut;
                dtpFin.Value = absence.Datefin;
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.Motif.libelle);
            }
            else
            {
                MessageBox.Show("Une absence doit être sélectionnée.", "Information");
            }
        }
        /// <summary>
        /// Suppression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show(
                    $"Voulez-vous vraiment supprimer l'absence de " + personnelSelectionne.Nom + " " + personnelSelectionne.Prenom + " ?\n" +
                    $"Du {absence.Datedebut.Date.ToString("dd/MM/yyyy")} au {absence.Datefin.Date.ToString("dd/MM/yyyy")}", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsences();
                }
            }
            else
            {
                MessageBox.Show("Une absence doit être sélectionnée.", "Information");
            }
        }
    }
}
