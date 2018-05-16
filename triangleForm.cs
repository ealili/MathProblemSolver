using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathProblemSolver
{
    public partial class triangleForm : Form
    {
        public triangleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double baseLength, side1, side2;
            if (ValidationFunctions.validateDoubleInput(getBase.Text)
                && ValidationFunctions.validateDoubleInput(getSide1.Text)
                && ValidationFunctions.validateDoubleInput(getSide2.Text))
            {
                side1 = double.Parse(getSide1.Text);
                side2 = double.Parse(getSide2.Text);
                baseLength = double.Parse(getBase.Text);
                //Creating a Triangle object
                Triangle triangle = new Triangle(baseLength, side1, side2);
                showArea.Text = "The area is " + triangle.calculateArea().ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid values!", "Warning");
            }

          
            //try
            //{
            //    baseLength = double.Parse(getBase.Text);
            //    height = double.Parse(getHeight.Text);
            //    double area = baseLength * height / 2;
            //    showArea.Text = "The area is " + area.ToString();
            //}
            //catch
            //{
            //    MessageBox.Show("Please enter valid values for length and height.");

            //}

        }
    }
}
