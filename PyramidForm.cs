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
    public partial class PyramidForm : Form
    {
        public PyramidForm()
        {
            InitializeComponent();
        }

        private void pyramidBackBtn_Click(object sender, EventArgs e)
        {
            _3dForm threeD = new _3dForm();
            this.Hide();
            threeD.Show();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double baseLength = double.Parse(getBase.Text);
                double height = double.Parse(getHeight.Text);
                double width = double.Parse(getWidth.Text);
                PyramidRectangularBased rectBased = new PyramidRectangularBased(baseLength, height, width);
                showArea.Text = "The area is " + TwoDimensionalShape.setPrecision(rectBased.calculateArea());
                showVolume.Text = "The volume is " + TwoDimensionalShape.setPrecision(rectBased.calculateVolume()); 
            }
            catch
            {
                MessageBox.Show("Invalid Input!", "Warning");
                showArea.Text = "";
                showVolume.Text = "";
                getBase.Text = "";
                getHeight.Text = "";
                getWidth.Text = "";
            }
        }
    }
}
