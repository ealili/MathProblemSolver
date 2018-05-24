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
    public partial class RectangleForm : Form
    {
        public RectangleForm()
        {
            InitializeComponent();
            this.AcceptButton = calcButton;
        }

        //Hiding the current window and the showing the previous one
        private void rectangleBackButton_Click(object sender, EventArgs e)
        {
            _2dForm twoD = new _2dForm();
            this.Hide();
            twoD.Show();
        }

        //Calculation Button
        private void calcButton_Click(object sender, EventArgs e)
        {
            double baseLength, side;
            try
            {
                baseLength = double.Parse(getBase.Text);
                side = double.Parse(getSide.Text);
                Rectangle rectangle = new Rectangle(baseLength, side);
                showArea.Text = "The area is " + rectangle.calculateArea().ToString();
                showPerimeter.Text = "The perimeter is " + rectangle.calculatePerimeter().ToString();
            }
            catch
            {
                MessageBox.Show("Invalid input!", "Warning");
                showArea.Text = "";
                showPerimeter.Text = "";
                getBase.Text = "";
                getSide.Text = "";
            }
        }
    }
}
