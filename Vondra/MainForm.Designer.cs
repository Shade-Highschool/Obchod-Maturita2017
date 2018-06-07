namespace Vondra
{
    partial class MainForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vytvořitNovýProduktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editovatProduktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smazatProduktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zobrazDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zobrazBezdrátovéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zobrazNejlevnějšíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cenaZaWattToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(718, 498);
            this.listBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.editaceToolStripMenuItem,
            this.informaceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uložDataToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // editaceToolStripMenuItem
            // 
            this.editaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vytvořitNovýProduktToolStripMenuItem,
            this.editovatProduktToolStripMenuItem,
            this.smazatProduktToolStripMenuItem});
            this.editaceToolStripMenuItem.Name = "editaceToolStripMenuItem";
            this.editaceToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.editaceToolStripMenuItem.Text = "Editace";
            // 
            // vytvořitNovýProduktToolStripMenuItem
            // 
            this.vytvořitNovýProduktToolStripMenuItem.Name = "vytvořitNovýProduktToolStripMenuItem";
            this.vytvořitNovýProduktToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.vytvořitNovýProduktToolStripMenuItem.Text = "Vytvořit nový produkt";
            this.vytvořitNovýProduktToolStripMenuItem.Click += new System.EventHandler(this.vytvořitNovýProduktToolStripMenuItem_Click);
            // 
            // editovatProduktToolStripMenuItem
            // 
            this.editovatProduktToolStripMenuItem.Name = "editovatProduktToolStripMenuItem";
            this.editovatProduktToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.editovatProduktToolStripMenuItem.Text = "Editovat produkt";
            this.editovatProduktToolStripMenuItem.Click += new System.EventHandler(this.editovatProduktToolStripMenuItem_Click);
            // 
            // smazatProduktToolStripMenuItem
            // 
            this.smazatProduktToolStripMenuItem.Name = "smazatProduktToolStripMenuItem";
            this.smazatProduktToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.smazatProduktToolStripMenuItem.Text = "Smazat produkt";
            this.smazatProduktToolStripMenuItem.Click += new System.EventHandler(this.smazatProduktToolStripMenuItem_Click);
            // 
            // uložDataToolStripMenuItem
            // 
            this.uložDataToolStripMenuItem.Name = "uložDataToolStripMenuItem";
            this.uložDataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uložDataToolStripMenuItem.Text = "Ulož data";
            this.uložDataToolStripMenuItem.Click += new System.EventHandler(this.uložDataToolStripMenuItem_Click);
            // 
            // informaceToolStripMenuItem
            // 
            this.informaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zobrazDetailToolStripMenuItem,
            this.zobrazBezdrátovéToolStripMenuItem,
            this.zobrazNejlevnějšíToolStripMenuItem,
            this.cenaZaWattToolStripMenuItem1});
            this.informaceToolStripMenuItem.Name = "informaceToolStripMenuItem";
            this.informaceToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.informaceToolStripMenuItem.Text = "Informace";
            // 
            // zobrazDetailToolStripMenuItem
            // 
            this.zobrazDetailToolStripMenuItem.Name = "zobrazDetailToolStripMenuItem";
            this.zobrazDetailToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.zobrazDetailToolStripMenuItem.Text = "Zobraz detail";
            this.zobrazDetailToolStripMenuItem.Click += new System.EventHandler(this.zobrazDetailToolStripMenuItem_Click);
            // 
            // zobrazBezdrátovéToolStripMenuItem
            // 
            this.zobrazBezdrátovéToolStripMenuItem.Name = "zobrazBezdrátovéToolStripMenuItem";
            this.zobrazBezdrátovéToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.zobrazBezdrátovéToolStripMenuItem.Text = "Zobraz bezdrátové";
            this.zobrazBezdrátovéToolStripMenuItem.Click += new System.EventHandler(this.zobrazBezdrátovéToolStripMenuItem_Click);
            // 
            // zobrazNejlevnějšíToolStripMenuItem
            // 
            this.zobrazNejlevnějšíToolStripMenuItem.Name = "zobrazNejlevnějšíToolStripMenuItem";
            this.zobrazNejlevnějšíToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.zobrazNejlevnějšíToolStripMenuItem.Text = "Zobraz nejlevnější";
            this.zobrazNejlevnějšíToolStripMenuItem.Click += new System.EventHandler(this.zobrazNejlevnějšíToolStripMenuItem_Click);
            // 
            // cenaZaWattToolStripMenuItem1
            // 
            this.cenaZaWattToolStripMenuItem1.Name = "cenaZaWattToolStripMenuItem1";
            this.cenaZaWattToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.cenaZaWattToolStripMenuItem1.Text = "Cena za watt";
            this.cenaZaWattToolStripMenuItem1.Click += new System.EventHandler(this.cenaZaWattToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 522);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vytvořitNovýProduktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editovatProduktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smazatProduktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zobrazDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zobrazBezdrátovéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zobrazNejlevnějšíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cenaZaWattToolStripMenuItem1;
    }
}

