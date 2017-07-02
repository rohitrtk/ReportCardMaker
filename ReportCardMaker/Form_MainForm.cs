using System;
using System.IO;
using System.Windows.Forms;

namespace ReportCardMaker
{
    public partial class Form_MainForm : Form
    {
        public Form_MainForm()
        {
            InitializeComponent();
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