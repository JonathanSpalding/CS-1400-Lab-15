// Author: Jonathan Spalding
// Assignment: Lab 15
// Instructor Roger deBry
// Clas: CS 1400
// Date Written: 2/25/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        //class reference to Triangle Class
        private Triangle tc;
        public Form1()
        {
            InitializeComponent();
            //create the Triangle object
            tc = new Triangle();
        }
        // The button1_click method
        // Purpose: take the length of both sides and put them in variables, then return the method CalcHypotenuse to output the Hypotenuse.
        // Parameters: The sending object, and the event arguments
        // returns: none
        private void button1_Click(object sender, EventArgs e)
        {
            //convert the input boxes from string to double
            double sideAValue = double.Parse(sideA.Text);
            double sideBValue = double.Parse(sideB.Text);
            //save the values of sideB and sideC in the the Triangle Object
            tc = new Triangle(sideAValue, sideBValue);
            //call back the method for calculating sideC
            double siceCValue = tc.CalcSideC();
            //convert to string and place it in its own variable
            string sideCOutStr = $"{siceCValue}"; 
            //output the string to the output box
            sideC.Text = sideCOutStr;
        }
    }
}
