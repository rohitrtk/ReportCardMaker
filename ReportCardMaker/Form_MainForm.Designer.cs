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
            this.TextBox_Preview = new System.Windows.Forms.TextBox();
            this.Label_PreviewLabel = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_GreatJobOn = new System.Windows.Forms.Label();
            this.Label_WorkOn = new System.Windows.Forms.Label();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.ComboBox_GreatJobOn = new System.Windows.Forms.ComboBox();
            this.ComboBox_WorkOn = new System.Windows.Forms.ComboBox();
            this.Button_Preview = new System.Windows.Forms.Button();
            this.Button_Output = new System.Windows.Forms.Button();
            this.TextBox_SavePath = new System.Windows.Forms.TextBox();
            this.Label_SavePath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_Preview
            // 
            this.TextBox_Preview.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Preview.Location = new System.Drawing.Point(219, 30);
            this.TextBox_Preview.Multiline = true;
            this.TextBox_Preview.Name = "TextBox_Preview";
            this.TextBox_Preview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Preview.Size = new System.Drawing.Size(268, 354);
            this.TextBox_Preview.TabIndex = 1;
            // 
            // Label_PreviewLabel
            // 
            this.Label_PreviewLabel.AutoSize = true;
            this.Label_PreviewLabel.Location = new System.Drawing.Point(216, 14);
            this.Label_PreviewLabel.Name = "Label_PreviewLabel";
            this.Label_PreviewLabel.Size = new System.Drawing.Size(45, 13);
            this.Label_PreviewLabel.TabIndex = 2;
            this.Label_PreviewLabel.Text = "Preview";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(12, 37);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(38, 13);
            this.Label_Name.TabIndex = 4;
            this.Label_Name.Text = "Name:";
            // 
            // Label_GreatJobOn
            // 
            this.Label_GreatJobOn.AutoSize = true;
            this.Label_GreatJobOn.Location = new System.Drawing.Point(12, 64);
            this.Label_GreatJobOn.Name = "Label_GreatJobOn";
            this.Label_GreatJobOn.Size = new System.Drawing.Size(73, 13);
            this.Label_GreatJobOn.TabIndex = 6;
            this.Label_GreatJobOn.Text = "Great Job On:";
            // 
            // Label_WorkOn
            // 
            this.Label_WorkOn.AutoSize = true;
            this.Label_WorkOn.Location = new System.Drawing.Point(12, 91);
            this.Label_WorkOn.Name = "Label_WorkOn";
            this.Label_WorkOn.Size = new System.Drawing.Size(53, 13);
            this.Label_WorkOn.TabIndex = 8;
            this.Label_WorkOn.Text = "Work On:";
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(86, 34);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(118, 20);
            this.TextBox_Name.TabIndex = 5;
            // 
            // ComboBox_GreatJobOn
            // 
            this.ComboBox_GreatJobOn.FormattingEnabled = true;
            this.ComboBox_GreatJobOn.Location = new System.Drawing.Point(86, 61);
            this.ComboBox_GreatJobOn.Name = "ComboBox_GreatJobOn";
            this.ComboBox_GreatJobOn.Size = new System.Drawing.Size(118, 21);
            this.ComboBox_GreatJobOn.TabIndex = 9;
            // 
            // ComboBox_WorkOn
            // 
            this.ComboBox_WorkOn.FormattingEnabled = true;
            this.ComboBox_WorkOn.Location = new System.Drawing.Point(86, 88);
            this.ComboBox_WorkOn.Name = "ComboBox_WorkOn";
            this.ComboBox_WorkOn.Size = new System.Drawing.Size(118, 21);
            this.ComboBox_WorkOn.TabIndex = 10;
            // 
            // Button_Preview
            // 
            this.Button_Preview.Location = new System.Drawing.Point(15, 119);
            this.Button_Preview.Name = "Button_Preview";
            this.Button_Preview.Size = new System.Drawing.Size(189, 23);
            this.Button_Preview.TabIndex = 11;
            this.Button_Preview.Text = "Preview";
            this.Button_Preview.UseVisualStyleBackColor = true;
            this.Button_Preview.Click += new System.EventHandler(this.Button_Preview_Click);
            // 
            // Button_Output
            // 
            this.Button_Output.Location = new System.Drawing.Point(15, 148);
            this.Button_Output.Name = "Button_Output";
            this.Button_Output.Size = new System.Drawing.Size(189, 23);
            this.Button_Output.TabIndex = 12;
            this.Button_Output.Text = "Output";
            this.Button_Output.UseVisualStyleBackColor = true;
            // 
            // TextBox_SavePath
            // 
            this.TextBox_SavePath.Location = new System.Drawing.Point(71, 394);
            this.TextBox_SavePath.Name = "TextBox_SavePath";
            this.TextBox_SavePath.Size = new System.Drawing.Size(416, 20);
            this.TextBox_SavePath.TabIndex = 13;
            // 
            // Label_SavePath
            // 
            this.Label_SavePath.AutoSize = true;
            this.Label_SavePath.Location = new System.Drawing.Point(12, 397);
            this.Label_SavePath.Name = "Label_SavePath";
            this.Label_SavePath.Size = new System.Drawing.Size(60, 13);
            this.Label_SavePath.TabIndex = 14;
            this.Label_SavePath.Text = "Save Path:";
            // 
            // Form_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(499, 438);
            this.Controls.Add(this.Label_SavePath);
            this.Controls.Add(this.TextBox_SavePath);
            this.Controls.Add(this.Button_Output);
            this.Controls.Add(this.Button_Preview);
            this.Controls.Add(this.ComboBox_WorkOn);
            this.Controls.Add(this.ComboBox_GreatJobOn);
            this.Controls.Add(this.Label_WorkOn);
            this.Controls.Add(this.Label_GreatJobOn);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.Label_PreviewLabel);
            this.Controls.Add(this.TextBox_Preview);
            this.Name = "Form_MainForm";
            this.Load += new System.EventHandler(this.Form_MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBox_Preview;
        private System.Windows.Forms.Label Label_PreviewLabel;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_GreatJobOn;
        private System.Windows.Forms.Label Label_WorkOn;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.ComboBox ComboBox_GreatJobOn;
        private System.Windows.Forms.ComboBox ComboBox_WorkOn;
        private System.Windows.Forms.Button Button_Preview;
        private System.Windows.Forms.Button Button_Output;
        private System.Windows.Forms.TextBox TextBox_SavePath;
        private System.Windows.Forms.Label Label_SavePath;
    }
}

