namespace SMDIRandomizer.Forms
{
    partial class AppInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppInfoForm));
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.BuiltAgainstLabel = new System.Windows.Forms.Label();
            this.BuiltAgainstLink = new System.Windows.Forms.LinkLabel();
            this.PrePleaseVisitLabel = new System.Windows.Forms.Label();
            this.PleaseVisitLink = new System.Windows.Forms.LinkLabel();
            this.PosPleaseVisitlabel = new System.Windows.Forms.Label();
            this.ContactTable = new System.Windows.Forms.TableLayoutPanel();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.GitHubLabel = new System.Windows.Forms.Label();
            this.EmailLink = new System.Windows.Forms.LinkLabel();
            this.GitHubLink = new System.Windows.Forms.LinkLabel();
            this.CopyLinkMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyLinkLocaionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTable.SuspendLayout();
            this.ContactTable.SuspendLayout();
            this.CopyLinkMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.VersionLabel, 0, 0);
            this.MainTable.Controls.Add(this.BuiltAgainstLabel, 0, 2);
            this.MainTable.Controls.Add(this.BuiltAgainstLink, 0, 3);
            this.MainTable.Controls.Add(this.PrePleaseVisitLabel, 0, 5);
            this.MainTable.Controls.Add(this.PleaseVisitLink, 0, 6);
            this.MainTable.Controls.Add(this.PosPleaseVisitlabel, 0, 7);
            this.MainTable.Controls.Add(this.ContactTable, 0, 8);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 11;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(444, 296);
            this.MainTable.TabIndex = 0;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.Location = new System.Drawing.Point(3, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(275, 15);
            this.VersionLabel.TabIndex = 0;
            this.VersionLabel.Text = "Super Metroid Desktop Item Randomizer version";
            // 
            // BuiltAgainstLabel
            // 
            this.BuiltAgainstLabel.AutoSize = true;
            this.BuiltAgainstLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuiltAgainstLabel.Location = new System.Drawing.Point(3, 35);
            this.BuiltAgainstLabel.Name = "BuiltAgainstLabel";
            this.BuiltAgainstLabel.Size = new System.Drawing.Size(422, 30);
            this.BuiltAgainstLabel.TabIndex = 1;
            this.BuiltAgainstLabel.Text = "This randomizer was built against the on-line \"Super Metroid Item Randomizer\" ver" +
    "sion 2.10 (2019-01-16) built by tewtal that can be found at: ";
            // 
            // BuiltAgainstLink
            // 
            this.BuiltAgainstLink.AutoSize = true;
            this.BuiltAgainstLink.Location = new System.Drawing.Point(3, 65);
            this.BuiltAgainstLink.Name = "BuiltAgainstLink";
            this.BuiltAgainstLink.Size = new System.Drawing.Size(209, 15);
            this.BuiltAgainstLink.TabIndex = 2;
            this.BuiltAgainstLink.TabStop = true;
            this.BuiltAgainstLink.Text = "https://itemrando.supermetroid.run/";
            this.BuiltAgainstLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Click);
            // 
            // PrePleaseVisitLabel
            // 
            this.PrePleaseVisitLabel.AutoSize = true;
            this.PrePleaseVisitLabel.Location = new System.Drawing.Point(3, 100);
            this.PrePleaseVisitLabel.Name = "PrePleaseVisitLabel";
            this.PrePleaseVisitLabel.Size = new System.Drawing.Size(70, 15);
            this.PrePleaseVisitLabel.TabIndex = 3;
            this.PrePleaseVisitLabel.Text = "Please visit";
            // 
            // PleaseVisitLink
            // 
            this.PleaseVisitLink.AutoSize = true;
            this.PleaseVisitLink.Location = new System.Drawing.Point(3, 115);
            this.PleaseVisitLink.Name = "PleaseVisitLink";
            this.PleaseVisitLink.Size = new System.Drawing.Size(236, 15);
            this.PleaseVisitLink.TabIndex = 4;
            this.PleaseVisitLink.TabStop = true;
            this.PleaseVisitLink.Text = "http://dessyreqt.github.io/smrandomizer/";
            this.PleaseVisitLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Click);
            // 
            // PosPleaseVisitlabel
            // 
            this.PosPleaseVisitlabel.AutoSize = true;
            this.PosPleaseVisitlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PosPleaseVisitlabel.Location = new System.Drawing.Point(3, 130);
            this.PosPleaseVisitlabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.PosPleaseVisitlabel.Name = "PosPleaseVisitlabel";
            this.PosPleaseVisitlabel.Size = new System.Drawing.Size(438, 15);
            this.PosPleaseVisitlabel.TabIndex = 5;
            this.PosPleaseVisitlabel.Text = "for more details about the original randomizer built by Dessyreqt";
            // 
            // ContactTable
            // 
            this.ContactTable.AutoSize = true;
            this.ContactTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContactTable.ColumnCount = 2;
            this.ContactTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ContactTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ContactTable.Controls.Add(this.EmailLabel, 0, 0);
            this.ContactTable.Controls.Add(this.GitHubLabel, 0, 1);
            this.ContactTable.Controls.Add(this.EmailLink, 1, 0);
            this.ContactTable.Controls.Add(this.GitHubLink, 1, 1);
            this.ContactTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactTable.Location = new System.Drawing.Point(3, 168);
            this.ContactTable.Name = "ContactTable";
            this.ContactTable.RowCount = 2;
            this.ContactTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContactTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContactTable.Size = new System.Drawing.Size(438, 90);
            this.ContactTable.TabIndex = 6;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailLabel.Location = new System.Drawing.Point(3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(169, 30);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Problems? Contact me at the e-mail:";
            // 
            // GitHubLabel
            // 
            this.GitHubLabel.AutoSize = true;
            this.GitHubLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GitHubLabel.Location = new System.Drawing.Point(3, 30);
            this.GitHubLabel.Name = "GitHubLabel";
            this.GitHubLabel.Size = new System.Drawing.Size(169, 15);
            this.GitHubLabel.TabIndex = 1;
            this.GitHubLabel.Text = "Or open an issue at:";
            // 
            // EmailLink
            // 
            this.EmailLink.AutoSize = true;
            this.EmailLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailLink.Location = new System.Drawing.Point(178, 0);
            this.EmailLink.Name = "EmailLink";
            this.EmailLink.Size = new System.Drawing.Size(257, 30);
            this.EmailLink.TabIndex = 2;
            this.EmailLink.TabStop = true;
            this.EmailLink.Text = "marcelodmc3@gmail.com";
            this.EmailLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmailLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Click);
            // 
            // GitHubLink
            // 
            this.GitHubLink.AutoSize = true;
            this.GitHubLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.GitHubLink.Location = new System.Drawing.Point(178, 30);
            this.GitHubLink.Name = "GitHubLink";
            this.GitHubLink.Size = new System.Drawing.Size(257, 30);
            this.GitHubLink.TabIndex = 3;
            this.GitHubLink.TabStop = true;
            this.GitHubLink.Text = "https://github.com/marcelodmc3/super-metroid-desktop-item-randomizer/issues";
            this.GitHubLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Click);
            // 
            // CopyLinkMenuStrip
            // 
            this.CopyLinkMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyLinkLocaionToolStripMenuItem});
            this.CopyLinkMenuStrip.Name = "CopyLinkMenuStrip";
            this.CopyLinkMenuStrip.Size = new System.Drawing.Size(103, 26);
            // 
            // CopyLinkLocaionToolStripMenuItem
            // 
            this.CopyLinkLocaionToolStripMenuItem.Image = global::SMDIRandomizer.Properties.Resources.Copy_32x32;
            this.CopyLinkLocaionToolStripMenuItem.Name = "CopyLinkLocaionToolStripMenuItem";
            this.CopyLinkLocaionToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.CopyLinkLocaionToolStripMenuItem.Text = "Copy";
            this.CopyLinkLocaionToolStripMenuItem.Click += new System.EventHandler(this.CopyLinkLocaionToolStripMenuItem_Click);
            // 
            // AppInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 296);
            this.Controls.Add(this.MainTable);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 335);
            this.MinimumSize = new System.Drawing.Size(460, 335);
            this.Name = "AppInfoForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            this.ContactTable.ResumeLayout(false);
            this.ContactTable.PerformLayout();
            this.CopyLinkMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label BuiltAgainstLabel;
        private System.Windows.Forms.LinkLabel BuiltAgainstLink;
        private System.Windows.Forms.Label PrePleaseVisitLabel;
        private System.Windows.Forms.LinkLabel PleaseVisitLink;
        private System.Windows.Forms.Label PosPleaseVisitlabel;
        private System.Windows.Forms.TableLayoutPanel ContactTable;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label GitHubLabel;
        private System.Windows.Forms.LinkLabel EmailLink;
        private System.Windows.Forms.LinkLabel GitHubLink;
        private System.Windows.Forms.ContextMenuStrip CopyLinkMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyLinkLocaionToolStripMenuItem;
    }
}