namespace MathProblemSolver
{
    partial class RectangleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectangleForm));
            this.rectangleBackButton = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.baseLabel = new System.Windows.Forms.Label();
            this.sideLabel = new System.Windows.Forms.Label();
            this.getBase = new System.Windows.Forms.TextBox();
            this.getSide = new System.Windows.Forms.TextBox();
            this.showArea = new System.Windows.Forms.Label();
            this.showPerimeter = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rectangleBackButton
            // 
            this.rectangleBackButton.AutoSize = true;
            this.rectangleBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectangleBackButton.Location = new System.Drawing.Point(65, 90);
            this.rectangleBackButton.Name = "rectangleBackButton";
            this.rectangleBackButton.Size = new System.Drawing.Size(73, 24);
            this.rectangleBackButton.TabIndex = 0;
            this.rectangleBackButton.Text = "< Back";
            this.rectangleBackButton.Click += new System.EventHandler(this.rectangleBackButton_Click);
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(564, 233);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(119, 34);
            this.calcButton.TabIndex = 1;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabel.Location = new System.Drawing.Point(137, 215);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(128, 20);
            this.baseLabel.TabIndex = 2;
            this.baseLabel.Text = "Enter the base";
            // 
            // sideLabel
            // 
            this.sideLabel.AutoSize = true;
            this.sideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideLabel.Location = new System.Drawing.Point(138, 277);
            this.sideLabel.Name = "sideLabel";
            this.sideLabel.Size = new System.Drawing.Size(131, 24);
            this.sideLabel.TabIndex = 3;
            this.sideLabel.Text = "Enter the side ";
            // 
            // getBase
            // 
            this.getBase.Location = new System.Drawing.Point(319, 215);
            this.getBase.Name = "getBase";
            this.getBase.Size = new System.Drawing.Size(100, 20);
            this.getBase.TabIndex = 4;
            // 
            // getSide
            // 
            this.getSide.Location = new System.Drawing.Point(319, 277);
            this.getSide.Name = "getSide";
            this.getSide.Size = new System.Drawing.Size(100, 20);
            this.getSide.TabIndex = 5;
            // 
            // showArea
            // 
            this.showArea.AutoSize = true;
            this.showArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showArea.Location = new System.Drawing.Point(265, 358);
            this.showArea.Name = "showArea";
            this.showArea.Size = new System.Drawing.Size(0, 20);
            this.showArea.TabIndex = 6;
            // 
            // showPerimeter
            // 
            this.showPerimeter.AutoSize = true;
            this.showPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPerimeter.Location = new System.Drawing.Point(269, 405);
            this.showPerimeter.Name = "showPerimeter";
            this.showPerimeter.Size = new System.Drawing.Size(0, 20);
            this.showPerimeter.TabIndex = 7;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(329, 90);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(104, 24);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Rectangle";
            // 
            // RectangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 496);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.showPerimeter);
            this.Controls.Add(this.showArea);
            this.Controls.Add(this.getSide);
            this.Controls.Add(this.getBase);
            this.Controls.Add(this.sideLabel);
            this.Controls.Add(this.baseLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.rectangleBackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(829, 535);
            this.MinimumSize = new System.Drawing.Size(829, 535);
            this.Name = "RectangleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RectangleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rectangleBackButton;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label sideLabel;
        private System.Windows.Forms.TextBox getBase;
        private System.Windows.Forms.TextBox getSide;
        private System.Windows.Forms.Label showArea;
        private System.Windows.Forms.Label showPerimeter;
        private System.Windows.Forms.Label titleLabel;
    }
}