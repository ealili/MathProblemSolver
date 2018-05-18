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
    public partial class CubeForm : Form
    {
        public CubeForm()
        {
            InitializeComponent();
        }

        private void cubeBackButton_Click(object sender, EventArgs e)
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
                Cube cube = new Cube(baseLength);
                showVolume.Text = "The volume is " + cube.calculateVolume().ToString();
                showArea.Text = "The area is " + cube.calculateArea().ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Input!", "Warning");
                showVolume.Text = "";
                showArea.Text = "";
                getBase.Text = "";
            }
        }
    }
}
