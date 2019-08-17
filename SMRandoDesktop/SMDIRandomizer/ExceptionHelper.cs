using System;
using System.IO;
using System.Windows.Forms;

namespace SMDIRandomizer
{
    /// <summary>
    /// Contains extension methods for the <see cref="Exception"/> class
    /// </summary>
    public static class ExceptionHelper
    {
        public static void Log(this Exception ex)
        {
            try
            {
                // If the error was during the randomization process
                if (ex is RandomizationException rex)
                {
                    // Open the log file
                    string logfilename = Core.LogPath + "RND_Error_log_" + DateTime.UtcNow.Ticks.ToString("X16") + ".txt";
                    using (TextWriter tw = new StreamWriter(logfilename))
                    {
                        // Write the parameters at the time of the exception
                        tw.WriteLine(rex.Message);
                        tw.WriteLine(nameof(rex.Seed) + ": " + rex.Seed);
                        tw.WriteLine(nameof(rex.Difficulty) + ": " + rex.Difficulty);
                        tw.WriteLine(nameof(rex.ROMName) + ": " + rex.ROMName);
                        tw.WriteLine(rex.StackTrace);

                        // Write the remaining information of the exeption
                        Exception iex = rex.InnerException;
                        while (iex != null)
                        {
                            tw.WriteLine("- - - - - ");
                            tw.WriteLine(iex.Message);
                            tw.WriteLine(iex.StackTrace);

                            iex = iex.InnerException;
                        }
                    }
                }

                else
                {
                    // Create the log file
                    string logfilename = Core.LogPath + "Error_log_" + DateTime.UtcNow.Ticks.ToString("X16") + ".txt";
                    using (TextWriter tw = new StreamWriter(logfilename))
                    {
                        // Write the information of the exception
                        tw.WriteLine(ex.Message);
                        tw.WriteLine(ex.StackTrace);

                        // Write the information of the innerexceptions if there is any
                        Exception iex = ex.InnerException;
                        while (iex != null)
                        {
                            tw.WriteLine("- - - - - ");
                            tw.WriteLine(iex.Message);
                            tw.WriteLine(iex.StackTrace);

                            iex = iex.InnerException;
                        }
                    }
                }
            } catch {; }
        }

        public static void LogAndDisplayMessage(this Exception ex)
        {
            ex.Log();

            // Show message box
            MessageBox.Show(
                Properties.Resources.GenericErrorMessage,
                Properties.Resources.ErrorCaption,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
