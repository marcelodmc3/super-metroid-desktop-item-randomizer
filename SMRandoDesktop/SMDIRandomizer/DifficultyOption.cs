using System;
using ItemRandomizer;

namespace SMDIRandomizer
{
    /// <summary>
    /// Stores the randomizer difficulty level
    /// </summary>
    public class DifficultyOption : IComparable<DifficultyOption>
    {
        // Properties
        #region Properties
        /// <summary>
        /// Randomizer difficulty
        /// </summary>
        public Types.Difficulty Difficulty { get; private set; }

        /// <summary>
        /// The sort order of the difficulty
        /// </summary>
        private int DifficultyOrder { get { return (int)this.Difficulty; } }

        /// <summary>
        /// The name of the difficulty
        /// </summary>
        private string DifficultyDisplayName { get; set; }
        #endregion

        // Constructors
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="difficulty"></param>
        public DifficultyOption(Types.Difficulty difficulty)
        {
            switch (difficulty)
            {
                // Setting the display name for the Casual difficulty
                case Types.Difficulty.Casual:
                    this.DifficultyDisplayName = Properties.Resources.Difficulty_Casual;
                    break;

                // Setting the display name for the Casual difficulty
                case Types.Difficulty.Normal:
                    this.DifficultyDisplayName = Properties.Resources.Difficulty_Normal;
                    break;

                // Setting the display name for the Casual difficulty
                case Types.Difficulty.Hard:
                    this.DifficultyDisplayName = Properties.Resources.Difficulty_Hard;
                    break;

                // Setting the display name for the Casual difficulty
                case Types.Difficulty.Tournament:
                    this.DifficultyDisplayName = Properties.Resources.Difficulty_Tournament;
                    break;

                // Setting the display name for the Casual difficulty
                case Types.Difficulty.Open:
                    this.DifficultyDisplayName = Properties.Resources.Difficulty_Open;
                    break;

                // Setting the display name for the Casual difficulty
                case Types.Difficulty.Full:
                    this.DifficultyDisplayName = Properties.Resources.Difficulty_Full;
                    break;

                // Throw error in case of difficulty not recognized
                default: throw new NotSupportedException(difficulty.ToString());
            }

            // Set the difficulty level
            this.Difficulty = difficulty;
        }
        #endregion

        // Public
        #region Public
        /// <summary>
        /// Compares the order of the difficulties
        /// </summary>
        /// <param name="other">Other difficulties object to compare against</param>
        /// <returns></returns>
        public int CompareTo(DifficultyOption other)
        {
            return this.DifficultyOrder.CompareTo(other.DifficultyOrder);
        }

        /// <summary>
        /// Converts to the string representation
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.DifficultyDisplayName;
        }
        #endregion
    }
}
