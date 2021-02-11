// 
// Author: Sonadi Kannangara 
// Date: January 22, 2021
// Description: 
// This program allows the user to enter the units shipped for seven days and calculates the average 
// of units shipped per week. If the user wants to calculate the average of another set of units 
//shipped, user can reset the program and enter the values again. 
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageUnitsShipped
{
    public partial class formAverageUnitsShipped : Form
    {
        // Class level variable declarations.
        int currentDay = 1;
        int currentTotal = 0;

        public formAverageUnitsShipped()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Calculates and displays the average from the entered units shipped by user for 7 days.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // Declare constants and variables.
            const int MinimumUnits = 0;
            const int MaximumUnits = 5000;
            const int MaximumDays = 7;
            int finalEntry;


            // Check the input number is a whole number.
            if (int.TryParse(textBoxEntryNumber.Text, out finalEntry))
            {
                // Check the input number is between 0 and 5000.
                if (finalEntry >= MinimumUnits && finalEntry <= MaximumUnits)
                {
                    // Add the new entry to the list of past entries.
                    textBoxPastEntries.Text += finalEntry + "\r\n";

                    //Increment the currentTotal by the finalEntry.
                    currentTotal += finalEntry;

                    // Increment the day by 1 (CurrentDay = CurrentDay + 1).
                    currentDay++;

                    // Clear the entry textbox.
                    textBoxEntryNumber.Clear();

                    // If the currentDay is greater than MaximumDays.
                    if (currentDay > MaximumDays)
                    {
                        // Calculate the average. 
                        double averageUnits;
                        averageUnits = (double)currentTotal / (double)MaximumDays;

                        // Output the Result (avearge of units shipped).
                        labelAverageOutput.Text = "Average per day: " + Math.Round(averageUnits, 2);

                        // Disable controls of textBoxEntryNumber & buttonEnter.
                        textBoxEntryNumber.Enabled = false;
                        buttonEnter.Enabled = false;

                        // Set focus to reset button.
                        buttonReset.Focus();
                    }
                    // The day is greater than or equal to MaximumDays.
                    else
                    {
                        // Display the currentDay.
                        labelDay.Text = "Day " + currentDay;

                        // Set focus to the new entry.
                        textBoxEntryNumber.Focus();                          
                    }
                }
                // The number entered is less than 0 or greater than 5000
                else
                {
                    // Display the error message in a message box.
                    MessageBox.Show("Enter a value between " + MinimumUnits + " and " + MaximumUnits + ".", "Invalid Entry!");
                    textBoxEntryNumber.SelectAll();
                    textBoxEntryNumber.Focus();
                }
            }
            // The number entered is not an integer.
            else
            {
                // Display the error message in a message box.
                MessageBox.Show("Entry must be a numeric value.", "Invalid Entry!");
                textBoxEntryNumber.SelectAll();
                textBoxEntryNumber.Focus();
            }                       
        }

        /// <summary>
        /// Resets the form for new data entry, including resetting class variables and re-enabling controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            // Clear the input and output fields.
            textBoxEntryNumber.Clear();
            textBoxPastEntries.Clear();
            labelAverageOutput.Text = String.Empty;
            // Reset the label day to "Day 1"
            labelDay.Text = "Day 1";

            // Reset the global variables.
            currentDay = 1;
            currentTotal = 0;

            // RE-enable any controls that mey be disabled.
            textBoxEntryNumber.Enabled = true;
            buttonEnter.Enabled = true;

            // Set focus for easy data entry.
            textBoxEntryNumber.Focus();
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
