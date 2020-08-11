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
    public partial class Identification_frm : Form
    {

        public Accueil_frm accueil_frm = null;
        public Identification_frm()
        {
            InitializeComponent();
            customDesign();
           

        }
        public Identification_frm(Form callingForm)
        {
            this.KeyPreview = true;
            accueil_frm = callingForm as Accueil_frm;
            InitializeComponent();
            customDesign();
            string name = "Identification";
            accueil_frm.Lbl_titre = name.ToString();
            txt_mdp.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;

        }

        private void customDesign()
        {
             panel_menu.Location = new Point(
             this.ClientSize.Width / 2 - panel_menu.Size.Width / 2,
             this.ClientSize.Height / 2 - panel_menu.Size.Height / 2);
             panel_menu.Anchor = AnchorStyles.None;

        }

       
        private void Identification_frm_KeyUp(object sender, KeyEventArgs e)
        {
            accueil_frm.Txt_login = txt_login.Text;
            accueil_frm.Txt_mdp = txt_mdp.Text;

          


            
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                txt_mdp.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                //Hides Textbox password
                txt_mdp.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }
    }
}
