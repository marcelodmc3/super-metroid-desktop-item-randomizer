using ItemRandomizer;
using Microsoft.Win32;

namespace SMRandoDesktop
{
    /// <summary>
    /// Stores the parameters for the randomization
    /// </summary>
    public class RandomizerParameters
    {
        // Properties
        #region Properties
        /// <summary>
        /// Randomizer difficulty
        /// </summary>
        public Types.Difficulty Difficulty { get; set; }

        /// <summary>
        /// Number o random seed numbers selected by the user
        /// </summary>
        public int RandomSeedCount { get; set; }

        /// <summary>
        /// Seed number picked by the user
        /// </summary>
        public int Seed { get; set; }

        /// <summary>
        /// Indicates if it's necessary to generate a Spoiler file
        /// </summary>
        public bool SaveSpoilers { get; set; }

        /// <summary>
        /// File path of the ROM source file
        /// </summary>
        public string SourceFilePath { get; set; }

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
        }

        /// <summary>
        /// Load the information from the Registry
        /// </summary>
        /// <param name="registerkey">Key to acess the registry</param>
        public RandomizerParameters(string registerkey)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registerkey))
            {
                int userinputseed = (int)key.GetValue(nameof(this.UserInputSeed), 1);
                this.UserInputSeed = userinputseed == 1;

                int savespoilers = (int)key.GetValue(nameof(this.SaveSpoilers), 0);
                this.SaveSpoilers = savespoilers == 1;

                this.Seed = (int)key.GetValue(nameof(this.Seed), 0);
                this.RandomSeedCount = (int)key.GetValue(nameof(this.RandomSeedCount), 1);
                this.SourceFilePath = (string)key.GetValue(nameof(this.SourceFilePath), string.Empty);
                this.Difficulty = (Types.Difficulty)(int)key.GetValue(nameof(this.Difficulty), 1);
            }
        }
        #endregion

        // Public methods
        #region Public
        /// <summary>
        /// Save the randomization parameters to the registry
        /// </summary>
        /// <param name="registerkey">Key to acess the registry</param>
        public void SaveParameters(string registerkey)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registerkey))
            {
                key.SetValue(nameof(this.UserInputSeed), this.UserInputSeed ? 1 : 0);
                key.SetValue(nameof(this.SaveSpoilers), this.SaveSpoilers ? 1 : 0);
                key.SetValue(nameof(this.Seed), this.Seed);
                key.SetValue(nameof(this.RandomSeedCount), this.RandomSeedCount);
                key.SetValue(nameof(this.SourceFilePath), this.SourceFilePath);
                key.SetValue(nameof(this.Difficulty), (int)this.Difficulty);
            }
        }
        #endregion
    }
}
