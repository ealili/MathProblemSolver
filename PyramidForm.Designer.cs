namespace MathProblemSolver
{
    partial class PyramidForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PyramidForm));
            this.pyramidBackBtn = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.baseLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.getBase = new System.Windows.Forms.TextBox();
            this.getHeight = new System.Windows.Forms.TextBox();
            this.getWidth = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.showArea = new System.Windows.Forms.Label();
            this.showVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pyramidBackBtn
            // 
            this.pyramidBackBtn.AutoSize = true;
            this.pyramidBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pyramidBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pyramidBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pyramidBackBtn.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.pyramidBackBtn.Location = new System.Drawing.Point(12, 120);
            this.pyramidBackBtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pyramidBackBtn.Name = "pyramidBackBtn";
            this.pyramidBackBtn.Size = new System.Drawing.Size(67, 24);
            this.pyramidBackBtn.TabIndex = 0;
            this.pyramidBackBtn.Text = "< Back";
            this.pyramidBackBtn.Click += new System.EventHandler(this.pyramidBackBtn_Click);
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
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Rectangular Based Pyramid";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabel.ForeColor = System.Drawing.Color.White;
            this.baseLabel.Location = new System.Drawing.Point(157, 217);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(114, 20);
            this.baseLabel.TabIndex = 2;
            this.baseLabel.Text = "Enter the base";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.ForeColor = System.Drawing.Color.White;
            this.heightLabel.Location = new System.Drawing.Point(157, 265);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(123, 20);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Enter the height";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.ForeColor = System.Drawing.Color.White;
            this.widthLabel.Location = new System.Drawing.Point(157, 312);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(116, 20);
            this.widthLabel.TabIndex = 4;
            this.widthLabel.Text = "Enter the width";
            // 
            // getBase
            // 
            this.getBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.getBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getBase.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.getBase.Location = new System.Drawing.Point(358, 216);
            this.getBase.Name = "getBase";
            this.getBase.Size = new System.Drawing.Size(100, 24);
            this.getBase.TabIndex = 5;
            this.getBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // getHeight
            // 
            this.getHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.getHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getHeight.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.getHeight.Location = new System.Drawing.Point(358, 264);
            this.getHeight.Name = "getHeight";
            this.getHeight.Size = new System.Drawing.Size(100, 24);
            this.getHeight.TabIndex = 6;
            this.getHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // getWidth
            // 
            this.getWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.getWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getWidth.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.getWidth.Location = new System.Drawing.Point(358, 311);
            this.getWidth.Name = "getWidth";
            this.getWidth.Size = new System.Drawing.Size(100, 24);
            this.getWidth.TabIndex = 7;
            this.getWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculateButton
            // 
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(548, 256);
            this.calculateButton.MinimumSize = new System.Drawing.Size(120, 40);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(120, 40);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // showArea
            // 
            this.showArea.AutoSize = true;
            this.showArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showArea.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.showArea.Location = new System.Drawing.Point(161, 382);
            this.showArea.Name = "showArea";
            this.showArea.Size = new System.Drawing.Size(0, 24);
            this.showArea.TabIndex = 9;
            // 
            // showVolume
            // 
            this.showVolume.AutoSize = true;
            this.showVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showVolume.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.showVolume.Location = new System.Drawing.Point(161, 421);
            this.showVolume.Name = "showVolume";
            this.showVolume.Size = new System.Drawing.Size(0, 24);
            this.showVolume.TabIndex = 10;
            // 
            // PyramidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(809, 491);
            this.Controls.Add(this.showVolume);
            this.Controls.Add(this.showArea);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.getWidth);
            this.Controls.Add(this.getHeight);
            this.Controls.Add(this.getBase);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.baseLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pyramidBackBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(829, 534);
            this.MinimumSize = new System.Drawing.Size(829, 534);
            this.Name = "PyramidForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pyramid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pyramidBackBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox getBase;
        private System.Windows.Forms.TextBox getHeight;
        private System.Windows.Forms.TextBox getWidth;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label showArea;
        private System.Windows.Forms.Label showVolume;
    }
}