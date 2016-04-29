// Author: Jonathan Spalding
// Assignment: Lab 15
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 2/25/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    // The Triangle class definition
    class Triangle
    {
        // State the data members of the class.
        private double a = 0;
        private double b = 0;
        // The default constructor
        // Purpose: It sets all declared variables
        // Parameters: None
        // Returns: None
        public Triangle()
            {
            a = 0;
            b = 0;
            }
        // The parameterized constructor
        // Purpose: It sets all declared variables (data members of the class) to the values passed in
        // Parameters: Integers, the numTokens and numQuarters.
        // Returns: None
        public Triangle(double p1, double p2)
        {
            a = p1;
            b = p2;
        }
        // The CalcSideC method
        // Purpose: To return the length of side c.
        // Parameters: None
        // Returns: double sideC
        public double CalcSideC()
        {
            //get the square root of side a squared plus side b squared.
            double sideC = Math.Sqrt(a * a + b * b);
            return sideC;
        }
    }
}
