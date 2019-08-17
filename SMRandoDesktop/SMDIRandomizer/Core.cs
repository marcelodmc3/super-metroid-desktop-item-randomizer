using System;
using System.IO;

namespace SMDIRandomizer
{
    /// <summary>
    /// Class containg information usefull for the application
    /// </summary>
    public static class Core
    {
        #if DEBUG
        /// <summary>
        /// Indicates if the application was compiled with the debug configuration
        /// </summary>
        public static bool Debug = true;

        #else
        /// <summary>
        /// Indicates if the application was compiled with the debug configuration
        /// </summary>
        public static bool Debug = false;
        #endif

        /// <summary>
        /// Folder path that contains the application executable
        /// </summary>
        public static string ApplicationPath = AppDomain.CurrentDomain.BaseDirectory;

        /// <summary>
        /// Folder path that contains the exception log files
        /// </summary>
        public static string LogPath
        {
            get
            {
                // Composes the log folder path
                string logpath = ApplicationPath + "\\ERROR_LOGS\\";

                // Creates the log file path if it does not exists yet
                Directory.CreateDirectory(logpath);

                // Retorn the log folder
                return logpath;
            }
        }
    }
}
