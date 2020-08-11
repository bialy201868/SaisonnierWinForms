namespace SaisonnierWinForms
{
    partial class Accueil_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil_frm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_identif = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_inscription = new System.Windows.Forms.Button();
            this.btn_contact = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_identification = new System.Windows.Forms.Panel();
            this.btn_identif_back = new System.Windows.Forms.Button();
            this.btn_identification = new System.Windows.Forms.Button();
            this.lbl_msg_info_error = new System.Windows.Forms.Label();
            this.btn_deconection = new System.Windows.Forms.Button();
            this.lbl_msg_info = new System.Windows.Forms.Label();
            this.panel_inscription = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_inscription_agriculteur = new System.Windows.Forms.Button();
            this.btn_back_agriculteur = new System.Windows.Forms.Button();
            this.panel_submenu = new System.Windows.Forms.Panel();
            this.btn_agriculteur = new System.Windows.Forms.Button();
            this.btn_saisonnier = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.panel_identification.SuspendLayout();
            this.panel_inscription.SuspendLayout();
            this.panel_submenu.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 34);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(213, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(561, 124);
            this.panel5.TabIndex = 0;
            // 
            // btn_identif
            // 
            this.btn_identif.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_identif.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_identif.FlatAppearance.BorderSize = 0;
            this.btn_identif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_identif.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_identif.Location = new System.Drawing.Point(0, 34);
            this.btn_identif.Name = "btn_identif";
            this.btn_identif.Size = new System.Drawing.Size(210, 45);
            this.btn_identif.TabIndex = 0;
            this.btn_identif.Text = "S\'identifier";
            this.btn_identif.UseVisualStyleBackColor = false;
            this.btn_identif.Click += new System.EventHandler(this.btn_identif_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 32);
            this.panel2.TabIndex = 1;
            // 
            // btn_inscription
            // 
            this.btn_inscription.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_inscription.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_inscription.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inscription.Location = new System.Drawing.Point(0, 111);
            this.btn_inscription.Name = "btn_inscription";
            this.btn_inscription.Size = new System.Drawing.Size(210, 45);
            this.btn_inscription.TabIndex = 2;
            this.btn_inscription.Text = "Inscription";
            this.btn_inscription.UseVisualStyleBackColor = false;
            this.btn_inscription.Click += new System.EventHandler(this.btn_inscription_Click);
            // 
            // btn_contact
            // 
            this.btn_contact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_contact.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contact.Location = new System.Drawing.Point(0, 634);
            this.btn_contact.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.btn_contact.Name = "btn_contact";
            this.btn_contact.Size = new System.Drawing.Size(210, 45);
            this.btn_contact.TabIndex = 3;
            this.btn_contact.Text = "Contacte-nous";
            this.btn_contact.UseVisualStyleBackColor = true;
            this.btn_contact.Click += new System.EventHandler(this.btn_contact_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Controls.Add(this.panel_identification);
            this.panel_menu.Controls.Add(this.lbl_msg_info_error);
            this.panel_menu.Controls.Add(this.btn_deconection);
            this.panel_menu.Controls.Add(this.lbl_msg_info);
            this.panel_menu.Controls.Add(this.panel_inscription);
            this.panel_menu.Controls.Add(this.panel_submenu);
            this.panel_menu.Controls.Add(this.btn_contact);
            this.panel_menu.Controls.Add(this.btn_inscription);
            this.panel_menu.Controls.Add(this.panel2);
            this.panel_menu.Controls.Add(this.btn_identif);
            this.panel_menu.Controls.Add(this.panel1);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(212, 681);
            this.panel_menu.TabIndex = 0;
            // 
            // panel_identification
            // 
            this.panel_identification.Controls.Add(this.btn_identif_back);
            this.panel_identification.Controls.Add(this.btn_identification);
            this.panel_identification.Location = new System.Drawing.Point(0, 475);
            this.panel_identification.Name = "panel_identification";
            this.panel_identification.Size = new System.Drawing.Size(210, 91);
            this.panel_identification.TabIndex = 13;
            this.panel_identification.Visible = false;
            // 
            // btn_identif_back
            // 
            this.btn_identif_back.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_identif_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_identif_back.BackgroundImage")));
            this.btn_identif_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_identif_back.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_identif_back.Location = new System.Drawing.Point(0, 45);
            this.btn_identif_back.Name = "btn_identif_back";
            this.btn_identif_back.Size = new System.Drawing.Size(210, 45);
            this.btn_identif_back.TabIndex = 4;
            this.btn_identif_back.UseVisualStyleBackColor = false;
            this.btn_identif_back.Click += new System.EventHandler(this.btn_back_identification_Click);
            // 
            // btn_identification
            // 
            this.btn_identification.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_identification.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_identification.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_identification.Location = new System.Drawing.Point(0, 0);
            this.btn_identification.Name = "btn_identification";
            this.btn_identification.Size = new System.Drawing.Size(210, 45);
            this.btn_identification.TabIndex = 3;
            this.btn_identification.Text = "S\'identifier";
            this.btn_identification.UseVisualStyleBackColor = false;
            this.btn_identification.Click += new System.EventHandler(this.btn_identification_Click);
            // 
            // lbl_msg_info_error
            // 
            this.lbl_msg_info_error.AutoSize = true;
            this.lbl_msg_info_error.BackColor = System.Drawing.Color.DarkKhaki;
            this.lbl_msg_info_error.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg_info_error.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_msg_info_error.Location = new System.Drawing.Point(8, 437);
            this.lbl_msg_info_error.Name = "lbl_msg_info_error";
            this.lbl_msg_info_error.Size = new System.Drawing.Size(0, 16);
            this.lbl_msg_info_error.TabIndex = 12;
            // 
            // btn_deconection
            // 
            this.btn_deconection.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_deconection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_deconection.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deconection.Location = new System.Drawing.Point(0, 248);
            this.btn_deconection.Name = "btn_deconection";
            this.btn_deconection.Size = new System.Drawing.Size(210, 53);
            this.btn_deconection.TabIndex = 14;
            this.btn_deconection.Text = "Déconnecter";
            this.btn_deconection.UseVisualStyleBackColor = false;
            this.btn_deconection.Visible = false;
            this.btn_deconection.Click += new System.EventHandler(this.btn_deconection_Click);
            // 
            // lbl_msg_info
            // 
            this.lbl_msg_info.AutoSize = true;
            this.lbl_msg_info.BackColor = System.Drawing.Color.DarkKhaki;
            this.lbl_msg_info.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg_info.ForeColor = System.Drawing.Color.Green;
            this.lbl_msg_info.Location = new System.Drawing.Point(19, 430);
            this.lbl_msg_info.Name = "lbl_msg_info";
            this.lbl_msg_info.Size = new System.Drawing.Size(0, 25);
            this.lbl_msg_info.TabIndex = 12;
            // 
            // panel_inscription
            // 
            this.panel_inscription.Controls.Add(this.btn_inscription_agriculteur);
            this.panel_inscription.Controls.Add(this.btn_back_agriculteur);
            this.panel_inscription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_inscription.Location = new System.Drawing.Point(0, 475);
            this.panel_inscription.Name = "panel_inscription";
            this.panel_inscription.Size = new System.Drawing.Size(210, 159);
            this.panel_inscription.TabIndex = 10;
            this.panel_inscription.Visible = false;
            // 
            // btn_inscription_agriculteur
            // 
            this.btn_inscription_agriculteur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_inscription_agriculteur.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inscription_agriculteur.Location = new System.Drawing.Point(0, 0);
            this.btn_inscription_agriculteur.Margin = new System.Windows.Forms.Padding(0);
            this.btn_inscription_agriculteur.Name = "btn_inscription_agriculteur";
            this.btn_inscription_agriculteur.Size = new System.Drawing.Size(210, 45);
            this.btn_inscription_agriculteur.TabIndex = 4;
            this.btn_inscription_agriculteur.TabStop = false;
            this.btn_inscription_agriculteur.Text = "Inscription";
            this.btn_inscription_agriculteur.UseVisualStyleBackColor = true;
            this.btn_inscription_agriculteur.Click += new System.EventHandler(this.btn_inscription_agri_or_saison_Click);
            // 
            // btn_back_agriculteur
            // 
            this.btn_back_agriculteur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back_agriculteur.BackgroundImage")));
            this.btn_back_agriculteur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back_agriculteur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_back_agriculteur.Location = new System.Drawing.Point(0, 45);
            this.btn_back_agriculteur.Margin = new System.Windows.Forms.Padding(0);
            this.btn_back_agriculteur.Name = "btn_back_agriculteur";
            this.btn_back_agriculteur.Size = new System.Drawing.Size(210, 45);
            this.btn_back_agriculteur.TabIndex = 5;
            this.btn_back_agriculteur.TabStop = false;
            this.btn_back_agriculteur.UseVisualStyleBackColor = true;
            this.btn_back_agriculteur.Click += new System.EventHandler(this.btn_back_agriculteur_Click);
            // 
            // panel_submenu
            // 
            this.panel_submenu.Controls.Add(this.btn_agriculteur);
            this.panel_submenu.Controls.Add(this.btn_saisonnier);
            this.panel_submenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_submenu.Location = new System.Drawing.Point(0, 156);
            this.panel_submenu.Name = "panel_submenu";
            this.panel_submenu.Size = new System.Drawing.Size(210, 92);
            this.panel_submenu.TabIndex = 5;
            // 
            // btn_agriculteur
            // 
            this.btn_agriculteur.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_agriculteur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_agriculteur.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agriculteur.Location = new System.Drawing.Point(0, 40);
            this.btn_agriculteur.Name = "btn_agriculteur";
            this.btn_agriculteur.Size = new System.Drawing.Size(210, 40);
            this.btn_agriculteur.TabIndex = 4;
            this.btn_agriculteur.Text = "Agriculteur";
            this.btn_agriculteur.UseVisualStyleBackColor = false;
            this.btn_agriculteur.Click += new System.EventHandler(this.btn_agriculteur_Click);
            // 
            // btn_saisonnier
            // 
            this.btn_saisonnier.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_saisonnier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_saisonnier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_saisonnier.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saisonnier.Location = new System.Drawing.Point(0, 0);
            this.btn_saisonnier.Name = "btn_saisonnier";
            this.btn_saisonnier.Size = new System.Drawing.Size(210, 40);
            this.btn_saisonnier.TabIndex = 4;
            this.btn_saisonnier.Text = "Saisonnier";
            this.btn_saisonnier.UseVisualStyleBackColor = false;
            this.btn_saisonnier.Click += new System.EventHandler(this.btn_saisonnier_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Transparent;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(212, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.panel_main.Size = new System.Drawing.Size(1178, 681);
            this.panel_main.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.lbl_titre);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(212, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1178, 105);
            this.panel6.TabIndex = 6;
            // 
            // lbl_titre
            // 
            this.lbl_titre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_titre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titre.Font = new System.Drawing.Font("Roboto Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(0, 0);
            this.lbl_titre.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(1178, 100);
            this.lbl_titre.TabIndex = 0;
            this.lbl_titre.Text = "Bienvenue dans Saisonnier";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Accueil_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1390, 681);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_menu);
            this.MinimumSize = new System.Drawing.Size(1130, 718);
            this.Name = "Accueil_frm";
            this.Text = "Accueil Saisonnier";
            this.panel1.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel_identification.ResumeLayout(false);
            this.panel_inscription.ResumeLayout(false);
            this.panel_submenu.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_identif;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_inscription;
        private System.Windows.Forms.Button btn_contact;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Button btn_agriculteur;
        private System.Windows.Forms.Button btn_saisonnier;
        private System.Windows.Forms.Panel panel_submenu;
        private System.Windows.Forms.FlowLayoutPanel panel_inscription;
        private System.Windows.Forms.Button btn_inscription_agriculteur;
        private System.Windows.Forms.Button btn_back_agriculteur;
        private System.Windows.Forms.Label lbl_msg_info;
        private System.Windows.Forms.Panel panel_identification;
        private System.Windows.Forms.Button btn_identification;
        private System.Windows.Forms.Button btn_identif_back;
        private System.Windows.Forms.Label lbl_msg_info_error;
        private System.Windows.Forms.Button btn_deconection;
    }
}