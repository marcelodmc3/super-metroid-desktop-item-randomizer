using System;
using System.Windows.Forms;

namespace SMDIRandomizer.Forms
{
    /// <summary>
    /// Displays the "about" form
    /// </summary>
    public partial class AppInfoForm : Form
    {
        // Class constructors
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public AppInfoForm()
        {
            this.InitializeComponent();
        }
        #endregion

        // Private Methods
        #region Private
        /// <summary>
        /// Click on the context menu strip
        /// </summary>
        private void CopyLinkLocaionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Copy the link location to the clipboard
                if (sender is ToolStripMenuItem link)
                {
                    if (link.Tag is string linktext)
                    {
                        Clipboard.SetText(linktext);
                    }
                }
            }

            catch (Exception ex)
            {
                ex.Log();
            }
        }

        /// <summary>
        /// Click on any link label
        /// </summary>
        private void LinkLabel_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Righ mouse click?
                if (e.Button == MouseButtons.Right)
                {
                    if (sender is LinkLabel link)
                    {
                        // Displays the "copy" menu option
                        this.CopyLinkLocaionToolStripMenuItem.Tag = link.Text;
                        this.CopyLinkMenuStrip.Show(link, link.PointToClient(MousePosition));
                    }
                }
                else // Left mouse click?
                {
                    // Try to open link destination
                    LinkLabel link = sender as LinkLabel;
                    link.LinkVisited = true;
                    System.Diagnostics.Process.Start(link.Text);
                }
            }
            catch (Exception ex)
            {
                ex.Log();
            }
        }
        #endregion
    }
}
