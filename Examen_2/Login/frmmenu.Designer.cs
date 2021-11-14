namespace Login
{
    partial class frmmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiposDeSoporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeSoporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiketesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeSoporteToolStripMenuItem,
            this.estadoDeSoporteToolStripMenuItem,
            this.tiketesToolStripMenuItem,
            this.detalleToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tiposDeSoporteToolStripMenuItem
            // 
            this.tiposDeSoporteToolStripMenuItem.Name = "tiposDeSoporteToolStripMenuItem";
            this.tiposDeSoporteToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.tiposDeSoporteToolStripMenuItem.Text = "Tipos de soporte";
            this.tiposDeSoporteToolStripMenuItem.Click += new System.EventHandler(this.tiposDeSoporteToolStripMenuItem_Click);
            // 
            // estadoDeSoporteToolStripMenuItem
            // 
            this.estadoDeSoporteToolStripMenuItem.Name = "estadoDeSoporteToolStripMenuItem";
            this.estadoDeSoporteToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.estadoDeSoporteToolStripMenuItem.Text = "Estado de soporte ";
            this.estadoDeSoporteToolStripMenuItem.Click += new System.EventHandler(this.estadoDeSoporteToolStripMenuItem_Click);
            // 
            // tiketesToolStripMenuItem
            // 
            this.tiketesToolStripMenuItem.Name = "tiketesToolStripMenuItem";
            this.tiketesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.tiketesToolStripMenuItem.Text = "Tiketes ";
            this.tiketesToolStripMenuItem.Click += new System.EventHandler(this.tiketesToolStripMenuItem_Click);
            // 
            // detalleToolStripMenuItem
            // 
            this.detalleToolStripMenuItem.Name = "detalleToolStripMenuItem";
            this.detalleToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.detalleToolStripMenuItem.Text = "Detalle";
            this.detalleToolStripMenuItem.Click += new System.EventHandler(this.detalleToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "frmmenu";
            this.Text = "frmmenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiposDeSoporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoDeSoporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiketesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}