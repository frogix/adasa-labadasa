namespace adasa_project
{
    partial class DrawnGraph
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
            this.graphPB = new System.Windows.Forms.PictureBox();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.currentStageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graphPB)).BeginInit();
            this.SuspendLayout();
            // 
            // graphPB
            // 
            this.graphPB.Dock = System.Windows.Forms.DockStyle.Top;
            this.graphPB.Location = new System.Drawing.Point(0, 0);
            this.graphPB.Margin = new System.Windows.Forms.Padding(0);
            this.graphPB.Name = "graphPB";
            this.graphPB.Size = new System.Drawing.Size(1600, 759);
            this.graphPB.TabIndex = 0;
            this.graphPB.TabStop = false;
            // 
            // buttonLeft
            // 
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeft.Location = new System.Drawing.Point(500, 850);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 67);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRight.Location = new System.Drawing.Point(1000, 850);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 67);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // currentStageLabel
            // 
            this.currentStageLabel.AutoSize = true;
            this.currentStageLabel.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentStageLabel.Location = new System.Drawing.Point(756, 865);
            this.currentStageLabel.Name = "currentStageLabel";
            this.currentStageLabel.Size = new System.Drawing.Size(70, 42);
            this.currentStageLabel.TabIndex = 3;
            this.currentStageLabel.Text = "1/1";
            // 
            // DrawnGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 991);
            this.Controls.Add(this.currentStageLabel);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.graphPB);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DrawnGraph";
            this.Text = "DrawnGraph";
            ((System.ComponentModel.ISupportInitialize)(this.graphPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox graphPB;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Label currentStageLabel;
    }
}