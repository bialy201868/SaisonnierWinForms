using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Controleur;
using DAL;


namespace SaisonnierWinForms
{


   
    public partial class Agriculteur_inscription_frm : Form
    {

        public Accueil_frm accueil_frm = null;



    


        public Agriculteur_inscription_frm()
        {
          
           
        }

        public Agriculteur_inscription_frm(Form callingForm)
        {
            this.KeyPreview = true;
            accueil_frm = callingForm as Accueil_frm;



            InitializeComponent();
            customDesign();
            RegionCTRL region = new RegionCTRL();

            var listRegion = region.GetFromDB();


            combo_region.DataSource = new BindingSource(listRegion, null);
            combo_region.ValueMember = "Key";
            combo_region.DisplayMember = "Value";
            combo_region.SelectedIndex = -1;
           
            
         
        }


        private void customDesign()
        {
            panel_menu.Location = new Point(
            this.ClientSize.Width / 2 - panel_menu.Size.Width / 2,
            this.ClientSize.Height / 2 - panel_menu.Size.Height / 2);
            panel_menu.Anchor = AnchorStyles.None;

          


        }
    

        private void Agriculteur_inscription_frm_KeyUp(object sender, KeyEventArgs e)
        {

            accueil_frm.Txt_agri_login = txt_login.Text;
            accueil_frm.Txt_agri_mdp = txt_mdp.Text;

            accueil_frm.Txt_agri_nom = txt_nom.Text;
            accueil_frm.Txt_agri_prenom = txt_prenom.Text;
            accueil_frm.Txt_agri_email = txt_email.Text;
            accueil_frm.Txt_agri_description = txt_description.Text;
            accueil_frm.Txt_agri_tele = txt_tele.Text;

         

        }

    

    
        public  void btn_validation_Click(object sender, EventArgs e)
        {

        



        }

        private void combo_region_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (combo_region.SelectedIndex > 0)
            {
            
                accueil_frm.Txt_agri_region = Int16.Parse(combo_region.SelectedValue.ToString());

            }





        }
    }
 }

