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

        private void triangleLabel_Click(object sender, EventArgs e)
        {
            triangleForm tForm = new triangleForm();
            this.Visible = false;
            tForm.Show();
        }
    }
}
