namespace SaisonnierWinForms
{
    partial class Saisonnier_profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saisonnier_profile));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.lbl_info = new System.Windows.Forms.Label();
            this.panel_profil_info = new System.Windows.Forms.Panel();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_tele = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.lbl_tele = new System.Windows.Forms.Label();
            this.panel_recherche_offre = new System.Windows.Forms.Panel();
            this.dg_all_propositions = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_date_debut = new System.Windows.Forms.Label();
            this.date_debut = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_valide_reset = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_deinscrire = new System.Windows.Forms.Button();
            this.btn_inscription_proposition = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_valide = new System.Windows.Forms.Button();
            this.btn_supprime_profil = new System.Windows.Forms.Button();
            this.btn_modif_profil = new System.Windows.Forms.Button();
            this.btn_recherche_offre = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            this.panel_profil_info.SuspendLayout();
            this.panel_recherche_offre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_all_propositions)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_valide_reset.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_menu.Controls.Add(this.lbl_info);
            this.panel_menu.Controls.Add(this.panel_recherche_offre);
            this.panel_menu.Controls.Add(this.panel3);
            this.panel_menu.Location = new System.Drawing.Point(180, 78);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(852, 480);
            this.panel_menu.TabIndex = 0;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(257, 3);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 23);
            this.lbl_info.TabIndex = 10;
            // 
            // panel_profil_info
            // 
            this.panel_profil_info.BackColor = System.Drawing.Color.White;
            this.panel_profil_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_profil_info.Controls.Add(this.datepicker);
            this.panel_profil_info.Controls.Add(this.lbl_date);
            this.panel_profil_info.Controls.Add(this.txt_nom);
            this.panel_profil_info.Controls.Add(this.lbl_nom);
            this.panel_profil_info.Controls.Add(this.txt_description);
            this.panel_profil_info.Controls.Add(this.txt_tele);
            this.panel_profil_info.Controls.Add(this.label1);
            this.panel_profil_info.Controls.Add(this.label2);
            this.panel_profil_info.Controls.Add(this.lbl_description);
            this.panel_profil_info.Controls.Add(this.txt_email);
            this.panel_profil_info.Controls.Add(this.txt_prenom);
            this.panel_profil_info.Controls.Add(this.lbl_tele);
            this.panel_profil_info.Enabled = false;
            this.panel_profil_info.Location = new System.Drawing.Point(0, 1);
            this.panel_profil_info.Name = "panel_profil_info";
            this.panel_profil_info.Size = new System.Drawing.Size(623, 335);
            this.panel_profil_info.TabIndex = 1;
            this.panel_profil_info.Visible = false;
            // 
            // datepicker
            // 
            this.datepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker.Location = new System.Drawing.Point(17, 213);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(275, 29);
            this.datepicker.TabIndex = 8;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(17, 178);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(114, 18);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Date de naissance";
            // 
            // txt_nom
            // 
            this.txt_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.Location = new System.Drawing.Point(328, 53);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(275, 29);
            this.txt_nom.TabIndex = 4;
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.Location = new System.Drawing.Point(327, 18);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(36, 18);
            this.lbl_nom.TabIndex = 0;
            this.lbl_nom.Text = "Nom";
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.Location = new System.Drawing.Point(328, 213);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(275, 98);
            this.txt_description.TabIndex = 7;
            // 
            // txt_tele
            // 
            this.txt_tele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tele.Location = new System.Drawing.Point(328, 133);
            this.txt_tele.Name = "txt_tele";
            this.txt_tele.Size = new System.Drawing.Size(275, 29);
            this.txt_tele.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(327, 178);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(75, 18);
            this.lbl_description.TabIndex = 0;
            this.lbl_description.Text = "Description";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(17, 133);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(275, 29);
            this.txt_email.TabIndex = 5;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prenom.Location = new System.Drawing.Point(17, 53);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(275, 29);
            this.txt_prenom.TabIndex = 3;
            // 
            // lbl_tele
            // 
            this.lbl_tele.AutoSize = true;
            this.lbl_tele.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tele.Location = new System.Drawing.Point(327, 98);
            this.lbl_tele.Name = "lbl_tele";
            this.lbl_tele.Size = new System.Drawing.Size(68, 18);
            this.lbl_tele.TabIndex = 0;
            this.lbl_tele.Text = "Téléphone";
            // 
            // panel_recherche_offre
            // 
            this.panel_recherche_offre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_recherche_offre.Controls.Add(this.dg_all_propositions);
            this.panel_recherche_offre.Controls.Add(this.panel2);
            this.panel_recherche_offre.Enabled = false;
            this.panel_recherche_offre.Location = new System.Drawing.Point(16, 26);
            this.panel_recherche_offre.Name = "panel_recherche_offre";
            this.panel_recherche_offre.Size = new System.Drawing.Size(626, 424);
            this.panel_recherche_offre.TabIndex = 9;
            this.panel_recherche_offre.Visible = false;
            // 
            // dg_all_propositions
            // 
            this.dg_all_propositions.AllowUserToAddRows = false;
            this.dg_all_propositions.AllowUserToResizeColumns = false;
            this.dg_all_propositions.AllowUserToResizeRows = false;
            this.dg_all_propositions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_all_propositions.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dg_all_propositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_all_propositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_all_propositions.Location = new System.Drawing.Point(0, 112);
            this.dg_all_propositions.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.dg_all_propositions.MultiSelect = false;
            this.dg_all_propositions.Name = "dg_all_propositions";
            this.dg_all_propositions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dg_all_propositions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_all_propositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_all_propositions.Size = new System.Drawing.Size(622, 308);
            this.dg_all_propositions.TabIndex = 10;
            this.dg_all_propositions.SelectionChanged += new System.EventHandler(this.dg_all_propositions_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbl_date_debut);
            this.panel2.Controls.Add(this.panel_profil_info);
            this.panel2.Controls.Add(this.date_debut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 112);
            this.panel2.TabIndex = 0;
            // 
            // lbl_date_debut
            // 
            this.lbl_date_debut.AutoSize = true;
            this.lbl_date_debut.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_debut.Location = new System.Drawing.Point(174, 24);
            this.lbl_date_debut.Name = "lbl_date_debut";
            this.lbl_date_debut.Size = new System.Drawing.Size(91, 23);
            this.lbl_date_debut.TabIndex = 0;
            this.lbl_date_debut.Text = "Date debut";
            // 
            // date_debut
            // 
            this.date_debut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_debut.Location = new System.Drawing.Point(178, 64);
            this.date_debut.Name = "date_debut";
            this.date_debut.Size = new System.Drawing.Size(283, 30);
            this.date_debut.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel_valide_reset);
            this.panel3.Controls.Add(this.btn_supprime_profil);
            this.panel3.Controls.Add(this.btn_modif_profil);
            this.panel3.Controls.Add(this.btn_recherche_offre);
            this.panel3.Location = new System.Drawing.Point(655, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 426);
            this.panel3.TabIndex = 0;
            // 
            // panel_valide_reset
            // 
            this.panel_valide_reset.Controls.Add(this.btn_back);
            this.panel_valide_reset.Controls.Add(this.btn_deinscrire);
            this.panel_valide_reset.Controls.Add(this.btn_inscription_proposition);
            this.panel_valide_reset.Controls.Add(this.btn_reset);
            this.panel_valide_reset.Controls.Add(this.btn_valide);
            this.panel_valide_reset.Location = new System.Drawing.Point(0, 200);
            this.panel_valide_reset.Name = "panel_valide_reset";
            this.panel_valide_reset.Size = new System.Drawing.Size(175, 118);
            this.panel_valide_reset.TabIndex = 2;
            this.panel_valide_reset.Visible = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_back.Location = new System.Drawing.Point(0, 79);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(175, 39);
            this.btn_back.TabIndex = 1;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_deinscrire
            // 
            this.btn_deinscrire.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_deinscrire.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deinscrire.Location = new System.Drawing.Point(88, 0);
            this.btn_deinscrire.Name = "btn_deinscrire";
            this.btn_deinscrire.Size = new System.Drawing.Size(86, 75);
            this.btn_deinscrire.TabIndex = 0;
            this.btn_deinscrire.Text = "Désinscrire";
            this.btn_deinscrire.UseVisualStyleBackColor = false;
            this.btn_deinscrire.Visible = false;
            this.btn_deinscrire.Click += new System.EventHandler(this.btn_deinscription_proposition_Click);
            // 
            // btn_inscription_proposition
            // 
            this.btn_inscription_proposition.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_inscription_proposition.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inscription_proposition.Location = new System.Drawing.Point(88, 0);
            this.btn_inscription_proposition.Name = "btn_inscription_proposition";
            this.btn_inscription_proposition.Size = new System.Drawing.Size(86, 75);
            this.btn_inscription_proposition.TabIndex = 0;
            this.btn_inscription_proposition.Text = "S\'inscrire";
            this.btn_inscription_proposition.UseVisualStyleBackColor = false;
            this.btn_inscription_proposition.Visible = false;
            this.btn_inscription_proposition.Click += new System.EventHandler(this.btn_inscription_proposition_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_reset.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(89, 0);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(86, 75);
            this.btn_reset.TabIndex = 0;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_valide
            // 
            this.btn_valide.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_valide.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valide.Location = new System.Drawing.Point(0, 0);
            this.btn_valide.Name = "btn_valide";
            this.btn_valide.Size = new System.Drawing.Size(86, 75);
            this.btn_valide.TabIndex = 0;
            this.btn_valide.Text = "Valider";
            this.btn_valide.UseVisualStyleBackColor = false;
            this.btn_valide.Click += new System.EventHandler(this.btn_valide_Click);
            // 
            // btn_supprime_profil
            // 
            this.btn_supprime_profil.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_supprime_profil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_supprime_profil.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprime_profil.Location = new System.Drawing.Point(0, 347);
            this.btn_supprime_profil.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btn_supprime_profil.Name = "btn_supprime_profil";
            this.btn_supprime_profil.Size = new System.Drawing.Size(175, 75);
            this.btn_supprime_profil.TabIndex = 1;
            this.btn_supprime_profil.Text = "Supprimer le profil";
            this.btn_supprime_profil.UseVisualStyleBackColor = false;
            this.btn_supprime_profil.Click += new System.EventHandler(this.btn_supprime_profil_Click);
            // 
            // btn_modif_profil
            // 
            this.btn_modif_profil.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_modif_profil.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modif_profil.Location = new System.Drawing.Point(0, 100);
            this.btn_modif_profil.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btn_modif_profil.Name = "btn_modif_profil";
            this.btn_modif_profil.Size = new System.Drawing.Size(175, 75);
            this.btn_modif_profil.TabIndex = 1;
            this.btn_modif_profil.Text = "Modifier le profil";
            this.btn_modif_profil.UseVisualStyleBackColor = false;
            this.btn_modif_profil.Click += new System.EventHandler(this.btn_modif_profil_Click);
            // 
            // btn_recherche_offre
            // 
            this.btn_recherche_offre.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_recherche_offre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_recherche_offre.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recherche_offre.Location = new System.Drawing.Point(0, 0);
            this.btn_recherche_offre.Name = "btn_recherche_offre";
            this.btn_recherche_offre.Size = new System.Drawing.Size(175, 75);
            this.btn_recherche_offre.TabIndex = 0;
            this.btn_recherche_offre.Text = "Recherche une offre";
            this.btn_recherche_offre.UseVisualStyleBackColor = false;
            this.btn_recherche_offre.Click += new System.EventHandler(this.btn_recherche_offre_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Saisonnier_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1406, 845);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_menu);
            this.Name = "Saisonnier_profile";
            this.Text = "Saisonnier_profile";
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel_profil_info.ResumeLayout(false);
            this.panel_profil_info.PerformLayout();
            this.panel_recherche_offre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_all_propositions)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel_valide_reset.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_supprime_profil;
        private System.Windows.Forms.Button btn_modif_profil;
        private System.Windows.Forms.Button btn_recherche_offre;
        private System.Windows.Forms.Panel panel_profil_info;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_tele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.Label lbl_tele;
        private System.Windows.Forms.Panel panel_recherche_offre;
        private System.Windows.Forms.DataGridView dg_all_propositions;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_date_debut;
        private System.Windows.Forms.DateTimePicker date_debut;
        private System.Windows.Forms.Panel panel_valide_reset;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_valide;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_inscription_proposition;
        private System.Windows.Forms.Button btn_deinscrire;
        private System.Windows.Forms.Button button1;
    }
}