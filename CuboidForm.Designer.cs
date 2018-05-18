namespace MathProblemSolver
{
    partial class CuboidForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuboidForm));
            this.cuboidBackButton = new System.Windows.Forms.Label();
            this.baseLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.getBase = new System.Windows.Forms.TextBox();
            this.getHeight = new System.Windows.Forms.TextBox();
            this.getWidth = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.showVolume = new System.Windows.Forms.Label();
            this.showArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cuboidBackButton
            // 
            this.cuboidBackButton.AutoSize = true;
            this.cuboidBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuboidBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuboidBackButton.Location = new System.Drawing.Point(72, 92);
            this.cuboidBackButton.Name = "cuboidBackButton";
            this.cuboidBackButton.Size = new System.Drawing.Size(73, 24);
            this.cuboidBackButton.TabIndex = 0;
            this.cuboidBackButton.Text = "< Back";
            this.cuboidBackButton.Click += new System.EventHandler(this.cuboidBackButton_Click);
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabel.Location = new System.Drawing.Point(193, 189);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(128, 20);
            this.baseLabel.TabIndex = 1;
            this.baseLabel.Text = "Enter the base";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(193, 249);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(139, 20);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "Enter the height";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(190, 303);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(131, 20);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Enter the width";
            // 
            // getBase
            // 
            this.getBase.Location = new System.Drawing.Point(422, 189);
            this.getBase.Name = "getBase";
            this.getBase.Size = new System.Drawing.Size(100, 20);
            this.getBase.TabIndex = 4;
            // 
            // getHeight
            // 
            this.getHeight.Location = new System.Drawing.Point(422, 249);
            this.getHeight.Name = "getHeight";
            this.getHeight.Size = new System.Drawing.Size(100, 20);
            this.getHeight.TabIndex = 5;
            // 
            // getWidth
            // 
            this.getWidth.Location = new System.Drawing.Point(422, 305);
            this.getWidth.Name = "getWidth";
            this.getWidth.Size = new System.Drawing.Size(100, 20);
            this.getWidth.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(625, 235);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(113, 49);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // showVolume
            // 
            this.showVolume.AutoSize = true;
            this.showVolume.Location = new System.Drawing.Point(167, 376);
            this.showVolume.Name = "showVolume";
            this.showVolume.Size = new System.Drawing.Size(0, 13);
            this.showVolume.TabIndex = 8;
            // 
            // showArea
            // 
            this.showArea.AutoSize = true;
            this.showArea.Location = new System.Drawing.Point(167, 416);
            this.showArea.Name = "showArea";
            this.showArea.Size = new System.Drawing.Size(0, 13);
            this.showArea.TabIndex = 9;
            // 
            // CuboidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 496);
            this.Controls.Add(this.showArea);
            this.Controls.Add(this.showVolume);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.getWidth);
            this.Controls.Add(this.getHeight);
            this.Controls.Add(this.getBase);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.baseLabel);
            this.Controls.Add(this.cuboidBackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(829, 535);
            this.MinimumSize = new System.Drawing.Size(829, 535);
            this.Name = "CuboidForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuboidForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cuboidBackButton;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox getBase;
        private System.Windows.Forms.TextBox getHeight;
        private System.Windows.Forms.TextBox getWidth;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label showVolume;
        private System.Windows.Forms.Label showArea;
    }
}