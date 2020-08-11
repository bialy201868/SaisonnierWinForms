namespace SaisonnierWinForms
{
    partial class Admin_frm
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
            this.panel_modif = new System.Windows.Forms.Panel();
            this.txt_code_region = new System.Windows.Forms.TextBox();
            this.txt_nom_region = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_info_panel = new System.Windows.Forms.DataGridView();
            this.lbl_info = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_modif = new System.Windows.Forms.Button();
            this.btn_ajoute = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saisonnierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agriculteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_msg_info = new System.Windows.Forms.Label();
            this.panel_menu.SuspendLayout();
            this.panel_modif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_info_panel)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.White;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_menu.Controls.Add(this.lbl_msg_info);
            this.panel_menu.Controls.Add(this.panel_modif);
            this.panel_menu.Controls.Add(this.dg_info_panel);
            this.panel_menu.Controls.Add(this.lbl_info);
            this.panel_menu.Controls.Add(this.panel3);
            this.panel_menu.Controls.Add(this.menuStrip1);
            this.panel_menu.Location = new System.Drawing.Point(21, -15);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(852, 480);
            this.panel_menu.TabIndex = 3;
            // 
            // panel_modif
            // 
            this.panel_modif.Controls.Add(this.txt_code_region);
            this.panel_modif.Controls.Add(this.txt_nom_region);
            this.panel_modif.Controls.Add(this.label2);
            this.panel_modif.Controls.Add(this.label1);
            this.panel_modif.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_modif.Location = new System.Drawing.Point(0, 371);
            this.panel_modif.Name = "panel_modif";
            this.panel_modif.Size = new System.Drawing.Size(669, 105);
            this.panel_modif.TabIndex = 5;
            this.panel_modif.Visible = false;
            // 
            // txt_code_region
            // 
            this.txt_code_region.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code_region.Location = new System.Drawing.Point(115, 39);
            this.txt_code_region.Name = "txt_code_region";
            this.txt_code_region.Size = new System.Drawing.Size(171, 27);
            this.txt_code_region.TabIndex = 7;
            // 
            // txt_nom_region
            // 
            this.txt_nom_region.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom_region.Location = new System.Drawing.Point(382, 39);
            this.txt_nom_region.Name = "txt_nom_region";
            this.txt_nom_region.Size = new System.Drawing.Size(171, 27);
            this.txt_nom_region.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom Region";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Code Region";
            // 
            // dg_info_panel
            // 
            this.dg_info_panel.AllowUserToAddRows = false;
            this.dg_info_panel.AllowUserToResizeColumns = false;
            this.dg_info_panel.AllowUserToResizeRows = false;
            this.dg_info_panel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_info_panel.BackgroundColor = System.Drawing.Color.White;
            this.dg_info_panel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_info_panel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_info_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dg_info_panel.Location = new System.Drawing.Point(0, 28);
            this.dg_info_panel.Margin = new System.Windows.Forms.Padding(2);
            this.dg_info_panel.Name = "dg_info_panel";
            this.dg_info_panel.RowHeadersWidth = 51;
            this.dg_info_panel.RowTemplate.Height = 24;
            this.dg_info_panel.Size = new System.Drawing.Size(669, 277);
            this.dg_info_panel.TabIndex = 4;
            this.dg_info_panel.SelectionChanged += new System.EventHandler(this.dg_info_panel_SelectionChanged);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(161, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 23);
            this.lbl_info.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btn_modif);
            this.panel3.Controls.Add(this.btn_ajoute);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(669, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 448);
            this.panel3.TabIndex = 0;
            // 
            // btn_modif
            // 
            this.btn_modif.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_modif.Enabled = false;
            this.btn_modif.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modif.Location = new System.Drawing.Point(0, 100);
            this.btn_modif.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(175, 75);
            this.btn_modif.TabIndex = 1;
            this.btn_modif.Text = "Modifier";
            this.btn_modif.UseVisualStyleBackColor = false;
            this.btn_modif.Click += new System.EventHandler(this.btn_modif_Click);
            // 
            // btn_ajoute
            // 
            this.btn_ajoute.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ajoute.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ajoute.Enabled = false;
            this.btn_ajoute.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoute.Location = new System.Drawing.Point(0, 0);
            this.btn_ajoute.Name = "btn_ajoute";
            this.btn_ajoute.Size = new System.Drawing.Size(175, 75);
            this.btn_ajoute.TabIndex = 0;
            this.btn_ajoute.Text = "Ajouter";
            this.btn_ajoute.UseVisualStyleBackColor = false;
            this.btn_ajoute.Click += new System.EventHandler(this.btn_ajoute_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisonnierToolStripMenuItem,
            this.agriculteurToolStripMenuItem,
            this.regionToolStripMenuItem,
            this.propositionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(848, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saisonnierToolStripMenuItem
            // 
            this.saisonnierToolStripMenuItem.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saisonnierToolStripMenuItem.Name = "saisonnierToolStripMenuItem";
            this.saisonnierToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.saisonnierToolStripMenuItem.Text = "Saisonnier";
            this.saisonnierToolStripMenuItem.Click += new System.EventHandler(this.saisonnierToolStripMenuItem_Click);
            // 
            // agriculteurToolStripMenuItem
            // 
            this.agriculteurToolStripMenuItem.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agriculteurToolStripMenuItem.Name = "agriculteurToolStripMenuItem";
            this.agriculteurToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.agriculteurToolStripMenuItem.Text = "Agriculteur";
            this.agriculteurToolStripMenuItem.Click += new System.EventHandler(this.agriculteurToolStripMenuItem_Click);
            // 
            // regionToolStripMenuItem
            // 
            this.regionToolStripMenuItem.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionToolStripMenuItem.Name = "regionToolStripMenuItem";
            this.regionToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.regionToolStripMenuItem.Text = "Region";
            this.regionToolStripMenuItem.Click += new System.EventHandler(this.regionToolStripMenuItem_Click);
            // 
            // propositionToolStripMenuItem
            // 
            this.propositionToolStripMenuItem.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propositionToolStripMenuItem.Name = "propositionToolStripMenuItem";
            this.propositionToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.propositionToolStripMenuItem.Text = "Proposition";
            this.propositionToolStripMenuItem.Click += new System.EventHandler(this.propositionToolStripMenuItem_Click);
            // 
            // lbl_msg_info
            // 
            this.lbl_msg_info.AutoSize = true;
            this.lbl_msg_info.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg_info.Location = new System.Drawing.Point(191, 322);
            this.lbl_msg_info.Name = "lbl_msg_info";
            this.lbl_msg_info.Size = new System.Drawing.Size(0, 23);
            this.lbl_msg_info.TabIndex = 8;
            // 
            // Admin_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1293, 685);
            this.Controls.Add(this.panel_menu);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin_frm";
            this.Text = "Admin";
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel_modif.ResumeLayout(false);
            this.panel_modif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_info_panel)).EndInit();
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.Button btn_ajoute;
        private System.Windows.Forms.DataGridView dg_info_panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saisonnierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agriculteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propositionToolStripMenuItem;
        private System.Windows.Forms.Panel panel_modif;
        private System.Windows.Forms.TextBox txt_code_region;
        private System.Windows.Forms.TextBox txt_nom_region;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_msg_info;
    }
}