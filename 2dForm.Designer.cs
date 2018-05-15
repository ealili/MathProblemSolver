namespace MathProblemSolver
{
    partial class _2dForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_2dForm));
            this.label1 = new System.Windows.Forms.Label();
            this.squareLabel = new System.Windows.Forms.Label();
            this.triangleLabel = new System.Windows.Forms.Label();
            this.rectangleLabel = new System.Windows.Forms.Label();
            this.circleLabel = new System.Windows.Forms.Label();
            this.trapezoidLabel = new System.Windows.Forms.Label();
            this.parallelogramLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the 2D shape below";
            // 
            // squareLabel
            // 
            this.squareLabel.AutoSize = true;
            this.squareLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.squareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareLabel.Location = new System.Drawing.Point(101, 171);
            this.squareLabel.Name = "squareLabel";
            this.squareLabel.Size = new System.Drawing.Size(67, 20);
            this.squareLabel.TabIndex = 1;
            this.squareLabel.Text = "Square";
            // 
            // triangleLabel
            // 
            this.triangleLabel.AutoSize = true;
            this.triangleLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triangleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triangleLabel.Location = new System.Drawing.Point(346, 171);
            this.triangleLabel.Name = "triangleLabel";
            this.triangleLabel.Size = new System.Drawing.Size(73, 20);
            this.triangleLabel.TabIndex = 2;
            this.triangleLabel.Text = "Triangle";
            this.triangleLabel.Click += new System.EventHandler(this.triangleLabel_Click);
            // 
            // rectangleLabel
            // 
            this.rectangleLabel.AutoSize = true;
            this.rectangleLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectangleLabel.Location = new System.Drawing.Point(609, 171);
            this.rectangleLabel.Name = "rectangleLabel";
            this.rectangleLabel.Size = new System.Drawing.Size(91, 20);
            this.rectangleLabel.TabIndex = 3;
            this.rectangleLabel.Text = "Rectangle";
            // 
            // circleLabel
            // 
            this.circleLabel.AutoSize = true;
            this.circleLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleLabel.Location = new System.Drawing.Point(101, 381);
            this.circleLabel.Name = "circleLabel";
            this.circleLabel.Size = new System.Drawing.Size(54, 20);
            this.circleLabel.TabIndex = 4;
            this.circleLabel.Text = "Circle";
            this.circleLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // trapezoidLabel
            // 
            this.trapezoidLabel.AutoSize = true;
            this.trapezoidLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trapezoidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trapezoidLabel.Location = new System.Drawing.Point(346, 381);
            this.trapezoidLabel.Name = "trapezoidLabel";
            this.trapezoidLabel.Size = new System.Drawing.Size(88, 20);
            this.trapezoidLabel.TabIndex = 5;
            this.trapezoidLabel.Text = "Trapezoid";
            // 
            // parallelogramLabel
            // 
            this.parallelogramLabel.AutoSize = true;
            this.parallelogramLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parallelogramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parallelogramLabel.Location = new System.Drawing.Point(609, 381);
            this.parallelogramLabel.Name = "parallelogramLabel";
            this.parallelogramLabel.Size = new System.Drawing.Size(118, 20);
            this.parallelogramLabel.TabIndex = 6;
            this.parallelogramLabel.Text = "Parallelogram";
            // 
            // _2dForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 496);
            this.Controls.Add(this.parallelogramLabel);
            this.Controls.Add(this.trapezoidLabel);
            this.Controls.Add(this.circleLabel);
            this.Controls.Add(this.rectangleLabel);
            this.Controls.Add(this.triangleLabel);
            this.Controls.Add(this.squareLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(829, 535);
            this.MinimumSize = new System.Drawing.Size(829, 535);
            this.Name = "_2dForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_2dForm";
            this.Load += new System.EventHandler(this._2dForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label squareLabel;
        private System.Windows.Forms.Label triangleLabel;
        private System.Windows.Forms.Label rectangleLabel;
        private System.Windows.Forms.Label circleLabel;
        private System.Windows.Forms.Label trapezoidLabel;
        private System.Windows.Forms.Label parallelogramLabel;
    }
}