namespace MathProblemSolver
{
    partial class ParallelogramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParallelogramForm));
            this.parallelogramBackButton = new System.Windows.Forms.Label();
            this.baseLabel = new System.Windows.Forms.Label();
            this.sideLabel = new System.Windows.Forms.Label();
            this.getBase = new System.Windows.Forms.TextBox();
            this.getSide = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.showArea = new System.Windows.Forms.Label();
            this.showPerimeter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.getHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // parallelogramBackButton
            // 
            this.parallelogramBackButton.AutoSize = true;
            this.parallelogramBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parallelogramBackButton.Location = new System.Drawing.Point(68, 149);
            this.parallelogramBackButton.Name = "parallelogramBackButton";
            this.parallelogramBackButton.Size = new System.Drawing.Size(86, 29);
            this.parallelogramBackButton.TabIndex = 0;
            this.parallelogramBackButton.Text = "< Back";
            this.parallelogramBackButton.Click += new System.EventHandler(this.parallelogramBackButton_Click);
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabel.Location = new System.Drawing.Point(226, 249);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(168, 29);
            this.baseLabel.TabIndex = 1;
            this.baseLabel.Text = "Enter the base";
            // 
            // sideLabel
            // 
            this.sideLabel.AutoSize = true;
            this.sideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideLabel.Location = new System.Drawing.Point(226, 296);
            this.sideLabel.Name = "sideLabel";
            this.sideLabel.Size = new System.Drawing.Size(161, 29);
            this.sideLabel.TabIndex = 2;
            this.sideLabel.Text = "Enter the side";
            // 
            // getBase
            // 
            this.getBase.Location = new System.Drawing.Point(482, 246);
            this.getBase.Name = "getBase";
            this.getBase.Size = new System.Drawing.Size(100, 22);
            this.getBase.TabIndex = 3;
            // 
            // getSide
            // 
            this.getSide.Location = new System.Drawing.Point(482, 296);
            this.getSide.Name = "getSide";
            this.getSide.Size = new System.Drawing.Size(100, 22);
            this.getSide.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(674, 259);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(88, 48);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // showArea
            // 
            this.showArea.AutoSize = true;
            this.showArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showArea.Location = new System.Drawing.Point(229, 427);
            this.showArea.Name = "showArea";
            this.showArea.Size = new System.Drawing.Size(0, 29);
            this.showArea.TabIndex = 6;
            // 
            // showPerimeter
            // 
            this.showPerimeter.AutoSize = true;
            this.showPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPerimeter.Location = new System.Drawing.Point(229, 493);
            this.showPerimeter.Name = "showPerimeter";
            this.showPerimeter.Size = new System.Drawing.Size(0, 29);
            this.showPerimeter.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter the height";
            // 
            // getHeight
            // 
            this.getHeight.Location = new System.Drawing.Point(482, 348);
            this.getHeight.Name = "getHeight";
            this.getHeight.Size = new System.Drawing.Size(100, 22);
            this.getHeight.TabIndex = 9;
            // 
            // ParallelogramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 596);
            this.Controls.Add(this.getHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showPerimeter);
            this.Controls.Add(this.showArea);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.getSide);
            this.Controls.Add(this.getBase);
            this.Controls.Add(this.sideLabel);
            this.Controls.Add(this.baseLabel);
            this.Controls.Add(this.parallelogramBackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1099, 647);
            this.MinimumSize = new System.Drawing.Size(1099, 647);
            this.Name = "ParallelogramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParallelogramForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label parallelogramBackButton;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label sideLabel;
        private System.Windows.Forms.TextBox getBase;
        private System.Windows.Forms.TextBox getSide;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label showArea;
        private System.Windows.Forms.Label showPerimeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox getHeight;
    }
}