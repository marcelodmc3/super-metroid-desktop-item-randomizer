using ItemRandomizer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SMDIRandomizer.Forms
{
    /// <summary>
    /// Form for the parametrization of the randomizer
    /// </summary>
    public partial class SMRandomGeneratorForm : Form
    {
        // Constants
        #region Const
        /// <summary>
        /// Registry key to save and load settings
        /// </summary>
        private const string REGISTRY_KEY = @"SOFTWARE\Super Metroid Randomizer";
        #endregion

        // Form Variables
        #region Variables
        /// <summary>
        /// Watcher to check for new exception log files
        /// </summary>
        FileSystemWatcher _FileWatcher;

        /// <summary>
        /// Last randomized ROM file path
        /// </summary>
        private string _LasRandomizedROMFile;

        /// <summary>
        /// Supported difficulties available to the ramdomizer
        /// </summary>
        private readonly Types.Difficulty[] _SupportedDifficulties = new Types.Difficulty[]
        {
            Types.Difficulty.Casual,
            Types.Difficulty.Normal,
            Types.Difficulty.Hard,
            Types.Difficulty.Tournament,
            Types.Difficulty.Open,
            Types.Difficulty.Full
        };
        #endregion

        // Constructors
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public SMRandomGeneratorForm()
        {
            // Create the visual components
            this.InitializeComponent();

            // Max value alowed for a seed
            this.SeedNumericSelection.Maximum = int.MaxValue;

            // Try to load the last section parameters
            RandomizerParameters rdparameters = null;
            try { rdparameters = new RandomizerParameters(REGISTRY_KEY);}
            catch (Exception ex)
            {
                this.PrintUserMessage(Properties.Resources.LoadingSettingsErrorMessage, UserMessageType.Warning);
                this.PrintUserMessage(Properties.Resources.LoadingDefaultMessage, UserMessageType.Information);

                ex.Log();

                rdparameters = new RandomizerParameters();
            }

            // Populates the difficulty option combobox
            this.PopulateRandomizerParameters(rdparameters);

            // Check for exception log files
            this.CheckExceptionLogFiles();

            // Display the application version
            this.Text += " - " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
        #endregion

        // Private Methods
        #region Private
        /// <summary>
        /// Click to see the application info
        /// </summary>
        private void AppInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (AppInfoForm form = new AppInfoForm())
                {
                    form.ShowDialog(this);
                }
            }

            catch (Exception ex) { ex.LogAndDisplayMessage(); }
        }

        /// <summary>
        /// Check for the exception log files
        /// </summary>
        private void CheckExceptionLogFiles()
        {
            // Create the file watcher
            this._FileWatcher = new FileSystemWatcher(Core.LogPath, "*.txt");
            this._FileWatcher.BeginInit();
            this._FileWatcher.Created += this.FileWatcher_Changed;

            // Enable file watcher
            try { this._FileWatcher.EnableRaisingEvents = true; }
            catch {; }

            // Ends the inicialization
            this._FileWatcher.EndInit();
        }

        /// <summary>
        /// Composes the new file name of the newly randomized ROM
        /// </summary>
        /// <param name="seed">Seed number</param>
        /// <param name="difficulty">Difficulty of the seed</param>
        /// <param name="sourcefilename">Source file name</param>
        /// <returns></returns>
        private string ComposeFileName(int seed, Types.Difficulty difficulty, string sourcefilename)
        {
            // Gets the extension
            string extension = Path.GetExtension(sourcefilename);

            // Composes the filename based on the seed and difficulty
            switch (difficulty)
            {
                // Setting the file name for the Casual difficulty
                case Types.Difficulty.Casual:
                    return "CX" + seed.ToString() + extension;

                // Setting the file name for the Casual difficulty
                case Types.Difficulty.Normal:
                    return "X" + seed.ToString() + extension;

                // Setting the file name for the Casual difficulty
                case Types.Difficulty.Hard:
                    return "HX" + seed.ToString() + extension;

                // Setting the file name for the Casual difficulty
                case Types.Difficulty.Tournament:
                    return "TX" + seed.ToString() + extension;

                // Setting the file name for the Casual difficulty
                case Types.Difficulty.Open:
                    return "OX" + seed.ToString() + extension;

                // Setting the file name for the Casual difficulty
                case Types.Difficulty.Full:
                    return "FX" + seed.ToString() + extension;

                // Throw error in case of difficulty not recognized
                default: throw new NotSupportedException(difficulty.ToString());
            }
        }

        /// <summary>
        /// Click to select the emulator executable
        /// </summary>
        private void EmulatorSourceButton_Click(object sender, EventArgs e)
        {
            try
            {
                // If the user confirms the selection
                if (this.OpenEmulatorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Stores the filename
                    this.EmulatorSourceTextBox.Text = this.OpenEmulatorDialog.FileName;
                }
            }

            catch (Exception ex)
            {
                ex.LogAndDisplayMessage();
            }
        }

        /// <summary>
        /// Click to see the exception logs
        /// </summary>
        private void ErrorLogButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExceptionLogForm form = 
                    new ExceptionLogForm(Directory.GetFiles(Core.LogPath, "*.txt").ToList()))
                {
                    form.ShowDialog(this);
                }
            }
            catch (Exception ex) { ex.LogAndDisplayMessage(); }
        }

        /// <summary>
        /// Click to select a ROM file for randomization
        /// </summary>
        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                // If the user confirms the selection
                if (this.OpenRomDialog.ShowDialog() == DialogResult.OK)
                {
                    // Stores the filename
                    this.FileSelectTextBox.Text = this.OpenRomDialog.FileName;
                }
            }

            catch (Exception ex)
            {
                ex.LogAndDisplayMessage();
            }
        }

        /// <summary>
        /// When the text in the file selection is changed
        /// </summary>
        private void FileSelectTextBox_TextChanged(object sender, EventArgs e)
        {
            // Makes shure the background color is not representing "error"
            ((TextBox)sender).BackColor = this.BackColor;
        }

        /// <summary>
        /// Every time a new log file is added
        /// </summary>
        private void FileWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            // Necessário sincronizar com a tela? Repassa chamada!
            if (this.InvokeRequired) this.BeginInvoke(new Action<object, FileSystemEventArgs>(this.FileWatcher_Changed), sender, e);
            else
            {
                this.ErrorLogButton.Enabled = 
                    this.ErrorLogButton.Visible = 
                    Directory.GetFiles(Core.LogPath, "*.txt").Length > 0;
            }
        }

        /// <summary>
        /// Return the current randomization parameters
        /// </summary>
        private RandomizerParameters GetRandomizerParameters()
        {
            // Get the randomization parameters
            RandomizerParameters rdparameters = new RandomizerParameters()
            {
                UserInputSeed = this.SeedRadioButton.Checked,
                SourceFilePath = this.FileSelectTextBox.Text,
                Seed = (int)this.SeedNumericSelection.Value,
                SaveSpoilers = this.SpoilerCheckBox.Checked,
                RandomSeedCount = (int)this.RandomSeedNumericSelection.Value,
                Difficulty = (this.DifficultyComboBox.SelectedItem as DifficultyOption).Difficulty,
                StartEmulator = this.UseEmulatorCheckBox.Checked,
                EmulatorExecutablePath = this.EmulatorSourceTextBox.Text
            };

            return rdparameters;
        }

        /// <summary>
        /// Populates the difficulty option combobox
        /// </summary>
        /// <param name="lastselected">Last item selected</param>
        private void PopulateRandomizerParameters(RandomizerParameters rdparameters)
        {
            // Set previously used parameters
            this.FileSelectTextBox.Text = rdparameters.SourceFilePath;
            this.SeedRadioButton.Checked = rdparameters.UserInputSeed;
            this.RandomSeedRadioButton.Checked = !rdparameters.UserInputSeed;
            this.SeedNumericSelection.Value = rdparameters.Seed;
            this.RandomSeedNumericSelection.Value = rdparameters.RandomSeedCount;
            this.SpoilerCheckBox.Checked = rdparameters.SaveSpoilers;
            this.UseEmulatorCheckBox.Checked = rdparameters.StartEmulator;
            this.EmulatorSourceTextBox.Text = rdparameters.EmulatorExecutablePath;

            // Populates the difficulty combobox options
            List<DifficultyOption> options = new List<DifficultyOption>();
            foreach (Types.Difficulty difficulty in this._SupportedDifficulties)
            {
                options.Add(new DifficultyOption(difficulty));
            }

            options.Sort();

            this.DifficultyComboBox.Items.AddRange(options.ToArray());

            // Pre-select the option from the user registry
            this.DifficultyComboBox.SelectedIndex = (int)rdparameters.Difficulty;
        }

        /// <summary>
        /// Displays a message to the user about any possible errors, warnings and the randomizantion process
        /// </summary>
        /// <param name="message">The message to be printed</param>
        /// <param name="messagetype">The type of message: Error, waring, information or sucess</param>
        private void PrintUserMessage(string message, UserMessageType messagetype = UserMessageType.Information)
        {
            // Create label with the message
            Label messagelabel = new Label()
            {
                Font = this.Font,
                AutoSize = true,
                Dock = DockStyle.Top,
                Text = message
            };

            // Set the color
            switch(messagetype)
            {
                case UserMessageType.Sucess:
                    messagelabel.ForeColor = Color.Green;
                    break;

                case UserMessageType.Warning:
                    messagelabel.ForeColor = Color.DarkOrange;
                    break;

                case UserMessageType.Error:
                    messagelabel.ForeColor = Color.Red;
                    break;
            }

            // Print the message
            this.MessagesFlowPanel.Controls.Add(messagelabel);
            this.MessagesFlowPanel.VerticalScroll.Value = this.MessagesFlowPanel.VerticalScroll.Maximum;
        }

        /// <summary>
        /// Click no the "Randomize!" button to start a randomziation process
        /// </summary>
        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the filepath is valid
                if (string.IsNullOrWhiteSpace(this.FileSelectTextBox.Text) || !File.Exists(this.FileSelectTextBox.Text))
                {
                    // If it is invalid, change the color of the text box to show the problem
                    this.FileSelectTextBox.BackColor = Color.Salmon;
                    this.PrintUserMessage(Properties.Resources.FilePathWarning, UserMessageType.Warning);
                    this.PrintUserMessage("", UserMessageType.Warning);
                    return;
                }

                // Check if the emulator is valid
                if (this.UseEmulatorCheckBox.Checked && (string.IsNullOrWhiteSpace(this.EmulatorSourceTextBox.Text) || !File.Exists(this.EmulatorSourceTextBox.Text)))
                {
                    // If it is invalid, change the color of the text box to show the problem
                    this.EmulatorSourceTextBox.BackColor = Color.Salmon;
                    this.PrintUserMessage(Properties.Resources.EmulatorFilePathWarning, UserMessageType.Warning);
                    this.PrintUserMessage("", UserMessageType.Warning);
                    return;
                }

                // Get the randomization parameters
                RandomizerParameters rdparameters = this.GetRandomizerParameters();

                // Disabel all user actions while processing
                this.DifficultyTable.Enabled = false;
                this.RomSourceTable.Enabled = false;
                this.SeedingMethodTable.Enabled = false;
                this.RandomizeButton.Enabled = false;
                this.AppInfoButton.Enabled = false;
                this.ErrorLogButton.Enabled = false;

                this.RandomizerThread.RunWorkerAsync(rdparameters);
            }
            catch (Exception ex)
            {
                ex.LogAndDisplayMessage();

                // Enable user actions
                this.DifficultyTable.Enabled = true;
                this.RomSourceTable.Enabled = true;
                this.SeedingMethodTable.Enabled = true;
                this.RandomizeButton.Enabled = true;
                this.AppInfoButton.Enabled = true;
                this.ErrorLogButton.Enabled = true;
            }
        }

        /// <summary>
        /// Deals whith exceptions during the randomization process
        /// </summary>
        /// <param name="ex">Exeption details</param>
        private void RandomizerErrorTreatment(Exception ex)
        {
            // Print message in the form
            this.PrintUserMessage(Properties.Resources.ShortErrorMessage, UserMessageType.Error);

            // Show message box
            MessageBox.Show(
                Properties.Resources.ErrorMessage,
                Properties.Resources.ErrorCaption,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            // Try to log the error message
            ex.Log();
        }

        /// <summary>
        /// Background thread to perform the randomization process
        /// </summary>
        private void RandomizerThread_DoWork(object sender, DoWorkEventArgs e)
        {
            // Parameter is valid?
            if (e.Argument is RandomizerParameters rdparameters)
            {
                // Progress message
                this.BeginInvoke(
                    new Action<string, UserMessageType>(this.PrintUserMessage), 
                    Properties.Resources.LoadingRomMessage, UserMessageType.Information);

                // Load Rom file
                byte[] roombytes = null;
                using (FileStream romfile = new FileStream(rdparameters.SourceFilePath, FileMode.Open))
                {
                    roombytes = new byte[(int)romfile.Length];

                    romfile.Read(roombytes, 0, (int)romfile.Length);
                }

                // Progress message
                this.BeginInvoke(
                    new Action<string, UserMessageType>(this.PrintUserMessage),
                    Properties.Resources.LoadingRomMessageSucess, UserMessageType.Sucess);

                // Check the seed parameter
                int randocount = rdparameters.UserInputSeed ? 1 : rdparameters.RandomSeedCount;

                Random rd = new Random();
                int[] seeds = new int[randocount];

                // Foreach seed to genareate
                for (int i = 0; i < randocount; i++)
                {
                    // Input seed is valid?
                    if (rdparameters.UserInputSeed && rdparameters.Seed > 0)
                    {
                        // Use the input by the user
                        seeds[i] = rdparameters.Seed;
                    }
                    else
                    {
                        bool seedrepeated = true;
                        int newseed = 0;

                        do
                        {
                            // Genarate a new random seed checking against repetition
                            newseed = rd.Next(1000000, 9999999);
                            for (int j = 0; j < i; j++)
                            {
                                if (seeds[j] == newseed) { seedrepeated = false; break; }
                            }

                            // Only stops if the seed generated is unique
                        } while (!seedrepeated);

                        seeds[i] = newseed;
                    }
                }

                // Gets the folder path that contains the source ROM file
                string folderpath = Path.GetDirectoryName(rdparameters.SourceFilePath) + "\\";

                // For each seed generated
                for (int i = 0; i < randocount; i++)
                {
                    // Seed used in the current randomization
                    int seed = seeds[i];

                    // Progress message
                    this.BeginInvoke(
                        new Action<string, UserMessageType>(this.PrintUserMessage),
                        string.Format(Properties.Resources.RandomizingMessage, seed, (i + 1), randocount), UserMessageType.Information);

                    Tuple<int, byte[]> randoresult = null;

                    // Output file names
                    string filename = "Super Metroid " + this.ComposeFileName(seed, rdparameters.Difficulty, rdparameters.SourceFilePath);
                    string filepath = folderpath + filename;
                    string spoilerfilepath = filepath + ".spoilers.txt";
                    string tempspoilersfile = Path.GetTempFileName();

                    try
                    {
                        // Creates a new rom data based on the seed and difficulty
                        randoresult = Randomizer.Randomize(
                            seed,
                            rdparameters.Difficulty,
                            rdparameters.SaveSpoilers,
                            tempspoilersfile,
                            roombytes);
                    } catch (Exception ex)
                    {
                        throw new RandomizationException(
                            seed, 
                            (int)rdparameters.Difficulty, 
                            rdparameters.SourceFilePath, 
                            "Error while randomizing the ROM", 
                            ex);
                    }

                    // Write the spoiler files
                    SpoilersWriter.WriteSpoilers(tempspoilersfile, spoilerfilepath);

                    // Try to delete temp file, ignore-it if not possible
                    try { File.Delete(tempspoilersfile); } catch {; }

                    // Saves the new rom on the same folder as the source file
                    using (FileStream resultrom = new FileStream(filepath, FileMode.Create, FileAccess.ReadWrite))
                    {
                        resultrom.Write(randoresult.Item2, 0, randoresult.Item2.Length);
                    }

                    // Set the last randomized ROM file
                    this._LasRandomizedROMFile = filepath;

                    // Progress message
                    this.BeginInvoke(
                        new Action<string, UserMessageType>(this.PrintUserMessage),
                        string.Format(Properties.Resources.RandomizingMessageSucess, "\"" + filename + "\""), UserMessageType.Sucess);
                }

                e.Result = rdparameters;
            }

            else throw new ArgumentException("RandomizerParameters");
        }

        /// <summary>
        /// After the conclusion of the randomizantion process
        /// </summary>
        private void RandomizerThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                // Throw any error
                if (e.Error != null) this.RandomizerErrorTreatment(e.Error);

                else
                {
                    // If the result is valid
                    if (e.Result is RandomizerParameters rdparameters)
                    {
                        // Inform the user
                        this.PrintUserMessage(" ", UserMessageType.Sucess);
                        this.PrintUserMessage(Properties.Resources.GenerateROMLocation, UserMessageType.Sucess);

                        // Start emulator after the randomization?
                        if (rdparameters.StartEmulator)
                        {
                            try
                            {
                                // Get emulator name
                                string emulatorname = Path.GetFileName(rdparameters.EmulatorExecutablePath);
                                
                                // Inform the user that the emulator is about to star
                                this.PrintUserMessage(" ", UserMessageType.Sucess);
                                this.PrintUserMessage(string.Format(Properties.Resources.EmulatorStartingMessage, emulatorname));

                                // Lauch the emulator
                                System.Diagnostics.Process.Start(rdparameters.EmulatorExecutablePath, "\"" + this._LasRandomizedROMFile + "\"");
                                this.PrintUserMessage(string.Format(Properties.Resources.EmulatorStartedMessage, emulatorname), UserMessageType.Sucess);
                            }

                            // Problems?
                            catch (Exception ex)
                            {
                                // Inform the user about the error
                                this.PrintUserMessage(Properties.Resources.EmulatorStartingErrorMessage, UserMessageType.Error);
                                ex.LogAndDisplayMessage();
                            }
                        }
                    }
                    else
                    {
                        throw new NullReferenceException("RandomizerParameters");
                    }
                }
            }

            catch (ThreadAbortException) {; }

            catch (Exception ex)
            {
                this.RandomizerErrorTreatment(ex);
            }

            finally
            {
                // Enable user actions
                this.DifficultyTable.Enabled = true;
                this.RomSourceTable.Enabled = true;
                this.SeedingMethodTable.Enabled = true;
                this.RandomizeButton.Enabled = true;
                this.AppInfoButton.Enabled = true;
                this.ErrorLogButton.Enabled = true;
            }
        }

        /// <summary>
        /// When the form is closed
        /// </summary>
        private void SMRandomGeneratorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                // Save parameters
                RandomizerParameters rdparameters = this.GetRandomizerParameters();
                rdparameters.SaveParameters(REGISTRY_KEY);
            }

            // If there is an error while saving the parameters, just log it and ignore it
            catch (Exception ex)
            {
                ex.Log();
            }
        }

        /// <summary>
        /// When the user request the closing of the application
        /// </summary>
        private void SMRandoGeneratorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if thread is running and ask the user for confirmation
            if (this.RandomizerThread.IsBusy)
            {
                if (MessageBox.Show(
                    Properties.Resources.ConfirmClosingMessage,
                    Properties.Resources.ConfirmClosingCaption,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// When the option to load the emulator is checked/unchecked
        /// </summary>
        private void UseEmulatorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.EmulatorSourceTable.Enabled = this.UseEmulatorCheckBox.Checked;
            this.EmulatorSourceTextBox.BackColor = this.BackColor;
        }
        #endregion
    }
}
