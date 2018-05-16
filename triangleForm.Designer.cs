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
            this.label1 = new System.Windows.Forms.Label();
            this.showArea = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.getSide2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabel.Location = new System.Drawing.Point(202, 171);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(128, 20);
            this.baseLabel.TabIndex = 0;
            this.baseLabel.Text = "Enter the base";
            // 
            // getBase
            // 
            this.getBase.Location = new System.Drawing.Point(425, 171);
            this.getBase.Name = "getBase";
            this.getBase.Size = new System.Drawing.Size(100, 20);
            this.getBase.TabIndex = 1;
            // 
            // side1Label
            // 
            this.side1Label.AutoSize = true;
            this.side1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.side1Label.Location = new System.Drawing.Point(202, 233);
            this.side1Label.Name = "side1Label";
            this.side1Label.Size = new System.Drawing.Size(126, 20);
            this.side1Label.TabIndex = 2;
            this.side1Label.Text = "Enter one side";
            // 
            // getSide1
            // 
            this.getSide1.Location = new System.Drawing.Point(425, 233);
            this.getSide1.Name = "getSide1";
            this.getSide1.Size = new System.Drawing.Size(100, 20);
            this.getSide1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Triangle";
            // 
            // showArea
            // 
            this.showArea.AutoSize = true;
            this.showArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showArea.Location = new System.Drawing.Point(202, 355);
            this.showArea.Name = "showArea";
            this.showArea.Size = new System.Drawing.Size(0, 20);
            this.showArea.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate Area";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter the other side";
            // 
            // getSide2
            // 
            this.getSide2.Location = new System.Drawing.Point(425, 296);
            this.getSide2.Name = "getSide2";
            this.getSide2.Size = new System.Drawing.Size(100, 20);
            this.getSide2.TabIndex = 8;
            // 
            // triangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 496);
            this.Controls.Add(this.getSide2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showArea);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label showArea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox getSide2;
    }
}