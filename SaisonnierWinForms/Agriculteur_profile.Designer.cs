namespace SaisonnierWinForms
{
    partial class Agriculteur_profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agriculteur_profile));
            this.panel_profil_info = new System.Windows.Forms.Panel();
            this.combo_region = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.panel_ajoute_offre = new System.Windows.Forms.Panel();
            this.check_publication = new System.Windows.Forms.CheckBox();
            this.numeric_salaire = new System.Windows.Forms.NumericUpDown();
            this.numeric_jour = new System.Windows.Forms.NumericUpDown();
            this.numeric_heures = new System.Windows.Forms.NumericUpDown();
            this.numeric_place = new System.Windows.Forms.NumericUpDown();
            this.date_fin = new System.Windows.Forms.DateTimePicker();
            this.date_debut = new System.Windows.Forms.DateTimePicker();
            this.lbl_salaire = new System.Windows.Forms.Label();
            this.lbl_nb_jour = new System.Windows.Forms.Label();
            this.lbl_nb_h = new System.Windows.Forms.Label();
            this.lbl_nb_place = new System.Windows.Forms.Label();
            this.lbl_date_fin = new System.Windows.Forms.Label();
            this.lbl_date_debut = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.lbl_info = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_valide_reset = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_valide = new System.Windows.Forms.Button();
            this.btn_supprime_profil = new System.Windows.Forms.Button();
            this.btn_modif_profil = new System.Windows.Forms.Button();
            this.btn_ajoute_offre = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_profil_info.SuspendLayout();
            this.panel_ajoute_offre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_salaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_jour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_heures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_place)).BeginInit();
            this.panel_menu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_valide_reset.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_profil_info
            // 
            this.panel_profil_info.BackColor = System.Drawing.Color.White;
            this.panel_profil_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_profil_info.Controls.Add(this.combo_region);
            this.panel_profil_info.Controls.Add(this.label3);
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
            this.panel_profil_info.Location = new System.Drawing.Point(23, 30);
            this.panel_profil_info.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_profil_info.Name = "panel_profil_info";
            this.panel_profil_info.Size = new System.Drawing.Size(829, 414);
            this.panel_profil_info.TabIndex = 1;
            this.panel_profil_info.Visible = false;
            // 
            // combo_region
            // 
            this.combo_region.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_region.FormattingEnabled = true;
            this.combo_region.Location = new System.Drawing.Point(23, 262);
            this.combo_region.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_region.Name = "combo_region";
            this.combo_region.Size = new System.Drawing.Size(365, 37);
            this.combo_region.TabIndex = 6;
            this.combo_region.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Region";
            // 
            // txt_nom
            // 
            this.txt_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.Location = new System.Drawing.Point(437, 65);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(365, 34);
            this.txt_nom.TabIndex = 4;
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.Location = new System.Drawing.Point(436, 22);
            this.lbl_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(46, 23);
            this.lbl_nom.TabIndex = 0;
            this.lbl_nom.Text = "Nom";
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.Location = new System.Drawing.Point(437, 262);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(365, 120);
            this.txt_description.TabIndex = 7;
            // 
            // txt_tele
            // 
            this.txt_tele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tele.Location = new System.Drawing.Point(437, 164);
            this.txt_tele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tele.Name = "txt_tele";
            this.txt_tele.Size = new System.Drawing.Size(365, 34);
            this.txt_tele.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(436, 219);
            this.lbl_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(96, 23);
            this.lbl_description.TabIndex = 0;
            this.lbl_description.Text = "Description";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(23, 164);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(365, 34);
            this.txt_email.TabIndex = 5;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prenom.Location = new System.Drawing.Point(23, 65);
            this.txt_prenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(365, 34);
            this.txt_prenom.TabIndex = 3;
            // 
            // lbl_tele
            // 
            this.lbl_tele.AutoSize = true;
            this.lbl_tele.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tele.Location = new System.Drawing.Point(436, 121);
            this.lbl_tele.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tele.Name = "lbl_tele";
            this.lbl_tele.Size = new System.Drawing.Size(87, 23);
            this.lbl_tele.TabIndex = 0;
            this.lbl_tele.Text = "Téléphone";
            // 
            // panel_ajoute_offre
            // 
            this.panel_ajoute_offre.BackColor = System.Drawing.Color.White;
            this.panel_ajoute_offre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_ajoute_offre.Controls.Add(this.check_publication);
            this.panel_ajoute_offre.Controls.Add(this.numeric_salaire);
            this.panel_ajoute_offre.Controls.Add(this.numeric_jour);
            this.panel_ajoute_offre.Controls.Add(this.numeric_heures);
            this.panel_ajoute_offre.Controls.Add(this.numeric_place);
            this.panel_ajoute_offre.Controls.Add(this.date_fin);
            this.panel_ajoute_offre.Controls.Add(this.date_debut);
            this.panel_ajoute_offre.Controls.Add(this.lbl_salaire);
            this.panel_ajoute_offre.Controls.Add(this.lbl_nb_jour);
            this.panel_ajoute_offre.Controls.Add(this.lbl_nb_h);
            this.panel_ajoute_offre.Controls.Add(this.lbl_nb_place);
            this.panel_ajoute_offre.Controls.Add(this.lbl_date_fin);
            this.panel_ajoute_offre.Controls.Add(this.lbl_date_debut);
            this.panel_ajoute_offre.Enabled = false;
            this.panel_ajoute_offre.Location = new System.Drawing.Point(192, 30);
            this.panel_ajoute_offre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_ajoute_offre.Name = "panel_ajoute_offre";
            this.panel_ajoute_offre.Size = new System.Drawing.Size(459, 523);
            this.panel_ajoute_offre.TabIndex = 1;
            this.panel_ajoute_offre.Visible = false;
            // 
            // check_publication
            // 
            this.check_publication.AutoSize = true;
            this.check_publication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_publication.Location = new System.Drawing.Point(47, 366);
            this.check_publication.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check_publication.Name = "check_publication";
            this.check_publication.Size = new System.Drawing.Size(154, 33);
            this.check_publication.TabIndex = 10;
            this.check_publication.Text = "Publication";
            this.check_publication.UseVisualStyleBackColor = true;
            // 
            // numeric_salaire
            // 
            this.numeric_salaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_salaire.Location = new System.Drawing.Point(47, 263);
            this.numeric_salaire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeric_salaire.Name = "numeric_salaire";
            this.numeric_salaire.Size = new System.Drawing.Size(160, 34);
            this.numeric_salaire.TabIndex = 9;
            // 
            // numeric_jour
            // 
            this.numeric_jour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_jour.Location = new System.Drawing.Point(248, 460);
            this.numeric_jour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeric_jour.Name = "numeric_jour";
            this.numeric_jour.Size = new System.Drawing.Size(160, 34);
            this.numeric_jour.TabIndex = 9;
            // 
            // numeric_heures
            // 
            this.numeric_heures.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_heures.Location = new System.Drawing.Point(248, 362);
            this.numeric_heures.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeric_heures.Name = "numeric_heures";
            this.numeric_heures.Size = new System.Drawing.Size(160, 34);
            this.numeric_heures.TabIndex = 9;
            // 
            // numeric_place
            // 
            this.numeric_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_place.Location = new System.Drawing.Point(248, 265);
            this.numeric_place.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeric_place.Name = "numeric_place";
            this.numeric_place.Size = new System.Drawing.Size(160, 34);
            this.numeric_place.TabIndex = 9;
            // 
            // date_fin
            // 
            this.date_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_fin.Location = new System.Drawing.Point(41, 164);
            this.date_fin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_fin.Name = "date_fin";
            this.date_fin.Size = new System.Drawing.Size(365, 34);
            this.date_fin.TabIndex = 8;
            // 
            // date_debut
            // 
            this.date_debut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_debut.Location = new System.Drawing.Point(41, 66);
            this.date_debut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_debut.Name = "date_debut";
            this.date_debut.Size = new System.Drawing.Size(365, 34);
            this.date_debut.TabIndex = 8;
            // 
            // lbl_salaire
            // 
            this.lbl_salaire.AutoSize = true;
            this.lbl_salaire.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salaire.Location = new System.Drawing.Point(43, 225);
            this.lbl_salaire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_salaire.Name = "lbl_salaire";
            this.lbl_salaire.Size = new System.Drawing.Size(61, 23);
            this.lbl_salaire.TabIndex = 0;
            this.lbl_salaire.Text = "Salaire";
            // 
            // lbl_nb_jour
            // 
            this.lbl_nb_jour.AutoSize = true;
            this.lbl_nb_jour.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nb_jour.Location = new System.Drawing.Point(244, 422);
            this.lbl_nb_jour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nb_jour.Name = "lbl_nb_jour";
            this.lbl_nb_jour.Size = new System.Drawing.Size(134, 23);
            this.lbl_nb_jour.TabIndex = 0;
            this.lbl_nb_jour.Text = "Nombre de jours";
            // 
            // lbl_nb_h
            // 
            this.lbl_nb_h.AutoSize = true;
            this.lbl_nb_h.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nb_h.Location = new System.Drawing.Point(244, 324);
            this.lbl_nb_h.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nb_h.Name = "lbl_nb_h";
            this.lbl_nb_h.Size = new System.Drawing.Size(137, 23);
            this.lbl_nb_h.TabIndex = 0;
            this.lbl_nb_h.Text = "Nombre d\'heures";
            // 
            // lbl_nb_place
            // 
            this.lbl_nb_place.AutoSize = true;
            this.lbl_nb_place.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nb_place.Location = new System.Drawing.Point(244, 225);
            this.lbl_nb_place.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nb_place.Name = "lbl_nb_place";
            this.lbl_nb_place.Size = new System.Drawing.Size(145, 23);
            this.lbl_nb_place.TabIndex = 0;
            this.lbl_nb_place.Text = "Nombre de places";
            // 
            // lbl_date_fin
            // 
            this.lbl_date_fin.AutoSize = true;
            this.lbl_date_fin.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_fin.Location = new System.Drawing.Point(37, 127);
            this.lbl_date_fin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_date_fin.Name = "lbl_date_fin";
            this.lbl_date_fin.Size = new System.Drawing.Size(67, 23);
            this.lbl_date_fin.TabIndex = 0;
            this.lbl_date_fin.Text = "Date fin";
            // 
            // lbl_date_debut
            // 
            this.lbl_date_debut.AutoSize = true;
            this.lbl_date_debut.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_debut.Location = new System.Drawing.Point(37, 28);
            this.lbl_date_debut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_date_debut.Name = "lbl_date_debut";
            this.lbl_date_debut.Size = new System.Drawing.Size(91, 23);
            this.lbl_date_debut.TabIndex = 0;
            this.lbl_date_debut.Text = "Date debut";
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_menu.Controls.Add(this.lbl_info);
            this.panel_menu.Controls.Add(this.panel_ajoute_offre);
            this.panel_menu.Controls.Add(this.panel3);
            this.panel_menu.Controls.Add(this.panel_profil_info);
            this.panel_menu.Location = new System.Drawing.Point(140, 46);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(1135, 590);
            this.panel_menu.TabIndex = 2;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(215, 0);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 29);
            this.lbl_info.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel_valide_reset);
            this.panel3.Controls.Add(this.btn_supprime_profil);
            this.panel3.Controls.Add(this.btn_modif_profil);
            this.panel3.Controls.Add(this.btn_ajoute_offre);
            this.panel3.Location = new System.Drawing.Point(873, 27);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 523);
            this.panel3.TabIndex = 0;
            // 
            // panel_valide_reset
            // 
            this.panel_valide_reset.Controls.Add(this.btn_back);
            this.panel_valide_reset.Controls.Add(this.btn_reset);
            this.panel_valide_reset.Controls.Add(this.btn_valide);
            this.panel_valide_reset.Location = new System.Drawing.Point(0, 246);
            this.panel_valide_reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_valide_reset.Name = "panel_valide_reset";
            this.panel_valide_reset.Size = new System.Drawing.Size(233, 145);
            this.panel_valide_reset.TabIndex = 2;
            this.panel_valide_reset.Visible = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_back.Location = new System.Drawing.Point(0, 97);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(233, 48);
            this.btn_back.TabIndex = 1;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_reset.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(119, 0);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(115, 92);
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
            this.btn_valide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_valide.Name = "btn_valide";
            this.btn_valide.Size = new System.Drawing.Size(115, 92);
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
            this.btn_supprime_profil.Location = new System.Drawing.Point(0, 427);
            this.btn_supprime_profil.Margin = new System.Windows.Forms.Padding(4, 37, 4, 4);
            this.btn_supprime_profil.Name = "btn_supprime_profil";
            this.btn_supprime_profil.Size = new System.Drawing.Size(233, 92);
            this.btn_supprime_profil.TabIndex = 1;
            this.btn_supprime_profil.Text = "Supprimer le profil";
            this.btn_supprime_profil.UseVisualStyleBackColor = false;
            this.btn_supprime_profil.Click += new System.EventHandler(this.btn_supprime_profil_Click);
            // 
            // btn_modif_profil
            // 
            this.btn_modif_profil.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_modif_profil.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modif_profil.Location = new System.Drawing.Point(0, 123);
            this.btn_modif_profil.Margin = new System.Windows.Forms.Padding(4, 37, 4, 4);
            this.btn_modif_profil.Name = "btn_modif_profil";
            this.btn_modif_profil.Size = new System.Drawing.Size(233, 92);
            this.btn_modif_profil.TabIndex = 1;
            this.btn_modif_profil.Text = "Modifier le profil";
            this.btn_modif_profil.UseVisualStyleBackColor = false;
            this.btn_modif_profil.Click += new System.EventHandler(this.btn_modif_profil_Click);
            // 
            // btn_ajoute_offre
            // 
            this.btn_ajoute_offre.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ajoute_offre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ajoute_offre.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoute_offre.Location = new System.Drawing.Point(0, 0);
            this.btn_ajoute_offre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ajoute_offre.Name = "btn_ajoute_offre";
            this.btn_ajoute_offre.Size = new System.Drawing.Size(233, 92);
            this.btn_ajoute_offre.TabIndex = 0;
            this.btn_ajoute_offre.Text = "Ajouter une offre";
            this.btn_ajoute_offre.UseVisualStyleBackColor = false;
            this.btn_ajoute_offre.Click += new System.EventHandler(this.btn_ajoute_offre_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 351);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "Supprimer le profil";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 100);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modifier le profil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 75);
            this.button3.TabIndex = 0;
            this.button3.Text = "Ajouter une offre";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Agriculteur_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1924, 785);
            this.Controls.Add(this.panel_menu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Agriculteur_profile";
            this.Text = "Agriculteur_profile";
            this.panel_profil_info.ResumeLayout(false);
            this.panel_profil_info.PerformLayout();
            this.panel_ajoute_offre.ResumeLayout(false);
            this.panel_ajoute_offre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_salaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_jour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_heures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_place)).EndInit();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel_valide_reset.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_profil_info;
        private System.Windows.Forms.Panel panel_ajoute_offre;
        private System.Windows.Forms.ComboBox combo_region;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_tele;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_tele;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.CheckBox check_publication;
        private System.Windows.Forms.NumericUpDown numeric_salaire;
        private System.Windows.Forms.NumericUpDown numeric_jour;
        private System.Windows.Forms.NumericUpDown numeric_heures;
        private System.Windows.Forms.NumericUpDown numeric_place;
        private System.Windows.Forms.DateTimePicker date_fin;
        private System.Windows.Forms.DateTimePicker date_debut;
        private System.Windows.Forms.Label lbl_salaire;
        private System.Windows.Forms.Label lbl_nb_jour;
        private System.Windows.Forms.Label lbl_nb_h;
        private System.Windows.Forms.Label lbl_nb_place;
        private System.Windows.Forms.Label lbl_date_fin;
        private System.Windows.Forms.Label lbl_date_debut;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_supprime_profil;
        private System.Windows.Forms.Button btn_modif_profil;
        private System.Windows.Forms.Button btn_ajoute_offre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel_valide_reset;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_valide;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_info;
    }
}