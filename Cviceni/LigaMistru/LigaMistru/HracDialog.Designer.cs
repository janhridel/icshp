namespace LigaMistru
{
    partial class HracDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jmenoTextBox = new System.Windows.Forms.TextBox();
            this.golyTextBox = new System.Windows.Forms.TextBox();
            this.klubComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.stornoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Klub";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Góly";
            // 
            // jmenoTextBox
            // 
            this.jmenoTextBox.Location = new System.Drawing.Point(56, 6);
            this.jmenoTextBox.Name = "jmenoTextBox";
            this.jmenoTextBox.Size = new System.Drawing.Size(100, 20);
            this.jmenoTextBox.TabIndex = 3;
            // 
            // golyTextBox
            // 
            this.golyTextBox.Location = new System.Drawing.Point(56, 67);
            this.golyTextBox.Name = "golyTextBox";
            this.golyTextBox.Size = new System.Drawing.Size(41, 20);
            this.golyTextBox.TabIndex = 4;
            // 
            // klubComboBox
            // 
            this.klubComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.klubComboBox.FormattingEnabled = true;
            this.klubComboBox.Location = new System.Drawing.Point(56, 37);
            this.klubComboBox.Name = "klubComboBox";
            this.klubComboBox.Size = new System.Drawing.Size(121, 21);
            this.klubComboBox.Sorted = true;
            this.klubComboBox.TabIndex = 5;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(15, 102);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // stornoButton
            // 
            this.stornoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.stornoButton.Location = new System.Drawing.Point(105, 104);
            this.stornoButton.Name = "stornoButton";
            this.stornoButton.Size = new System.Drawing.Size(72, 21);
            this.stornoButton.TabIndex = 7;
            this.stornoButton.Text = "Storno";
            this.stornoButton.UseVisualStyleBackColor = true;
            // 
            // HracDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 135);
            this.Controls.Add(this.stornoButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.klubComboBox);
            this.Controls.Add(this.golyTextBox);
            this.Controls.Add(this.jmenoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HracDialog";
            this.Text = "Hráč";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jmenoTextBox;
        private System.Windows.Forms.TextBox golyTextBox;
        private System.Windows.Forms.ComboBox klubComboBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button stornoButton;
    }
}