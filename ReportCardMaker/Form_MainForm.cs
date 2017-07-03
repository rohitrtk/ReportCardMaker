using System;
using System.Windows.Forms;

namespace ReportCardMaker
{
    public partial class Form_MainForm : Form
    {
        #region readonly variables
        private readonly string[] _skills;
        private readonly string[] _outlines;
        #endregion
        #region variables

        #endregion
        public Form_MainForm()
        {
            InitializeComponent();

            _skills = Util.GetTemplate("Skills");
            _outlines = Util.GetTemplate("Outlines");

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

        private void Form_MainForm_Load(object sender, EventArgs e)
        {
            Text = Util.Name + " | " + Util.Version;
        }

        private void TextBox_Name_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}