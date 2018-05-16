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
    public partial class SquareForm : Form
    {
        public SquareForm()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            
        }

        private void squareBackButton_Click(object sender, EventArgs e)
        {
            _2dForm twoD = new _2dForm();
            this.Hide();
            twoD.Show();
        }
    }
}
