namespace MathProblemSolver
{
    partial class SquareForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SquareForm));
            this.squareBackButton = new System.Windows.Forms.Label();
            this.squareSideLabel = new System.Windows.Forms.Label();
            this.getBase = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.showArea = new System.Windows.Forms.Label();
            this.showPerimeter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // squareBackButton
            // 
            this.squareBackButton.AutoSize = true;
            this.squareBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.squareBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareBackButton.Location = new System.Drawing.Point(58, 115);
            this.squareBackButton.Name = "squareBackButton";
            this.squareBackButton.Size = new System.Drawing.Size(73, 24);
            this.squareBackButton.TabIndex = 0;
            this.squareBackButton.Text = "< Back";
            this.squareBackButton.Click += new System.EventHandler(this.squareBackButton_Click);
            // 
            // squareSideLabel
            // 
            this.squareSideLabel.AutoSize = true;
            this.squareSideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareSideLabel.Location = new System.Drawing.Point(157, 243);
            this.squareSideLabel.Name = "squareSideLabel";
            this.squareSideLabel.Size = new System.Drawing.Size(206, 20);
            this.squareSideLabel.TabIndex = 1;
            this.squareSideLabel.Text = "Enter the side of the square";
            // 
            // getBase
            // 
            this.getBase.Location = new System.Drawing.Point(429, 242);
            this.getBase.Name = "getBase";
            this.getBase.Size = new System.Drawing.Size(100, 20);
            this.getBase.TabIndex = 2;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(572, 242);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(124, 23);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // showArea
            // 
            this.showArea.AutoSize = true;
            this.showArea.Location = new System.Drawing.Point(161, 320);
            this.showArea.Name = "showArea";
            this.showArea.Size = new System.Drawing.Size(0, 13);
            this.showArea.TabIndex = 4;
            // 
            // showPerimeter
            // 
            this.showPerimeter.AutoSize = true;
            this.showPerimeter.Location = new System.Drawing.Point(161, 371);
            this.showPerimeter.Name = "showPerimeter";
            this.showPerimeter.Size = new System.Drawing.Size(0, 13);
            this.showPerimeter.TabIndex = 5;
            // 
            // SquareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 496);
            this.Controls.Add(this.showPerimeter);
            this.Controls.Add(this.showArea);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.getBase);
            this.Controls.Add(this.squareSideLabel);
            this.Controls.Add(this.squareBackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(829, 535);
            this.MinimumSize = new System.Drawing.Size(829, 535);
            this.Name = "SquareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SquareForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label squareBackButton;
        private System.Windows.Forms.Label squareSideLabel;
        private System.Windows.Forms.TextBox getBase;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label showArea;
        private System.Windows.Forms.Label showPerimeter;
    }
}