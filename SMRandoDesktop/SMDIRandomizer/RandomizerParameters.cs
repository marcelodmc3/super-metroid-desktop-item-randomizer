using Base;
using ItemRandomizer;
using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;

namespace SMDIRandomizer
{
    /// <summary>
    /// Stores the parameters for the randomization
    /// </summary>
    public class RandomizerParameters
    {
        // Constants
        #region Const
        /// <summary>
        /// Registry key to save and load settings
        /// </summary>
        private const string REGISTRY_KEY = @"SOFTWARE\Super Metroid Randomizer";
        #endregion

        // Properties
        #region Properties
        /// <summary>
        /// Randomizer difficulty
        /// </summary>
        public Types.Difficulty Difficulty { get; set; }

        /// <summary>
        /// File path of the emulator executable
        /// </summary>
        public string EmulatorExecutablePath { get; set; }

        /// <summary>
        /// Path to the last randomized ROM file
        /// </summary>
        public string LasRandomizedROMFile { get; set; }

        /// <summary>
        /// Number o random seed numbers selected by the user
        /// </summary>
        public int RandomSeedCount { get; set; }

        /// <summary>
        /// Indicates if it's necessary to generate a Spoiler file
        /// </summary>
        public bool SaveSpoilers { get; set; }

        /// <summary>
        /// Seed number picked by the user
        /// </summary>
        public int Seed { get; set; }

        /// <summary>
        /// File path of the ROM source file
        /// </summary>
        public string SourceFilePath { get; set; }

        /// <summary>
        /// Lauch the emulator selected by the user after the randomization process?
        /// </summary>
        public bool StartEmulator { get; set; }

        /// <summary>
        /// Indicates if the seed used was inputed by the user
        /// </summary>
        public bool UserInputSeed { get; set; }
        #endregion

        // Class constructors
        #region Constructors
        /// <summary>
        /// Defaul constructor
        /// </summary>
        public RandomizerParameters()
        {
            this.Difficulty = Types.Difficulty.Normal;
            this.RandomSeedCount = 1;
            this.Seed = 0;
            this.UserInputSeed = true;
            this.SourceFilePath = string.Empty;
            this.EmulatorExecutablePath = string.Empty;
        }

        /// <summary>
        /// Load the parameters
        /// </summary>
        /// <param name="isStandalone">Indicates if the application is running on the standalone mode</param>
        public RandomizerParameters(bool isStandalone)
            : this()
        {
            if (isStandalone)
            {
                if (File.Exists(Core.StandAloneFilePath))
                {
                    // Parse the parameters from the config file
                    string[] parameterstext = File.ReadAllLines(Core.StandAloneFilePath);
                    Dictionary<string, string> parameters = new Dictionary<string, string>();
                    foreach(string parameter in parameterstext)
                    {
                        string[] keyvalue = parameter.Split('=');

                        parameters.Add(keyvalue[0], keyvalue[1]);
                    }

                    int userinputseed = parameters.ContainsKey(nameof(this.UserInputSeed)) ? int.Parse(parameters[nameof(this.UserInputSeed)]) : 1;
                    this.UserInputSeed = userinputseed == 1;

                    int savespoilers = parameters.ContainsKey(nameof(this.SaveSpoilers)) ? int.Parse(parameters[nameof(this.SaveSpoilers)]) : 0;
                    this.SaveSpoilers = savespoilers == 1;

                    int startemulator = parameters.ContainsKey(nameof(this.StartEmulator)) ? int.Parse(parameters[nameof(this.StartEmulator)]) : 0;
                    this.StartEmulator = savespoilers == 1;

                    this.Seed = parameters.ContainsKey(nameof(this.Seed)) ? int.Parse(parameters[nameof(this.Seed)]) : 0;
                    this.RandomSeedCount = parameters.ContainsKey(nameof(this.RandomSeedCount)) ? int.Parse(parameters[nameof(this.RandomSeedCount)]) : 1;
                    this.SourceFilePath = parameters.ContainsKey(nameof(this.SourceFilePath)) ? parameters[nameof(this.SourceFilePath)] : string.Empty;
                    this.Difficulty = (Types.Difficulty)(parameters.ContainsKey(nameof(this.Difficulty)) ? int.Parse(parameters[nameof(this.Difficulty)]) : 1);
                    this.EmulatorExecutablePath = parameters.ContainsKey(nameof(this.EmulatorExecutablePath)) ? parameters[nameof(this.EmulatorExecutablePath)] : string.Empty;
                }
            }
            else
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RandomizerParameters.REGISTRY_KEY))
                {
                    int userinputseed = (int)key.GetValue(nameof(this.UserInputSeed), 1);
                    this.UserInputSeed = userinputseed == 1;

                    int savespoilers = (int)key.GetValue(nameof(this.SaveSpoilers), 0);
                    this.SaveSpoilers = savespoilers == 1;

                    int startemulator = (int)key.GetValue(nameof(this.StartEmulator), 0);
                    this.StartEmulator = startemulator == 1;

                    this.Seed = (int)key.GetValue(nameof(this.Seed), 0);
                    this.RandomSeedCount = (int)key.GetValue(nameof(this.RandomSeedCount), 1);
                    this.SourceFilePath = (string)key.GetValue(nameof(this.SourceFilePath), string.Empty);
                    this.Difficulty = (Types.Difficulty)(int)key.GetValue(nameof(this.Difficulty), 1);
                    this.EmulatorExecutablePath = (string)key.GetValue(nameof(this.EmulatorExecutablePath), string.Empty);
                }
            }
        }
        #endregion

        // Public methods
        #region Public
        /// <summary>
        /// Save the randomization parameters
        /// </summary>
        /// <param name="isStandalone">Indicates if the application is running on the standalone mode</param>
        public void SaveParameters(bool isStandalone)
        {
            if (isStandalone)
            {
                // Save the parameters to the config file
                File.WriteAllText(Core.StandAloneFilePath, 
                    $"" + nameof(this.UserInputSeed) + "=" + (this.UserInputSeed ? 1 : 0) + "\n" +
                    $"" + nameof(this.SaveSpoilers) + "=" + (this.SaveSpoilers ? 1 : 0) + "\n" +
                    $"" + nameof(this.Seed) + "=" + this.Seed + "\n" +
                    $"" + nameof(this.RandomSeedCount) + "=" + this.RandomSeedCount + "\n" +
                    $"" + nameof(this.SourceFilePath) + "=" + this.SourceFilePath + "\n" +
                    $"" + nameof(this.Difficulty) + "=" + (int)this.Difficulty + "\n" +
                    $"" + nameof(this.EmulatorExecutablePath) + "=" + this.EmulatorExecutablePath + "\n" +
                    $"" + nameof(this.StartEmulator) + "=" + (this.StartEmulator ? 1 : 0) +
                    $"");
            }
            else
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RandomizerParameters.REGISTRY_KEY))
                {
                    key.SetValue(nameof(this.UserInputSeed), this.UserInputSeed ? 1 : 0);
                    key.SetValue(nameof(this.SaveSpoilers), this.SaveSpoilers ? 1 : 0);
                    key.SetValue(nameof(this.Seed), this.Seed);
                    key.SetValue(nameof(this.RandomSeedCount), this.RandomSeedCount);
                    key.SetValue(nameof(this.SourceFilePath), this.SourceFilePath);
                    key.SetValue(nameof(this.Difficulty), (int)this.Difficulty);
                    key.SetValue(nameof(this.EmulatorExecutablePath), this.EmulatorExecutablePath);
                    key.SetValue(nameof(this.StartEmulator), this.StartEmulator ? 1 : 0);
                }
            }
        }
        #endregion
    }
}
