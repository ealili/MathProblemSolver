namespace MathProblemSolver
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.shapeChoosingLabel = new System.Windows.Forms.Label();
            this.twoDimensionalButton = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.threeDimensionalButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.titleLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 76);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(826, 49);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "MathProblemSolver";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeChoosingLabel
            // 
            this.shapeChoosingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.shapeChoosingLabel.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeChoosingLabel.ForeColor = System.Drawing.Color.White;
            this.shapeChoosingLabel.Location = new System.Drawing.Point(1, 197);
            this.shapeChoosingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shapeChoosingLabel.Name = "shapeChoosingLabel";
            this.shapeChoosingLabel.Size = new System.Drawing.Size(827, 51);
            this.shapeChoosingLabel.TabIndex = 1;
            this.shapeChoosingLabel.Text = "Choose the type below";
            this.shapeChoosingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twoDimensionalButton
            // 
            this.twoDimensionalButton.AutoSize = true;
            this.twoDimensionalButton.BackColor = System.Drawing.Color.Transparent;
            this.twoDimensionalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.twoDimensionalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twoDimensionalButton.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.twoDimensionalButton.FlatAppearance.BorderSize = 0;
            this.twoDimensionalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.twoDimensionalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoDimensionalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoDimensionalButton.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.twoDimensionalButton.Location = new System.Drawing.Point(236, 265);
            this.twoDimensionalButton.Margin = new System.Windows.Forms.Padding(2);
            this.twoDimensionalButton.Name = "twoDimensionalButton";
            this.twoDimensionalButton.Size = new System.Drawing.Size(153, 146);
            this.twoDimensionalButton.TabIndex = 2;
            this.twoDimensionalButton.Text = "2D";
            this.twoDimensionalButton.UseVisualStyleBackColor = false;
            this.twoDimensionalButton.Click += new System.EventHandler(this.twoDimensionalButton_Click);
            this.twoDimensionalButton.MouseLeave += new System.EventHandler(this.twoDimensionalButton_MouseLeave);
            this.twoDimensionalButton.MouseHover += new System.EventHandler(this.twoDimensionalButton_MouseHover);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.headerPanel.Controls.Add(this.panel1);
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Location = new System.Drawing.Point(1, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(828, 156);
            this.headerPanel.TabIndex = 4;
            // 
            // threeDimensionalButton
            // 
            this.threeDimensionalButton.AutoSize = true;
            this.threeDimensionalButton.BackColor = System.Drawing.Color.Transparent;
            this.threeDimensionalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.threeDimensionalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.threeDimensionalButton.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.threeDimensionalButton.FlatAppearance.BorderSize = 0;
            this.threeDimensionalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.threeDimensionalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeDimensionalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeDimensionalButton.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.threeDimensionalButton.Location = new System.Drawing.Point(433, 265);
            this.threeDimensionalButton.Margin = new System.Windows.Forms.Padding(2);
            this.threeDimensionalButton.Name = "threeDimensionalButton";
            this.threeDimensionalButton.Size = new System.Drawing.Size(153, 146);
            this.threeDimensionalButton.TabIndex = 3;
            this.threeDimensionalButton.Text = "3D";
            this.threeDimensionalButton.UseVisualStyleBackColor = false;
            this.threeDimensionalButton.Click += new System.EventHandler(this.threeDimensionalButton_Click);
            this.threeDimensionalButton.MouseLeave += new System.EventHandler(this.threeDimensionalButton_MouseLeave);
            this.threeDimensionalButton.MouseHover += new System.EventHandler(this.threeDimensionalButton_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 37);
            this.panel1.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(792, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(32, 32);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(829, 535);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.threeDimensionalButton);
            this.Controls.Add(this.twoDimensionalButton);
            this.Controls.Add(this.shapeChoosingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(829, 535);
            this.MinimumSize = new System.Drawing.Size(829, 535);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MathProblemSolver";
            this.headerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label shapeChoosingLabel;
        private System.Windows.Forms.Button twoDimensionalButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button threeDimensionalButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
    }
}

