namespace MathProblemSolver
{
    partial class ConeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConeForm));
            this.radiusLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.getRadius = new System.Windows.Forms.TextBox();
            this.getHeight = new System.Windows.Forms.TextBox();
            this.showArea = new System.Windows.Forms.Label();
            this.showVolume = new System.Windows.Forms.Label();
            this.coneBackButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiusLabel.Location = new System.Drawing.Point(220, 198);
            this.radiusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(142, 24);
            this.radiusLabel.TabIndex = 0;
            this.radiusLabel.Text = "Enter the radius";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(220, 240);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(143, 24);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Enter the height";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(552, 213);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(74, 31);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // getRadius
            // 
            this.getRadius.Location = new System.Drawing.Point(404, 203);
            this.getRadius.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getRadius.Name = "getRadius";
            this.getRadius.Size = new System.Drawing.Size(76, 20);
            this.getRadius.TabIndex = 3;
            // 
            // getHeight
            // 
            this.getHeight.Location = new System.Drawing.Point(404, 245);
            this.getHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getHeight.Name = "getHeight";
            this.getHeight.Size = new System.Drawing.Size(76, 20);
            this.getHeight.TabIndex = 4;
            // 
            // showArea
            // 
            this.showArea.AutoSize = true;
            this.showArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showArea.Location = new System.Drawing.Point(221, 335);
            this.showArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showArea.Name = "showArea";
            this.showArea.Size = new System.Drawing.Size(0, 24);
            this.showArea.TabIndex = 5;
            // 
            // showVolume
            // 
            this.showVolume.AutoSize = true;
            this.showVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showVolume.Location = new System.Drawing.Point(221, 386);
            this.showVolume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showVolume.Name = "showVolume";
            this.showVolume.Size = new System.Drawing.Size(0, 24);
            this.showVolume.TabIndex = 6;
            // 
            // coneBackButton
            // 
            this.coneBackButton.AutoSize = true;
            this.coneBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coneBackButton.Location = new System.Drawing.Point(56, 107);
            this.coneBackButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coneBackButton.Name = "coneBackButton";
            this.coneBackButton.Size = new System.Drawing.Size(67, 24);
            this.coneBackButton.TabIndex = 7;
            this.coneBackButton.Text = "< Back";
            this.coneBackButton.Click += new System.EventHandler(this.coneBackButton_Click);
            // 
            // ConeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 491);
            this.Controls.Add(this.coneBackButton);
            this.Controls.Add(this.showVolume);
            this.Controls.Add(this.showArea);
            this.Controls.Add(this.getHeight);
            this.Controls.Add(this.getRadius);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.radiusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(829, 534);
            this.MinimumSize = new System.Drawing.Size(829, 534);
            this.Name = "ConeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox getRadius;
        private System.Windows.Forms.TextBox getHeight;
        private System.Windows.Forms.Label showArea;
        private System.Windows.Forms.Label showVolume;
        private System.Windows.Forms.Label coneBackButton;
    }
}