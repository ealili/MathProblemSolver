﻿namespace MathProblemSolver
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // squareBackButton
            // 
            this.squareBackButton.AutoSize = true;
            this.squareBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.squareBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareBackButton.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.squareBackButton.Location = new System.Drawing.Point(16, 148);
            this.squareBackButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.squareBackButton.Name = "squareBackButton";
            this.squareBackButton.Size = new System.Drawing.Size(86, 29);
            this.squareBackButton.TabIndex = 0;
            this.squareBackButton.Text = "< Back";
            this.squareBackButton.Click += new System.EventHandler(this.squareBackButton_Click);
            // 
            // squareSideLabel
            // 
            this.squareSideLabel.AutoSize = true;
            this.squareSideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareSideLabel.ForeColor = System.Drawing.Color.White;
            this.squareSideLabel.Location = new System.Drawing.Point(213, 297);
            this.squareSideLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.squareSideLabel.Name = "squareSideLabel";
            this.squareSideLabel.Size = new System.Drawing.Size(249, 25);
            this.squareSideLabel.TabIndex = 1;
            this.squareSideLabel.Text = "Enter the side of the square";
            // 
            // getBase
            // 
            this.getBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.getBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getBase.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.getBase.Location = new System.Drawing.Point(544, 295);
            this.getBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getBase.Name = "getBase";
            this.getBase.Size = new System.Drawing.Size(132, 27);
            this.getBase.TabIndex = 2;
            this.getBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.calcButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.calcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.ForeColor = System.Drawing.Color.White;
            this.calcButton.Location = new System.Drawing.Point(761, 295);
            this.calcButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(132, 27);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // showArea
            // 
            this.showArea.AutoSize = true;
            this.showArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showArea.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.showArea.Location = new System.Drawing.Point(215, 394);
            this.showArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showArea.Name = "showArea";
            this.showArea.Size = new System.Drawing.Size(0, 29);
            this.showArea.TabIndex = 4;
            // 
            // showPerimeter
            // 
            this.showPerimeter.AutoSize = true;
            this.showPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPerimeter.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.showPerimeter.Location = new System.Drawing.Point(215, 457);
            this.showPerimeter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showPerimeter.Name = "showPerimeter";
            this.showPerimeter.Size = new System.Drawing.Size(0, 29);
            this.showPerimeter.TabIndex = 5;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.titleLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.MaximumSize = new System.Drawing.Size(1080, 123);
            this.titleLabel.MinimumSize = new System.Drawing.Size(1080, 123);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1080, 123);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Square";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SquareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1077, 597);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.showPerimeter);
            this.Controls.Add(this.showArea);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.getBase);
            this.Controls.Add(this.squareSideLabel);
            this.Controls.Add(this.squareBackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1099, 648);
            this.MinimumSize = new System.Drawing.Size(1099, 648);
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
        private System.Windows.Forms.Label titleLabel;
    }
}