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
            this.titleLabel = new System.Windows.Forms.Label();
            this.choosingLabel = new System.Windows.Forms.Label();
            this.coneButton = new System.Windows.Forms.Button();
            this.cylinderButton = new System.Windows.Forms.Button();
            this.pyramidButton = new System.Windows.Forms.Button();
            this.sphereButton = new System.Windows.Forms.Button();
            this.cuboidButton = new System.Windows.Forms.Button();
            this.cubeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // threeDBackButton
            // 
            this.threeDBackButton.AutoSize = true;
            this.threeDBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.threeDBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeDBackButton.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.threeDBackButton.Location = new System.Drawing.Point(12, 120);
            this.threeDBackButton.Name = "threeDBackButton";
            this.threeDBackButton.Size = new System.Drawing.Size(67, 24);
            this.threeDBackButton.TabIndex = 0;
            this.threeDBackButton.Text = "< Back";
            this.threeDBackButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.threeDBackButton.Click += new System.EventHandler(this.threeDBackButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.titleLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.MinimumSize = new System.Drawing.Size(810, 100);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(810, 100);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "3D Shapes";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choosingLabel
            // 
            this.choosingLabel.AutoSize = true;
            this.choosingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosingLabel.ForeColor = System.Drawing.Color.White;
            this.choosingLabel.Location = new System.Drawing.Point(0, 150);
            this.choosingLabel.MinimumSize = new System.Drawing.Size(810, 20);
            this.choosingLabel.Name = "choosingLabel";
            this.choosingLabel.Size = new System.Drawing.Size(810, 20);
            this.choosingLabel.TabIndex = 9;
            this.choosingLabel.Text = "Choose the 3D shape below";
            this.choosingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coneButton
            // 
            this.coneButton.AutoSize = true;
            this.coneButton.FlatAppearance.BorderSize = 0;
            this.coneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coneButton.Image = global::MathProblemSolver.Properties.Resources._3D_cone_2nd;
            this.coneButton.Location = new System.Drawing.Point(125, 334);
            this.coneButton.Name = "coneButton";
            this.coneButton.Size = new System.Drawing.Size(102, 125);
            this.coneButton.TabIndex = 6;
            this.coneButton.UseVisualStyleBackColor = true;
            this.coneButton.Click += new System.EventHandler(this.coneButton_Click);
            // 
            // cylinderButton
            // 
            this.cylinderButton.AutoSize = true;
            this.cylinderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cylinderButton.FlatAppearance.BorderSize = 0;
            this.cylinderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cylinderButton.Image = global::MathProblemSolver.Properties.Resources._3D_cylinder_2nd;
            this.cylinderButton.Location = new System.Drawing.Point(585, 214);
            this.cylinderButton.Name = "cylinderButton";
            this.cylinderButton.Size = new System.Drawing.Size(101, 111);
            this.cylinderButton.TabIndex = 5;
            this.cylinderButton.UseVisualStyleBackColor = true;
            this.cylinderButton.Click += new System.EventHandler(this.cylinderButton_Click);
            // 
            // pyramidButton
            // 
            this.pyramidButton.AutoSize = true;
            this.pyramidButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pyramidButton.FlatAppearance.BorderSize = 0;
            this.pyramidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pyramidButton.Image = global::MathProblemSolver.Properties.Resources._3D_squareBasedPyramid_2nd;
            this.pyramidButton.Location = new System.Drawing.Point(570, 331);
            this.pyramidButton.Name = "pyramidButton";
            this.pyramidButton.Size = new System.Drawing.Size(134, 131);
            this.pyramidButton.TabIndex = 4;
            this.pyramidButton.UseVisualStyleBackColor = true;
            this.pyramidButton.Click += new System.EventHandler(this.pyramidButton_Click);
            // 
            // sphereButton
            // 
            this.sphereButton.AutoSize = true;
            this.sphereButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sphereButton.FlatAppearance.BorderSize = 0;
            this.sphereButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sphereButton.Image = global::MathProblemSolver.Properties.Resources._3D_sphere_2nd;
            this.sphereButton.Location = new System.Drawing.Point(348, 348);
            this.sphereButton.Name = "sphereButton";
            this.sphereButton.Size = new System.Drawing.Size(110, 111);
            this.sphereButton.TabIndex = 3;
            this.sphereButton.UseVisualStyleBackColor = true;
            this.sphereButton.Click += new System.EventHandler(this.sphereButton_Click);
            // 
            // cuboidButton
            // 
            this.cuboidButton.AutoSize = true;
            this.cuboidButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuboidButton.FlatAppearance.BorderSize = 0;
            this.cuboidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuboidButton.Image = global::MathProblemSolver.Properties.Resources._3D_cuboid_2nd;
            this.cuboidButton.Location = new System.Drawing.Point(339, 217);
            this.cuboidButton.Name = "cuboidButton";
            this.cuboidButton.Size = new System.Drawing.Size(128, 108);
            this.cuboidButton.TabIndex = 2;
            this.cuboidButton.UseVisualStyleBackColor = true;
            this.cuboidButton.Click += new System.EventHandler(this.cuboidButton_Click);
            // 
            // cubeButton
            // 
            this.cubeButton.AutoSize = true;
            this.cubeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cubeButton.FlatAppearance.BorderSize = 0;
            this.cubeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cubeButton.Image = global::MathProblemSolver.Properties.Resources._3D_cube_2nd;
            this.cubeButton.Location = new System.Drawing.Point(125, 217);
            this.cubeButton.Name = "cubeButton";
            this.cubeButton.Size = new System.Drawing.Size(111, 111);
            this.cubeButton.TabIndex = 1;
            this.cubeButton.UseVisualStyleBackColor = true;
            this.cubeButton.Click += new System.EventHandler(this.cubeButton_Click);
            // 
            // _3dForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(808, 491);
            this.Controls.Add(this.choosingLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.coneButton);
            this.Controls.Add(this.cylinderButton);
            this.Controls.Add(this.pyramidButton);
            this.Controls.Add(this.sphereButton);
            this.Controls.Add(this.cuboidButton);
            this.Controls.Add(this.cubeButton);
            this.Controls.Add(this.threeDBackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(828, 534);
            this.MinimumSize = new System.Drawing.Size(828, 534);
            this.Name = "_3dForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3D Shapes";
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
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label choosingLabel;
    }
}