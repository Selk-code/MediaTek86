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
    public partial class FrmAbsences : Form
    {

        private BindingSource bdgAbsences = new BindingSource();

        private BindingSource bdgMotifs = new BindingSource();

        public Personnel personnelSelectionne {  get; set; }

        private FrmAbsenceController controller;

        private Boolean enCoursDeModifAbs;

        public FrmAbsences()
        {
            InitializeComponent();
            Init();
            enCoursModifAbsences(false);
        }

        public void Init()
        {
            controller = new FrmAbsenceController();
            RemplirListeMotifs();
        }

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

        private void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cboService.DataSource = bdgMotifs;
        }
        private void FrmAbsences_Load_1(object sender, EventArgs e)
        {
            RemplirListeAbsences();
            grbAffichageAbsence.Text = $"Absence(s) de {personnelSelectionne.Nom} {personnelSelectionne.Prenom}";
        }

        private void btnAnnulAbsence_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                enCoursModifAbsences(false);
            }
        }

        private void btnEnregAbsence_Click(object sender, EventArgs e)
        {
            if (dtpDebut.Value.Date <= dtpFin.Value.Date)
            {
                Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                if (enCoursDeModifAbs)
                {
                    Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                    absence.Datedebut = dtpDebut.Value.Date;
                    absence.Datefin = dtpFin.Value.Date;
                    absence.Motif = motif;
                    controller.
                }
            }
            else
            {
                MessageBox.Show("La date de début ne peut être postérieure à la date de fin de l'absence", "Information");
            }
        }
    }
}
