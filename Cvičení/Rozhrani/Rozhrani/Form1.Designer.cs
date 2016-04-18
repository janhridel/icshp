namespace Rozhrani
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
            this.celaCislaListBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pocetLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seznamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přidatNaZačátekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přidatNaKonecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.vymazatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.konecProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.napovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generovatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.vymazatDuplicitníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seřaďToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // celaCislaListBox
            // 
            this.celaCislaListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.celaCislaListBox.FormattingEnabled = true;
            this.celaCislaListBox.ItemHeight = 24;
            this.celaCislaListBox.Location = new System.Drawing.Point(12, 25);
            this.celaCislaListBox.Name = "celaCislaListBox";
            this.celaCislaListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.celaCislaListBox.Size = new System.Drawing.Size(307, 268);
            this.celaCislaListBox.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.pocetLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 314);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(331, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabel1.Text = "Počet prvků:";
            // 
            // pocetLabel
            // 
            this.pocetLabel.Name = "pocetLabel";
            this.pocetLabel.Size = new System.Drawing.Size(13, 17);
            this.pocetLabel.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seznamToolStripMenuItem,
            this.napovědaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(331, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seznamToolStripMenuItem
            // 
            this.seznamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generovatToolStripMenuItem,
            this.toolStripSeparator3,
            this.přidatNaZačátekToolStripMenuItem,
            this.přidatNaKonecToolStripMenuItem,
            this.toolStripSeparator1,
            this.vymazatToolStripMenuItem,
            this.vymazatDuplicitníToolStripMenuItem,
            this.toolStripSeparator4,
            this.seřaďToolStripMenuItem,
            this.toolStripSeparator2,
            this.konecProgramuToolStripMenuItem});
            this.seznamToolStripMenuItem.Name = "seznamToolStripMenuItem";
            this.seznamToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.seznamToolStripMenuItem.Text = "Seznam";
            // 
            // přidatNaZačátekToolStripMenuItem
            // 
            this.přidatNaZačátekToolStripMenuItem.Name = "přidatNaZačátekToolStripMenuItem";
            this.přidatNaZačátekToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.přidatNaZačátekToolStripMenuItem.Text = "Přidat na začátek...";
            this.přidatNaZačátekToolStripMenuItem.Click += new System.EventHandler(this.přidatNaZačátekToolStripMenuItem_Click);
            // 
            // přidatNaKonecToolStripMenuItem
            // 
            this.přidatNaKonecToolStripMenuItem.Name = "přidatNaKonecToolStripMenuItem";
            this.přidatNaKonecToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.přidatNaKonecToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.přidatNaKonecToolStripMenuItem.Text = "Přidat na konec...";
            this.přidatNaKonecToolStripMenuItem.Click += new System.EventHandler(this.přidatNaKonecToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // vymazatToolStripMenuItem
            // 
            this.vymazatToolStripMenuItem.Name = "vymazatToolStripMenuItem";
            this.vymazatToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.vymazatToolStripMenuItem.Text = "Vymazat";
            this.vymazatToolStripMenuItem.Click += new System.EventHandler(this.vymazatToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // konecProgramuToolStripMenuItem
            // 
            this.konecProgramuToolStripMenuItem.Name = "konecProgramuToolStripMenuItem";
            this.konecProgramuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.konecProgramuToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.konecProgramuToolStripMenuItem.Text = "Konec programu";
            this.konecProgramuToolStripMenuItem.Click += new System.EventHandler(this.konecProgramuToolStripMenuItem_Click);
            // 
            // napovědaToolStripMenuItem
            // 
            this.napovědaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem});
            this.napovědaToolStripMenuItem.Name = "napovědaToolStripMenuItem";
            this.napovědaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.napovědaToolStripMenuItem.Text = "Napověda";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.oProgramuToolStripMenuItem.Text = "O programu...";
            // 
            // generovatToolStripMenuItem
            // 
            this.generovatToolStripMenuItem.Name = "generovatToolStripMenuItem";
            this.generovatToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.generovatToolStripMenuItem.Text = "Generovat";
            this.generovatToolStripMenuItem.Click += new System.EventHandler(this.generovatToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(205, 6);
            // 
            // vymazatDuplicitníToolStripMenuItem
            // 
            this.vymazatDuplicitníToolStripMenuItem.Name = "vymazatDuplicitníToolStripMenuItem";
            this.vymazatDuplicitníToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.vymazatDuplicitníToolStripMenuItem.Text = "Vymazat duplicitní";
            this.vymazatDuplicitníToolStripMenuItem.Click += new System.EventHandler(this.vymazatDuplicitníToolStripMenuItem_Click);
            // 
            // seřaďToolStripMenuItem
            // 
            this.seřaďToolStripMenuItem.Name = "seřaďToolStripMenuItem";
            this.seřaďToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.seřaďToolStripMenuItem.Text = "Seřaď";
            this.seřaďToolStripMenuItem.Click += new System.EventHandler(this.seřaďToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(205, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 336);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.celaCislaListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Seznam čísel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox celaCislaListBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel pocetLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seznamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přidatNaZačátekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přidatNaKonecToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem vymazatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem konecProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem napovědaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generovatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem vymazatDuplicitníToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem seřaďToolStripMenuItem;
    }
}

