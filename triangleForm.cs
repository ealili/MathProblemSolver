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
    public partial class triangleForm : Form
    {
        public triangleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double baseLength, height;
            baseLength = double.Parse(getBase.Text);
            height = double.Parse(getHeight.Text);
            double area;
            area = baseLength * height / 2;
            showArea.Text = "The area is " + area.ToString();
        }
    }
}
