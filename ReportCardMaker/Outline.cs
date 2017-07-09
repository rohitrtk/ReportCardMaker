using System;
using System.Collections.Generic;

namespace ReportCardMaker
{
    /// <summary>
    /// Contains outlines to create report cards
    /// </summary>
    public partial class Outline
    {
        #region variables
        /// <summary>
        /// The string from the constructor
        /// </summary>
        private readonly string _outlineText;

        /// <summary>
        /// The actual outline that will be displayed to the form
        /// </summary>
        private string _trueOutline;

        /// <summary>
        /// Name being used in the outline
        /// </summary>
        private readonly string _name;

        /// <summary>
        /// Skills being used in the outline
        /// </summary>
        private readonly List<string> _skills;

        /// <summary>
        /// The current number of skills that have been read
        /// </summary>
        private int _skillCounter;
        #endregion

        /// <summary>
        /// Returns the name of the person for whom this outline is written for
        /// </summary>
        public string Name { get => _name; }

        /// <summary>
        /// Creates a new outline with a string as the actual outline
        /// </summary>
        /// <param name="outlineText"></param>
        public Outline(string name, string outlineText)
        {
            _name = name;
            _outlineText = outlineText;
            _trueOutline = String.Empty;

            _skills = new List<string>();
            _skillCounter = 0;
        }

        /// <summary>
        /// Generates a string based on an outline
        /// </summary>
        public void GenerateOutline()
        {
            // Array of strings split by whitespace
            string[] words = _outlineText.Split(null);

            /* 
             * Iterates through the array of strings and compares them to tokens (defined in the Tokens struct)
             * If the string contains a token, it calls the SplitWord function to determine what the token
             * needs to be replaced with
             */
            for (int i = 0; i < words.Length; i++)
            {
                // Compares name
                if (words[i].Contains(Tokens.NAME)) words[i] = SplitWord(words[i], _name, Tokens.NAME.Length);
                // Compares skill
                else if (words[i].Contains(Tokens.SKILL))
                {
                    words[i] = SplitWord(words[i], _skills[_skillCounter], Tokens.SKILL.Length);
                    ++_skillCounter;
                }
                // Compares custom
                else if (words[i].Contains(Tokens.CUSTOM)) words[i] = SplitWord(words[i], Tokens.REPLACE, Tokens.CUSTOM.Length);
            }

            // Foreach variable in the array of words, append it to the true outline
            foreach (var v in words) _trueOutline += (v + " ");
        }

        /// <summary>
        /// Splits the word into a token and a character,
        /// replaces the token with the desired string and then returns
        /// the new word with the character i.e {name}!? -> Rohit!?
        /// </summary>
        /// <param name="word"></param>
        /// <param name="replace"></param>
        /// <param name="tokenLength"></param>
        /// <returns></returns>
        private string SplitWord(string word, string replace, int tokenLength)
        {
            var w = word.ToCharArray();

            var w2 = String.Empty;
            for (int i = word.Length; i > tokenLength; i--) w2 += w[i - 1];

            return replace + w2;
        }

        /// <summary>
        /// Returns the true outline (The outline that will be read by the student and potential parent(s))
        /// </summary>
        /// <returns></returns>
        public string GetFinishedOutline()
        {
            return _trueOutline;
        }

        /// <summary>
        /// Called to add a skill to the list of skills
        /// </summary>
        /// <param name="skill"></param>
        public void AddSkill(string skill)
        {
            _skills.Add(skill);
        }
    }

    /// <summary>
    /// Storage struct containing various tokens that can be compared
    /// </summary>
    internal struct Tokens
    {
        public const string NAME = "{name}";
        public const string SKILL = "{skill}";
        public const string CUSTOM = "{custom}";
        public const string WORK = "{work}";
        public const string REPLACE = "{Replace Me!}";
    }
}