using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ReportCardMaker
{
    /// <summary>
    /// Static utility class containing methods to load and save data
    /// </summary>
    public static partial class Util
    {
        #region variables
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
        /// Name of the file which contains skills 
        /// </summary>
        private const string _skillsPath = "\\skills.txt";

        /// <summary>
        /// Name of the file which contains outlines
        /// </summary>
        private const string _outlinesPath = "\\outlines.txt";

        /// <summary>
        /// Template locations
        /// </summary>
        private readonly static Dictionary<string, string[]> _templates;

        /// <summary>
        /// Returns this applications name
        /// </summary>
        public static string Name => _name;

        /// <summary>
        /// Returns this applications version
        /// </summary>
        public static string Version => _version;

        /// <summary>
        /// Returns the save path of this application
        /// </summary>
        public static string SavePath => _savePath;
        #endregion

        /// <summary>
        /// Static constructor
        /// </summary>
        static Util()
        {
            _name = "Report Card Maker";
            _version = "v0.2";
            _savePath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));

            string[] skills = LoadTextTo(_savePath + _skillsPath);
            string[] outlines = LoadTextTo(_savePath + _outlinesPath);

            _templates = new Dictionary<string, string[]>
            {
                { "Skills", skills },
                { "Outlines", outlines }
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
            if (!File.Exists(file)) throw new FileNotFoundException();

            string[] data = File.ReadAllLines(file);

            output = data;
        }

        /// <summary>
        /// Loads text to an output string as a return value
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string[] LoadTextTo(string file)
        {   
            if (!File.Exists(file)) throw new FileNotFoundException();

            return File.ReadAllLines(file);
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

        /// <summary>
        /// Returns the desired template based on a string key
        /// Returns null if no such key exists
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string[] GetValue(string key)
        {
            try
            {
                return _templates[key];
            }
            catch(Exception e)
            {
                Error(e.Data.ToString(), "trying to use key: " + key);
                return null;
            }
        }

        /// <summary>
        /// Prints out a string to the console; used to debug
        /// </summary>
        /// <param name="e"></param>
        private static void Error(string e)
        {
            Console.WriteLine("Exception {0} was thrown!", e);
        }

        /// <summary>
        /// Prints out a string to the console with a custom message; used to debug
        /// </summary>
        /// <param name="e"></param>
        /// <param name="whl"></param>
        private static void Error(string e, string whl)
        {
            Console.WriteLine("Exception {0} was thrown while {1}!", e, whl);
        }
    }
}