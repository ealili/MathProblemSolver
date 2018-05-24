﻿namespace MathProblemSolver
{
    partial class SphereForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SphereForm));
            this.sphereBackButton = new System.Windows.Forms.Label();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.getRadius = new System.Windows.Forms.TextBox();
            this.showArea = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.showVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sphereBackButton
            // 
            this.sphereBackButton.AutoSize = true;
            this.sphereBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sphereBackButton.Location = new System.Drawing.Point(74, 132);
            this.sphereBackButton.Name = "sphereBackButton";
            this.sphereBackButton.Size = new System.Drawing.Size(86, 29);
            this.sphereBackButton.TabIndex = 0;
            this.sphereBackButton.Text = "< Back";
            this.sphereBackButton.Click += new System.EventHandler(this.sphereBackButton_Click);
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiusLabel.Location = new System.Drawing.Point(265, 287);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(187, 29);
            this.radiusLabel.TabIndex = 1;
            this.radiusLabel.Text = "Enter the radius ";
            // 
            // getRadius
            // 
            this.getRadius.Location = new System.Drawing.Point(503, 293);
            this.getRadius.Name = "getRadius";
            this.getRadius.Size = new System.Drawing.Size(100, 22);
            this.getRadius.TabIndex = 2;
            // 
            // showArea
            // 
            this.showArea.AutoSize = true;
            this.showArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showArea.Location = new System.Drawing.Point(265, 392);
            this.showArea.Name = "showArea";
            this.showArea.Size = new System.Drawing.Size(0, 29);
            this.showArea.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(745, 293);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(91, 29);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // showVolume
            // 
            this.showVolume.AutoSize = true;
            this.showVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showVolume.Location = new System.Drawing.Point(270, 466);
            this.showVolume.Name = "showVolume";
            this.showVolume.Size = new System.Drawing.Size(0, 29);
            this.showVolume.TabIndex = 5;
            // 
            // SphereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 600);
            this.Controls.Add(this.showVolume);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.showArea);
            this.Controls.Add(this.getRadius);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.sphereBackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1099, 647);
            this.MinimumSize = new System.Drawing.Size(1099, 647);
            this.Name = "SphereForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SphereForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sphereBackButton;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.TextBox getRadius;
        private System.Windows.Forms.Label showArea;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label showVolume;
    }
}