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
using MediaTek86.view;

namespace MediaTek86
{
   

    /// <summary>
    /// Fenêtre principal affichant les personnels et leurs services
    /// </summary>
    public partial class FrmMediaTek86 : Form
    {

        /// <summary>
        /// Objet gérant la liste des personnels
        /// </summary>
        private BindingSource bdgPersonnels = new BindingSource();

        /// <summary>
        /// Objet gérant la liste des services
        /// </summary>
        private BindingSource bdgServices = new BindingSource();

        /// <summary>
        /// Contrôleur de la fenêtre principale
        /// </summary>
        private FrmMediaTek86Controller controller;

        /// <summary>
        /// Booléen permettant de vérifier si une modification est en cours
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;
        
        /// <summary>
        /// Constructeur de la fenêtre principale + initialisation
        /// </summary>
        public FrmMediaTek86()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmMediaTek86Controller();
            RemplirListePersonnels();
            RemplirListeServices();
        }

        /// <summary>
        /// Affichage des personnels
        /// </summary>
        private void RemplirListePersonnels()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            dgvPersonnels.DataSource = bdgPersonnels;
            dgvPersonnels.Columns["idpersonnel"].Visible = false;
        }

        /// <summary>
        /// Affichage des services dans la comboBox
        /// </summary>
        private void RemplirListeServices()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgServices.DataSource = lesServices;
            cboService.DataSource = bdgServices;
        }

        /// <summary>
        /// Crée et ouvre la fenêtre des absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGererAbsence_Click(object sender, EventArgs e)
        {

            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                FrmAbsences frm = new FrmAbsences();
                frm.personnelSelectionne = personnel;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Un personnel doit être séléctionnée.", "Information");
            }
                
        }

        /// <summary>
        /// Enregistrement de la modification ou de l'ajout d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregPersonnel_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                Service service = (Service)bdgServices.List[bdgServices.Position];
                if (enCoursDeModifPersonnel)
                {
                    Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                    personnel.Nom = txtNom.Text;
                    personnel.Prenom = txtPrenom.Text;
                    personnel.Tel = txtTel.Text;
                    personnel.Mail = txtMail.Text;
                    personnel.Service = service;
                    controller.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service);
                    controller.AddPersonnel(personnel);
                }
                RemplirListePersonnels();
                enCoursModifPersonnel(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// Modification de groupes accessibles selon si le responsable ajoute ou modifie un personnel
        /// </summary>
        /// <param name="modif"></param>
        private void enCoursModifPersonnel(Boolean modif)
        {
            enCoursDeModifPersonnel = modif;
            grbLesPersonnels.Enabled = !modif;

            if (modif) 
            {
                grbPersonnel.Text = "modifier un personnel";
            }
            else
            {
                grbPersonnel.Text = "ajouter un personnel";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
            }
        }


        /// <summary>
        /// Modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0) 
            {
                enCoursModifPersonnel(true);
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                txtNom.Text = personnel.Nom;
                txtPrenom.Text= personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text= personnel.Mail;
                cboService.SelectedIndex = cboService.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }



        }

        /// <summary>
        /// Annulation de l'opération en cours (ajout ou modification d'un personnel) et nettoyage des zones de saisies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulPersonnel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                enCoursModifPersonnel(false);
            }
        }

        /// <summary>
        /// Suppression d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                if (MessageBox.Show("Souhaitez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnels();
                }
            }
            else
            {
                MessageBox.Show("Il faut séléctionner une ligne à supprimer.", "Information");
            }
        }
    }
}
