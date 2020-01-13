namespace adasa_project
{
    partial class DataInputView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftComboBox = new System.Windows.Forms.ComboBox();
            this.RightComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addConnectionButton = new System.Windows.Forms.Button();
            this.dependenciesList = new System.Windows.Forms.ListBox();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.DeleteConnectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(144, 67);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(60, 29);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество вершин";
            // 
            // LeftComboBox
            // 
            this.LeftComboBox.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftComboBox.FormattingEnabled = true;
            this.LeftComboBox.Location = new System.Drawing.Point(58, 140);
            this.LeftComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LeftComboBox.Name = "LeftComboBox";
            this.LeftComboBox.Size = new System.Drawing.Size(62, 29);
            this.LeftComboBox.TabIndex = 2;
            // 
            // RightComboBox
            // 
            this.RightComboBox.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightComboBox.FormattingEnabled = true;
            this.RightComboBox.Location = new System.Drawing.Point(220, 140);
            this.RightComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RightComboBox.Name = "RightComboBox";
            this.RightComboBox.Size = new System.Drawing.Size(62, 29);
            this.RightComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "=>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите связь";
            // 
            // addConnectionButton
            // 
            this.addConnectionButton.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addConnectionButton.Location = new System.Drawing.Point(112, 187);
            this.addConnectionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addConnectionButton.Name = "addConnectionButton";
            this.addConnectionButton.Size = new System.Drawing.Size(118, 31);
            this.addConnectionButton.TabIndex = 6;
            this.addConnectionButton.Text = "Добавить!";
            this.addConnectionButton.UseVisualStyleBackColor = true;
            this.addConnectionButton.Click += new System.EventHandler(this.addConnectionButton_Click);
            // 
            // dependenciesList
            // 
            this.dependenciesList.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dependenciesList.FormattingEnabled = true;
            this.dependenciesList.ItemHeight = 21;
            this.dependenciesList.Location = new System.Drawing.Point(47, 236);
            this.dependenciesList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dependenciesList.Name = "dependenciesList";
            this.dependenciesList.Size = new System.Drawing.Size(185, 130);
            this.dependenciesList.TabIndex = 7;
            // 
            // ComputeButton
            // 
            this.ComputeButton.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputeButton.Location = new System.Drawing.Point(107, 388);
            this.ComputeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(144, 37);
            this.ComputeButton.TabIndex = 8;
            this.ComputeButton.Text = "Найти!";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // DeleteConnectionButton
            // 
            this.DeleteConnectionButton.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteConnectionButton.Location = new System.Drawing.Point(243, 269);
            this.DeleteConnectionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteConnectionButton.Name = "DeleteConnectionButton";
            this.DeleteConnectionButton.Size = new System.Drawing.Size(118, 59);
            this.DeleteConnectionButton.TabIndex = 9;
            this.DeleteConnectionButton.Text = "Удалить связь!";
            this.DeleteConnectionButton.UseVisualStyleBackColor = true;
            this.DeleteConnectionButton.Click += new System.EventHandler(this.DeleteConnectionButton_Click);
            // 
            // DataInputView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 459);
            this.Controls.Add(this.DeleteConnectionButton);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.dependenciesList);
            this.Controls.Add(this.addConnectionButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RightComboBox);
            this.Controls.Add(this.LeftComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DataInputView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LeftComboBox;
        private System.Windows.Forms.ComboBox RightComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addConnectionButton;
        private System.Windows.Forms.ListBox dependenciesList;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.Button DeleteConnectionButton;
    }
}

