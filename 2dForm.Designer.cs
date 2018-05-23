﻿namespace MathProblemSolver
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
            this.titleLabel = new System.Windows.Forms.Label();
            choosingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // choosingLabel
            // 
            choosingLabel.AutoSize = true;
            choosingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            choosingLabel.ForeColor = System.Drawing.Color.White;
            choosingLabel.Location = new System.Drawing.Point(0, 185);
            choosingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            choosingLabel.MinimumSize = new System.Drawing.Size(1080, 25);
            choosingLabel.Name = "choosingLabel";
            choosingLabel.Size = new System.Drawing.Size(1080, 25);
            choosingLabel.TabIndex = 0;
            choosingLabel.Text = "Choose the 2D shape below";
            choosingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twoDBackButton
            // 
            this.twoDBackButton.AutoSize = true;
            this.twoDBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twoDBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoDBackButton.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.twoDBackButton.Location = new System.Drawing.Point(16, 148);
            this.twoDBackButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.twoDBackButton.Name = "twoDBackButton";
            this.twoDBackButton.Size = new System.Drawing.Size(86, 29);
            this.twoDBackButton.TabIndex = 7;
            this.twoDBackButton.Text = "< Back";
            this.twoDBackButton.Click += new System.EventHandler(this.label2_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triangleButton.Location = new System.Drawing.Point(480, 310);
            this.triangleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(100, 28);
            this.triangleButton.TabIndex = 8;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(155, 311);
            this.squareButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(100, 28);
            this.squareButton.TabIndex = 9;
            this.squareButton.Text = "Square";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(771, 311);
            this.rectangleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(100, 28);
            this.rectangleButton.TabIndex = 10;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(155, 464);
            this.circleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(100, 28);
            this.circleButton.TabIndex = 11;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // trapezoidButton
            // 
            this.trapezoidButton.Location = new System.Drawing.Point(480, 464);
            this.trapezoidButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trapezoidButton.Name = "trapezoidButton";
            this.trapezoidButton.Size = new System.Drawing.Size(100, 28);
            this.trapezoidButton.TabIndex = 12;
            this.trapezoidButton.Text = "Trapezoid";
            this.trapezoidButton.UseVisualStyleBackColor = true;
            this.trapezoidButton.Click += new System.EventHandler(this.trapezoidButton_Click);
            // 
            // parallelogramButton
            // 
            this.parallelogramButton.Location = new System.Drawing.Point(771, 464);
            this.parallelogramButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parallelogramButton.Name = "parallelogramButton";
            this.parallelogramButton.Size = new System.Drawing.Size(112, 28);
            this.parallelogramButton.TabIndex = 13;
            this.parallelogramButton.Text = "Parallelogram";
            this.parallelogramButton.UseVisualStyleBackColor = true;
            this.parallelogramButton.Click += new System.EventHandler(this.parallelogramButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.titleLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.MinimumSize = new System.Drawing.Size(1080, 123);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1080, 123);
            this.titleLabel.TabIndex = 15;
            this.titleLabel.Text = "2D Shapes";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _2dForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1077, 596);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.parallelogramButton);
            this.Controls.Add(this.trapezoidButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.twoDBackButton);
            this.Controls.Add(choosingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1099, 647);
            this.MinimumSize = new System.Drawing.Size(1099, 647);
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
        private System.Windows.Forms.Label titleLabel;
    }
}