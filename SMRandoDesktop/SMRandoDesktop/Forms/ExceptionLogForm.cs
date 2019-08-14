using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SMRandoDesktop.Forms
{
    /// <summary>
    /// Form that shows the application error log files
    /// </summary>
    public partial class ExceptionLogForm : Form
    {
        // Private methods
        #region Private
        /// <summary>
        /// Index of the currently selected log file
        /// </summary>
        private int _DiplayedIndex;

        /// <summary>
        /// 
        /// </summary>
        private List<LogFileInfo> _LogFiles;
        #endregion

        // Class constructors
        #region Constructors
        /// <summary>
        /// Cretes based on a list of logfiles
        /// </summary>
        /// <param name="logfiles">Log files paths</param>
        public ExceptionLogForm(List<string> logfiles)
        {
            if (logfiles == null) throw new ArgumentNullException(nameof(logfiles));
            if (logfiles.Count == 0) throw new ArgumentException(nameof(logfiles) + " is empty");

            this.InitializeComponent();

            // Stores the logfiles sorted by date
            this._LogFiles = new List<LogFileInfo>(logfiles.Count);
            foreach (string file in logfiles) this._LogFiles.Add(new LogFileInfo(file));
            this._LogFiles.Sort();

            // Shows the first log file
            this.DisplayLogFile();
        }
        #endregion

        // Private methods
        #region Private
        /// <summary>
        /// Click to copy the currently displayed log text
        /// </summary>
        private void CopyButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Copy the displayed text to the clipboard
                Clipboard.SetText(this.LogTextBox.Text);
            }
            catch (Exception ex) { ex.LogAndDisplayMessage(); }
        }

        /// <summary>
        /// Display the currently selected log file
        /// </summary>
        private void DisplayLogFile()
        {
            // Ajust the buttons states
            this.PrevisousLogButton.Enabled = this._DiplayedIndex > 0;
            this.NexLogBUtton.Enabled = this._DiplayedIndex < this._LogFiles.Count - 1;

            // Select the log file info
            LogFileInfo loginfo = this._LogFiles[this._DiplayedIndex];

            // Ajust the labels text
            this.LogCounterLabel.Text = string.Format(Properties.Resources.LogErrorCountLabel, (this._DiplayedIndex + 1), this._LogFiles.Count);
            this.LogDateLabel.Text = loginfo.LogFileCreationDate.ToShortDateString() + " " + loginfo.LogFileCreationDate.ToShortTimeString();

            // Display the log content
            this.LogTextBox.Text = File.ReadAllText(loginfo.LogFilePath, Encoding.UTF8);
        }

        /// <summary>
        /// Show the next lof file content
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NexLogBUtton_Click(object sender, EventArgs e)
        {
            try
            {
                this._DiplayedIndex++;

                this.DisplayLogFile();
            }
            catch (Exception ex) { ex.LogAndDisplayMessage(); }
        }

        /// <summary>
        /// Show the previous log file content
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrevisousLogButton_Click(object sender, EventArgs e)
        {
            try
            {
                this._DiplayedIndex--;
                this.DisplayLogFile();
            }
            catch (Exception ex) { ex.LogAndDisplayMessage(); }
        }
        #endregion

        // LogFileInfo
        #region LogFileInfo
        /// <summary>
        /// Information of an exception log file
        /// </summary>
        private class LogFileInfo : IComparable<LogFileInfo>
        {
            // Properties
            #region Properties
            /// <summary>
            /// The file cretion date
            /// </summary>
            public DateTime LogFileCreationDate { get; private set; }

            /// <summary>
            /// The log filepath
            /// </summary>
            public string LogFilePath { get; private set; }
            #endregion

            // Class constructors
            #region
            /// <summary>
            /// Creates a log file info based on the exception log filepath
            /// </summary>
            /// <param name="filepath"></param>
            public LogFileInfo(string filepath)
            {
                // Validate the parameter
                if (string.IsNullOrWhiteSpace(filepath)) throw new ArgumentException("Invalid file path: " + nameof(filepath));

                // Store the file info
                this.LogFilePath = filepath;
                this.LogFileCreationDate = File.GetCreationTime(filepath);
            }
            #endregion

            // Public methods
            #region Public
            /// <summary>
            /// Compares two log files based on the creation date
            /// </summary>
            /// <param name="other"></param>
            /// <returns></returns>
            public int CompareTo(LogFileInfo other)
            {
                return other.LogFileCreationDate.CompareTo(this.LogFileCreationDate);
            }
            #endregion
        }
        #endregion
    }
}
