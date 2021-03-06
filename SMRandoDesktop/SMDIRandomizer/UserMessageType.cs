﻿namespace SMDIRandomizer
{
    /// <summary>
    /// Determines the type of message displayed to the user
    /// </summary>
    public enum UserMessageType : byte
    {
        /// <summary>
        /// Sucess message. Color GREEN
        /// </summary>
        Sucess = 0,

        /// <summary>
        /// Information message. Color BLACK
        /// </summary>
        Information = 1,

        /// <summary>
        /// Warning message. Color YELLOW
        /// </summary>
        Warning = 2,

        /// <summary>
        /// Error message. Color RED
        /// </summary>
        Error = 3
    }
}
