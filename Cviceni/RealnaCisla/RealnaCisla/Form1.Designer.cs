namespace RealnaCisla
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
            this.cislaListBox = new System.Windows.Forms.ListBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otevřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generovatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kulturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.výchozíWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.češtinaČeskáRepublikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angličtinaVelkáBritánieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angličtinaSpojenéStátyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portugalštinaPortugalskoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portugalštinaBrazílieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cislaListBox
            // 
            this.cislaListBox.ColumnWidth = 100;
            this.cislaListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cislaListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cislaListBox.FormattingEnabled = true;
            this.cislaListBox.ItemHeight = 25;
            this.cislaListBox.Location = new System.Drawing.Point(0, 24);
            this.cislaListBox.MultiColumn = true;
            this.cislaListBox.Name = "cislaListBox";
            this.cislaListBox.Size = new System.Drawing.Size(887, 451);
            this.cislaListBox.TabIndex = 0;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "cisla";
            this.saveFileDialog.Filter = "Textové soubory (*.txt)|*.txt|Binární soubory (*.bin)|*.bin";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Textové soubory (*.txt)|*.txt|Binární soubory (*.bin)|*.bin";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.kulturaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otevřítToolStripMenuItem,
            this.uložitJakoToolStripMenuItem,
            this.toolStripSeparator1,
            this.konecToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // otevřítToolStripMenuItem
            // 
            this.otevřítToolStripMenuItem.Name = "otevřítToolStripMenuItem";
            this.otevřítToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.otevřítToolStripMenuItem.Text = "Otevřít...";
            this.otevřítToolStripMenuItem.Click += new System.EventHandler(this.otevřítToolStripMenuItem_Click);
            // 
            // uložitJakoToolStripMenuItem
            // 
            this.uložitJakoToolStripMenuItem.Name = "uložitJakoToolStripMenuItem";
            this.uložitJakoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.uložitJakoToolStripMenuItem.Text = "Uložit jako...";
            this.uložitJakoToolStripMenuItem.Click += new System.EventHandler(this.uložitJakoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.konecToolStripMenuItem.Text = "Konec";
            this.konecToolStripMenuItem.Click += new System.EventHandler(this.konecToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generovatToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // generovatToolStripMenuItem
            // 
            this.generovatToolStripMenuItem.Name = "generovatToolStripMenuItem";
            this.generovatToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.generovatToolStripMenuItem.Text = "Generovat";
            this.generovatToolStripMenuItem.Click += new System.EventHandler(this.generovatToolStripMenuItem_Click);
            // 
            // kulturaToolStripMenuItem
            // 
            this.kulturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.výchozíWindowsToolStripMenuItem,
            this.češtinaČeskáRepublikaToolStripMenuItem,
            this.angličtinaVelkáBritánieToolStripMenuItem,
            this.angličtinaSpojenéStátyToolStripMenuItem,
            this.portugalštinaPortugalskoToolStripMenuItem,
            this.portugalštinaBrazílieToolStripMenuItem});
            this.kulturaToolStripMenuItem.Name = "kulturaToolStripMenuItem";
            this.kulturaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.kulturaToolStripMenuItem.Text = "Kultura";
            // 
            // výchozíWindowsToolStripMenuItem
            // 
            this.výchozíWindowsToolStripMenuItem.Name = "výchozíWindowsToolStripMenuItem";
            this.výchozíWindowsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.výchozíWindowsToolStripMenuItem.Text = "Výchozí (Windows)";
            this.výchozíWindowsToolStripMenuItem.Click += new System.EventHandler(this.výchozíWindowsToolStripMenuItem_Click);
            // 
            // češtinaČeskáRepublikaToolStripMenuItem
            // 
            this.češtinaČeskáRepublikaToolStripMenuItem.Name = "češtinaČeskáRepublikaToolStripMenuItem";
            this.češtinaČeskáRepublikaToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.češtinaČeskáRepublikaToolStripMenuItem.Text = "Čeština (Česká republika)";
            this.češtinaČeskáRepublikaToolStripMenuItem.Click += new System.EventHandler(this.češtinaČeskáRepublikaToolStripMenuItem_Click);
            // 
            // angličtinaVelkáBritánieToolStripMenuItem
            // 
            this.angličtinaVelkáBritánieToolStripMenuItem.Name = "angličtinaVelkáBritánieToolStripMenuItem";
            this.angličtinaVelkáBritánieToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.angličtinaVelkáBritánieToolStripMenuItem.Text = "Angličtina (Velká Británie)";
            this.angličtinaVelkáBritánieToolStripMenuItem.Click += new System.EventHandler(this.angličtinaVelkáBritánieToolStripMenuItem_Click);
            // 
            // angličtinaSpojenéStátyToolStripMenuItem
            // 
            this.angličtinaSpojenéStátyToolStripMenuItem.Name = "angličtinaSpojenéStátyToolStripMenuItem";
            this.angličtinaSpojenéStátyToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.angličtinaSpojenéStátyToolStripMenuItem.Text = "Angličtina (Spojené státy)";
            this.angličtinaSpojenéStátyToolStripMenuItem.Click += new System.EventHandler(this.angličtinaSpojenéStátyToolStripMenuItem_Click);
            // 
            // portugalštinaPortugalskoToolStripMenuItem
            // 
            this.portugalštinaPortugalskoToolStripMenuItem.Name = "portugalštinaPortugalskoToolStripMenuItem";
            this.portugalštinaPortugalskoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.portugalštinaPortugalskoToolStripMenuItem.Text = "Portugalština (Portugalsko)";
            this.portugalštinaPortugalskoToolStripMenuItem.Click += new System.EventHandler(this.portugalštinaPortugalskoToolStripMenuItem_Click);
            // 
            // portugalštinaBrazílieToolStripMenuItem
            // 
            this.portugalštinaBrazílieToolStripMenuItem.Name = "portugalštinaBrazílieToolStripMenuItem";
            this.portugalštinaBrazílieToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.portugalštinaBrazílieToolStripMenuItem.Text = "Portugalština (Brazílie)";
            this.portugalštinaBrazílieToolStripMenuItem.Click += new System.EventHandler(this.portugalštinaBrazílieToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 475);
            this.Controls.Add(this.cislaListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Prezentace reálných čísel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cislaListBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otevřítToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generovatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kulturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem výchozíWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem češtinaČeskáRepublikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem angličtinaVelkáBritánieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem angličtinaSpojenéStátyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portugalštinaPortugalskoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portugalštinaBrazílieToolStripMenuItem;
    }
}

