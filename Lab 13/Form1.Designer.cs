namespace Lab_13
{
    partial class Form1
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
            if (disposing && (components != null)) {
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Task1 = new System.Windows.Forms.TabPage();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.Task2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.Task1.SuspendLayout();
            this.Task2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Task1);
            this.TabControl.Controls.Add(this.Task2);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(549, 422);
            this.TabControl.TabIndex = 0;
            // 
            // Task1
            // 
            this.Task1.Controls.Add(this.ComboBox);
            this.Task1.Controls.Add(this.TextBox);
            this.Task1.Controls.Add(this.RemoveButton);
            this.Task1.Controls.Add(this.AddButton);
            this.Task1.Location = new System.Drawing.Point(4, 22);
            this.Task1.Name = "Task1";
            this.Task1.Padding = new System.Windows.Forms.Padding(3);
            this.Task1.Size = new System.Drawing.Size(541, 396);
            this.Task1.TabIndex = 0;
            this.Task1.Text = "Task1";
            this.Task1.UseVisualStyleBackColor = true;
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(8, 32);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(134, 21);
            this.ComboBox.TabIndex = 3;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(8, 6);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(135, 20);
            this.TextBox.TabIndex = 2;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(222, 6);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(67, 21);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Видалити";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(149, 6);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(67, 20);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Task2
            // 
            this.Task2.Controls.Add(this.textBox1);
            this.Task2.Location = new System.Drawing.Point(4, 22);
            this.Task2.Name = "Task2";
            this.Task2.Padding = new System.Windows.Forms.Padding(3);
            this.Task2.Size = new System.Drawing.Size(541, 396);
            this.Task2.TabIndex = 1;
            this.Task2.Text = "Task2";
            this.Task2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(3, 373);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(535, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 422);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.Task1.ResumeLayout(false);
            this.Task1.PerformLayout();
            this.Task2.ResumeLayout(false);
            this.Task2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.TextBox TextBox;

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Task1;
        private System.Windows.Forms.TabPage Task2;
        #endregion
    }
}