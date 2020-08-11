namespace SaisonnierWinForms
{
    partial class Identification_frm
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
            this.panel_menu = new System.Windows.Forms.Panel();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_menu.Controls.Add(this.checkBox);
            this.panel_menu.Controls.Add(this.txt_mdp);
            this.panel_menu.Controls.Add(this.txt_login);
            this.panel_menu.Controls.Add(this.lbl_mdp);
            this.panel_menu.Controls.Add(this.lbl_login);
            this.panel_menu.Location = new System.Drawing.Point(230, 130);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(310, 233);
            this.panel_menu.TabIndex = 0;
            // 
            // txt_mdp
            // 
            this.txt_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mdp.Location = new System.Drawing.Point(20, 157);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.Size = new System.Drawing.Size(275, 29);
            this.txt_mdp.TabIndex = 2;
            // 
            // txt_login
            // 
            this.txt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login.Location = new System.Drawing.Point(20, 64);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(275, 29);
            this.txt_login.TabIndex = 2;
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mdp.Location = new System.Drawing.Point(17, 119);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(96, 19);
            this.lbl_mdp.TabIndex = 1;
            this.lbl_mdp.Text = "Mot de passe";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(17, 27);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(45, 19);
            this.lbl_login.TabIndex = 1;
            this.lbl_login.Text = "Login";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(20, 192);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(122, 17);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "Visible mot de passe";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // Identification_frm
            // 
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(959, 525);
            this.Controls.Add(this.panel_menu);
            this.Name = "Identification_frm";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Identification_frm_KeyUp);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

 
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.CheckBox checkBox;
    }
}