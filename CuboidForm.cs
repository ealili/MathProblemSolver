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
    public partial class CuboidForm : Form
    {
        public CuboidForm()
        {
            InitializeComponent();

        }

        private void cuboidBackButton_Click(object sender, EventArgs e)
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
                Cuboid cuboid = new Cuboid(baseLength, height, width);
                showVolume.Text = "The volume is " + cuboid.calculateVolume().ToString();
                showArea.Text = "The area is " + cuboid.calculateArea().ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Input!", "Warning!");
                getBase.Text = "";
                getHeight.Text = "";
                getWidth.Text = "";
                showArea.Text = "";
                showVolume.Text = "";
            }
        }
    }
}
