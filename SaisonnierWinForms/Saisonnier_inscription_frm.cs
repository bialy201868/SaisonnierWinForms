using System;
using System.Drawing;
using System.Windows.Forms;

namespace SaisonnierWinForms
{
    public partial class Saisonnier_inscription_frm : Form

    {
        public Accueil_frm accueil_frm = null;

        public Saisonnier_inscription_frm() { }

        public Saisonnier_inscription_frm(Form callingForm)
        {
            this.KeyPreview = true;
            accueil_frm = callingForm as Accueil_frm;

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

        private void Saisonnier_inscription_frm_KeyUp(object sender, KeyEventArgs e)
        {
            accueil_frm.Txt_saison_login = txt_login.Text;
            accueil_frm.Txt_saison_mdp = txt_mdp.Text;
            accueil_frm.Txt_saison_nom = txt_nom.Text;
            accueil_frm.Txt_saison_prenom = txt_prenom.Text;
            accueil_frm.Txt_saison_email = txt_email.Text;
            accueil_frm.Txt_saison_description = txt_description.Text;
            accueil_frm.Txt_saison_tele = txt_tele.Text;
            accueil_frm.Txt_saison_date = date_picker.Text;
        }

        public void btn_validation_Click(object sender, EventArgs e)
        {
          
        }
    }
}
