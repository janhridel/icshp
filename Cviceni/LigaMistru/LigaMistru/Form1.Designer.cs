namespace LigaMistru
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.jmenoColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.klubColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.golyColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pridejButton = new System.Windows.Forms.Button();
            this.vymazButton = new System.Windows.Forms.Button();
            this.upravButton = new System.Windows.Forms.Button();
            this.nejlepsiButton = new System.Windows.Forms.Button();
            this.registrovatButton = new System.Windows.Forms.Button();
            this.zrusitButton = new System.Windows.Forms.Button();
            this.konecProgramu = new System.Windows.Forms.Button();
            this.protokolTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.jmenoColumn,
            this.klubColumn,
            this.golyColumn});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(295, 197);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // jmenoColumn
            // 
            this.jmenoColumn.Text = "Jméno";
            this.jmenoColumn.Width = 74;
            // 
            // klubColumn
            // 
            this.klubColumn.Text = "Klub";
            this.klubColumn.Width = 77;
            // 
            // golyColumn
            // 
            this.golyColumn.Text = "Góly";
            // 
            // pridejButton
            // 
            this.pridejButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pridejButton.Location = new System.Drawing.Point(313, 12);
            this.pridejButton.Name = "pridejButton";
            this.pridejButton.Size = new System.Drawing.Size(75, 23);
            this.pridejButton.TabIndex = 1;
            this.pridejButton.Text = "Přidej...";
            this.pridejButton.UseVisualStyleBackColor = true;
            this.pridejButton.Click += new System.EventHandler(this.pridejButton_Click);
            // 
            // vymazButton
            // 
            this.vymazButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.vymazButton.Location = new System.Drawing.Point(313, 41);
            this.vymazButton.Name = "vymazButton";
            this.vymazButton.Size = new System.Drawing.Size(75, 23);
            this.vymazButton.TabIndex = 2;
            this.vymazButton.Text = "Vymaž";
            this.vymazButton.UseVisualStyleBackColor = true;
            this.vymazButton.Click += new System.EventHandler(this.vymazButton_Click);
            // 
            // upravButton
            // 
            this.upravButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.upravButton.Location = new System.Drawing.Point(313, 70);
            this.upravButton.Name = "upravButton";
            this.upravButton.Size = new System.Drawing.Size(75, 23);
            this.upravButton.TabIndex = 3;
            this.upravButton.Text = "Upravit...";
            this.upravButton.UseVisualStyleBackColor = true;
            this.upravButton.Click += new System.EventHandler(this.upravButton_Click);
            // 
            // nejlepsiButton
            // 
            this.nejlepsiButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nejlepsiButton.Location = new System.Drawing.Point(313, 99);
            this.nejlepsiButton.Name = "nejlepsiButton";
            this.nejlepsiButton.Size = new System.Drawing.Size(75, 23);
            this.nejlepsiButton.TabIndex = 4;
            this.nejlepsiButton.Text = "Nejlepší...";
            this.nejlepsiButton.UseVisualStyleBackColor = true;
            this.nejlepsiButton.Click += new System.EventHandler(this.nejlepsiButton_Click);
            // 
            // registrovatButton
            // 
            this.registrovatButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.registrovatButton.Location = new System.Drawing.Point(313, 128);
            this.registrovatButton.Name = "registrovatButton";
            this.registrovatButton.Size = new System.Drawing.Size(75, 23);
            this.registrovatButton.TabIndex = 5;
            this.registrovatButton.Text = "Registrovat";
            this.registrovatButton.UseVisualStyleBackColor = true;
            this.registrovatButton.Click += new System.EventHandler(this.registrovatButton_Click);
            // 
            // zrusitButton
            // 
            this.zrusitButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.zrusitButton.Location = new System.Drawing.Point(313, 157);
            this.zrusitButton.Name = "zrusitButton";
            this.zrusitButton.Size = new System.Drawing.Size(75, 23);
            this.zrusitButton.TabIndex = 6;
            this.zrusitButton.Text = "Zrušit";
            this.zrusitButton.UseVisualStyleBackColor = true;
            this.zrusitButton.Click += new System.EventHandler(this.zrusitButton_Click);
            // 
            // konecProgramu
            // 
            this.konecProgramu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.konecProgramu.Location = new System.Drawing.Point(313, 186);
            this.konecProgramu.Name = "konecProgramu";
            this.konecProgramu.Size = new System.Drawing.Size(75, 23);
            this.konecProgramu.TabIndex = 7;
            this.konecProgramu.Text = "Konec";
            this.konecProgramu.UseVisualStyleBackColor = true;
            this.konecProgramu.Click += new System.EventHandler(this.konecProgramu_Click);
            // 
            // protokolTextBox
            // 
            this.protokolTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.protokolTextBox.Location = new System.Drawing.Point(12, 215);
            this.protokolTextBox.Multiline = true;
            this.protokolTextBox.Name = "protokolTextBox";
            this.protokolTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.protokolTextBox.Size = new System.Drawing.Size(374, 57);
            this.protokolTextBox.TabIndex = 8;
            this.protokolTextBox.TextChanged += new System.EventHandler(this.protokolTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 282);
            this.Controls.Add(this.protokolTextBox);
            this.Controls.Add(this.konecProgramu);
            this.Controls.Add(this.zrusitButton);
            this.Controls.Add(this.registrovatButton);
            this.Controls.Add(this.nejlepsiButton);
            this.Controls.Add(this.upravButton);
            this.Controls.Add(this.vymazButton);
            this.Controls.Add(this.pridejButton);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Liga Mistrů";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader jmenoColumn;
        private System.Windows.Forms.ColumnHeader klubColumn;
        private System.Windows.Forms.ColumnHeader golyColumn;
        private System.Windows.Forms.Button pridejButton;
        private System.Windows.Forms.Button vymazButton;
        private System.Windows.Forms.Button upravButton;
        private System.Windows.Forms.Button nejlepsiButton;
        private System.Windows.Forms.Button registrovatButton;
        private System.Windows.Forms.Button zrusitButton;
        private System.Windows.Forms.Button konecProgramu;
        private System.Windows.Forms.TextBox protokolTextBox;
    }
}

