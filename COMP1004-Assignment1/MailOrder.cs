/**
App: COMP1004-Assignment1
Author: Nicholas Oshukany
Last Modified: 01/29/2017
Description: Calculate sales bonuses for employees based on entered values.
*/

using System;
using System.Windows.Forms;

namespace COMP1004_Assignment1
{
    public partial class salesBonusForm : Form
    {
        ///Initialization
        public salesBonusForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Ensure valid entries for hoursWorked text field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hoursWorkedTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                double _hoursWorked;
                
                //if the field is not left blank
                if(hoursWorkedTextBox.Text != "")
                {
                    //if hours are over 160, let the user know with an error
                    if (Convert.ToDouble(hoursWorkedTextBox.Text) > 160)
                    {
                        MessageBox.Show("Hours worked must be 160 or less.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //else use the entry as Hours Worked
                    else {
                        _hoursWorked = Convert.ToDouble(hoursWorkedTextBox.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                //if entry is not numerical, provide an error
                MessageBox.Show("Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("An error occurred", ex);
            }
        }

        /// <summary>
        /// Ensure a currency value is assigned to the value entered by the user when the field is left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void totalSalesTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                double _totalSales;
                string _currencyTotal;

                if(totalSalesTextBox.Text != "")
                {
                    //convert string to double to ensure numerical entry
                    _totalSales = Convert.ToDouble(totalSalesTextBox.Text);
                    //convert double back to a string and assign a localized currency to two digits
                    _currencyTotal = _totalSales.ToString("C2");

                    //set currencyTotal as the thext for total sales
                    totalSalesTextBox.Text = _currencyTotal;
                }            }
            catch (Exception ex)
            {
                //if entry is not numerical, provide an error
                MessageBox.Show("Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("An error occurred", ex);
            }
        }

        /// <summary>
        /// Switch to English text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void englishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //fields to change to English
            employeeNameLabel.Text = "Employee's Name";
            employeeIDLabel.Text = "Employee ID";
            hoursWorkedLabel.Text = "Total Hours Worked";
            totalSalesLabel.Text = "Total Monthly Sales";
            salesBonusLabel.Text = "Sales Bonus";
            calculateButton.Text = "Calculate";
            nextButton.Text = "Next";
            printButton.Text = "Print";
            clearButton.Text = "Clear";
        }

        /// <summary>
        /// Switch to French text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //fields to change to French
            employeeNameLabel.Text = "Nom de l'Employé";
            employeeIDLabel.Text = "ID Employé";
            hoursWorkedLabel.Text = "Heures Travaillées";
            totalSalesLabel.Text = "Ventes Totales";
            salesBonusLabel.Text = "Bonus de Vente";
            calculateButton.Text = "Calculer";
            nextButton.Text = "Prochain";
            printButton.Text = "Impression";
            clearButton.Text = "Clair";
        }

        /// <summary>
        /// Calculate the Sales Bonus for the Employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double _pctHoursWorked;
            double _totalBonusAmt;
            double _salesBonus;

            //Formula to convert hours worked and total sales into a sales bonus
            _pctHoursWorked = Convert.ToDouble(hoursWorkedTextBox.Text) / 160;
            _totalBonusAmt = Convert.ToDouble(totalSalesTextBox.Text.Substring(1)) * 0.02;
            _salesBonus = _pctHoursWorked * _totalBonusAmt;

            salesBonusTextBox.Text = _salesBonus.ToString();
        }

        /// <summary>
        /// Funcionality to move onto the next employee without clearing the total monthly sales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            //clear the following fields
            employeeNameTextBox.Clear();
            employeeIDTextBox.Clear();
            hoursWorkedTextBox.Clear();
            salesBonusTextBox.Clear();
        }

        /// <summary>
        /// Print option for the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printButton_Click(object sender, EventArgs e)
        {
            //notify the user that the form has been sent to the printer
            MessageBox.Show("Form has been sent to the printer.", "Printing...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Clear all the fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear the following fields
            employeeNameTextBox.Clear();
            employeeIDTextBox.Clear();
            hoursWorkedTextBox.Clear();
            totalSalesTextBox.Clear();
            salesBonusTextBox.Clear();
        }
    }
}
