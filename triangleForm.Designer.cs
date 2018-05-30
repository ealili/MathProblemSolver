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
            this.baseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabel.ForeColor = System.Drawing.Color.White;
            this.baseLabel.Location = new System.Drawing.Point(202, 199);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(114, 20);
            this.baseLabel.TabIndex = 0;
            this.baseLabel.Text = "Enter the base";
            // 
            // getBase
            // 
            this.getBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.getBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getBase.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.getBase.Location = new System.Drawing.Point(415, 199);
            this.getBase.MinimumSize = new System.Drawing.Size(100, 27);
            this.getBase.Name = "getBase";
            this.getBase.Size = new System.Drawing.Size(100, 23);
            this.getBase.TabIndex = 1;
            this.getBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // side1Label
            // 
            this.side1Label.AutoSize = true;
            this.side1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.side1Label.ForeColor = System.Drawing.Color.White;
            this.side1Label.Location = new System.Drawing.Point(202, 245);
            this.side1Label.Name = "side1Label";
            this.side1Label.Size = new System.Drawing.Size(112, 20);
            this.side1Label.TabIndex = 2;
            this.side1Label.Text = "Enter one side";
            // 
            // getSide1
            // 
            this.getSide1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.getSide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSide1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.getSide1.Location = new System.Drawing.Point(415, 248);
            this.getSide1.MinimumSize = new System.Drawing.Size(100, 27);
            this.getSide1.Name = "getSide1";
            this.getSide1.Size = new System.Drawing.Size(100, 23);
            this.getSide1.TabIndex = 3;
            this.getSide1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.titleLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.MinimumSize = new System.Drawing.Size(810, 100);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(810, 100);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Triangle";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showArea
            // 
            this.showArea.AutoSize = true;
            this.showArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showArea.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.showArea.Location = new System.Drawing.Point(202, 358);
            this.showArea.Name = "showArea";
            this.showArea.Size = new System.Drawing.Size(0, 24);
            this.showArea.TabIndex = 5;
            // 
            // calcButton
            // 
            this.calcButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.calcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.ForeColor = System.Drawing.Color.White;
            this.calcButton.Location = new System.Drawing.Point(582, 239);
            this.calcButton.MaximumSize = new System.Drawing.Size(120, 40);
            this.calcButton.MinimumSize = new System.Drawing.Size(120, 40);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(120, 40);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(202, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter the other side";
            // 
            // getSide2
            // 
            this.getSide2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.getSide2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSide2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.getSide2.Location = new System.Drawing.Point(415, 300);
            this.getSide2.MaximumSize = new System.Drawing.Size(100, 27);
            this.getSide2.MinimumSize = new System.Drawing.Size(100, 27);
            this.getSide2.Name = "getSide2";
            this.getSide2.Size = new System.Drawing.Size(100, 23);
            this.getSide2.TabIndex = 8;
            this.getSide2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // triangleBackButton
            // 
            this.triangleBackButton.AutoSize = true;
            this.triangleBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triangleBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triangleBackButton.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.triangleBackButton.Location = new System.Drawing.Point(12, 120);
            this.triangleBackButton.Name = "triangleBackButton";
            this.triangleBackButton.Size = new System.Drawing.Size(67, 24);
            this.triangleBackButton.TabIndex = 9;
            this.triangleBackButton.Text = "< Back";
            this.triangleBackButton.Click += new System.EventHandler(this.triangleBackButton_Click);
            // 
            // showPerimeter
            // 
            this.showPerimeter.AutoSize = true;
            this.showPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPerimeter.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.showPerimeter.Location = new System.Drawing.Point(202, 424);
            this.showPerimeter.Name = "showPerimeter";
            this.showPerimeter.Size = new System.Drawing.Size(0, 24);
            this.showPerimeter.TabIndex = 10;
            // 
            // triangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(809, 492);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(829, 535);
            this.MinimumSize = new System.Drawing.Size(829, 535);
            this.Name = "triangleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triangle";
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