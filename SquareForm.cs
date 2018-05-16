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
    public partial class SquareForm : Form
    {
        public SquareForm()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                double baseLength = double.Parse(getBase.Text);
                Square square = new Square(baseLength);
                showArea.Text = "The area is " + square.calculateArea().ToString();
                showPerimeter.Text = "The perimeter is " + square.calculatePerimeter().ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Input!", "Warning");
                showArea.Text = "";
                showPerimeter.Text = "";
                getBase.Text = "";
            }

        }

        private void squareBackButton_Click(object sender, EventArgs e)
        {
            _2dForm twoD = new _2dForm();
            this.Hide();
            twoD.Show();
        }
    }
}
