namespace MathProblemSolver
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
            this.sphereBackButton.Location = new System.Drawing.Point(56, 107);
            this.sphereBackButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sphereBackButton.Name = "sphereBackButton";
            this.sphereBackButton.Size = new System.Drawing.Size(67, 24);
            this.sphereBackButton.TabIndex = 0;
            this.sphereBackButton.Text = "< Back";
            this.sphereBackButton.Click += new System.EventHandler(this.sphereBackButton_Click);
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiusLabel.Location = new System.Drawing.Point(199, 233);
            this.radiusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(147, 24);
            this.radiusLabel.TabIndex = 1;
            this.radiusLabel.Text = "Enter the radius ";
            // 
            // getRadius
            // 
            this.getRadius.Location = new System.Drawing.Point(377, 238);
            this.getRadius.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getRadius.Name = "getRadius";
            this.getRadius.Size = new System.Drawing.Size(76, 20);
            this.getRadius.TabIndex = 2;
            // 
            // showArea
            // 
            this.showArea.AutoSize = true;
            this.showArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showArea.Location = new System.Drawing.Point(199, 318);
            this.showArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showArea.Name = "showArea";
            this.showArea.Size = new System.Drawing.Size(0, 24);
            this.showArea.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(559, 238);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(68, 24);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // showVolume
            // 
            this.showVolume.AutoSize = true;
            this.showVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showVolume.Location = new System.Drawing.Point(202, 379);
            this.showVolume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showVolume.Name = "showVolume";
            this.showVolume.Size = new System.Drawing.Size(0, 24);
            this.showVolume.TabIndex = 5;
            // 
            // SphereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 494);
            this.Controls.Add(this.showVolume);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.showArea);
            this.Controls.Add(this.getRadius);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.sphereBackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(828, 533);
            this.MinimumSize = new System.Drawing.Size(828, 533);
            this.Name = "SphereForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sphere";
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