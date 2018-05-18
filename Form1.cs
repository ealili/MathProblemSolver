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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void twoDimensionalButton_MouseHover(object sender, EventArgs e)
        {
            twoDimensionalButton.Size = new Size(140, 160);
        }

        private void twoDimensionalButton_MouseLeave(object sender, EventArgs e)
        {
            twoDimensionalButton.Size = new Size(140, 140);
        }

        private void threeDimensionalButton_MouseHover(object sender, EventArgs e)
        {
            threeDimensionalButton.Size = new Size(140, 160);
        }

        private void threeDimensionalButton_MouseLeave(object sender, EventArgs e)
        {
            threeDimensionalButton.Size = new Size(140, 140);
        }

        private void twoDimensionalButton_Click(object sender, EventArgs e)
        {
            _2dForm twoD = new _2dForm();
            this.Hide();
            twoD.Show();
        }

        private void threeDimensionalButton_Click(object sender, EventArgs e)
        {
            _3dForm threeD = new _3dForm();
            this.Hide();
            threeD.Show();
        }
    }
}
