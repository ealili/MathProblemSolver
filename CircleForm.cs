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
    public partial class CircleForm : Form
    {
        public CircleForm()
        {
            InitializeComponent();
            this.AcceptButton = calculateButton;
        }

        private void circleBackLabel_Click(object sender, EventArgs e)
        {
            _2dForm twoD = new _2dForm();
            this.Hide();
            twoD.Show();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = double.Parse(getRadius.Text);
                Circle circle = new Circle(radius);
                showArea.Text = "The area is " + TwoDimensionalShape.setPrecision(circle.calculateArea());
                showPerimeter.Text = "The circumference is " + TwoDimensionalShape.setPrecision(circle.calculatePerimeter());
            }
            catch
            {
                MessageBox.Show("Invalid Input!", "Warning");
                showArea.Text = "";
                showPerimeter.Text = "";
                getRadius.Text = "";
            }
        }
    }
}
