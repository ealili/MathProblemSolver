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
    public partial class _2dForm : Form
    {
        public _2dForm()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            triangleForm triangleForm = new triangleForm();
            this.Hide();
            triangleForm.Show();
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            RectangleForm rectangleForm = new RectangleForm();
            this.Hide();
            rectangleForm.Show();
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            SquareForm squareForm = new SquareForm();
            this.Hide();
            squareForm.Show();
        }
    }
}
