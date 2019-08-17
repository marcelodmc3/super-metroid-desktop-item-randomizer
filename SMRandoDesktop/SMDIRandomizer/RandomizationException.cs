using System;

namespace SMDIRandomizer
{
    /// <summary>
    /// Exception class for ROM randomization errors
    /// </summary>
    public class RandomizationException : Exception
    {
        // Exception properties
        #region Properties
        /// <summary>
        /// Difficulty level at the moment of the exception
        /// </summary>
        public int Difficulty { get; private set; }

        /// <summary>
        /// Gets the System.Exception instance that caused the current exception.
        /// </summary>
        public new Exception InnerException { get; private set; }

        /// <summary>
        /// Exception message
        /// </summary>
        public new string Message { get; private set; }

        /// <summary>
        /// Name of the ROM use at the time of the exception
        /// </summary>
        public string ROMName { get; private set; }

        /// <summary>
        /// Seed value at the moment of the exception
        /// </summary>
        public int Seed { get; private set; }
        #endregion

        // Constructors of the class
        #region Constructors
        /// <summary>
        /// Creates the exception detais
        /// </summary>
        /// <param name="seed">Seed value at the moment of the exception</param>
        /// <param name="difficulty">Difficulty level at the moment of the exception</param>
        /// <param name="message">Exception message</param>
        /// <param name="inerexcepion">Seed value at the moment of the exception</param>
        public RandomizationException(int seed, int difficulty, string romname, string message = null, Exception inerexcepion = null)
        {
            this.Seed = seed;
            this.Difficulty = difficulty;
            this.ROMName = romname;
            this.Message = message;
            this.InnerException = inerexcepion;
        }
        #endregion
    }
}
