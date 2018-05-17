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
    public partial class TrapezoidForm : Form
    {
        public TrapezoidForm()
        {
            InitializeComponent();
        }

        private void trapezoidBackButton_Click(object sender, EventArgs e)
        {
            _2dForm twoD = new _2dForm();
            this.Hide();
            twoD.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double baseLength = double.Parse(getBase.Text);
                double side1 = double.Parse(getSide1.Text);
                double side2 = double.Parse(getSide2.Text);
                double side3 = double.Parse(getSide3.Text);
                Trapezoid trapezoid = new Trapezoid(baseLength, side1, side2, side3);
                showArea.Text = "The area is " + trapezoid.calculateArea().ToString();
                showPerimeter.Text = "The perimeter is " + trapezoid.calculatePerimeter().ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Input", "Warning");
                showArea.Text = "";
                showPerimeter.Text = "";
                getBase.Text = "";
                getSide1.Text = "";
                getSide2.Text = "";
                getSide3.Text = "";            
            }
        }
    }
}
