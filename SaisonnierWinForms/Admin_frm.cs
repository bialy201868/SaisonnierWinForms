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
    public partial class Admin_frm : Form
    {
        AgriculteurCTRL a = null;
        SaisonnierCTRL s = null;
        PropositionCTRL p = null;
        RegionCTRL r = null;
        bool regionCheck = false;
        public Admin_frm()
        {
            InitializeComponent();
            customDesign();
            a = new AgriculteurCTRL();
            s = new SaisonnierCTRL();
            p = new PropositionCTRL();
            r = new RegionCTRL();
        }
        private void customDesign()
        {
            panel_menu.Location = new Point(
            this.ClientSize.Width / 2 - panel_menu.Size.Width / 2,
            this.ClientSize.Height / 2 - panel_menu.Size.Height / 2);
            panel_menu.Anchor = AnchorStyles.None;
        }

        private void saisonnierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regionCheck = false;
            panel_modif.Visible = false;
            var saisonniers = s.GetFromDB();
            var bindingList = new BindingList<saisonnier>(saisonniers);
            var source = new BindingSource(bindingList, null);
            dg_info_panel.DataSource = source;
        }

        private void agriculteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
             regionCheck = false;
            panel_modif.Visible = false;
            var agriculteurs = a.GetFromDB();
            var bindingList = new BindingList<agriculteur>(agriculteurs);
            var source = new BindingSource(bindingList, null);
            dg_info_panel.DataSource = source;
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_modif.Visible = true;
            btn_ajoute.Enabled = true;
            btn_modif.Enabled = true;
          



            var regions = r.GetRegionListFromDB();
            var bindingList = new BindingList<region>(regions);
            var source = new BindingSource(bindingList, null);
            dg_info_panel.DataSource = source;
            regionCheck = true;
        }

        private void propositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regionCheck = false;
            panel_modif.Visible = false;
            var propositions = p.GetPropositions();
            var bindingList = new BindingList<proposition>(propositions);
            var source = new BindingSource(bindingList, null);
            dg_info_panel.DataSource = source;
        }




        private void btn_ajoute_Click(object sender, EventArgs e)
        {
            var region = new region()
            {
                NOM_REGION = txt_nom_region.Text
            };
            int check = r.AddToDB(region);
            if (check != 0)
            {
                lbl_msg_info.Text = "Région ajoute";
               
            }
            this.Refresh();
        }

        private void btn_modif_Click(object sender, EventArgs e)
        {

            var region = new region()
            {
                CODE_REGION = Int16.Parse(txt_code_region.Text),
                NOM_REGION = txt_nom_region.Text
            };
            int check = r.UpdateDB(region);
            if (check != 0)
            {
                lbl_msg_info.Text = "Région modifie";
                this.Refresh();
            }
        }




  
       private void dg_info_panel_SelectionChanged(object sender, EventArgs e)
        {
            if (regionCheck)
            {
                if (dg_info_panel.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dg_info_panel.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dg_info_panel.Rows[selectedrowindex];


                    txt_code_region.Text = selectedRow.Cells["CODE_REGION"].Value.ToString();
                    txt_nom_region.Text = selectedRow.Cells["NOM_REGION"].Value.ToString();
                }
            }


         
        }

    }

}


