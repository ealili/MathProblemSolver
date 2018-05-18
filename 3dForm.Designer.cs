namespace MathProblemSolver
{
    partial class _3dForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_3dForm));
            this.threeDBackButton = new System.Windows.Forms.Label();
            this.cubeButton = new System.Windows.Forms.Button();
            this.cuboidButton = new System.Windows.Forms.Button();
            this.sphereButton = new System.Windows.Forms.Button();
            this.pyramidButton = new System.Windows.Forms.Button();
            this.cylinderButton = new System.Windows.Forms.Button();
            this.coneButton = new System.Windows.Forms.Button();
            this.threeDShapes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // threeDBackButton
            // 
            this.threeDBackButton.AutoSize = true;
            this.threeDBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.threeDBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeDBackButton.Location = new System.Drawing.Point(73, 108);
            this.threeDBackButton.Name = "threeDBackButton";
            this.threeDBackButton.Size = new System.Drawing.Size(73, 24);
            this.threeDBackButton.TabIndex = 0;
            this.threeDBackButton.Text = "< Back";
            this.threeDBackButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.threeDBackButton.Click += new System.EventHandler(this.threeDBackButton_Click);
            // 
            // cubeButton
            // 
            this.cubeButton.Location = new System.Drawing.Point(149, 229);
            this.cubeButton.Name = "cubeButton";
            this.cubeButton.Size = new System.Drawing.Size(75, 23);
            this.cubeButton.TabIndex = 1;
            this.cubeButton.Text = "Cube";
            this.cubeButton.UseVisualStyleBackColor = true;
            this.cubeButton.Click += new System.EventHandler(this.cubeButton_Click);
            // 
            // cuboidButton
            // 
            this.cuboidButton.Location = new System.Drawing.Point(358, 229);
            this.cuboidButton.Name = "cuboidButton";
            this.cuboidButton.Size = new System.Drawing.Size(75, 23);
            this.cuboidButton.TabIndex = 2;
            this.cuboidButton.Text = "Cuboid";
            this.cuboidButton.UseVisualStyleBackColor = true;
            this.cuboidButton.Click += new System.EventHandler(this.cuboidButton_Click);
            // 
            // sphereButton
            // 
            this.sphereButton.Location = new System.Drawing.Point(358, 343);
            this.sphereButton.Name = "sphereButton";
            this.sphereButton.Size = new System.Drawing.Size(75, 23);
            this.sphereButton.TabIndex = 3;
            this.sphereButton.Text = "Sphere";
            this.sphereButton.UseVisualStyleBackColor = true;
            // 
            // pyramidButton
            // 
            this.pyramidButton.Location = new System.Drawing.Point(585, 343);
            this.pyramidButton.Name = "pyramidButton";
            this.pyramidButton.Size = new System.Drawing.Size(75, 23);
            this.pyramidButton.TabIndex = 4;
            this.pyramidButton.Text = "Pyramid";
            this.pyramidButton.UseVisualStyleBackColor = true;
            // 
            // cylinderButton
            // 
            this.cylinderButton.Location = new System.Drawing.Point(585, 229);
            this.cylinderButton.Name = "cylinderButton";
            this.cylinderButton.Size = new System.Drawing.Size(75, 23);
            this.cylinderButton.TabIndex = 5;
            this.cylinderButton.Text = "Cylinder";
            this.cylinderButton.UseVisualStyleBackColor = true;
            // 
            // coneButton
            // 
            this.coneButton.Location = new System.Drawing.Point(149, 343);
            this.coneButton.Name = "coneButton";
            this.coneButton.Size = new System.Drawing.Size(75, 23);
            this.coneButton.TabIndex = 6;
            this.coneButton.Text = "Cone";
            this.coneButton.UseVisualStyleBackColor = true;
            // 
            // threeDShapes
            // 
            this.threeDShapes.AutoSize = true;
            this.threeDShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeDShapes.Location = new System.Drawing.Point(345, 85);
            this.threeDShapes.Name = "threeDShapes";
            this.threeDShapes.Size = new System.Drawing.Size(111, 24);
            this.threeDShapes.TabIndex = 7;
            this.threeDShapes.Text = "3D Shapes";
            // 
            // _3dForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 496);
            this.Controls.Add(this.threeDShapes);
            this.Controls.Add(this.coneButton);
            this.Controls.Add(this.cylinderButton);
            this.Controls.Add(this.pyramidButton);
            this.Controls.Add(this.sphereButton);
            this.Controls.Add(this.cuboidButton);
            this.Controls.Add(this.cubeButton);
            this.Controls.Add(this.threeDBackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(829, 535);
            this.MinimumSize = new System.Drawing.Size(829, 535);
            this.Name = "_3dForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_3dForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label threeDBackButton;
        private System.Windows.Forms.Button cubeButton;
        private System.Windows.Forms.Button cuboidButton;
        private System.Windows.Forms.Button sphereButton;
        private System.Windows.Forms.Button pyramidButton;
        private System.Windows.Forms.Button cylinderButton;
        private System.Windows.Forms.Button coneButton;
        private System.Windows.Forms.Label threeDShapes;
    }
}