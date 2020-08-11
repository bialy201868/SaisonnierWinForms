using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Controleur;


namespace SaisonnierWinForms
{
    public partial class Accueil_frm : Form
    {
        public string Txt_login { get; set; }
        public string Txt_mdp { get; set; }

        public string Txt_agri_prenom { get; set; }

        public string Txt_agri_nom { get; set; }

        public string Txt_agri_tele { get; set; }

        public string Txt_agri_email { get; set; }

        public int Txt_agri_region { get; set; } = 0;

        public string Txt_agri_description { get; set; }

        public string Txt_agri_login { get; set; }

        public string Txt_agri_mdp { get; set; }

        public string Txt_saison_prenom { get; set; }

        public string Txt_saison_nom { get; set; }

        public string Txt_saison_tele { get; set; }

        public string Txt_saison_email { get; set; }

        public string Txt_saison_date { get; set; }

        public string Txt_saison_description { get; set; }

        public string Txt_saison_login { get; set; }

        public string Txt_saison_mdp { get; set; }

        /// <summary>
        /// check quel bouton a été appuyer, saisonnier ou agriculteur, avant inscription
        /// </summary>
        public bool Saisonnier_check { get; set; } = true;
 
        public string Lbl_titre
        {
            get { return lbl_titre.Text; }
            set { lbl_titre.Text = value; }
        }
   
        public Accueil_frm()
        {         
                InitializeComponent();
                panel_submenu.Visible = false;
        }
        //fonction responsable pour drop-menu "Inscription"
        private void hideSubMenu()
        {
            if (panel_submenu.Visible == true)
            {
                panel_submenu.Visible = false;
            }


        }
        //bouton responsable pour afficher form "Identification_frm" et adaptation manu
        private void btn_identif_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            Identification_frm objForm = new Identification_frm(this);
            objForm.TopLevel = false;
            panel_main.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
          
              
                panel_inscription.Visible = false;
                panel_submenu.Visible = false;                  
                panel_identification.Visible = true;

        }
        //bouton responsable pour drop-menu "Inscription" et fermer les fenêtre ouvert(si il y a)
        private void btn_inscription_Click(object sender, EventArgs e)
        {
            panel_identification.Visible = false;

            lbl_titre.Text = "Bienvenue dans Saisonnier";
            Identification_frm obj = (Identification_frm)Application.OpenForms["Identification_frm"];
            if (Application.OpenForms.OfType<Identification_frm>().Any())
            {
                obj.Close();

            }

            if (panel_submenu.Visible == false)
            {
                panel_submenu.Visible = true;
            }
            else
            {
                panel_submenu.Visible = false;
            }
              
        }
        //buton responsable pour ouvrir la fenêtre "Saisonnier_inscription_frm"
        private void btn_saisonnier_Click(object sender, EventArgs e)
        {
            Saisonnier_check = true;

            panel_main.Controls.Clear();
            Saisonnier_inscription_frm objForm = new Saisonnier_inscription_frm(this);
            objForm.TopLevel = false;
            panel_main.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
            hideSubMenu();


            panel_identification.Visible = false;

            panel_inscription.Visible = true;
             
        }
        //buton responsable pour ouvrir la fenêtre "Agriculteur_inscription_frm"
        private void btn_agriculteur_Click(object sender, EventArgs e)
        {

            Saisonnier_check = false;

            panel_main.Controls.Clear();
            Agriculteur_inscription_frm objForm = new Agriculteur_inscription_frm(this);
            objForm.TopLevel = false;
            panel_main.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
            hideSubMenu();

            panel_identification.Visible = false;

            panel_inscription.Visible = true;           

        }
        //fonction responsable pour vérification du formulaire
        public bool vérification_du_formulaire()
        {
            if (string.IsNullOrEmpty(Txt_agri_login) ||
                string.IsNullOrEmpty(Txt_agri_mdp) ||
                string.IsNullOrEmpty(Txt_agri_prenom) ||
                string.IsNullOrEmpty(Txt_agri_nom) ||
                string.IsNullOrEmpty(Txt_agri_tele) ||
                string.IsNullOrEmpty(Txt_agri_email) ||
                 Txt_agri_region == 0 ||
                string.IsNullOrEmpty(Txt_agri_description)
                )
            {
                lbl_msg_info_error.Text = "Remplissez tous les champs";
                foo();
                async void foo()
                {
                    await Task.Delay(3000);
                    lbl_msg_info_error.Text = "";
                }
                return false;
            }
            return true;
        }
        //buton d'abord vérifie si (saison au agri), ensuite inscription
        public void btn_inscription_agri_or_saison_Click(object sender, EventArgs e)
        {

            if (Saisonnier_check == false)
            {
                if (vérification_du_formulaire())           
                {
                    //création une instance d'objet login
                    login login = new login()
                    {
                        CODE_AUTOR = 1,
                        LOGIN1 = Txt_agri_login,
                        MOT_DE_PASSE = Txt_agri_mdp
                    };
                    //création une instance d'objet LoginCTRL
                    LoginCTRL l = new LoginCTRL();
                    int id_login = l.AddLogin(login);

                    //création une instance d'objet agriculteur
                    agriculteur agriculteur = new agriculteur()
                    {
                        NOM_AGRI = Txt_agri_nom,
                        PRENOM_AGRI = Txt_agri_prenom,
                        MAIL_AGRI = Txt_agri_email,
                        PROFIL_TEXTE = Txt_agri_description,
                        TEL_AGRI = Txt_agri_tele,
                        CODE_REGION = Txt_agri_region,
                        ID_LOGIN = id_login
                    };

                    int code_agri = 0;

                    //création une instance d'objet AgriculteurCTRL
                    AgriculteurCTRL a = new AgriculteurCTRL();

                    code_agri = a.AddToDB(agriculteur);
                    if (code_agri != 0)
                    {
                        //un message confirmation ajouter du profil
                        lbl_msg_info.Text = "Profile Ajoute";
                        foo();
                        async void foo()
                        {
                            //le message disparaît après 3s.
                            await Task.Delay(3000);
                            panel_inscription.Visible = false;
                            lbl_msg_info.Text = "";
                            panel_main.Controls.Clear();
                            lbl_titre.Text = "Bienvenue dans Saisonnier";
                        }
                    }
                }
            }else if(Saisonnier_check == true)
            {
                if (string.IsNullOrEmpty(Txt_saison_login) ||
               string.IsNullOrEmpty(Txt_saison_mdp) ||
               string.IsNullOrEmpty(Txt_saison_prenom) ||
               string.IsNullOrEmpty(Txt_saison_nom) ||
               string.IsNullOrEmpty(Txt_saison_tele) ||
               string.IsNullOrEmpty(Txt_saison_email) ||
                Txt_saison_date == "" ||
               string.IsNullOrEmpty(Txt_saison_description)
               )
                {

                    lbl_msg_info_error.Text = "Remplissez tous les champs";
                    foo();
                    async void foo()
                    {
                        await Task.Delay(3000);
                        lbl_msg_info_error.Text = "";
                    }
                }
                else
                {
                    DateTime date;
                    DateTime.TryParse(Txt_saison_date.ToString(), out date);
                    login login = new login()
                    {
                        CODE_AUTOR = 2,
                        LOGIN1 = Txt_saison_login,
                        MOT_DE_PASSE = Txt_saison_mdp
                    };
                    LoginCTRL l = new LoginCTRL();
                    int id_login = l.AddLogin(login);
                    saisonnier saisonnier = new saisonnier()
                    {
                        NOM_SAISON = Txt_saison_nom,
                        PRENOM_SAISON = Txt_saison_prenom,
                        MAIL_SAISONNIER = Txt_saison_email,
                        PROFIL_TEXTE_SAISON = Txt_saison_description,
                        TEL_SAISONNIER = Txt_saison_tele,
                        DATE_NAISSANCE_SAISON = date,
                        ID_LOGIN = id_login
                    };

                    SaisonnierCTRL s = new SaisonnierCTRL();
                    var code_saison = s.AddToDB(saisonnier);
                    if (code_saison != 0)
                    {
                        lbl_msg_info.Text = "Profile Ajoute";
                        foo();
                        async void foo()
                        {
                            await Task.Delay(3000);
                            lbl_msg_info.Text = "";
                            panel_inscription.Visible = false;
                            panel_main.Controls.Clear();
                            lbl_titre.Text = "Bienvenue dans Saisonnier";
                        }
                    }
                }
            }
        }
        //fonction responsable fermeture de tous les panel
        private void panelChange()
        {
            btn_contact.Visible = false;
            panel_identification.Visible = false;
            panel_inscription.Visible = false;
            panel_submenu.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            btn_identif.Visible = false;
            btn_inscription.Visible = false;
            btn_deconection.Visible = true;
        }
        //bouton responsable pour identification_login et mdp
        private void btn_identification_Click(object sender, EventArgs e)
        {
            LoginCTRL l = new LoginCTRL();
             var login =  l.CheckLogin(Txt_login, Txt_mdp);
            if (Txt_login == "admin" && Txt_mdp == "admin")
            {
                panelChange();
                lbl_msg_info_error.Text = "";
                panel_identification.Visible = false;
                panel_inscription.Visible = false;

                lbl_titre.Text = "Vous êtes connecté en tant que Admin";
                panel_main.Controls.Clear();

                Admin_frm objForm = new Admin_frm();
                objForm.TopLevel = false;
                panel_main.Controls.Add(objForm);
                objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objForm.Dock = DockStyle.Fill;
                objForm.Show();
                hideSubMenu();

                if (panel_inscription.Visible == true)
                {
                    panel_inscription.Visible = false;
                }
            }
            else if (login != null  )
            {
                int id_login = login.ID_LOGIN;
                panelChange();


                if (login.CODE_AUTOR == 1)
                {
                    lbl_msg_info_error.Text = "";
                    panel_identification.Visible = false;
                    panel_inscription.Visible = false;

                    lbl_titre.Text = "Vous êtes connecté en tant que Agriculteur";
                    panel_main.Controls.Clear();
                    
                    Agriculteur_profile objForm = new Agriculteur_profile(id_login,this);
                    objForm.TopLevel = false;
                    panel_main.Controls.Add(objForm);
                    objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    objForm.Dock = DockStyle.Fill;
                    objForm.Show();
                    hideSubMenu();
                 
                       if (panel_inscription.Visible == true)
                       {
                           panel_inscription.Visible = false;
                       }
                }
                else if (login.CODE_AUTOR == 2)
                {
                    lbl_msg_info_error.Text = "";
                    panel_identification.Visible = false;
                    panel_inscription.Visible = false;


                    lbl_titre.Text = "Vous êtes connecté en tant que Saisonnier";
                    panel_main.Controls.Clear();
                    Saisonnier_profile objForm = new Saisonnier_profile(this,id_login);
                    objForm.TopLevel = false;
                    panel_main.Controls.Add(objForm);
                    objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    objForm.Dock = DockStyle.Fill;
                    objForm.Show();
                    hideSubMenu();
                   
                    if (panel_inscription.Visible == true)
                    {
                        panel_inscription.Visible = false;
                    }
                }
            }
            else
            {
                lbl_msg_info_error.Text = "L'utilisateur n'existe pas";
                foo();
                async void foo()
                {
                    await Task.Delay(3000);
                    lbl_msg_info_error.Text = "";

                }
            }
        }
        //bouton flèche retour
        private void btn_back_agriculteur_Click(object sender, EventArgs e)
        {
            lbl_titre.Text = "Bienvenue dans Saisonnier";
            if (Saisonnier_check == false)
            {
                Agriculteur_inscription_frm obj = (Agriculteur_inscription_frm)Application.OpenForms["Agriculteur_inscription_frm"];
                obj.Close();
                panel_main.Controls.Clear();
                panel_inscription.Visible = false;
               
            }else if(Saisonnier_check == true)
            {
                Saisonnier_inscription_frm obj = (Saisonnier_inscription_frm)Application.OpenForms["Saisonnier_inscription_frm"];
                obj.Close();
                panel_main.Controls.Clear();
                panel_inscription.Visible = false;
            }
        }
        ////bouton flèche retour dans "Identification"
        private void btn_back_identification_Click(object sender, EventArgs e)
        {
            Identification_frm obj = (Identification_frm)Application.OpenForms["Identification_frm"];
            obj.Close();
            panel_main.Controls.Clear();
            panel_identification.Visible = false;
            lbl_titre.Text = "Bienvenue dans Saisonnier";
        }
        //buton responsable pour ouvrir la fenêtre "Contact_frm"
        private void btn_contact_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            Contact_frm objForm = new Contact_frm();
            objForm.TopLevel = false;
            panel_main.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
            hideSubMenu();
            panel_inscription.Visible = true;
        
            if (panel_inscription.Visible == true)
            {
                panel_inscription.Visible = false;
            }
            if (panel_identification.Visible == true)
            {
                panel_identification.Visible = false;
            }
        }
        //buton responsable déconnecter profile
        public void btn_deconection_Click(object sender, EventArgs e)
        {

           
            btn_contact.Visible = true;
            panel_main.Controls.Clear();
            lbl_titre.Text = "Bienvenue dans Saisonnier";
            panel1.Visible = true;
            panel2.Visible = true;
            btn_identif.Visible = true;
            btn_inscription.Visible = true;

            btn_deconection.Visible = false;


        }

 
    }
    
}
