using System;
using System.IO;

namespace Base
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

        /// <summary>
        /// Indicates if the application was compiled using the stand alone settings
        /// </summary>
        public static bool StandAlone = false;
#else
        /// <summary>
        /// Indicates if the application was compiled with the debug configuration
        /// </summary>
        public static bool Debug = false;

#if STAND_ALONE
        /// <summary>
        /// Indicates if the application was compiled using the stand alone settings
        /// </summary>
        public static bool StandAlone = true;

#else
        /// <summary>
        /// Indicates if the application was compiled using the stand alone settings
        /// </summary>
        public static bool StandAlone = false;
#endif

#endif
        /// <summary>
        /// Path to the stando alone configuration file
        /// </summary>
        public static string StandAloneFilePath
        {
            get
            {
                // Returns the path based on the applicatoin folder
                return Core.ApplicationPath + "\\" + System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".param";
            }
        }

        /// <summary>
        /// Folder path that contains the application executable
        /// </summary>
        public static readonly string ApplicationPath = AppDomain.CurrentDomain.BaseDirectory;

        /// <summary>
        /// The directory that serves as a common repository for application-specific data for the current roaming user.
        /// </summary>
        public static readonly string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        /// <summary>
        /// The directory that serves as a common repository for application-specific data that is used by all users.
        /// </summary>
        public static readonly string CommonAppData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

        /// <summary>
        /// Folder path that contains the exception log files
        /// </summary>
        public static string LogPath
        {
            get
            {
                // Composes the log folder path
                string logpath = (Core.Debug || Core.StandAlone ? Core.ApplicationPath : Core.CommonAppData + "\\" + System.Diagnostics.Process.GetCurrentProcess().ProcessName) + "\\ERROR_LOGS\\";

                // Creates the log file path if it does not exists yet
                Directory.CreateDirectory(logpath);

                // Retorn the log folder
                return logpath;
            }
        }

        /// <summary>
        /// Folder path to the patches files
        /// </summary>
        public static string PatchesPath
        {
            get
            {
                // Composes the patches path
                string patchespath = Core.ApplicationPath + "\\patches\\";

                // Retorn the log folder
                return patchespath;
            }
        }
    }
}
