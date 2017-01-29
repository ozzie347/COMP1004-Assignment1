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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new salesBonusForm());
        }
    }
}
