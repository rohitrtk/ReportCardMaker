using System;
using System.IO;

namespace ReportCardMaker
{
    public static partial class Util
    {
        /// <summary>
        /// Name of the project
        /// </summary>
        private const string _name = "Report Card Maker";

        /// <summary>
        /// Project Version
        /// </summary>
        private const string _version = "v0.1";

        /// <summary>
        /// Save file location
        /// </summary>
        /// TODO: Set up the save path in a settings file which can be altered for each user
        private static string _savePath;

        public static string Name => _name;
        public static string Version => _version;

#region LoadTextTo
        /// <summary>
        /// Loads text to an output string specified in the parameters
        /// </summary>
        /// <param name="file"></param>
        /// <param name="output"></param>
        public static void LoadTextTo(string file, string output)
        {
            var data = File.ReadAllText(file);
            output = data;
        }

        /// <summary>
        /// Loads text to an output string as a return value
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string LoadTextTo(string file)
        {
            return File.ReadAllText(file);
        }
#endregion
        /// <summary>
        /// Saves a string of text to a file specified in the parameters
        /// </summary>
        /// <param name="file"></param>
        /// <param name="input"></param>
        public static void SaveTextTo(string file, string input)
        {
            // If the file doesn't exist, create it at the save path
            if (!File.Exists(file)) File.Create(_savePath);

            // Create a new stream writer to append the text to the file
            var w = new StreamWriter(file, append: true);

            // Add the text in to the file
            w.WriteLine(input + "\n");

            // Close the stream writer
            w.Close();
        }
    }
}