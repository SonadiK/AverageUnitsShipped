
namespace AverageUnitsShipped
{
    partial class formAverageUnitsShipped
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelUnitsPrompt = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxEntryNumber = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.textBoxPastEntries = new System.Windows.Forms.TextBox();
            this.labelAverageOutput = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelUnitsPrompt
            // 
            this.labelUnitsPrompt.Location = new System.Drawing.Point(98, 35);
            this.labelUnitsPrompt.Name = "labelUnitsPrompt";
            this.labelUnitsPrompt.Size = new System.Drawing.Size(60, 25);
            this.labelUnitsPrompt.TabIndex = 0;
            this.labelUnitsPrompt.Text = "&Units:";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(27, 254);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(94, 29);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Click to calculate the current units shipped");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(156, 254);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(105, 29);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset this form to enter new entries");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(300, 254);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 29);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to end the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // textBoxEntryNumber
            // 
            this.textBoxEntryNumber.Location = new System.Drawing.Point(164, 35);
            this.textBoxEntryNumber.Name = "textBoxEntryNumber";
            this.textBoxEntryNumber.Size = new System.Drawing.Size(76, 27);
            this.textBoxEntryNumber.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBoxEntryNumber, "Enter the units shipped");
            // 
            // labelDay
            // 
            this.labelDay.Location = new System.Drawing.Point(261, 38);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(64, 25);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day 1";
            // 
            // textBoxPastEntries
            // 
            this.textBoxPastEntries.Location = new System.Drawing.Point(98, 68);
            this.textBoxPastEntries.Multiline = true;
            this.textBoxPastEntries.Name = "textBoxPastEntries";
            this.textBoxPastEntries.ReadOnly = true;
            this.textBoxPastEntries.Size = new System.Drawing.Size(212, 138);
            this.textBoxPastEntries.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxPastEntries, "Displays the units shipped for 7 days");
            // 
            // labelAverageOutput
            // 
            this.labelAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageOutput.Location = new System.Drawing.Point(72, 219);
            this.labelAverageOutput.Name = "labelAverageOutput";
            this.labelAverageOutput.Size = new System.Drawing.Size(273, 25);
            this.labelAverageOutput.TabIndex = 4;
            this.labelAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelAverageOutput, "Displays the calculated average of units shipped");
            this.labelAverageOutput.Click += new System.EventHandler(this.label3_Click);
            // 
            // formAverageUnitsShipped
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(420, 312);
            this.Controls.Add(this.labelAverageOutput);
            this.Controls.Add(this.textBoxPastEntries);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textBoxEntryNumber);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelUnitsPrompt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAverageUnitsShipped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnitsPrompt;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxEntryNumber;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textBoxPastEntries;
        private System.Windows.Forms.Label labelAverageOutput;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

