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
            System.Windows.Forms.Label choosingLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_2dForm));
            this.twoDBackButton = new System.Windows.Forms.Label();
            this.triangleButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.trapezoidButton = new System.Windows.Forms.Button();
            this.parallelogramButton = new System.Windows.Forms.Button();
            choosingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // choosingLabel
            // 
            choosingLabel.AutoSize = true;
            choosingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            choosingLabel.Location = new System.Drawing.Point(276, 84);
            choosingLabel.Name = "choosingLabel";
            choosingLabel.Size = new System.Drawing.Size(234, 20);
            choosingLabel.TabIndex = 0;
            choosingLabel.Text = "Choose the 2D shape below";
            // 
            // twoDBackButton
            // 
            this.twoDBackButton.AutoSize = true;
            this.twoDBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twoDBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoDBackButton.Location = new System.Drawing.Point(12, 18);
            this.twoDBackButton.Name = "twoDBackButton";
            this.twoDBackButton.Size = new System.Drawing.Size(73, 24);
            this.twoDBackButton.TabIndex = 7;
            this.twoDBackButton.Text = "< Back";
            this.twoDBackButton.Click += new System.EventHandler(this.label2_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triangleButton.Location = new System.Drawing.Point(350, 206);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(75, 23);
            this.triangleButton.TabIndex = 8;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(116, 205);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(75, 23);
            this.squareButton.TabIndex = 9;
            this.squareButton.Text = "Square";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(578, 205);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(75, 23);
            this.rectangleButton.TabIndex = 10;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(116, 377);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(75, 23);
            this.circleButton.TabIndex = 11;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // trapezoidButton
            // 
            this.trapezoidButton.Location = new System.Drawing.Point(350, 377);
            this.trapezoidButton.Name = "trapezoidButton";
            this.trapezoidButton.Size = new System.Drawing.Size(75, 23);
            this.trapezoidButton.TabIndex = 12;
            this.trapezoidButton.Text = "Trapezoid";
            this.trapezoidButton.UseVisualStyleBackColor = true;
            this.trapezoidButton.Click += new System.EventHandler(this.trapezoidButton_Click);
            // 
            // parallelogramButton
            // 
            this.parallelogramButton.Location = new System.Drawing.Point(578, 377);
            this.parallelogramButton.Name = "parallelogramButton";
            this.parallelogramButton.Size = new System.Drawing.Size(84, 23);
            this.parallelogramButton.TabIndex = 13;
            this.parallelogramButton.Text = "Parallelogram";
            this.parallelogramButton.UseVisualStyleBackColor = true;
            // 
            // _2dForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 496);
            this.Controls.Add(this.parallelogramButton);
            this.Controls.Add(this.trapezoidButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.twoDBackButton);
            this.Controls.Add(choosingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(829, 535);
            this.MinimumSize = new System.Drawing.Size(829, 535);
            this.Name = "_2dForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_2dForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label twoDBackButton;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button trapezoidButton;
        private System.Windows.Forms.Button parallelogramButton;
    }
}