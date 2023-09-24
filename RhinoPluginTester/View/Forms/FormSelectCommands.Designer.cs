namespace RhinoPluginTester.View.Forms
{
    partial class FormSelectCommands
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
            this.clbCommands = new System.Windows.Forms.CheckedListBox();
            this.btnRunTests = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clbCommands
            // 
            this.clbCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbCommands.FormattingEnabled = true;
            this.clbCommands.Location = new System.Drawing.Point(15, 42);
            this.clbCommands.Name = "clbCommands";
            this.clbCommands.Size = new System.Drawing.Size(340, 394);
            this.clbCommands.TabIndex = 0;
            // 
            // btnRunTests
            // 
            this.btnRunTests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunTests.Location = new System.Drawing.Point(218, 442);
            this.btnRunTests.Name = "btnRunTests";
            this.btnRunTests.Size = new System.Drawing.Size(134, 23);
            this.btnRunTests.TabIndex = 1;
            this.btnRunTests.Text = "Run Tests";
            this.btnRunTests.UseVisualStyleBackColor = true;
            this.btnRunTests.Click += new System.EventHandler(this.btnRunTests_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select commands to test";
            // 
            // FormSelectCommands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRunTests);
            this.Controls.Add(this.clbCommands);
            this.MinimumSize = new System.Drawing.Size(380, 519);
            this.Name = "FormSelectCommands";
            this.Text = "Rhino Plugin Tester - Select Commands";
            this.Load += new System.EventHandler(this.FormSelectCommands_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbCommands;
        private System.Windows.Forms.Button btnRunTests;
        private System.Windows.Forms.Label label1;
    }
}