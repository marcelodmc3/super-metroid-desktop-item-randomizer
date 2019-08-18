using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SMDIRandomizer
{
    /// <summary>
    /// Manages the writing of the spoiler file
    /// </summary>
    public static class SpoilersWriter
    {
        // Class variables
        #region Variables
        /// <summary>
        /// Aux Items
        /// </summary>
        private static string[] _AuxItems = new string[]
        {
                "X-Ray Scope",
                "Grappling Beam"
        };

        /// <summary>
        /// Beam Items
        /// </summary>
        private static string[] _BeamItems = new string[]
        {
                "Charge Beam",
                "Wave Beam",
                "Plasma Beam",
                "Ice Beam",
                "Spazer"
        };

        /// <summary>
        /// Boot Items
        /// </summary>
        private static string[] _BootItems = new string[]
        {
                "Hi-Jump Boots",
                "Space Jump",
                "Speed Booster"
        };

        /// <summary>
        /// Bluble Moutaind and right norfair Item locations
        /// </summary>
        private static string[] _BubbleMoutainAndUpperRightNorfair = new string[]
        {
                "Missile (bubble Norfair green door)",
                "Missile (bubble Norfair)",
                "Missile (Speed Booster)",
                "Speed Booster",
                "Missile (Wave Beam)",
                "Wave Beam",
                "Reserve Tank, Norfair"
        };

        /// <summary>
        /// Crocomire Item locations
        /// </summary>
        private static string[] _Crocomire = new string[]
        {
                "Power Bomb (Crocomire)",
                "Missile (below Crocomire)",
                "Missile (Grapple Beam)",
                "Grapple Beam",
                "Energy Tank, Crocomire",
                "Missile (above Crocomire)"
        };

        /// <summary>
        /// Energy Tank Items
        /// </summary>
        private static string _EnergyTankItems = "Energy Tank";

        /// <summary>
        /// Kraid and Upper Norfair Item locations
        /// </summary>
        private static string[] _KraidAndUpperLeftNorfair = new string[]
        {
                "Energy Tank, Kraid",
                "Missile (Kraid)",
                "Varia Suit",
                "Missile (lava room)",
                "Ice Beam -> Spring Ball",
                "Missile (below Ice Beam)",
                "Missile (Norfair Reserve Tank)",
                "Hi-Jump Boots -> Energy Tank",
                "Missile (Hi-Jump Boots)",
                "Energy Tank (Hi-Jump Boots)"
        };

        /// <summary>
        /// Green And Pink Brinstar Item locations
        /// </summary>
        private static string[] _GreenAndPinkBrinstar = new string[]
        {
                "Power Bomb (green Brinstar bottom)",
                "Super Missile (pink Brinstar)",
                "Missile (green Brinstar below super missile)",
                "Super Missile (green Brinstar top)",
                "Reserve Tank, Brinstar",
                "Missile (green Brinstar behind missile)",
                "Missile (green Brinstar behind reserve tank)",
                "Missile (pink Brinstar top)",
                "Missile (pink Brinstar bottom)",
                "Charge Beam",
                "Power Bomb (pink Brinstar)",
                "Missile (green Brinstar pipe)",
                "Energy Tank, Brinstar Ceiling",
                "Energy Tank, Etecoons",
                "Super Missile (green Brinstar bottom)",
                "Energy Tank, Waterway",
                "Energy Tank, Brinstar Gate"
        };

        /// <summary>
        /// Landing site, crateria and blue brinstar Item Locations
        /// </summary>
        private static string[] _LandingSiteCrateriaBlueBrinstar = new string[]
        {
            "Power Bomb (Crateria surface)",
            "Missile (Crateria bottom)",
            "Bomb ",
            "Energy Tank, Terminator",
            "Missile (Crateria gauntlet right)",
            "Missile (Crateria gauntlet left)",
            "Super Missile (Crateria)",
            "Missile (Crateria middle)",
            "Missile (blue Brinstar top)",
            "Missile (blue Brinstar behind missile)",
            "Morphing Ball",
            "Power Bomb (blue Brinstar)",
            "Missile (blue Brinstar middle)",
            "Missile (blue Brinstar bottom)"
        };

        /// <summary>
        /// Lower Norfair Item locations
        /// </summary>
        private static string[] _LowerNorfair = new string[]
        {
                "Missile (Gold Torizo)",
                "Super Missile (Gold Torizo)",
                "Missile (Mickey Mouse room)",
                "Missile (lower Norfair above fire flea room)",
                "Power Bomb (lower Norfair above fire flea room)",
                "Power Bomb (Power Bombs of shame)",
                "Missile (lower Norfair near Wave Beam)",
                "Energy Tank, Ridley",
                "Screw Attack",
                "Energy Tank, Firefleas"
        };

        /// <summary>
        /// Maridia Item Locations
        /// </summary>
        private static string[] _Maridia = new string[]
        {
                "Missile (green Maridia shinespark)",
                "Super Missile (green Maridia)",
                "Energy Tank, Mama turtle",
                "Missile (green Maridia tatori)",
                "Super Missile (yellow Maridia)",
                "Missile (yellow Maridia super missile)",
                "Missile (yellow Maridia false wall)",
                "Plasma Beam",
                "Missile (left Maridia sand pit room)",
                "Reserve Tank, Maridia",
                "Missile (right Maridia sand pit room)",
                "Power Bomb (right Maridia sand pit room)",
                "Missile (pink Maridia)",
                "Super Missile (pink Maridia)",
                "Spring Ball",
                "Missile (Draygon)",
                "Energy Tank, Botwoon",
                "Space Jump"
        };

        /// <summary>
        /// Misc Items
        /// </summary>
        private static string[] _MiscItems = new string[]
        {
                "Morph Ball",
                "Bomb",
                "Spring Ball",
                "Screw Attack"
        };

        /// <summary>
        /// Missiles Items
        /// </summary>
        private static string _MissileItems = "Missile";

        /// <summary>
        /// Moat and WreckShip Item Locations
        /// </summary>
        private static string[] _MoatWestOceanAndWreckedShip = new string[]
        {
                "Missile (Crateria moat)",
                "Missile (outside Wrecked Ship bottom)",
                "Missile (outside Wrecked Ship top)",
                "Missile (outside Wrecked Ship middle)",
                "Missile (Wrecked Ship middle)",
                "Reserve Tank, Wrecked Ship",
                "Missile (Gravity Suit)",
                "Missile (Wrecked Ship top)",
                "Energy Tank, Wrecked Ship",
                "Super Missile (Wrecked Ship left)",
                "Right Super, Wrecked Ship",
                "Gravity Suit"
        };

        /// <summary>
        /// Power Bom Items
        /// </summary>
        private static string _PowerBombItems = "Power Bomb";

        /// <summary>
        /// Red Brinstar Item Locations
        /// </summary>
        private static string[] _RedBrinstar = new string[]
        {
                "X-Ray Scope",
                "Power Bomb (red Brinstar sidehopper room)",
                "Power Bomb (red Brinstar spike room)",
                "Missile (red Brinstar spike room)",
                "Spazer -> Reserve Tank"
        };

        /// <summary>
        /// Reserve tank Items
        /// </summary>
        private static string _ReserveTankItems = "Reserve Tank";

        /// <summary>
        /// Suit items
        /// </summary>
        private static string[] _SuitItems = new string[]
            {
                "Varia Suit",
                "Gravity Suit",
            };

        /// <summary>
        /// Super Missiles Items
        /// </summary>
        private static string _SuperMissileItems = "Super Missile";
        #endregion

        // Public Methods
        #region Public
        /// <summary>
        /// Write the spoilers file, containg the randomized items location
        /// </summary>
        /// <param name="sourcefile">Oringal spoiler files</param>
        /// <param name="destinationfile">Path to save the organized spoiler file</param>
        public static void WriteSpoilers(string sourcefile, string destinationfile)
        {
            // Check parameters
            if (!File.Exists(sourcefile)) throw new ArgumentException($"{sourcefile} does not exists.");

            // Read the original spoilers file content
            string[] spoilers = File.ReadAllLines(sourcefile);
            List<string[]> spoilersInfo = new List<string[]>();
            foreach (string spoilLine in spoilers)
            {
                spoilersInfo.Add(spoilLine.Replace(" -> ", ";").Split(';'));
            }

            // Create strem to save the spoiler file
            using (TextWriter spoilerWriter = new StreamWriter(destinationfile))
            {
                // Write by item type
                SpoilersWriter.WriteSpoilersByItemType(spoilerWriter, spoilersInfo);
                spoilerWriter.WriteLine();

                // Write by item location
                SpoilersWriter.WriteSpoilersByItemLocation(spoilerWriter, spoilersInfo);
            }
        }
        #endregion

        // Private Methods
        #region Private
        /// <summary>
        /// Text writer
        /// </summary>
        /// <param name="textwriter">Text writer</param>
        /// <param name="items">List of items</param>
        /// <param name="writingbylocation">Write randomized item location first or original item location first</param>
        private static void WriteItemLocation(TextWriter textwriter, IEnumerable<string[]> items, bool writingbylocation = false)
        {
            // Jump one line
            textwriter.WriteLine();

            // Write items locations
            foreach (string[] itemLocation in items)
                textwriter.WriteLine("\t\t" + itemLocation[writingbylocation ? 0 : 1] + " -> " + itemLocation[writingbylocation ? 1 : 0]);

            // Writem itens by location?
            if (writingbylocation)
                textwriter.WriteLine();
        }

        /// <summary>
        /// Write the spoilers information grouped by items location
        /// </summary>
        /// <param name="textwriter">Text writer</param>
        /// <param name="spoilersInfo">Original spoiler info</param>
        private static void WriteSpoilersByItemLocation(TextWriter textwriter, List<string[]> spoilersInfo)
        {
            // Header
            textwriter.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            textwriter.WriteLine("Items by location: ");
            textwriter.WriteLine();

            // Landing Site, Crateria and Blue Brinstar items
            textwriter.WriteLine("\tLanding Site, Crateria and Blue Brinstar [Original Item Location -> Randomized Item]:");
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => SpoilersWriter._LandingSiteCrateriaBlueBrinstar.Contains(m[0])), true);

            // Green and Pink Brinstar items
            textwriter.WriteLine("\tGreen and Pink Brinstar [Original Item Location -> Randomized Item]:");
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => SpoilersWriter._GreenAndPinkBrinstar.Contains(m[0])), true);

            // Red Brinstar items
            textwriter.WriteLine("\tRed Brinstar [Original Item Location -> Randomized Item]:");
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => SpoilersWriter._RedBrinstar.Contains(m[0])), true);

            // Moat, West Ocean and Wrecked Ship items
            textwriter.WriteLine("\tMoat, West Ocean and Wrecked Ship [Original Item Location -> Randomized Item]:");
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => SpoilersWriter._MoatWestOceanAndWreckedShip.Contains(m[0])), true);

            // Kraid and Upper-Left Norfair items
            textwriter.WriteLine("\tKraid and Upper-Left Norfair [Original Item Location -> Randomized Item]:");
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => SpoilersWriter._KraidAndUpperLeftNorfair.Contains(m[0])), true);

            // Bubble Moutain and Upper-Right Norfair items
            textwriter.WriteLine("\tBubble Moutain and Upper-Right Norfair [Original Item Location -> Randomized Item]:");
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => SpoilersWriter._BubbleMoutainAndUpperRightNorfair.Contains(m[0])), true);

            // Crocomire items
            textwriter.WriteLine("\tCrocomire [Original Item Location -> Randomized Item]:");
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => SpoilersWriter._Crocomire.Contains(m[0])), true);

            // Lower Norfair items
            textwriter.WriteLine("\tLower Norfair [Original Item Location -> Randomized Item]:");
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => SpoilersWriter._LowerNorfair.Contains(m[0])), true);

            // Maridia items
            textwriter.WriteLine("\tMaridia [Original Item Location -> Randomized Item]:");
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => SpoilersWriter._Maridia.Contains(m[0])), true);
        }

        /// <summary>
        /// Write the spoilers information grouped by item type
        /// </summary>
        /// <param name="textwriter">Text writer</param>
        /// <param name="spoilersInfo">Original spoiler info</param>
        private static void WriteSpoilersByItemType(TextWriter textwriter, List<string[]> spoilersInfo)
        {
            // Major items header
            textwriter.WriteLine("Items by type: ");
            textwriter.WriteLine();
            textwriter.WriteLine("\tMajor items [Randomized Item -> Original Item Location]:");

            // Suits
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => SpoilersWriter._SuitItems.Contains(m[1])));

            // Boots
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => SpoilersWriter._BootItems.Contains(m[1])));

            // Beams
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => SpoilersWriter._BeamItems.Contains(m[1])));

            // Misc
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => SpoilersWriter._MiscItems.Contains(m[1])));

            // Aux
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => SpoilersWriter._AuxItems.Contains(m[1])));

            // Energy Tanks
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => m[1].Equals(SpoilersWriter._EnergyTankItems)));

            // Reserve Tanks
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => m[1].Equals(SpoilersWriter._ReserveTankItems)));
            
            // Minor items header
            textwriter.WriteLine();
            textwriter.WriteLine("\tMinor items [Randomized Item -> Original Item Location]:");

            // Power bomb items
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => m[1].Equals(SpoilersWriter._PowerBombItems)));

            // Super Missile items
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => m[1].Equals(SpoilersWriter._SuperMissileItems)));

            // Item Missile items
            SpoilersWriter.WriteItemLocation(textwriter, spoilersInfo.Where(m => m[1].Equals(SpoilersWriter._MissileItems)));
        }
        #endregion
    }
}
