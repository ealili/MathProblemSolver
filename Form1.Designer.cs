namespace MathProblemSolver
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.shapeChoosingLabel = new System.Windows.Forms.Label();
            this.twoDimensionalButton = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.threeDimensionalButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(432, 45);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(238, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "MathProblemSolver";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeChoosingLabel
            // 
            this.shapeChoosingLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeChoosingLabel.Location = new System.Drawing.Point(1, 184);
            this.shapeChoosingLabel.Name = "shapeChoosingLabel";
            this.shapeChoosingLabel.Size = new System.Drawing.Size(1083, 24);
            this.shapeChoosingLabel.TabIndex = 1;
            this.shapeChoosingLabel.Text = "Choose the type below";
            this.shapeChoosingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twoDimensionalButton
            // 
            this.twoDimensionalButton.AutoSize = true;
            this.twoDimensionalButton.BackColor = System.Drawing.Color.Transparent;
            this.twoDimensionalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.twoDimensionalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twoDimensionalButton.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.twoDimensionalButton.FlatAppearance.BorderSize = 0;
            this.twoDimensionalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.twoDimensionalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoDimensionalButton.Image = ((System.Drawing.Image)(resources.GetObject("twoDimensionalButton.Image")));
            this.twoDimensionalButton.Location = new System.Drawing.Point(354, 275);
            this.twoDimensionalButton.Name = "twoDimensionalButton";
            this.twoDimensionalButton.Size = new System.Drawing.Size(146, 146);
            this.twoDimensionalButton.TabIndex = 2;
            this.twoDimensionalButton.UseVisualStyleBackColor = false;
            this.twoDimensionalButton.MouseLeave += new System.EventHandler(this.twoDimensionalButton_MouseLeave);
            this.twoDimensionalButton.MouseHover += new System.EventHandler(this.twoDimensionalButton_MouseHover);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.DimGray;
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Location = new System.Drawing.Point(1, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1083, 120);
            this.headerPanel.TabIndex = 4;
            // 
            // threeDimensionalButton
            // 
            this.threeDimensionalButton.AutoSize = true;
            this.threeDimensionalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.threeDimensionalButton.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.threeDimensionalButton.FlatAppearance.BorderSize = 0;
            this.threeDimensionalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.threeDimensionalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeDimensionalButton.Image = ((System.Drawing.Image)(resources.GetObject("threeDimensionalButton.Image")));
            this.threeDimensionalButton.Location = new System.Drawing.Point(554, 275);
            this.threeDimensionalButton.Name = "threeDimensionalButton";
            this.threeDimensionalButton.Size = new System.Drawing.Size(146, 146);
            this.threeDimensionalButton.TabIndex = 3;
            this.threeDimensionalButton.UseVisualStyleBackColor = true;
            this.threeDimensionalButton.MouseLeave += new System.EventHandler(this.threeDimensionalButton_MouseLeave);
            this.threeDimensionalButton.MouseHover += new System.EventHandler(this.threeDimensionalButton_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 140);
            this.label1.TabIndex = 5;
            this.label1.Text = "Square\r\nTriangle\r\nRectangle\r\nParallelogram\r\nTrapezoid\r\nPentagon\r\nCircle";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(760, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 120);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cube \r\nCuboid\r\nCylinder\r\nSquare Pyramid\r\nSphere\r\nCone\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.threeDimensionalButton);
            this.Controls.Add(this.twoDimensionalButton);
            this.Controls.Add(this.shapeChoosingLabel);
            this.MaximumSize = new System.Drawing.Size(1100, 650);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MathProblemSolver";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label shapeChoosingLabel;
        private System.Windows.Forms.Button twoDimensionalButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button threeDimensionalButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

