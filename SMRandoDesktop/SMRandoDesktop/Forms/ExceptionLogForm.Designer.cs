namespace SMRandoDesktop.Forms
{
    partial class ExceptionLogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionLogForm));
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.LogSelectionTable = new System.Windows.Forms.TableLayoutPanel();
            this.PrevisousLogButton = new System.Windows.Forms.Button();
            this.NexLogBUtton = new System.Windows.Forms.Button();
            this.LogCounterLabel = new System.Windows.Forms.Label();
            this.LogDateLabel = new System.Windows.Forms.Label();
            this.CopyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.ExplanationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainTable.SuspendLayout();
            this.LogSelectionTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.LogSelectionTable, 0, 0);
            this.MainTable.Controls.Add(this.LogTextBox, 0, 1);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(424, 511);
            this.MainTable.TabIndex = 0;
            // 
            // LogSelectionTable
            // 
            this.LogSelectionTable.AutoSize = true;
            this.LogSelectionTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogSelectionTable.ColumnCount = 6;
            this.LogSelectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LogSelectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LogSelectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LogSelectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LogSelectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LogSelectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LogSelectionTable.Controls.Add(this.PrevisousLogButton, 0, 0);
            this.LogSelectionTable.Controls.Add(this.NexLogBUtton, 1, 0);
            this.LogSelectionTable.Controls.Add(this.LogCounterLabel, 2, 0);
            this.LogSelectionTable.Controls.Add(this.LogDateLabel, 4, 0);
            this.LogSelectionTable.Controls.Add(this.CopyButton, 5, 0);
            this.LogSelectionTable.Controls.Add(this.label1, 3, 0);
            this.LogSelectionTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogSelectionTable.Location = new System.Drawing.Point(3, 3);
            this.LogSelectionTable.Name = "LogSelectionTable";
            this.LogSelectionTable.RowCount = 1;
            this.LogSelectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LogSelectionTable.Size = new System.Drawing.Size(418, 46);
            this.LogSelectionTable.TabIndex = 0;
            // 
            // PrevisousLogButton
            // 
            this.PrevisousLogButton.Image = global::SMRandoDesktop.Properties.Resources.Back_32x32;
            this.PrevisousLogButton.Location = new System.Drawing.Point(3, 3);
            this.PrevisousLogButton.MaximumSize = new System.Drawing.Size(40, 40);
            this.PrevisousLogButton.MinimumSize = new System.Drawing.Size(40, 40);
            this.PrevisousLogButton.Name = "PrevisousLogButton";
            this.PrevisousLogButton.Size = new System.Drawing.Size(40, 40);
            this.PrevisousLogButton.TabIndex = 0;
            this.ExplanationToolTip.SetToolTip(this.PrevisousLogButton, "Previous log file");
            this.PrevisousLogButton.UseVisualStyleBackColor = true;
            this.PrevisousLogButton.Click += new System.EventHandler(this.PrevisousLogButton_Click);
            // 
            // NexLogBUtton
            // 
            this.NexLogBUtton.Image = global::SMRandoDesktop.Properties.Resources.Foward_32x32;
            this.NexLogBUtton.Location = new System.Drawing.Point(49, 3);
            this.NexLogBUtton.MaximumSize = new System.Drawing.Size(40, 40);
            this.NexLogBUtton.MinimumSize = new System.Drawing.Size(40, 40);
            this.NexLogBUtton.Name = "NexLogBUtton";
            this.NexLogBUtton.Size = new System.Drawing.Size(40, 40);
            this.NexLogBUtton.TabIndex = 1;
            this.ExplanationToolTip.SetToolTip(this.NexLogBUtton, "Next log file");
            this.NexLogBUtton.UseVisualStyleBackColor = true;
            this.NexLogBUtton.Click += new System.EventHandler(this.NexLogBUtton_Click);
            // 
            // LogCounterLabel
            // 
            this.LogCounterLabel.AutoSize = true;
            this.LogCounterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogCounterLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogCounterLabel.Location = new System.Drawing.Point(95, 0);
            this.LogCounterLabel.Name = "LogCounterLabel";
            this.LogCounterLabel.Size = new System.Drawing.Size(81, 46);
            this.LogCounterLabel.TabIndex = 2;
            this.LogCounterLabel.Text = "00 out of 000";
            this.LogCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogDateLabel
            // 
            this.LogDateLabel.AutoSize = true;
            this.LogDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogDateLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogDateLabel.Location = new System.Drawing.Point(193, 0);
            this.LogDateLabel.Name = "LogDateLabel";
            this.LogDateLabel.Size = new System.Drawing.Size(176, 46);
            this.LogDateLabel.TabIndex = 3;
            this.LogDateLabel.Text = "WW/XX/ZZZ";
            this.LogDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExplanationToolTip.SetToolTip(this.LogDateLabel, "Date/Time of the log file creation");
            // 
            // CopyButton
            // 
            this.CopyButton.Image = global::SMRandoDesktop.Properties.Resources.Copy_32x32;
            this.CopyButton.Location = new System.Drawing.Point(375, 3);
            this.CopyButton.MaximumSize = new System.Drawing.Size(40, 40);
            this.CopyButton.MinimumSize = new System.Drawing.Size(40, 40);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(40, 40);
            this.CopyButton.TabIndex = 4;
            this.ExplanationToolTip.SetToolTip(this.CopyButton, "Copy the displayed log file text");
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(179, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogTextBox.Location = new System.Drawing.Point(3, 55);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(418, 453);
            this.LogTextBox.TabIndex = 1;
            // 
            // ExceptionLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 511);
            this.Controls.Add(this.MainTable);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 550);
            this.MinimumSize = new System.Drawing.Size(440, 550);
            this.Name = "ExceptionLogForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Error logs";
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            this.LogSelectionTable.ResumeLayout(false);
            this.LogSelectionTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.TableLayoutPanel LogSelectionTable;
        private System.Windows.Forms.Button PrevisousLogButton;
        private System.Windows.Forms.Button NexLogBUtton;
        private System.Windows.Forms.Label LogCounterLabel;
        private System.Windows.Forms.Label LogDateLabel;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.ToolTip ExplanationToolTip;
        private System.Windows.Forms.Label label1;
    }
}