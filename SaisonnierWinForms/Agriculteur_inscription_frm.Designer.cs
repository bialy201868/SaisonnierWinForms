namespace SaisonnierWinForms
{
    partial class Agriculteur_inscription_frm
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
            this.components = new System.ComponentModel.Container();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.combo_region = new System.Windows.Forms.ComboBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_tele = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.lbl_reigon = new System.Windows.Forms.Label();
            this.lbl_tele = new System.Windows.Forms.Label();
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_menu.Controls.Add(this.combo_region);
            this.panel_menu.Controls.Add(this.txt_description);
            this.panel_menu.Controls.Add(this.txt_tele);
            this.panel_menu.Controls.Add(this.txt_email);
            this.panel_menu.Controls.Add(this.txt_mdp);
            this.panel_menu.Controls.Add(this.txt_nom);
            this.panel_menu.Controls.Add(this.lbl_description);
            this.panel_menu.Controls.Add(this.txt_login);
            this.panel_menu.Controls.Add(this.txt_prenom);
            this.panel_menu.Controls.Add(this.lbl_reigon);
            this.panel_menu.Controls.Add(this.lbl_tele);
            this.panel_menu.Controls.Add(this.lbl_mdp);
            this.panel_menu.Controls.Add(this.lbl_email);
            this.panel_menu.Controls.Add(this.lbl_login);
            this.panel_menu.Controls.Add(this.lbl_nom);
            this.panel_menu.Controls.Add(this.lbl_prenom);
            this.panel_menu.Location = new System.Drawing.Point(31, 26);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(4, 62, 4, 4);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(1135, 590);
            this.panel_menu.TabIndex = 0;
            // 
            // combo_region
            // 
            this.combo_region.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_region.FormattingEnabled = true;
            this.combo_region.Location = new System.Drawing.Point(163, 364);
            this.combo_region.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_region.Name = "combo_region";
            this.combo_region.Size = new System.Drawing.Size(365, 37);
            this.combo_region.TabIndex = 6;
            this.combo_region.TabStop = false;
            this.combo_region.SelectedIndexChanged += new System.EventHandler(this.combo_region_SelectedIndexChanged);
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.Location = new System.Drawing.Point(607, 364);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(365, 120);
            this.txt_description.TabIndex = 7;
            // 
            // txt_tele
            // 
            this.txt_tele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tele.Location = new System.Drawing.Point(607, 271);
            this.txt_tele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tele.Name = "txt_tele";
            this.txt_tele.Size = new System.Drawing.Size(365, 34);
            this.txt_tele.TabIndex = 6;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(163, 271);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(365, 34);
            this.txt_email.TabIndex = 5;
            // 
            // txt_mdp
            // 
            this.txt_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mdp.Location = new System.Drawing.Point(607, 82);
            this.txt_mdp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.Size = new System.Drawing.Size(365, 34);
            this.txt_mdp.TabIndex = 2;
            // 
            // txt_nom
            // 
            this.txt_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.Location = new System.Drawing.Point(607, 175);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(365, 34);
            this.txt_nom.TabIndex = 4;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(603, 327);
            this.lbl_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(96, 23);
            this.lbl_description.TabIndex = 0;
            this.lbl_description.Text = "Description";
            // 
            // txt_login
            // 
            this.txt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login.Location = new System.Drawing.Point(163, 82);
            this.txt_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(365, 34);
            this.txt_login.TabIndex = 1;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prenom.Location = new System.Drawing.Point(163, 175);
            this.txt_prenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(365, 34);
            this.txt_prenom.TabIndex = 3;
            // 
            // lbl_reigon
            // 
            this.lbl_reigon.AutoSize = true;
            this.lbl_reigon.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reigon.Location = new System.Drawing.Point(161, 327);
            this.lbl_reigon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_reigon.Name = "lbl_reigon";
            this.lbl_reigon.Size = new System.Drawing.Size(61, 23);
            this.lbl_reigon.TabIndex = 0;
            this.lbl_reigon.Text = "Region";
            // 
            // lbl_tele
            // 
            this.lbl_tele.AutoSize = true;
            this.lbl_tele.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tele.Location = new System.Drawing.Point(603, 234);
            this.lbl_tele.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tele.Name = "lbl_tele";
            this.lbl_tele.Size = new System.Drawing.Size(87, 23);
            this.lbl_tele.TabIndex = 0;
            this.lbl_tele.Text = "Téléphone";
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mdp.Location = new System.Drawing.Point(603, 34);
            this.lbl_mdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(111, 23);
            this.lbl_mdp.TabIndex = 0;
            this.lbl_mdp.Text = "Mot de passe";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(159, 234);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(50, 23);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Email";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(161, 34);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(51, 23);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Login";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.Location = new System.Drawing.Point(603, 142);
            this.lbl_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(46, 23);
            this.lbl_nom.TabIndex = 0;
            this.lbl_nom.Text = "Nom";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prenom.Location = new System.Drawing.Point(161, 142);
            this.lbl_prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(69, 23);
            this.lbl_prenom.TabIndex = 0;
            this.lbl_prenom.Text = "Prénom";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Agriculteur_inscription_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1195, 711);
            this.Controls.Add(this.panel_menu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Agriculteur_inscription_frm";
            this.Text = "Agriculteur_inscription_frm";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Agriculteur_inscription_frm_KeyUp);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label lbl_tele;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_tele;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox combo_region;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.Label lbl_reigon;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_prenom;
    }
}