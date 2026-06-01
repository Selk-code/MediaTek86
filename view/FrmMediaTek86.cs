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
    public partial class FrmMediaTek86 : Form
    {
        private BindingSource bdgPersonnels = new BindingSource();

        private BindingSource bdgServices = new BindingSource();

        private FrmMediaTek86Controller controller;

        private Boolean enCoursDeModifPersonnel = false;
        
        
        public FrmMediaTek86()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            controller = new FrmMediaTek86Controller();
            RemplirListePersonnels();
            RemplirListeServices();
        }

        private void RemplirListePersonnels()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            dgvPersonnels.DataSource = bdgPersonnels;
            dgvPersonnels.Columns["idpersonnel"].Visible = false;
        }

        private void RemplirListeServices()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgServices.DataSource = lesServices;
            cboService.DataSource = bdgServices;
        }

        private void btnGererAbsence_Click(object sender, EventArgs e)
        {
            FrmAbsences frm = new FrmAbsences();
            frm.ShowDialog();
        }

        private void btnEnregPersonnel_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                Service service = (Service)bdgServices.List[bdgServices.Position];
                if (enCoursDeModifPersonnel)
                {
                    Personnel personnel = (Personnel)bdgPersonnels.List[bdgServices.Position];
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
        }

        private void enCoursModifPersonnel(Boolean modif)
        {
            enCoursDeModifPersonnel = modif;
            grbPersonnel.Enabled = !modif;

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
    }
}
