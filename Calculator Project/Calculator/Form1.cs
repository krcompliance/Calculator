using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author Name     Dong Hee Han
// Creation Date   25-09-2018
// Version Control 1.0

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        //Add comments here that explain these 4 Operator methods
        //Explain each of the Variables
        //Change these names to improve clarity
        //Try using the built-in REFACTOR

        // Declare local variables
        double total1 = 0; // Double variables to save a calculated result
        double total2 = 0; // Double variables to save a final value

        // boolean variables to show about which operator is clicked by a user
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;

        bool sineButtonClicked = false;
        bool cosineButtonClicked = false;
        bool tangentButtonClicked = false;
        bool sqrtButtonClicked = false;
        bool cubeRButtonClicked = false;

        // boolean variables to show about if there is more than one operator that a user has clicked
        bool isOneMoreOperand = false;

        public CalculatorForm()
        {
            InitializeComponent();
            txtDisplay.Clear();
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        // Button One click event
        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }
        // Button Two click event
        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }
        // Button Three click event
        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }
        // Button Four
        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }
        // button Five click event
        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }
        // Button Six click event
        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }
        // Button Seven click event
        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }
        // Button Eight click event
        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }
        // Button Nine click event
        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        // Button Zero click event
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        // Declare an event and action for a Clear button
        // Clear a text field and back to the initial value
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            backToInitialValue();
        }

        // Button Point click event
        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnDot.Text;
        }

        // Declare an event and action for a Plus button
        // If All of the initial value is null, forced to return the main screen
        private void btnPlus_Click(object sender, EventArgs e)
        {
           
            // if there are more than one operand that a user clicked,
            // calculate a expression using an operand except for a last operand that a user clicks 
            if (isOneMoreOperand)
            {
                // If a user continue to click a operand button in a row, 
                // stop calculating it and just return to the screen
                if (String.IsNullOrEmpty(txtDisplay.Text))
                {
                    // Set the boolean value
                    setButtonClicked("Plus");
                    return;
                }
                if (!calculateOnClickOperand())
                {
                    txtDisplay.Text = "Error";
                    // Back to the initial values
                    backToInitialValue();
                    return;
                }
                else
                {

                }
            }
            else
            {
                double num = 0;
                bool isNumber = double.TryParse(txtDisplay.Text.ToString(), out num);
                if (!isNumber)
                {
                    txtDisplay.Text = "Clear first";
                    return;
                }
                total1 += num;
            }
           
            // Clear the text box
            txtDisplay.Clear();

            // Set the boolean value
            setButtonClicked("Plus");
        }

        //Subtract a number
        private void btnMinus_Click(object sender, EventArgs e)
        {           
            // check if there are more than one operand that a user clicked
            if (isOneMoreOperand)
            {
                if (String.IsNullOrEmpty(txtDisplay.Text))
                {
                    // Set the boolean value
                    setButtonClicked("Minus");
                    return;
                }

                if (!calculateOnClickOperand())
                {
                    txtDisplay.Text = "Error";
                    // Back to the initial values
                    backToInitialValue();
                    return;
                }
                else
                {

                }
            }
            else
            {
                if (String.IsNullOrEmpty(txtDisplay.Text))
                {
                    txtDisplay.Text = "-";
                    return;
                }
                double num = 0;
                bool isNumber = double.TryParse(txtDisplay.Text.ToString(), out num);
                if (!isNumber)
                {
                    txtDisplay.Text = "Clear first";
                    return;
                }
                total1 += num;
            }
            
            txtDisplay.Clear();

            // Set the boolean value
            setButtonClicked("Minus");
        }

        // Devide a number
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (isOneMoreOperand)
            {
                if (String.IsNullOrEmpty(txtDisplay.Text))
                {
                    // Set the boolean value
                    setButtonClicked("Div");
                    return;
                }
                if (!calculateOnClickOperand())
                {
                   // Back to the initial values
                    backToInitialValue();
                    return;
                }
                else
                {

                }
            }
            else
            {
                double num = 0;
                bool isNumber = double.TryParse(txtDisplay.Text.ToString(), out num);
                if (!isNumber)
                {
                    txtDisplay.Text = "Clear first";
                    return;
                }
                total1 += num;
            }

            txtDisplay.Clear();

            // Set the boolean value
            setButtonClicked("Div");
        }

        // Multiply a number
        private void btnMultiply_Click(object sender, EventArgs e)
        { 
            if (isOneMoreOperand)
            {
                if (String.IsNullOrEmpty(txtDisplay.Text))
                {
                    // Set the boolean value
                    setButtonClicked("Mult");
                    return;
                }
                if (!calculateOnClickOperand())
                {
                    txtDisplay.Text = "Error";
                    // Back to the initial values
                    backToInitialValue();
                    return;
                }
                else
                {

                }
            }
            else
            {
                double num = 0;
                bool isNumber = double.TryParse(txtDisplay.Text.ToString(), out num);
                if (!isNumber)
                {
                    txtDisplay.Text = "Clear first";
                    return;
                }
                total1 += num;
            }
            txtDisplay.Clear();

            // Set the boolean value
            setButtonClicked("Mult");
        }

        // Set the boolean value in order to find out which operand is clicked by a user
        private void setButtonClicked(String clickButton)
        {
            // back to the initial value
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;

            sineButtonClicked = false;
            cosineButtonClicked = false;
            tangentButtonClicked = false;
            sqrtButtonClicked = false;
            cubeRButtonClicked = false;

            switch (clickButton)
            {
                case "Plus":
                    plusButtonClicked = true;
                    break;
                case "Minus":
                    minusButtonClicked = true;
                    break;
                case "Mult":
                    multiplyButtonClicked = true;
                    break;
                case "Div":
                    divideButtonClicked = true;
                    break;
                case "Sin":
                    sineButtonClicked = true;
                    break;
                case "Cos":
                    cosineButtonClicked = true;
                    break;
                case "Tan":
                    tangentButtonClicked = true;
                    break;
                case "Sqrt":
                    sqrtButtonClicked = true;
                    break;
                case "CubeR":
                    cubeRButtonClicked = false;
                    break;
                default:
                    break;
            }
            isOneMoreOperand = true;
        }

        // Calculate and display the final calculated values
        private void btnEquals_Click(object sender, EventArgs e)
        {
            // if a user press a operand button before pressing a number button
            if (String.IsNullOrEmpty(txtDisplay.Text))
            {
                txtDisplay.Text = "0";
            }
                        
            if (!calculateOnClickOperand())
            {
                if (divideButtonClicked == true)
                {
                }
                else
                {
                    // Show error message to a user
                    txtDisplay.Text = "Error";
                }

                // Back to the initial values
                backToInitialValue();
                return;
            }
            else
            {
                total2 = total1;
            }

            // Display a final result
            txtDisplay.Text = total1.ToString();

            // Back to the initial values
            backToInitialValue();
        }

        // if a user keeps trying to calculate something in a row
        // obtain a final value before using a final operand that a user click
        private Boolean calculateOnClickOperand()
        {
            Boolean isContinue = true;
            if (plusButtonClicked == true)
            {
                total1 = BasicMath.Arithmetic.Add(total1, double.Parse(txtDisplay.Text));
            }
            else if (minusButtonClicked == true)
            {
                total1 = BasicMath.Arithmetic.Sub(total1, double.Parse(txtDisplay.Text));
            }
            else if (divideButtonClicked == true)
            { 
                if(txtDisplay.Text.Equals("0"))
                {
                    isContinue = false;
                    txtDisplay.Text = "Cannot divide by zero";
                }
                else
                {
                    total1 = BasicMath.Arithmetic.Div(total1, double.Parse(txtDisplay.Text));
                }
            }
            else if (multiplyButtonClicked == true)
            {
                total1 = BasicMath.Arithmetic.Mult(total1, double.Parse(txtDisplay.Text));
            }
            else
            {
                isContinue = false;
            }

            return isContinue;
        }

        // Calculate a sine
        private void btnSin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDisplay.Text))
            {
                txtDisplay.Text = "0";
            }
            double num = 0;
            bool isNumber = double.TryParse(txtDisplay.Text.ToString(), out num);
            if(!isNumber)
            {
                txtDisplay.Text = "Clear first";
                return;
            }
            num = Math.Abs(num);
            if (num >= 0)
            {
                txtDisplay.Text = Trigonometric.Trigonometric.Sine(num).ToString();
                sineButtonClicked = true;
            }
            else
            {
                MessageBox.Show("Number must be positive", "Error Message");
                txtDisplay.Text = "0";
            }
        }

        // Calculate a cosine
        private void btnCos_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDisplay.Text))
            {
                txtDisplay.Text = "0";
            }
            double num = 0;
            bool isNumber = double.TryParse(txtDisplay.Text.ToString(), out num);
            if (!isNumber)
            {
                txtDisplay.Text = "Clear first";
                return;
            }
            num = Math.Abs(num);
            if (num >= 0)
            {
                txtDisplay.Text = Trigonometric.Trigonometric.Cosine(num).ToString();
                cosineButtonClicked = true;
            }
            else
            {
                MessageBox.Show("Number must be positive", "Error Message");
                txtDisplay.Text = "0";
            }
        }

        // Calculate a tangent
        private void btnTan_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDisplay.Text))
            {
                txtDisplay.Text = "0";
            }
            double num = 0;
            bool isNumber = double.TryParse(txtDisplay.Text.ToString(), out num);
            if (!isNumber)
            {
                txtDisplay.Text = "Clear first";
                return;
            }

            num = Math.Abs(num);
            if (num >= 0)
            {
                if(num == 90)
                {
                    txtDisplay.Text = "Number is invalid";
                    return;
                }
                txtDisplay.Text = Trigonometric.Trigonometric.Tangent(num).ToString();
                tangentButtonClicked = true;
            }
            else
            {
                MessageBox.Show("Number must be positive", "Error Message");
                txtDisplay.Text = "0";
            }
        }

        // Calculate a Square Root
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDisplay.Text))
            {
                txtDisplay.Text = "0";
            }
            double num = 0;
            bool isNumber = double.TryParse(txtDisplay.Text.ToString(), out num);
            if (!isNumber)
            {
                txtDisplay.Text = "Clear first";
                return;
            }
            if (num >= 0)
            {
                txtDisplay.Text = Algebraic.Algebraic.SquareRoot(num).ToString();
                sqrtButtonClicked = true;
            }
            else
            {
                txtDisplay.Text = "Number must be positive";
            }
        }

        // Calculate a Cube Root
        private void btncubeRT_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDisplay.Text))
            {
               txtDisplay.Text = "0";
            }
            double num = 0;
            bool isNumber = double.TryParse(txtDisplay.Text.ToString(), out num);
            if (!isNumber)
            {
                txtDisplay.Text = "Clear first";
                return;
            }
            num = Math.Abs(num);
            if (num >= 0)
            {
                txtDisplay.Text = Algebraic.Algebraic.CubeRT(num).ToString();
                cubeRButtonClicked = true;
            }
            else
            {
                MessageBox.Show("Number must be positive", "Error Message");
                txtDisplay.Text = "0";
            }
        }

        // Calculate a Inverse 
        private void btnInv_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDisplay.Text))
            {
                txtDisplay.Text = "0";
            }
            
            double num = 0;
            bool isNumber = double.TryParse(txtDisplay.Text.ToString(), out num);
            if (!isNumber)
            {
                txtDisplay.Text = "Clear first";
                return;
            }

            if(num != 0)
            {
                num = (-1) * num;
            }
            txtDisplay.Text = num.ToString();

            //String inverseType = "";
            //if (num >= 0 )
            //{
            //    if(sineButtonClicked)
            //    {
            //        if (num >= -1 && num <= 1)
            //        { }
            //        else
            //        {
            //            MessageBox.Show("Warning", "Target number must be greater than or equal to -1, but less than or equal to 1 ");
            //            return;
            //        }
            //        inverseType = "Sin";
            //    } else if(cosineButtonClicked)
            //    {
            //        if (num >= -1 && num <= 1)
            //        { }
            //        else
            //        {
            //            MessageBox.Show("Warning", "Target number must be greater than or equal to -1, but less than or equal to 1 ");
            //            return;
            //        }
            //        inverseType = "Cos";
            //    } else if (tangentButtonClicked)
            //    {
            //        if (num >= -1 && num <= 1)
            //        { }
            //        else
            //        {
            //            MessageBox.Show("Warning", "Target number must be greater than or equal to -1, but less than or equal to 1 ");
            //            return;
            //        }
            //        inverseType = "Tan";
            //    }
            //    else if (sqrtButtonClicked)
            //    {

            //        inverseType = "Sqrt";
            //    }
            //    else if (cubeRButtonClicked)
            //    {
            //        inverseType = "cubeR";
            //    }

            //    txtDisplay.Text = Algebraic.Algebraic.Inverse(inverseType, num).ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Number must be positive", "Error Message");
            //    txtDisplay.Text = "0";
            //}
        }

        // Receive a quit command from the memu
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        // Receive a clear command from the menu
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();

            backToInitialValue();
        }
        private void backToInitialValue()
        {
            total1 = 0;
            total2 = 0;

            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;

            sineButtonClicked = false;
            cosineButtonClicked = false;
            tangentButtonClicked = false;
            sqrtButtonClicked = false;
            cubeRButtonClicked = false;

            isOneMoreOperand = false;
        }
        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
