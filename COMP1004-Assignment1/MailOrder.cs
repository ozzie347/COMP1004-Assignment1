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
        
        private void _hoursWorkedTextBox_TextChanged(object sender, EventArgs e)
        {
            try {
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
    }
}
