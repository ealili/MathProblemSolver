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
    public partial class SphereForm : Form
    {
        public SphereForm()
        {
            InitializeComponent();
        }

        private void sphereBackButton_Click(object sender, EventArgs e)
        {
            _3dForm threeD = new _3dForm();
            this.Hide();
            threeD.Show();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = double.Parse(getRadius.Text);
                Sphere sphere = new Sphere(radius);
                showArea.Text = "The area is " + TwoDimensionalShape.setPrecision(sphere.calculateArea());
                showVolume.Text = "The volume is " + TwoDimensionalShape.setPrecision(sphere.calculateVolume());
            }
            catch
            {
                MessageBox.Show("Invalid Input!", "Warning");
                showArea.Text = "";
                showVolume.Text = "";
                getRadius.Text = "";
            }
        }
    }
}
