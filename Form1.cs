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
            twoDimensionalButton.ForeColor = Color.White;
            twoDimensionalButton.Font = new Font(twoDimensionalButton.Font.FontFamily, 64);
        }

        private void twoDimensionalButton_MouseLeave(object sender, EventArgs e)
        {
            twoDimensionalButton.ForeColor = Color.MediumSpringGreen;
            twoDimensionalButton.Font = new Font(twoDimensionalButton.Font.FontFamily, 60);
        }

        private void threeDimensionalButton_MouseHover(object sender, EventArgs e)
        {
            threeDimensionalButton.ForeColor = Color.White;
            threeDimensionalButton.Font = new Font(twoDimensionalButton.Font.FontFamily, 64);
        }

        private void threeDimensionalButton_MouseLeave(object sender, EventArgs e)
        {
            threeDimensionalButton.ForeColor = Color.MediumSpringGreen;
            threeDimensionalButton.Font = new Font(twoDimensionalButton.Font.FontFamily, 60);
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
