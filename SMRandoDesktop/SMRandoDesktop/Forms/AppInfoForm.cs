using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMRandoDesktop.Forms
{
    public partial class AppInfoForm : Form
    {
        public AppInfoForm()
        {
            InitializeComponent();
        }

        private void LinkLabel_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (sender is LinkLabel link)
                    {
                        this.CopyLinkLocaionToolStripMenuItem.Tag = link.Text;
                        this.CopyLinkMenuStrip.Show(link, link.PointToClient(MousePosition));
                    }
                }
                else
                {
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

        private void CopyLinkLocaionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
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
    }
}
