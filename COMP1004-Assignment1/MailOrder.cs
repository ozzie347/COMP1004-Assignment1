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
                double hoursWorked;
                hoursWorked = Convert.ToDouble(hoursWorkedTextBox.Text);

                if(hoursWorked > 160)
                {
                    MessageBox.Show("Hours worked must be 160 or less.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("An error occurred", ex);
            }
        }

        private void totalSalesTextBox_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    double totalSales;
            //    string currencyTotal;
            //    totalSales = Convert.ToDouble(totalSalesTextBox.Text.Substring(1));
            //    currencyTotal = totalSales.ToString("C0");

            //    totalSalesTextBox.Text = currencyTotal;                
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Console.WriteLine("An error occurred", ex);
            //}
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
    }
}
