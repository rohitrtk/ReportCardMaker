using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ReportCardMaker
{
    public static partial class Util
    {
        /// <summary>
        /// Name of the project
        /// </summary>
        private static readonly string _name;

        /// <summary>
        /// Project Version
        /// </summary>
        private static readonly string _version;

        /// <summary>
        /// Save file location
        /// </summary>
        private static readonly string _savePath;

        /// <summary>
        /// Template locations
        /// </summary>
        private readonly static Dictionary<string, string> _templates;

        public static string Name => _name;
        public static string Version => _version;
        public static string SavePath => _savePath;
        public static Dictionary<string, string> Templates => _templates;

        /// <summary>
        /// Static constructor
        /// </summary>
        static Util()
        {
            _name = "Report Card Maker";
            _version = "v0.1";
            _savePath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));

            _templates = new Dictionary<string, string>
            {
                { "Skills", _savePath + "skills" }
            };
        }

        #region LoadTextTo
        /// <summary>
        /// Loads text to an output string specified in the parameters
        /// </summary>
        /// <param name="file"></param>
        /// <param name="output"></param>
        public static void LoadTextTo(string file, string[] output)
        {
            string[] data;
            try
            {
                data = File.ReadAllLines(file);
            } 
            catch(Exception)
            {
                Console.WriteLine("An Error occured writing data from file to object");
                data = null;
            }

            output = data;
        }

        /// <summary>
        /// Loads text to an output string as a return value
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string[] LoadTextTo(string file)
        {
            try
            {
                return File.ReadAllLines(file);
            }
            catch (Exception)
            {
                Console.WriteLine("An Error occured writing data from file to object");
                return null;
            }
        }
        #endregion
        #region SaveTextTo
        /// <summary>
        /// Saves a string of text to a line in a file specified in the parameters
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
            w.WriteLine(input);

            // Close the stream writer
            w.Close();
        }

        /// <summary>
        /// Saves a string array of text to a file specified in the parameters
        /// </summary>
        /// <param name="file"></param>
        /// <param name="input"></param>
        public static void SaveTextTo(string file, string[] input)
        {
            // If the file doesn't exist, create it at the save path
            if (!File.Exists(file)) File.Create(_savePath);

            // Create a new stream writer to append the text to the file
            var w = new StreamWriter(file, append: true);

            // Foreach line of text in input; write it to the specified file
            foreach(var v in input)
            {
                w.WriteLine(v);
            }

            // Close the stream writer
            w.Close();
        }
        #endregion
    }
}