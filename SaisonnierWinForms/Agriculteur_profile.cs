using Controleur;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaisonnierWinForms
{
    public partial class Agriculteur_profile : Form
    {
        RegionCTRL r = null;
        AgriculteurCTRL a = null;
        PropositionCTRL p = null;
        agriculteur agri = null;
        public Accueil_frm accueil_frm = null;

        //pour vérifier sur quelle page nous sommes// pour button [valider] true == modifie profile
        bool checkPage = true;
        public Agriculteur_profile(int idlogin, Form callingForm)
        {
            accueil_frm = callingForm as Accueil_frm;
            r = new RegionCTRL();
            p = new PropositionCTRL();
            a = new AgriculteurCTRL();
            agri = a.GetAgri(idlogin);
            InitializeComponent();
            customDesign();
        }
        public Agriculteur_profile()
        {
            InitializeComponent();
            customDesign();
        }
        private void customDesign()
        {
            panel_menu.Location = new Point(
            this.ClientSize.Width / 2 - panel_menu.Size.Width / 2,
            this.ClientSize.Height / 2 - panel_menu.Size.Height / 2);
            panel_menu.Anchor = AnchorStyles.None;
        }

        private void btn_ajoute_offre_Click(object sender, EventArgs e)
        {
            btn_supprime_profil.Visible = false;
            panel_profil_info.Visible = false;
            panel_ajoute_offre.Visible = true;
            panel_profil_info.Enabled = false;
            panel_ajoute_offre.Enabled = true;
            panel_valide_reset.Visible = true;
            checkPage = false;
        
        }

        private void btn_modif_profil_Click(object sender, EventArgs e)
        {
            
            btn_supprime_profil.Visible = false;
            panel_ajoute_offre.Visible = false;
            panel_profil_info.Visible = true;
            panel_ajoute_offre.Enabled = false;
            panel_profil_info.Enabled = true;
            panel_valide_reset.Visible = true;

            var allRegions = r.GetFromDB();

            combo_region.DataSource = new BindingSource(allRegions, null);
            combo_region.ValueMember = "Key";
            combo_region.DisplayMember = "Value";
            //combo_region.SelectedIndex = -1;
          
            region region =  r.GetRegion(agri.CODE_REGION);
            txt_nom.Text = agri.NOM_AGRI;
            txt_prenom.Text = agri.PRENOM_AGRI;
            txt_email.Text = agri.MAIL_AGRI;
            txt_tele.Text = agri.TEL_AGRI;
            txt_description.Text = agri.PROFIL_TEXTE;
            combo_region.Text = region.NOM_REGION;
            checkPage = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            panel_valide_reset.Visible = false;
            panel_profil_info.Visible = false;
            panel_profil_info.Enabled = false;
            panel_ajoute_offre.Visible = false;    
            panel_ajoute_offre.Enabled = false;
            btn_supprime_profil.Visible = true;
        }

        private void btn_valide_Click(object sender, EventArgs e)
        {
            if (checkPage ==false)
            {
                DateTime d_debut;
                DateTime d_fin;
                DateTime.TryParse(date_debut.Text, out d_debut);
                DateTime.TryParse(date_fin.Text, out d_fin);

                bool dateCorrect = d_debut <= d_fin;
                if (dateCorrect)
                {
                    proposition proposition = new proposition()
                    {
                        CODE_AGRI = agri.CODE_AGRI,
                        DATE_DEBUT_PROPO = d_debut,
                        DATE_FIN_PROPO = d_fin,
                        SALAIRE_BRUT_HORAIRE = (float)Convert.ToDouble(numeric_salaire.Text),
                        NB_PLACES = Int16.Parse(numeric_place.Text),
                        NB_HEURES_JOUR = (float)Convert.ToDouble(numeric_heures.Text),
                        NB_JOURS_SEMAINE = (float)Convert.ToDouble(numeric_jour.Text),
                        PUBLIEE = 0
                    };
                    int nb_proposition = p.AddProposition(proposition, agri.CODE_AGRI);
                    lbl_info.Text = "*Vous avez ajouté vôtre " + nb_proposition + " proposition";
                    foo();
                    async void foo()
                    {
                        await Task.Delay(3000);
                        lbl_info.Text = "";
                    }
                }
                else
                {
                 
                    lbl_info.Text = "Date invalide!";
                    foo();
                    async void foo()
                    {
                        await Task.Delay(3000);
                        lbl_info.Text = "";
                    }
                }
               
            }

            else if (checkPage == true)
            {
                agriculteur agriModifie = new agriculteur()
                {
                    NOM_AGRI = txt_nom.Text,
                    PRENOM_AGRI = txt_prenom.Text,
                    TEL_AGRI = txt_tele.Text,
                    MAIL_AGRI = txt_email.Text,
                    PROFIL_TEXTE = txt_description.Text,
                    CODE_REGION = Int16.Parse(combo_region.SelectedValue.ToString()),
                    CODE_AGRI = agri.CODE_AGRI,
                    ID_LOGIN = agri.ID_LOGIN

                };

                int chechOK = a.UpdateDB(agriModifie);
                if (chechOK > 0)
                {
                    lbl_info.Text = "Profile modifié!";
                    foo();
                    async void foo()
                    {
                        await Task.Delay(3000);
                        lbl_info.Text = "";

                    }
                }
            }                
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (checkPage)
            {
                txt_nom.Text = "";
                txt_prenom.Text = "";
                txt_tele.Text = "";
                txt_email.Text = "";
                txt_description.Text = "";
                combo_region.Text = "";
            }
            else if (checkPage == false)
            {

                numeric_salaire.Text = "";
                numeric_place.Text = ""
; numeric_heures.Text = "";
                numeric_jour.Text = "";

            }
        }



        private void btn_supprime_profil_Click(object sender, EventArgs e)
        {
         

            int chechOK = a.DeleteFromDB(agri);
            
            if (chechOK > 0)
            {
                lbl_info.Text = "Profile supprimé";
                foo();
                async void foo()
                {
                    await Task.Delay(2000);
                    lbl_info.Text = "";

                    accueil_frm.btn_deconection_Click(this, e);
                }
            }
        }

      
    }
}
