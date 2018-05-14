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
            double baseLength, height;

            if (ValidationFunctions.validateDoubleInput(getHeight.Text) && 
                ValidationFunctions.validateDoubleInput(getBase.Text)) {
                baseLength = double.Parse(getBase.Text);
                height = double.Parse(getHeight.Text);
                double area = baseLength * height / 2;
                showArea.Text = "The area is " + area.ToString();
            }
            else
            {
                //We have a problem
                MessageBox.Show("Please enter valid values for length and height.");
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
