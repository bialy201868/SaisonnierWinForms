using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controleur;
using DAL;

namespace SaisonnierWinForms
{
    public partial class Saisonnier_profile : Form
    {
        SaisonnierCTRL s = null;
        saisonnier saisonnier = null;
        PropositionCTRL p = null;
        Accueil_frm accueil_frm = null;
        //if page active == modifeprofile ? checkPage == true;
        bool checkPage = true;

        public Saisonnier_profile(Form frm,int idlogin)
        {
            s = new SaisonnierCTRL();        
            p = new PropositionCTRL();
            accueil_frm = frm as Accueil_frm;
            saisonnier = s.GetSaisonnier(idlogin);
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

        private void btn_recherche_offre_Click(object sender, EventArgs e)
        {
            btn_reset.Visible = false;
            btn_inscription_proposition.Visible = true;

            btn_supprime_profil.Visible = false;
            panel_recherche_offre.Visible = true;
            panel_recherche_offre.Enabled = true;
            panel_profil_info.Visible = false;
            panel_profil_info.Enabled = false;
            panel_valide_reset.Visible = true;
            lbl_info.Text = "";
            checkPage = false;





        }

        private void btn_modif_profil_Click(object sender, EventArgs e)
        {
            btn_reset.Visible = true;
            btn_inscription_proposition.Visible = false;
            lbl_info.Text = "";
            btn_supprime_profil.Visible = false;
            panel_recherche_offre.Visible = false;
            panel_recherche_offre.Enabled = false;
           
            panel_profil_info.Enabled = true;
            panel_valide_reset.Visible = true;
            panel_profil_info.Visible = true;

            txt_prenom.Text = saisonnier.PRENOM_SAISON;
            txt_nom.Text = saisonnier.NOM_SAISON;
            txt_email.Text = saisonnier.MAIL_SAISONNIER;
            txt_tele.Text = saisonnier.TEL_SAISONNIER;
            txt_description.Text = saisonnier.PROFIL_TEXTE_SAISON;
            if (saisonnier.DATE_NAISSANCE_SAISON.ToString() == "01/01/0001 00:00:00")
            {
               datepicker.Text = "01/01/2000";
            }
            else
            {
                datepicker.Text = saisonnier.DATE_NAISSANCE_SAISON.ToString();
            }

            checkPage = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            btn_reset.Visible = true;
            btn_inscription_proposition.Visible = false;

            panel_valide_reset.Visible = false;

            panel_recherche_offre.Visible = false;
            panel_recherche_offre.Enabled = false;
            panel_profil_info.Visible = false;
            panel_profil_info.Enabled = false;

            btn_supprime_profil.Visible = true;

            lbl_info.Text = "";
        }

        private void btn_valide_Click(object sender, EventArgs e)
        {
          
            if (checkPage)
            {
                DateTime dt = this.datepicker.Value.Date;
                saisonnier = new saisonnier()
                {
                    NOM_SAISON = txt_nom.Text,
                    PRENOM_SAISON = txt_prenom.Text,
                    MAIL_SAISONNIER = txt_email.Text,
                    TEL_SAISONNIER = txt_tele.Text,
                    PROFIL_TEXTE_SAISON = txt_description.Text,
                    DATE_NAISSANCE_SAISON = dt,
                    CODE_SAISONNIER = saisonnier.CODE_SAISONNIER,
                    ID_LOGIN = saisonnier.ID_LOGIN
                };

               int confirm =  s.UpdateDB(saisonnier);
                if (confirm > 0)
                {
                    lbl_info.Text = "*Profile modifié";
                    foo();
                    async void foo()
                    {
                        await Task.Delay(3000);
                        lbl_info.Text = "";
                    }
                }

            }
            else if (checkPage == false)
            {

                var propositions = p.GetPropositions(date_debut.Value);

                    var bindingList = new BindingList<proposition>(propositions);
                var source = new BindingSource(bindingList, null);
                dg_all_propositions.DataSource = source;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (checkPage)
            {
                txt_nom.Text = "";
                txt_prenom.Text = "";
                txt_email.Text = "";
                txt_tele.Text = "";
                txt_description.Text = "";
            }
            
            
           
        }

        private void btn_supprime_profil_Click(object sender, EventArgs e)
        {
            int chechOK = s.DeleteFromDB(saisonnier);

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


        int value = 0;
        int code = 0;
        bool dejaInscrit = false;
        int codeInscrit = 0;
        private void btn_inscription_proposition_Click(object sender, EventArgs e)
        {
       


            if (value > 0 && dejaInscrit == false)
            {
                p.UpdatePropositionMinus(code);
                foreach (DataGridViewRow Myrow in dg_all_propositions.Rows)
                {
                    
                        if (Myrow.Cells["CODE_PROPOS"].Value.ToString() == code.ToString())
                        {
                           codeInscrit = code;
                            Myrow.DefaultCellStyle.BackColor = Color.Green;
                        }
                   
                  
                }
                lbl_info.Text = "Vous êtes inscrit..bravo!";
                foo();
                async void foo()
                {
                    await Task.Delay(3000);
                    lbl_info.Text = "";

                }
                dejaInscrit = true;
                btn_inscription_proposition.Visible = false;
                btn_deinscrire.Visible = true;
               
                this.Refresh();
            }
            else
            {
                this.lbl_info.BackColor = Color.Red;
                lbl_info.Text = "Vous êtes deja inscrit Madame!!";
                foo();
                async void foo()
                {
                    await Task.Delay(3000);
                    lbl_info.Text = "";
                    this.lbl_info.BackColor = Color.White;

                }
            }
        



        }

        private void btn_deinscription_proposition_Click(object sender, EventArgs e)
        {



            if (dejaInscrit == true)
            {
                p.UpdatePropositionPlus(codeInscrit);
                foreach (DataGridViewRow Myrow in dg_all_propositions.Rows)
                {
                   
                    
                        if (Myrow.Cells["CODE_PROPOS"].Value.ToString() == codeInscrit.ToString())
                        {
                            Myrow.DefaultCellStyle.BackColor = Color.White;
                        }
                    
                  

                }
                lbl_info.Text = "Vous êtes deinscrit!";
                foo();
                async void foo()
                {
                    await Task.Delay(3000);
                    lbl_info.Text = "";

                }
                dejaInscrit = true;
                btn_inscription_proposition.Visible = false;
                btn_deinscrire.Visible = true;

                btn_inscription_proposition.Visible = true;
                btn_deinscrire.Visible = false;
                dejaInscrit = false;

                this.Refresh();
            }
        




        }


        private void dg_all_propositions_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dg_all_propositions.SelectedCells.Count > 0)
            {
                int selectedrowindex = dg_all_propositions.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dg_all_propositions.Rows[selectedrowindex];
              

                    int valueTEST = (int)selectedRow.Cells["NB_PLACES"].Value;
           


                    if (valueTEST > 0)
                    {
                    code = Int16.Parse(selectedRow.Cells["CODE_PROPOS"].Value.ToString());
                    value = valueTEST;
                    }
                    else if (valueTEST <= 0)
                    {
                        this.lbl_info.BackColor = Color.Red;
                        lbl_info.Text = "Il n'y a plus de places..sorry!";
                        foo();
                        async void foo()
                        {
                            await Task.Delay(3000);
                            lbl_info.Text = "";
                            this.lbl_info.BackColor = Color.White;

                        }

                    }
                    else
                    {
                        this.lbl_info.BackColor = Color.Red;
                        lbl_info.Text = "Error! ...sorry";
                        foo();
                        async void foo()
                        {
                            await Task.Delay(3000);
                            lbl_info.Text = "";
                            this.lbl_info.BackColor = Color.White;

                        }
                    }
                
                



            }
        }
    }
}
