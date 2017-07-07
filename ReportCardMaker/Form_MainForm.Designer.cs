namespace ReportCardMaker
{
    partial class Form_MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MS_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MS_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox_Preview = new System.Windows.Forms.TextBox();
            this.Label_PreviewLabel = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_GreatJobOn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.ComboBox_GreatJobOn = new System.Windows.Forms.ComboBox();
            this.ComboBox_WorkOn = new System.Windows.Forms.ComboBox();
            this.Button_Preview = new System.Windows.Forms.Button();
            this.Button_Output = new System.Windows.Forms.Button();
            this.MS_MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS_MenuStrip
            // 
            this.MS_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_File,
            this.MS_Options});
            this.MS_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MS_MenuStrip.Name = "MS_MenuStrip";
            this.MS_MenuStrip.Size = new System.Drawing.Size(499, 24);
            this.MS_MenuStrip.TabIndex = 0;
            this.MS_MenuStrip.Text = "MenuStrip";
            // 
            // MS_File
            // 
            this.MS_File.Name = "MS_File";
            this.MS_File.Size = new System.Drawing.Size(37, 20);
            this.MS_File.Text = "File";
            // 
            // MS_Options
            // 
            this.MS_Options.Name = "MS_Options";
            this.MS_Options.Size = new System.Drawing.Size(61, 20);
            this.MS_Options.Text = "Options";
            // 
            // TextBox_Preview
            // 
            this.TextBox_Preview.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Preview.Location = new System.Drawing.Point(222, 76);
            this.TextBox_Preview.Multiline = true;
            this.TextBox_Preview.Name = "TextBox_Preview";
            this.TextBox_Preview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Preview.Size = new System.Drawing.Size(268, 354);
            this.TextBox_Preview.TabIndex = 1;
            // 
            // Label_PreviewLabel
            // 
            this.Label_PreviewLabel.AutoSize = true;
            this.Label_PreviewLabel.Location = new System.Drawing.Point(219, 60);
            this.Label_PreviewLabel.Name = "Label_PreviewLabel";
            this.Label_PreviewLabel.Size = new System.Drawing.Size(45, 13);
            this.Label_PreviewLabel.TabIndex = 2;
            this.Label_PreviewLabel.Text = "Preview";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(15, 83);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(38, 13);
            this.Label_Name.TabIndex = 4;
            this.Label_Name.Text = "Name:";
            // 
            // Label_GreatJobOn
            // 
            this.Label_GreatJobOn.AutoSize = true;
            this.Label_GreatJobOn.Location = new System.Drawing.Point(15, 110);
            this.Label_GreatJobOn.Name = "Label_GreatJobOn";
            this.Label_GreatJobOn.Size = new System.Drawing.Size(73, 13);
            this.Label_GreatJobOn.TabIndex = 6;
            this.Label_GreatJobOn.Text = "Great Job On:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Work On:";
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(89, 76);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(118, 20);
            this.TextBox_Name.TabIndex = 5;
            // 
            // ComboBox_GreatJobOn
            // 
            this.ComboBox_GreatJobOn.FormattingEnabled = true;
            this.ComboBox_GreatJobOn.Location = new System.Drawing.Point(89, 102);
            this.ComboBox_GreatJobOn.Name = "ComboBox_GreatJobOn";
            this.ComboBox_GreatJobOn.Size = new System.Drawing.Size(118, 21);
            this.ComboBox_GreatJobOn.TabIndex = 9;
            // 
            // ComboBox_WorkOn
            // 
            this.ComboBox_WorkOn.FormattingEnabled = true;
            this.ComboBox_WorkOn.Location = new System.Drawing.Point(89, 129);
            this.ComboBox_WorkOn.Name = "ComboBox_WorkOn";
            this.ComboBox_WorkOn.Size = new System.Drawing.Size(118, 21);
            this.ComboBox_WorkOn.TabIndex = 10;
            // 
            // Button_Preview
            // 
            this.Button_Preview.Location = new System.Drawing.Point(18, 165);
            this.Button_Preview.Name = "Button_Preview";
            this.Button_Preview.Size = new System.Drawing.Size(189, 23);
            this.Button_Preview.TabIndex = 11;
            this.Button_Preview.Text = "Preview";
            this.Button_Preview.UseVisualStyleBackColor = true;
            this.Button_Preview.Click += new System.EventHandler(this.Button_Preview_Click);
            // 
            // Button_Output
            // 
            this.Button_Output.Location = new System.Drawing.Point(18, 194);
            this.Button_Output.Name = "Button_Output";
            this.Button_Output.Size = new System.Drawing.Size(189, 23);
            this.Button_Output.TabIndex = 12;
            this.Button_Output.Text = "Output";
            this.Button_Output.UseVisualStyleBackColor = true;
            // 
            // Form_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(499, 438);
            this.Controls.Add(this.Button_Output);
            this.Controls.Add(this.Button_Preview);
            this.Controls.Add(this.ComboBox_WorkOn);
            this.Controls.Add(this.ComboBox_GreatJobOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_GreatJobOn);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.Label_PreviewLabel);
            this.Controls.Add(this.TextBox_Preview);
            this.Controls.Add(this.MS_MenuStrip);
            this.MainMenuStrip = this.MS_MenuStrip;
            this.Name = "Form_MainForm";
            this.Load += new System.EventHandler(this.Form_MainForm_Load);
            this.MS_MenuStrip.ResumeLayout(false);
            this.MS_MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MS_File;
        private System.Windows.Forms.ToolStripMenuItem MS_Options;
        private System.Windows.Forms.TextBox TextBox_Preview;
        private System.Windows.Forms.Label Label_PreviewLabel;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_GreatJobOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.ComboBox ComboBox_GreatJobOn;
        private System.Windows.Forms.ComboBox ComboBox_WorkOn;
        private System.Windows.Forms.Button Button_Preview;
        private System.Windows.Forms.Button Button_Output;
    }
}

