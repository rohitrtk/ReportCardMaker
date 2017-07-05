using System;
using System.Windows.Forms;

namespace ReportCardMaker
{
    /// <summary>
    /// Main form class
    /// </summary>
    public partial class Form_MainForm : Form
    {
        #region readonly variables
        private readonly string[] _skills;
        private readonly string[] _outlineTemplates;
        #endregion
        #region variables
        private Outline _outline;
        #endregion

        /// <summary>
        /// Constructor for main form
        /// </summary>
        public Form_MainForm()
        {
            InitializeComponent();

            _skills = Util.GetTemplate("Skills");
            _outlineTemplates = Util.GetTemplate("Outlines");

            _outline = new Outline("Rohit", _outlineTemplates[0]);
            _outline.GenerateOutline();

            InitializeFields();
        }

        /// <summary>
        /// Initializes various components on the main form so they can be used by the user
        /// </summary>
        private void InitializeFields()
        {
            foreach (string s in _skills)
            {
                ComboBox_GreatJobOn.Items.Add(s);
            }
        }

        /// <summary>
        /// Called when the main form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_MainForm_Load(object sender, EventArgs e)
        {
            Text = Util.Name + " | " + Util.Version;
        }

        private void TextBox_Name_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}