namespace MathProblemSolver
{
    partial class CubeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CubeForm));
            this.cubeBackButton = new System.Windows.Forms.Label();
            this.baseLabel = new System.Windows.Forms.Label();
            this.getBase = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.showVolume = new System.Windows.Forms.Label();
            this.showArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cubeBackButton
            // 
            this.cubeBackButton.AutoSize = true;
            this.cubeBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cubeBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cubeBackButton.Location = new System.Drawing.Point(66, 101);
            this.cubeBackButton.Name = "cubeBackButton";
            this.cubeBackButton.Size = new System.Drawing.Size(73, 24);
            this.cubeBackButton.TabIndex = 0;
            this.cubeBackButton.Text = "< Back";
            this.cubeBackButton.Click += new System.EventHandler(this.cubeBackButton_Click);
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabel.Location = new System.Drawing.Point(158, 258);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(128, 20);
            this.baseLabel.TabIndex = 1;
            this.baseLabel.Text = "Enter the base";
            // 
            // getBase
            // 
            this.getBase.Location = new System.Drawing.Point(365, 257);
            this.getBase.Name = "getBase";
            this.getBase.Size = new System.Drawing.Size(100, 20);
            this.getBase.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(580, 254);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // showVolume
            // 
            this.showVolume.AutoSize = true;
            this.showVolume.Location = new System.Drawing.Point(165, 351);
            this.showVolume.Name = "showVolume";
            this.showVolume.Size = new System.Drawing.Size(0, 13);
            this.showVolume.TabIndex = 4;
            // 
            // showArea
            // 
            this.showArea.AutoSize = true;
            this.showArea.Location = new System.Drawing.Point(165, 402);
            this.showArea.Name = "showArea";
            this.showArea.Size = new System.Drawing.Size(0, 13);
            this.showArea.TabIndex = 5;
            // 
            // CubeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 496);
            this.Controls.Add(this.showArea);
            this.Controls.Add(this.showVolume);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.getBase);
            this.Controls.Add(this.baseLabel);
            this.Controls.Add(this.cubeBackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(829, 535);
            this.MinimumSize = new System.Drawing.Size(829, 535);
            this.Name = "CubeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CubeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cubeBackButton;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.TextBox getBase;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label showVolume;
        private System.Windows.Forms.Label showArea;
    }
}