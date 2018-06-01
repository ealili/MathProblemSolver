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
            this.AcceptButton = calcButton;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double baseLength = double.Parse(getBase.Text);
                double side1 = double.Parse(getSide1.Text);
                double side2 = double.Parse(getSide2.Text);
                Triangle triangle = new Triangle(baseLength, side1, side2);
                showArea.Text = "The area is " + TwoDimensionalShape.setPrecision(triangle.calculateArea());
                showPerimeter.Text = "The perimeter is " + TwoDimensionalShape.setPrecision(triangle.calculatePerimeter());   
            }
            catch
            {
                errorWindow();
            }
        }

        public void errorWindow()
        {
            MessageBox.Show("Invalid Input", "Warning");
            showArea.Text = "";
            showPerimeter.Text = "";
            getBase.Text = "";
            getSide1.Text = "";
            getSide2.Text = "";
        }

        private void triangleBackButton_Click(object sender, EventArgs e)
        {
            _2dForm twoD = new _2dForm();
            this.Hide();
            twoD.Show();
        }
    }
}
