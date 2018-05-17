namespace MathProblemSolver
{
    partial class TrapezoidForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrapezoidForm));
            this.trapezoidBackButton = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.baseLabel = new System.Windows.Forms.Label();
            this.side1Label = new System.Windows.Forms.Label();
            this.side2Label = new System.Windows.Forms.Label();
            this.side3Label = new System.Windows.Forms.Label();
            this.getBase = new System.Windows.Forms.TextBox();
            this.getSide1 = new System.Windows.Forms.TextBox();
            this.getSide2 = new System.Windows.Forms.TextBox();
            this.getSide3 = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.showArea = new System.Windows.Forms.Label();
            this.showPerimeter = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.getHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // trapezoidBackButton
            // 
            this.trapezoidBackButton.AutoSize = true;
            this.trapezoidBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trapezoidBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trapezoidBackButton.Location = new System.Drawing.Point(101, 92);
            this.trapezoidBackButton.Name = "trapezoidBackButton";
            this.trapezoidBackButton.Size = new System.Drawing.Size(73, 24);
            this.trapezoidBackButton.TabIndex = 0;
            this.trapezoidBackButton.Text = "< Back";
            this.trapezoidBackButton.Click += new System.EventHandler(this.trapezoidBackButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(383, 59);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(104, 24);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Trapezoid";
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(176, 145);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(76, 13);
            this.baseLabel.TabIndex = 2;
            this.baseLabel.Text = "Enter the base";
            // 
            // side1Label
            // 
            this.side1Label.AutoSize = true;
            this.side1Label.Location = new System.Drawing.Point(176, 184);
            this.side1Label.Name = "side1Label";
            this.side1Label.Size = new System.Drawing.Size(60, 13);
            this.side1Label.TabIndex = 3;
            this.side1Label.Text = "Enter side1";
            // 
            // side2Label
            // 
            this.side2Label.AutoSize = true;
            this.side2Label.Location = new System.Drawing.Point(176, 219);
            this.side2Label.Name = "side2Label";
            this.side2Label.Size = new System.Drawing.Size(78, 13);
            this.side2Label.TabIndex = 4;
            this.side2Label.Text = "Enter the side2";
            // 
            // side3Label
            // 
            this.side3Label.AutoSize = true;
            this.side3Label.Location = new System.Drawing.Point(176, 248);
            this.side3Label.Name = "side3Label";
            this.side3Label.Size = new System.Drawing.Size(81, 13);
            this.side3Label.TabIndex = 5;
            this.side3Label.Text = "Enter the side 3";
            // 
            // getBase
            // 
            this.getBase.Location = new System.Drawing.Point(387, 145);
            this.getBase.Name = "getBase";
            this.getBase.Size = new System.Drawing.Size(100, 20);
            this.getBase.TabIndex = 6;
            // 
            // getSide1
            // 
            this.getSide1.Location = new System.Drawing.Point(387, 184);
            this.getSide1.Name = "getSide1";
            this.getSide1.Size = new System.Drawing.Size(100, 20);
            this.getSide1.TabIndex = 7;
            // 
            // getSide2
            // 
            this.getSide2.Location = new System.Drawing.Point(387, 219);
            this.getSide2.Name = "getSide2";
            this.getSide2.Size = new System.Drawing.Size(100, 20);
            this.getSide2.TabIndex = 8;
            // 
            // getSide3
            // 
            this.getSide3.Location = new System.Drawing.Point(387, 248);
            this.getSide3.Name = "getSide3";
            this.getSide3.Size = new System.Drawing.Size(100, 20);
            this.getSide3.TabIndex = 9;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(590, 191);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(114, 41);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // showArea
            // 
            this.showArea.AutoSize = true;
            this.showArea.Location = new System.Drawing.Point(174, 359);
            this.showArea.Name = "showArea";
            this.showArea.Size = new System.Drawing.Size(0, 13);
            this.showArea.TabIndex = 11;
            // 
            // showPerimeter
            // 
            this.showPerimeter.AutoSize = true;
            this.showPerimeter.Location = new System.Drawing.Point(174, 418);
            this.showPerimeter.Name = "showPerimeter";
            this.showPerimeter.Size = new System.Drawing.Size(0, 13);
            this.showPerimeter.TabIndex = 12;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(176, 282);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(85, 13);
            this.heightLabel.TabIndex = 13;
            this.heightLabel.Text = "Enter the height ";
            // 
            // getHeight
            // 
            this.getHeight.Location = new System.Drawing.Point(387, 279);
            this.getHeight.Name = "getHeight";
            this.getHeight.Size = new System.Drawing.Size(100, 20);
            this.getHeight.TabIndex = 14;
            // 
            // TrapezoidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 496);
            this.Controls.Add(this.getHeight);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.showPerimeter);
            this.Controls.Add(this.showArea);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.getSide3);
            this.Controls.Add(this.getSide2);
            this.Controls.Add(this.getSide1);
            this.Controls.Add(this.getBase);
            this.Controls.Add(this.side3Label);
            this.Controls.Add(this.side2Label);
            this.Controls.Add(this.side1Label);
            this.Controls.Add(this.baseLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.trapezoidBackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(829, 535);
            this.MinimumSize = new System.Drawing.Size(829, 535);
            this.Name = "TrapezoidForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrapezoidForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label trapezoidBackButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label side1Label;
        private System.Windows.Forms.Label side2Label;
        private System.Windows.Forms.Label side3Label;
        private System.Windows.Forms.TextBox getBase;
        private System.Windows.Forms.TextBox getSide1;
        private System.Windows.Forms.TextBox getSide2;
        private System.Windows.Forms.TextBox getSide3;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label showArea;
        private System.Windows.Forms.Label showPerimeter;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox getHeight;
    }
}