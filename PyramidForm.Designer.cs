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
            this.SuspendLayout();
            // 
            // pyramidBackBtn
            // 
            this.pyramidBackBtn.AutoSize = true;
            this.pyramidBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pyramidBackBtn.Location = new System.Drawing.Point(51, 100);
            this.pyramidBackBtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pyramidBackBtn.Name = "pyramidBackBtn";
            this.pyramidBackBtn.Size = new System.Drawing.Size(67, 24);
            this.pyramidBackBtn.TabIndex = 0;
            this.pyramidBackBtn.Text = "< Back";
            this.pyramidBackBtn.Click += new System.EventHandler(this.pyramidBackBtn_Click);
            // 
            // PyramidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 491);
            this.Controls.Add(this.pyramidBackBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}