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

        private void Button_Preview_Click(object sender, EventArgs e)
        {
            var name = TextBox_Name.Text;
            var gjo = ComboBox_GreatJobOn.SelectedItem.ToString();
            var workOn = ComboBox_WorkOn.SelectedText;
            
            if(name == null || name.Equals(String.Empty) || gjo == null || workOn == null)
            {
                MessageBox.Show("One or more fields is empty.\nPlease ensure all fields are filled", "Warning!");
                return;
            }

            Random r = new Random();
            var outlineNumber = 0; //(int)(r.NextDouble() + _outlineTemplates.Length);
            _outline = new Outline(name, _outlineTemplates[outlineNumber]);
            _outline.Skills.Add(gjo);
            _outline.GenerateOutline();

            TextBox_Preview.Text = _outline.GetFinishedOutline();
        }
    }
}