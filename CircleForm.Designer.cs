namespace MathProblemSolver
{
    partial class CircleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CircleForm));
            this.circleBackLabel = new System.Windows.Forms.Label();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.getRadius = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.showArea = new System.Windows.Forms.Label();
            this.showPerimeter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // circleBackLabel
            // 
            this.circleBackLabel.AutoSize = true;
            this.circleBackLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circleBackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleBackLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.circleBackLabel.Location = new System.Drawing.Point(12, 120);
            this.circleBackLabel.Name = "circleBackLabel";
            this.circleBackLabel.Size = new System.Drawing.Size(67, 24);
            this.circleBackLabel.TabIndex = 0;
            this.circleBackLabel.Text = "< Back";
            this.circleBackLabel.Click += new System.EventHandler(this.circleBackLabel_Click);
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiusLabel.ForeColor = System.Drawing.Color.White;
            this.radiusLabel.Location = new System.Drawing.Point(174, 240);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(122, 20);
            this.radiusLabel.TabIndex = 1;
            this.radiusLabel.Text = "Enter the radius";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.titleLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.MaximumSize = new System.Drawing.Size(810, 100);
            this.titleLabel.MinimumSize = new System.Drawing.Size(810, 100);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleLabel.Size = new System.Drawing.Size(810, 100);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Circle";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getRadius
            // 
            this.getRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.getRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getRadius.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.getRadius.Location = new System.Drawing.Point(354, 238);
            this.getRadius.MinimumSize = new System.Drawing.Size(100, 27);
            this.getRadius.Name = "getRadius";
            this.getRadius.Size = new System.Drawing.Size(100, 23);
            this.getRadius.TabIndex = 3;
            this.getRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculateButton
            // 
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(545, 236);
            this.calculateButton.MinimumSize = new System.Drawing.Size(105, 24);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(105, 24);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // showArea
            // 
            this.showArea.AutoSize = true;
            this.showArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showArea.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.showArea.Location = new System.Drawing.Point(174, 316);
            this.showArea.Name = "showArea";
            this.showArea.Size = new System.Drawing.Size(0, 24);
            this.showArea.TabIndex = 5;
            // 
            // showPerimeter
            // 
            this.showPerimeter.AutoSize = true;
            this.showPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPerimeter.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.showPerimeter.Location = new System.Drawing.Point(174, 364);
            this.showPerimeter.Name = "showPerimeter";
            this.showPerimeter.Size = new System.Drawing.Size(0, 24);
            this.showPerimeter.TabIndex = 6;
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(812, 495);
            this.Controls.Add(this.showPerimeter);
            this.Controls.Add(this.showArea);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.getRadius);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.circleBackLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(828, 534);
            this.MinimumSize = new System.Drawing.Size(828, 534);
            this.Name = "CircleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label circleBackLabel;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox getRadius;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label showArea;
        private System.Windows.Forms.Label showPerimeter;
    }
}