namespace LigaMistru
{
    partial class NejlepsiKlubyDialog
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
            this.klubyListBox = new System.Windows.Forms.ListBox();
            this.golPocetTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Počet gólů";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kluby";
            // 
            // klubyListBox
            // 
            this.klubyListBox.FormattingEnabled = true;
            this.klubyListBox.Location = new System.Drawing.Point(16, 69);
            this.klubyListBox.Name = "klubyListBox";
            this.klubyListBox.Size = new System.Drawing.Size(232, 121);
            this.klubyListBox.TabIndex = 2;
            // 
            // golPocetTextBox
            // 
            this.golPocetTextBox.Location = new System.Drawing.Point(16, 30);
            this.golPocetTextBox.Name = "golPocetTextBox";
            this.golPocetTextBox.ReadOnly = true;
            this.golPocetTextBox.Size = new System.Drawing.Size(100, 20);
            this.golPocetTextBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(173, 197);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // NejlepsiKlubyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 232);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.golPocetTextBox);
            this.Controls.Add(this.klubyListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NejlepsiKlubyDialog";
            this.Text = "Nejlepší kluby";
            this.Load += new System.EventHandler(this.NejlepsiKlubyDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox klubyListBox;
        private System.Windows.Forms.TextBox golPocetTextBox;
        private System.Windows.Forms.Button okButton;
    }
}