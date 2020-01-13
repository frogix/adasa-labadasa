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
            ((System.ComponentModel.ISupportInitialize)(this.graphPB)).BeginInit();
            this.SuspendLayout();
            // 
            // graphPB
            // 
            this.graphPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphPB.Location = new System.Drawing.Point(0, 0);
            this.graphPB.Margin = new System.Windows.Forms.Padding(0);
            this.graphPB.Name = "graphPB";
            this.graphPB.Size = new System.Drawing.Size(800, 450);
            this.graphPB.TabIndex = 0;
            this.graphPB.TabStop = false;
            // 
            // DrawnGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.graphPB);
            this.Name = "DrawnGraph";
            this.Text = "DrawnGraph";
            ((System.ComponentModel.ISupportInitialize)(this.graphPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox graphPB;
    }
}