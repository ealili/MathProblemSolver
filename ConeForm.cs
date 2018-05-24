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
    public partial class ConeForm : Form
    {
        public ConeForm()
        {
            InitializeComponent();
            this.AcceptButton = calculateButton;
        }

        private void coneBackButton_Click(object sender, EventArgs e)
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
                double height = double.Parse(getHeight.Text);
                Cone cone = new Cone(radius, height);
                showArea.Text = "The area is " + TwoDimensionalShape.setPrecision(cone.calculateArea());
                showVolume.Text = "The volume is " + TwoDimensionalShape.setPrecision(cone.calculateVolume());
            }
            catch
            {
                MessageBox.Show("Invalid Input!", "Warning");
                showArea.Text = "";
                showVolume.Text = "";
                getRadius.Text = "";
                getHeight.Text = "";
            }
        }
    }
}
