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
    public partial class _3dForm : Form
    {
        public _3dForm()
        {
            InitializeComponent();
        }

        private void threeDBackButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void cubeButton_Click(object sender, EventArgs e)
        {
            CubeForm cubeForm = new CubeForm();
            this.Hide();
            cubeForm.Show();
        }

        private void cuboidButton_Click(object sender, EventArgs e)
        {
            CuboidForm cuboidForm = new CuboidForm();
            this.Hide();
            cuboidForm.Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cylinderButton_Click(object sender, EventArgs e)
        {
            CylinderForm cylinderForm = new CylinderForm();
            this.Hide();
            cylinderForm.Show();
        }

        private void coneButton_Click(object sender, EventArgs e)
        {
            ConeForm coneForm = new ConeForm();
            this.Hide();
            coneForm.Show();
        }

        private void sphereButton_Click(object sender, EventArgs e)
        {
            SphereForm sphereForm = new SphereForm();
            this.Hide();
            sphereForm.Show();
        }
    }
}
