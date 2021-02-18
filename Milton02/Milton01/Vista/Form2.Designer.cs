
namespace Milton01.Vista
{
    partial class Form2
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
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.misionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionToolStripMenuItem1,
            this.misionToolStripMenuItem1,
            this.listaDeUsuariosToolStripMenuItem});
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.informaciónToolStripMenuItem.Text = "Información";
            // 
            // visionToolStripMenuItem1
            // 
            this.visionToolStripMenuItem1.Name = "visionToolStripMenuItem1";
            this.visionToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.visionToolStripMenuItem1.Text = "Vision";
            this.visionToolStripMenuItem1.Click += new System.EventHandler(this.visionToolStripMenuItem1_Click);
            // 
            // misionToolStripMenuItem1
            // 
            this.misionToolStripMenuItem1.Name = "misionToolStripMenuItem1";
            this.misionToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.misionToolStripMenuItem1.Text = "Mision";
            this.misionToolStripMenuItem1.Click += new System.EventHandler(this.misionToolStripMenuItem1_Click);
            // 
            // listaDeUsuariosToolStripMenuItem
            // 
            this.listaDeUsuariosToolStripMenuItem.Name = "listaDeUsuariosToolStripMenuItem";
            this.listaDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listaDeUsuariosToolStripMenuItem.Text = "Lista de Usuarios";
            this.listaDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.listaDeUsuariosToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem misionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDeUsuariosToolStripMenuItem;
    }
}