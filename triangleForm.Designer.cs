namespace MathProblemSolver
{
    partial class triangleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(triangleForm));
            this.baseLabel = new System.Windows.Forms.Label();
            this.getBase = new System.Windows.Forms.TextBox();
            this.side1Label = new System.Windows.Forms.Label();
            this.getSide1 = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.showArea = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.getSide2 = new System.Windows.Forms.TextBox();
            this.triangleBackButton = new System.Windows.Forms.Label();
            this.showPerimeter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabel.Location = new System.Drawing.Point(202, 184);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(128, 20);
            this.baseLabel.TabIndex = 0;
            this.baseLabel.Text = "Enter the base";
            // 
            // getBase
            // 
            this.getBase.Location = new System.Drawing.Point(425, 184);
            this.getBase.Name = "getBase";
            this.getBase.Size = new System.Drawing.Size(100, 20);
            this.getBase.TabIndex = 1;
            // 
            // side1Label
            // 
            this.side1Label.AutoSize = true;
            this.side1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.side1Label.Location = new System.Drawing.Point(202, 248);
            this.side1Label.Name = "side1Label";
            this.side1Label.Size = new System.Drawing.Size(126, 20);
            this.side1Label.TabIndex = 2;
            this.side1Label.Text = "Enter one side";
            // 
            // getSide1
            // 
            this.getSide1.Location = new System.Drawing.Point(425, 248);
            this.getSide1.Name = "getSide1";
            this.getSide1.Size = new System.Drawing.Size(100, 20);
            this.getSide1.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(353, 95);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(73, 20);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Triangle";
            // 
            // showArea
            // 
            this.showArea.AutoSize = true;
            this.showArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showArea.Location = new System.Drawing.Point(202, 391);
            this.showArea.Name = "showArea";
            this.showArea.Size = new System.Drawing.Size(0, 20);
            this.showArea.TabIndex = 5;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(586, 235);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(151, 44);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter the other side";
            // 
            // getSide2
            // 
            this.getSide2.Location = new System.Drawing.Point(425, 321);
            this.getSide2.Name = "getSide2";
            this.getSide2.Size = new System.Drawing.Size(100, 20);
            this.getSide2.TabIndex = 8;
            // 
            // triangleBackButton
            // 
            this.triangleBackButton.AutoSize = true;
            this.triangleBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triangleBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triangleBackButton.Location = new System.Drawing.Point(43, 92);
            this.triangleBackButton.Name = "triangleBackButton";
            this.triangleBackButton.Size = new System.Drawing.Size(73, 24);
            this.triangleBackButton.TabIndex = 9;
            this.triangleBackButton.Text = "< Back";
            this.triangleBackButton.Click += new System.EventHandler(this.triangleBackButton_Click);
            // 
            // showPerimeter
            // 
            this.showPerimeter.AutoSize = true;
            this.showPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPerimeter.Location = new System.Drawing.Point(202, 434);
            this.showPerimeter.Name = "showPerimeter";
            this.showPerimeter.Size = new System.Drawing.Size(0, 20);
            this.showPerimeter.TabIndex = 10;
            // 
            // triangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 496);
            this.Controls.Add(this.showPerimeter);
            this.Controls.Add(this.triangleBackButton);
            this.Controls.Add(this.getSide2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.showArea);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.getSide1);
            this.Controls.Add(this.side1Label);
            this.Controls.Add(this.getBase);
            this.Controls.Add(this.baseLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(829, 535);
            this.MinimumSize = new System.Drawing.Size(829, 535);
            this.Name = "triangleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "triangleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.TextBox getBase;
        private System.Windows.Forms.Label side1Label;
        private System.Windows.Forms.TextBox getSide1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label showArea;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox getSide2;
        private System.Windows.Forms.Label triangleBackButton;
        private System.Windows.Forms.Label showPerimeter;
    }
}