namespace SMRandoDesktop.Forms
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.BuiltAgainstLabel = new System.Windows.Forms.Label();
            this.BuiltAgainstLink = new System.Windows.Forms.LinkLabel();
            this.PrePleaseVisitLabel = new System.Windows.Forms.Label();
            this.PleaseVisitLink = new System.Windows.Forms.LinkLabel();
            this.PosPleaseVisitlabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.GitHubLabel = new System.Windows.Forms.Label();
            this.EmailLink = new System.Windows.Forms.LinkLabel();
            this.GitHubLink = new System.Windows.Forms.LinkLabel();
            this.CopyLinkMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyLinkLocaionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.CopyLinkMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.VersionLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BuiltAgainstLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BuiltAgainstLink, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PrePleaseVisitLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.PleaseVisitLink, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.PosPleaseVisitlabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 236);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.Location = new System.Drawing.Point(3, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(295, 15);
            this.VersionLabel.TabIndex = 0;
            this.VersionLabel.Text = "Super Metroid Desktop Item Randomizer version 0.9";
            // 
            // BuiltAgainstLabel
            // 
            this.BuiltAgainstLabel.AutoSize = true;
            this.BuiltAgainstLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuiltAgainstLabel.Location = new System.Drawing.Point(3, 35);
            this.BuiltAgainstLabel.Name = "BuiltAgainstLabel";
            this.BuiltAgainstLabel.Size = new System.Drawing.Size(352, 30);
            this.BuiltAgainstLabel.TabIndex = 1;
            this.BuiltAgainstLabel.Text = "This randomizer was built against the on-line \"Super Metroid Item Randomizer\" ver" +
    "sion 2.10 (2019-01-16) that can be found at: ";
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
            this.PosPleaseVisitlabel.Size = new System.Drawing.Size(418, 15);
            this.PosPleaseVisitlabel.TabIndex = 5;
            this.PosPleaseVisitlabel.Text = "for more details about the original randomizer built by Dessyreqt";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.EmailLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.GitHubLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.EmailLink, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.GitHubLink, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 168);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(418, 105);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailLabel.Location = new System.Drawing.Point(3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(161, 30);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Problems? Contact me at the e-mail:";
            // 
            // GitHubLabel
            // 
            this.GitHubLabel.AutoSize = true;
            this.GitHubLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GitHubLabel.Location = new System.Drawing.Point(3, 30);
            this.GitHubLabel.Name = "GitHubLabel";
            this.GitHubLabel.Size = new System.Drawing.Size(161, 15);
            this.GitHubLabel.TabIndex = 1;
            this.GitHubLabel.Text = "Or open an issue at:";
            // 
            // EmailLink
            // 
            this.EmailLink.AutoSize = true;
            this.EmailLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailLink.Location = new System.Drawing.Point(170, 0);
            this.EmailLink.Name = "EmailLink";
            this.EmailLink.Size = new System.Drawing.Size(245, 30);
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
            this.GitHubLink.Location = new System.Drawing.Point(170, 30);
            this.GitHubLink.Name = "GitHubLink";
            this.GitHubLink.Size = new System.Drawing.Size(245, 30);
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
            this.CopyLinkLocaionToolStripMenuItem.Image = global::SMRandoDesktop.Properties.Resources.Copy_32x32;
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
            this.ClientSize = new System.Drawing.Size(424, 236);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 275);
            this.MinimumSize = new System.Drawing.Size(440, 275);
            this.Name = "AppInfoForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.CopyLinkMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label BuiltAgainstLabel;
        private System.Windows.Forms.LinkLabel BuiltAgainstLink;
        private System.Windows.Forms.Label PrePleaseVisitLabel;
        private System.Windows.Forms.LinkLabel PleaseVisitLink;
        private System.Windows.Forms.Label PosPleaseVisitlabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label GitHubLabel;
        private System.Windows.Forms.LinkLabel EmailLink;
        private System.Windows.Forms.LinkLabel GitHubLink;
        private System.Windows.Forms.ContextMenuStrip CopyLinkMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyLinkLocaionToolStripMenuItem;
    }
}