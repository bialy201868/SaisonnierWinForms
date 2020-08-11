namespace SaisonnierWinForms
{
    partial class Contact_frm
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
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_menu.Controls.Add(this.lbl_mdp);
            this.panel_menu.Controls.Add(this.label1);
            this.panel_menu.Controls.Add(this.lbl_login);
            this.panel_menu.Location = new System.Drawing.Point(224, 94);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(310, 233);
            this.panel_menu.TabIndex = 0;
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mdp.Location = new System.Drawing.Point(153, 71);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(49, 19);
            this.lbl_mdp.TabIndex = 1;
            this.lbl_mdp.Text = "Bialek";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(100, 71);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(47, 19);
            this.lbl_login.TabIndex = 1;
            this.lbl_login.Text = "Jacek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "jacek.bialek1908@gmail.com";
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_menu);
            this.Name = "Contact";
            this.Text = "Contact";
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_login;
    }
}