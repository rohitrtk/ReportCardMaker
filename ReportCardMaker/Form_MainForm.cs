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
        /// <summary>
        /// Array of skills that can be worked on
        /// </summary>
        private readonly string[] _skills;

        /// <summary>
        /// Array of available templates
        /// </summary>
        private readonly string[] _outlineTemplates;
        #endregion
        #region variables
        /// <summary>
        /// Definition of an outline class (Will be written to multiple times)
        /// </summary>
        private Outline _outline;
        #endregion

        /// <summary>
        /// Constructor for main form
        /// </summary>
        public Form_MainForm()
        {
            InitializeComponent();

            // Fill arrays with a value from a util dictionary
            _skills = Util.GetValue("Skills");
            _outlineTemplates = Util.GetValue("Outlines");

            InitializeFields();
        }

        /// <summary>
        /// Initializes various components on the main form so they can be used by the user
        /// </summary>
        private void InitializeFields()
        {
            // Adds skills to comboboxes
            foreach (string s in _skills)
            {
                ComboBox_GreatJobOn.Items.Add(s);
                ComboBox_WorkOn.Items.Add(s);
            }
            ComboBox_GreatJobOn.SelectedIndex = 0;
            ComboBox_WorkOn.SelectedIndex = 0;
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

        /// <summary>
        /// Called when the preview button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Preview_Click(object sender, EventArgs e)
        {
            // Checks if all the fields are filled (If they're not, returns)
            if(TextBox_Name.Text == null || TextBox_Name.Text.Equals(String.Empty) || 
                ComboBox_GreatJobOn.SelectedItem == null || ComboBox_WorkOn.SelectedItem == null ||
                ComboBox_GreatJobOn.SelectedIndex == 0 || ComboBox_WorkOn.SelectedIndex == 0)
            {
                MessageBox.Show("One or more fields is empty.\nPlease ensure all fields are filled", "Warning!");
                return;
            }

            // Storage variables (Just so I don't need to write long names)
            var name = TextBox_Name.Text;
            var gjo = ComboBox_GreatJobOn.SelectedItem.ToString().ToLower();
            var workOn = ComboBox_WorkOn.SelectedItem.ToString().ToLower();

            // Chooses an outline to use
            Random r = new Random();
            var outlineNumber = (int)(r.NextDouble() * _outlineTemplates.Length);

            // Creatation and generation of an outline
            _outline = new Outline(name, _outlineTemplates[outlineNumber]);
            _outline.AddSkill(gjo);
            _outline.AddSkill(workOn);
            _outline.GenerateOutline();

            // Update the preview box to contain the true outline from the outline class
            TextBox_Preview.Text = _outline.GetFinishedOutline();
        }
    }
}