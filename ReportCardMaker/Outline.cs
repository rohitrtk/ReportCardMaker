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
        /// Customs being used in the outline
        /// </summary>
        private readonly List<string> _customs;

        /// <summary>
        /// Skills that need to be worked on in the outline
        /// </summary>
        private readonly List<string> _workOn;
        #endregion

        public string Name => _name;
        public List<string> Skills => _skills;
        public List<string> Customs => _customs;
        public List<string> WorkOn => _workOn;

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
            _customs = new List<string>();
            _workOn = new List<string>();
        }

        /// <summary>
        /// Generates a string based on an outline
        /// </summary>
        public void GenerateOutline()
        {
            string[] words = _outlineText.Split(null);
            
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(Tokens.NAME)) words[i] = SplitWord(words[i], Name, Tokens.NAME.Length);
                else if (words[i].Contains(Tokens.SKILL)) words[i] = SplitWord(words[i], Skills[0], Tokens.SKILL.Length);
                else if (words[i].Contains(Tokens.WORK)) words[i] = SplitWord(words[i], WorkOn[0], Tokens.WORK.Length);
                else if (words[i].Contains(Tokens.CUSTOM)) words[i] = SplitWord(words[i], Customs[0], Tokens.CUSTOM.Length);

                /*
                if (words[i].Equals(Tokens.NAME) || words[i].Contains(Tokens.NAME)) words[i] = Name;
                else if (words[i].Equals(Tokens.SKILL)) words[i] = Skills[0];
                else if (words[i].Equals(Tokens.WORK)) words[i] = WorkOn[0];
                */
            }

            //foreach (var v in words)
            //{
            //    _trueOutline += v;
            //}
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

            var w1 = replace;
            //var w1 = String.Empty;
            //for (int i = 0; i < w.Length; i++)
            //{
            //    if (i >= tokenLength) break;
            //    w1 += w[i];
            //}

            var w2 = String.Empty;
            for (int i = word.Length; i > tokenLength; i--)
            {
                w2 += w[i - 1];
            }

            return w1 + w2;
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
    }
}