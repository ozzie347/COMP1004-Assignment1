using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Assignment1
{
    public partial class salesBonusForm : Form
    {
        public salesBonusForm()
        {
            InitializeComponent();
        }
        
        private void hoursWorkedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double _hoursWorked;
                _hoursWorked = Convert.ToDouble(hoursWorkedTextBox.Text);

                if(_hoursWorked > 160)
                {
                    MessageBox.Show("Hours worked must be 160 or less.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("An error occurred", ex);
            }
        }

        private void totalSalesTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                double _totalSales;
                string _currencyTotal;
                _totalSales = Convert.ToDouble(totalSalesTextBox.Text);
                _currencyTotal = _totalSales.ToString("C2");

                totalSalesTextBox.Text = _currencyTotal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("An error occurred", ex);
            }
        }

        private void englishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
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

        private void frenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
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

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double _pctHoursWorked;
            double _totalBonusAmt;
            double _salesBonus;

            _pctHoursWorked = Convert.ToDouble(hoursWorkedTextBox.Text) / 160;
            _totalBonusAmt = Convert.ToDouble(totalSalesTextBox.Text.Substring(1)) * 0.02;
            _salesBonus = _pctHoursWorked * _totalBonusAmt;

            salesBonusTextBox.Text = _salesBonus.ToString();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            employeeNameTextBox.Clear();
            employeeIDTextBox.Clear();
            hoursWorkedTextBox.Clear();
            salesBonusTextBox.Clear();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form has been sent to the printer.", "Printing...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
