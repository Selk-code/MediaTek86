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
    public partial class FrmAuthentification : Form
    {
        
        /// <summary>
        /// Contrôleur de la fenêtre de connexion
        /// </summary>
        private FrmAuthentificationController controller;
        
        /// <summary>
        /// Constructeur de la fenêtre générant les composants graphiques
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisation du controlleur
        /// </summary>
        private void Init()
        {
            controller = new FrmAuthentificationController();
            txtLogin.Text = "Responsable";
            txtPwd.Text = "motdepasseuser";
            
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string pwd = txtPwd.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Responsable responsable = new Responsable(login, pwd);

                if (controller.ControleAuthentification(responsable))
                {
                    FrmMediaTek86 frm = new FrmMediaTek86();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login et/ou mot de passe saisi incorrect", "Alerte");
                }


            }
        }

       

        private void FrmAuthentification_Shown(object sender, EventArgs e)
        {
            btnConnecter.Focus();
        }
    }
}
