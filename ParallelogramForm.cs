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
    public partial class ParallelogramForm : Form
    {
        public ParallelogramForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double baseLength = double.Parse(getBase.Text);
                double side = double.Parse(getSide.Text);
                double height = double.Parse(getHeight.Text);        
                Parallelogram parallelogram = new Parallelogram(baseLength, side, height);
                showArea.Text = "The area is " + parallelogram.calculateArea().ToString();
                showPerimeter.Text = "The perimeter is " + parallelogram.calculatePerimeter().ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Input!", "Warning");
                showArea.Text = "";
                showPerimeter.Text = "";
                getBase.Text = "";
                getHeight.Text = "";
                getSide.Text = "";
            }
        }

        private void parallelogramBackButton_Click(object sender, EventArgs e)
        {
            _2dForm twoD = new _2dForm();
            this.Close();
            twoD.Show();
        }
    }
}
