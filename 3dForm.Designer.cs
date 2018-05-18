namespace MathProblemSolver
{
    partial class _3dForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_3dForm));
            this.threeDBackButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // threeDBackButton
            // 
            this.threeDBackButton.AutoSize = true;
            this.threeDBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.threeDBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeDBackButton.Location = new System.Drawing.Point(73, 108);
            this.threeDBackButton.Name = "threeDBackButton";
            this.threeDBackButton.Size = new System.Drawing.Size(73, 24);
            this.threeDBackButton.TabIndex = 0;
            this.threeDBackButton.Text = "< Back";
            this.threeDBackButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.threeDBackButton.Click += new System.EventHandler(this.threeDBackButton_Click);
            // 
            // _3dForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 496);
            this.Controls.Add(this.threeDBackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(829, 535);
            this.MinimumSize = new System.Drawing.Size(829, 535);
            this.Name = "_3dForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_3dForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label threeDBackButton;
    }
}