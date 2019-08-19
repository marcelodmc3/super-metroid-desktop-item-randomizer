namespace SMDIRandomizer.Forms
{
    partial class SMRandomGeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMRandomGeneratorForm));
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.OptionsTable = new System.Windows.Forms.TableLayoutPanel();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.RomSourceLabel = new System.Windows.Forms.Label();
            this.SeedingMethodTable = new System.Windows.Forms.TableLayoutPanel();
            this.SeedNumericSelection = new System.Windows.Forms.NumericUpDown();
            this.SeedRadioButton = new System.Windows.Forms.RadioButton();
            this.RandomSeedRadioButton = new System.Windows.Forms.RadioButton();
            this.RandomSeedNumericSelection = new System.Windows.Forms.NumericUpDown();
            this.SeedingMethodLabel = new System.Windows.Forms.Label();
            this.RomSourceTable = new System.Windows.Forms.TableLayoutPanel();
            this.FileSelectLabel = new System.Windows.Forms.Label();
            this.FileSelectButton = new System.Windows.Forms.Button();
            this.FileSelectTextBox = new System.Windows.Forms.TextBox();
            this.DifficultyTable = new System.Windows.Forms.TableLayoutPanel();
            this.DifficultySelectionLabel = new System.Windows.Forms.Label();
            this.DifficultyComboBox = new System.Windows.Forms.ComboBox();
            this.SpoilerCheckBox = new System.Windows.Forms.CheckBox();
            this.RandomizeButton = new System.Windows.Forms.Button();
            this.MessagesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.InfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.ErrorLogButton = new System.Windows.Forms.Button();
            this.AppInfoButton = new System.Windows.Forms.Button();
            this.SamusBackgroundImage = new System.Windows.Forms.PictureBox();
            this.OpenRomDialog = new System.Windows.Forms.OpenFileDialog();
            this.ExplantionToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RandomizerThread = new System.ComponentModel.BackgroundWorker();
            this.MainTable.SuspendLayout();
            this.OptionsTable.SuspendLayout();
            this.SeedingMethodTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeedNumericSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomSeedNumericSelection)).BeginInit();
            this.RomSourceTable.SuspendLayout();
            this.DifficultyTable.SuspendLayout();
            this.InfoTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SamusBackgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.MainTable.Controls.Add(this.OptionsTable, 1, 0);
            this.MainTable.Controls.Add(this.SamusBackgroundImage, 0, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 1;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(784, 511);
            this.MainTable.TabIndex = 1;
            // 
            // OptionsTable
            // 
            this.OptionsTable.BackColor = System.Drawing.Color.White;
            this.OptionsTable.ColumnCount = 1;
            this.OptionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OptionsTable.Controls.Add(this.DifficultyLabel, 0, 4);
            this.OptionsTable.Controls.Add(this.RomSourceLabel, 0, 0);
            this.OptionsTable.Controls.Add(this.SeedingMethodTable, 0, 3);
            this.OptionsTable.Controls.Add(this.SeedingMethodLabel, 0, 2);
            this.OptionsTable.Controls.Add(this.RomSourceTable, 0, 1);
            this.OptionsTable.Controls.Add(this.DifficultyTable, 0, 5);
            this.OptionsTable.Controls.Add(this.RandomizeButton, 0, 6);
            this.OptionsTable.Controls.Add(this.MessagesFlowPanel, 0, 7);
            this.OptionsTable.Controls.Add(this.InfoTable, 0, 8);
            this.OptionsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsTable.Location = new System.Drawing.Point(340, 3);
            this.OptionsTable.Name = "OptionsTable";
            this.OptionsTable.RowCount = 9;
            this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OptionsTable.Size = new System.Drawing.Size(441, 505);
            this.OptionsTable.TabIndex = 0;
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DifficultyLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyLabel.Location = new System.Drawing.Point(3, 186);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.DifficultyLabel.Size = new System.Drawing.Size(435, 46);
            this.DifficultyLabel.TabIndex = 5;
            this.DifficultyLabel.Text = "Difficulty";
            this.DifficultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RomSourceLabel
            // 
            this.RomSourceLabel.AutoSize = true;
            this.RomSourceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RomSourceLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomSourceLabel.Location = new System.Drawing.Point(3, 0);
            this.RomSourceLabel.Name = "RomSourceLabel";
            this.RomSourceLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.RomSourceLabel.Size = new System.Drawing.Size(435, 36);
            this.RomSourceLabel.TabIndex = 0;
            this.RomSourceLabel.Text = "ROM source";
            this.RomSourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SeedingMethodTable
            // 
            this.SeedingMethodTable.AutoSize = true;
            this.SeedingMethodTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SeedingMethodTable.ColumnCount = 2;
            this.SeedingMethodTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SeedingMethodTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SeedingMethodTable.Controls.Add(this.SeedNumericSelection, 1, 0);
            this.SeedingMethodTable.Controls.Add(this.SeedRadioButton, 0, 0);
            this.SeedingMethodTable.Controls.Add(this.RandomSeedRadioButton, 0, 1);
            this.SeedingMethodTable.Controls.Add(this.RandomSeedNumericSelection, 1, 1);
            this.SeedingMethodTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeedingMethodTable.Location = new System.Drawing.Point(3, 125);
            this.SeedingMethodTable.Name = "SeedingMethodTable";
            this.SeedingMethodTable.RowCount = 2;
            this.SeedingMethodTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SeedingMethodTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SeedingMethodTable.Size = new System.Drawing.Size(435, 58);
            this.SeedingMethodTable.TabIndex = 4;
            // 
            // SeedNumericSelection
            // 
            this.SeedNumericSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeedNumericSelection.Location = new System.Drawing.Point(244, 3);
            this.SeedNumericSelection.Name = "SeedNumericSelection";
            this.SeedNumericSelection.Size = new System.Drawing.Size(188, 23);
            this.SeedNumericSelection.TabIndex = 6;
            this.SeedNumericSelection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SeedRadioButton
            // 
            this.SeedRadioButton.AutoSize = true;
            this.SeedRadioButton.Checked = true;
            this.SeedRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeedRadioButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeedRadioButton.Location = new System.Drawing.Point(3, 3);
            this.SeedRadioButton.Name = "SeedRadioButton";
            this.SeedRadioButton.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.SeedRadioButton.Size = new System.Drawing.Size(235, 23);
            this.SeedRadioButton.TabIndex = 5;
            this.SeedRadioButton.TabStop = true;
            this.SeedRadioButton.Text = "Pick a specific seed number: ";
            this.SeedRadioButton.UseVisualStyleBackColor = true;
            // 
            // RandomSeedRadioButton
            // 
            this.RandomSeedRadioButton.AutoSize = true;
            this.RandomSeedRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RandomSeedRadioButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomSeedRadioButton.Location = new System.Drawing.Point(3, 32);
            this.RandomSeedRadioButton.Name = "RandomSeedRadioButton";
            this.RandomSeedRadioButton.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.RandomSeedRadioButton.Size = new System.Drawing.Size(235, 23);
            this.RandomSeedRadioButton.TabIndex = 7;
            this.RandomSeedRadioButton.Text = "Generate up to 100 random seeds:";
            this.RandomSeedRadioButton.UseVisualStyleBackColor = true;
            // 
            // RandomSeedNumericSelection
            // 
            this.RandomSeedNumericSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RandomSeedNumericSelection.Location = new System.Drawing.Point(244, 32);
            this.RandomSeedNumericSelection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RandomSeedNumericSelection.Name = "RandomSeedNumericSelection";
            this.RandomSeedNumericSelection.Size = new System.Drawing.Size(188, 23);
            this.RandomSeedNumericSelection.TabIndex = 8;
            this.RandomSeedNumericSelection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RandomSeedNumericSelection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SeedingMethodLabel
            // 
            this.SeedingMethodLabel.AutoSize = true;
            this.SeedingMethodLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeedingMethodLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeedingMethodLabel.Location = new System.Drawing.Point(3, 76);
            this.SeedingMethodLabel.Name = "SeedingMethodLabel";
            this.SeedingMethodLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.SeedingMethodLabel.Size = new System.Drawing.Size(435, 46);
            this.SeedingMethodLabel.TabIndex = 3;
            this.SeedingMethodLabel.Text = "Seeding method";
            this.SeedingMethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RomSourceTable
            // 
            this.RomSourceTable.ColumnCount = 3;
            this.RomSourceTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RomSourceTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RomSourceTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RomSourceTable.Controls.Add(this.FileSelectLabel, 0, 0);
            this.RomSourceTable.Controls.Add(this.FileSelectButton, 2, 0);
            this.RomSourceTable.Controls.Add(this.FileSelectTextBox, 1, 0);
            this.RomSourceTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RomSourceTable.Location = new System.Drawing.Point(3, 39);
            this.RomSourceTable.Name = "RomSourceTable";
            this.RomSourceTable.RowCount = 1;
            this.RomSourceTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RomSourceTable.Size = new System.Drawing.Size(435, 34);
            this.RomSourceTable.TabIndex = 0;
            // 
            // FileSelectLabel
            // 
            this.FileSelectLabel.AutoSize = true;
            this.FileSelectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileSelectLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileSelectLabel.Location = new System.Drawing.Point(3, 0);
            this.FileSelectLabel.Name = "FileSelectLabel";
            this.FileSelectLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.FileSelectLabel.Size = new System.Drawing.Size(127, 34);
            this.FileSelectLabel.TabIndex = 1;
            this.FileSelectLabel.Text = "Select the rom file:";
            this.FileSelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FileSelectButton
            // 
            this.FileSelectButton.AutoSize = true;
            this.FileSelectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FileSelectButton.Location = new System.Drawing.Point(400, 3);
            this.FileSelectButton.MaximumSize = new System.Drawing.Size(32, 28);
            this.FileSelectButton.MinimumSize = new System.Drawing.Size(32, 28);
            this.FileSelectButton.Name = "FileSelectButton";
            this.FileSelectButton.Size = new System.Drawing.Size(32, 28);
            this.FileSelectButton.TabIndex = 3;
            this.FileSelectButton.Text = "...";
            this.FileSelectButton.UseVisualStyleBackColor = true;
            this.FileSelectButton.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // FileSelectTextBox
            // 
            this.FileSelectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FileSelectTextBox.Location = new System.Drawing.Point(136, 5);
            this.FileSelectTextBox.Name = "FileSelectTextBox";
            this.FileSelectTextBox.Size = new System.Drawing.Size(258, 23);
            this.FileSelectTextBox.TabIndex = 2;
            this.FileSelectTextBox.TextChanged += new System.EventHandler(this.FileSelectTextBox_TextChanged);
            // 
            // DifficultyTable
            // 
            this.DifficultyTable.AutoSize = true;
            this.DifficultyTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DifficultyTable.ColumnCount = 2;
            this.DifficultyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DifficultyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DifficultyTable.Controls.Add(this.DifficultySelectionLabel, 0, 0);
            this.DifficultyTable.Controls.Add(this.DifficultyComboBox, 1, 0);
            this.DifficultyTable.Controls.Add(this.SpoilerCheckBox, 0, 1);
            this.DifficultyTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DifficultyTable.Location = new System.Drawing.Point(3, 235);
            this.DifficultyTable.Name = "DifficultyTable";
            this.DifficultyTable.RowCount = 2;
            this.DifficultyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DifficultyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DifficultyTable.Size = new System.Drawing.Size(435, 54);
            this.DifficultyTable.TabIndex = 6;
            // 
            // DifficultySelectionLabel
            // 
            this.DifficultySelectionLabel.AutoSize = true;
            this.DifficultySelectionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DifficultySelectionLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultySelectionLabel.Location = new System.Drawing.Point(3, 0);
            this.DifficultySelectionLabel.Name = "DifficultySelectionLabel";
            this.DifficultySelectionLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.DifficultySelectionLabel.Size = new System.Drawing.Size(145, 29);
            this.DifficultySelectionLabel.TabIndex = 10;
            this.DifficultySelectionLabel.Text = "Set the difficulty level:";
            this.DifficultySelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DifficultyComboBox
            // 
            this.DifficultyComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DifficultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DifficultyComboBox.FormattingEnabled = true;
            this.DifficultyComboBox.Location = new System.Drawing.Point(154, 3);
            this.DifficultyComboBox.Name = "DifficultyComboBox";
            this.DifficultyComboBox.Size = new System.Drawing.Size(278, 23);
            this.DifficultyComboBox.TabIndex = 11;
            // 
            // SpoilerCheckBox
            // 
            this.SpoilerCheckBox.AutoSize = true;
            this.SpoilerCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpoilerCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.SpoilerCheckBox.Location = new System.Drawing.Point(3, 32);
            this.SpoilerCheckBox.Name = "SpoilerCheckBox";
            this.SpoilerCheckBox.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.SpoilerCheckBox.Size = new System.Drawing.Size(145, 19);
            this.SpoilerCheckBox.TabIndex = 14;
            this.SpoilerCheckBox.Text = "Save spoilers file";
            this.ExplantionToolTip.SetToolTip(this.SpoilerCheckBox, "Generates a text file containing the location of the randomized items.\r\n");
            this.SpoilerCheckBox.UseVisualStyleBackColor = true;
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.AutoSize = true;
            this.RandomizeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RandomizeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RandomizeButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.RandomizeButton.Location = new System.Drawing.Point(5, 305);
            this.RandomizeButton.Margin = new System.Windows.Forms.Padding(5, 13, 5, 3);
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(431, 36);
            this.RandomizeButton.TabIndex = 7;
            this.RandomizeButton.Text = "Randomize!";
            this.RandomizeButton.UseVisualStyleBackColor = true;
            this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
            // 
            // MessagesFlowPanel
            // 
            this.MessagesFlowPanel.AutoScroll = true;
            this.MessagesFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagesFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MessagesFlowPanel.Location = new System.Drawing.Point(3, 347);
            this.MessagesFlowPanel.Name = "MessagesFlowPanel";
            this.MessagesFlowPanel.Size = new System.Drawing.Size(435, 115);
            this.MessagesFlowPanel.TabIndex = 7;
            this.MessagesFlowPanel.WrapContents = false;
            // 
            // InfoTable
            // 
            this.InfoTable.AutoSize = true;
            this.InfoTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InfoTable.ColumnCount = 3;
            this.InfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.InfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.InfoTable.Controls.Add(this.ErrorLogButton, 1, 0);
            this.InfoTable.Controls.Add(this.AppInfoButton, 2, 0);
            this.InfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoTable.Location = new System.Drawing.Point(3, 465);
            this.InfoTable.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.InfoTable.Name = "InfoTable";
            this.InfoTable.RowCount = 1;
            this.InfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InfoTable.Size = new System.Drawing.Size(435, 40);
            this.InfoTable.TabIndex = 8;
            // 
            // ErrorLogButton
            // 
            this.ErrorLogButton.AutoSize = true;
            this.ErrorLogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ErrorLogButton.Enabled = false;
            this.ErrorLogButton.Image = global::SMDIRandomizer.Properties.Resources.Error_32x32;
            this.ErrorLogButton.Location = new System.Drawing.Point(346, 0);
            this.ErrorLogButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ErrorLogButton.MaximumSize = new System.Drawing.Size(40, 40);
            this.ErrorLogButton.MinimumSize = new System.Drawing.Size(40, 40);
            this.ErrorLogButton.Name = "ErrorLogButton";
            this.ErrorLogButton.Size = new System.Drawing.Size(40, 40);
            this.ErrorLogButton.TabIndex = 16;
            this.ExplantionToolTip.SetToolTip(this.ErrorLogButton, "Click to see the full error log of this software.");
            this.ErrorLogButton.UseVisualStyleBackColor = true;
            this.ErrorLogButton.Visible = false;
            this.ErrorLogButton.Click += new System.EventHandler(this.ErrorLogButton_Click);
            // 
            // AppInfoButton
            // 
            this.AppInfoButton.AutoSize = true;
            this.AppInfoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AppInfoButton.Image = global::SMDIRandomizer.Properties.Resources.Info_32x32;
            this.AppInfoButton.Location = new System.Drawing.Point(392, 0);
            this.AppInfoButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.AppInfoButton.MaximumSize = new System.Drawing.Size(40, 40);
            this.AppInfoButton.MinimumSize = new System.Drawing.Size(40, 40);
            this.AppInfoButton.Name = "AppInfoButton";
            this.AppInfoButton.Size = new System.Drawing.Size(40, 40);
            this.AppInfoButton.TabIndex = 17;
            this.ExplantionToolTip.SetToolTip(this.AppInfoButton, "Information about this software.");
            this.AppInfoButton.UseVisualStyleBackColor = true;
            this.AppInfoButton.Click += new System.EventHandler(this.AppInfoButton_Click);
            // 
            // SamusBackgroundImage
            // 
            this.SamusBackgroundImage.BackgroundImage = global::SMDIRandomizer.Properties.Resources.SMBackgroud;
            this.SamusBackgroundImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SamusBackgroundImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SamusBackgroundImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("SamusBackgroundImage.InitialImage")));
            this.SamusBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.SamusBackgroundImage.Margin = new System.Windows.Forms.Padding(0);
            this.SamusBackgroundImage.Name = "SamusBackgroundImage";
            this.SamusBackgroundImage.Size = new System.Drawing.Size(337, 511);
            this.SamusBackgroundImage.TabIndex = 1;
            this.SamusBackgroundImage.TabStop = false;
            // 
            // OpenRomDialog
            // 
            this.OpenRomDialog.Title = "Select a rom file to randomize";
            // 
            // RandomizerThread
            // 
            this.RandomizerThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RandomizerThread_DoWork);
            this.RandomizerThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.RandomizerThread_RunWorkerCompleted);
            // 
            // SMRandomGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.MainTable);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "SMRandomGeneratorForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Metroid Desktop Item Randomizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SMRandoGeneratorForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SMRandomGeneratorForm_FormClosed);
            this.MainTable.ResumeLayout(false);
            this.OptionsTable.ResumeLayout(false);
            this.OptionsTable.PerformLayout();
            this.SeedingMethodTable.ResumeLayout(false);
            this.SeedingMethodTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeedNumericSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomSeedNumericSelection)).EndInit();
            this.RomSourceTable.ResumeLayout(false);
            this.RomSourceTable.PerformLayout();
            this.DifficultyTable.ResumeLayout(false);
            this.DifficultyTable.PerformLayout();
            this.InfoTable.ResumeLayout(false);
            this.InfoTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SamusBackgroundImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.TableLayoutPanel OptionsTable;
        private System.Windows.Forms.PictureBox SamusBackgroundImage;
        private System.Windows.Forms.Label SeedingMethodLabel;
        private System.Windows.Forms.TableLayoutPanel SeedingMethodTable;
        private System.Windows.Forms.NumericUpDown SeedNumericSelection;
        private System.Windows.Forms.RadioButton SeedRadioButton;
        private System.Windows.Forms.RadioButton RandomSeedRadioButton;
        private System.Windows.Forms.NumericUpDown RandomSeedNumericSelection;
        private System.Windows.Forms.Label RomSourceLabel;
        private System.Windows.Forms.TableLayoutPanel RomSourceTable;
        private System.Windows.Forms.Label FileSelectLabel;
        private System.Windows.Forms.Button FileSelectButton;
        private System.Windows.Forms.TextBox FileSelectTextBox;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.TableLayoutPanel DifficultyTable;
        private System.Windows.Forms.Label DifficultySelectionLabel;
        private System.Windows.Forms.ComboBox DifficultyComboBox;
        private System.Windows.Forms.Button RandomizeButton;
        private System.Windows.Forms.OpenFileDialog OpenRomDialog;
        private System.Windows.Forms.ToolTip ExplantionToolTip;
        private System.ComponentModel.BackgroundWorker RandomizerThread;
        private System.Windows.Forms.FlowLayoutPanel MessagesFlowPanel;
        private System.Windows.Forms.TableLayoutPanel InfoTable;
        private System.Windows.Forms.Button ErrorLogButton;
        private System.Windows.Forms.Button AppInfoButton;
        private System.Windows.Forms.CheckBox SpoilerCheckBox;
    }
}

