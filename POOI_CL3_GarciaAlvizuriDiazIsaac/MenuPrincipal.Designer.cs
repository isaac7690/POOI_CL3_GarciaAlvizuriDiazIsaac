namespace POOI_CL3_GarciaAlvizuriDiazIsaac
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mNTENIMIENTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTADODEESPECIALIDADESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTADODEENFERMEROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOENFERMEROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCTUALIZARENFERMEROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mNTENIMIENTOToolStripMenuItem,
            this.lISTADOSToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // mNTENIMIENTOToolStripMenuItem
            // 
            this.mNTENIMIENTOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVOENFERMEROToolStripMenuItem,
            this.aCTUALIZARENFERMEROToolStripMenuItem});
            this.mNTENIMIENTOToolStripMenuItem.Name = "mNTENIMIENTOToolStripMenuItem";
            this.mNTENIMIENTOToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.mNTENIMIENTOToolStripMenuItem.Text = "MANTENIMIENTO";
            // 
            // lISTADOSToolStripMenuItem
            // 
            this.lISTADOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lISTADODEESPECIALIDADESToolStripMenuItem,
            this.lISTADODEENFERMEROSToolStripMenuItem});
            this.lISTADOSToolStripMenuItem.Name = "lISTADOSToolStripMenuItem";
            this.lISTADOSToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.lISTADOSToolStripMenuItem.Text = "LISTADOS";
            // 
            // lISTADODEESPECIALIDADESToolStripMenuItem
            // 
            this.lISTADODEESPECIALIDADESToolStripMenuItem.Name = "lISTADODEESPECIALIDADESToolStripMenuItem";
            this.lISTADODEESPECIALIDADESToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.lISTADODEESPECIALIDADESToolStripMenuItem.Text = "LISTADO DE ESPECIALIDADES";
            // 
            // lISTADODEENFERMEROSToolStripMenuItem
            // 
            this.lISTADODEENFERMEROSToolStripMenuItem.Name = "lISTADODEENFERMEROSToolStripMenuItem";
            this.lISTADODEENFERMEROSToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.lISTADODEENFERMEROSToolStripMenuItem.Text = "LISTADO DE ENFERMEROS";
            // 
            // nUEVOENFERMEROToolStripMenuItem
            // 
            this.nUEVOENFERMEROToolStripMenuItem.Name = "nUEVOENFERMEROToolStripMenuItem";
            this.nUEVOENFERMEROToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.nUEVOENFERMEROToolStripMenuItem.Text = "NUEVO ENFERMERO";
            // 
            // aCTUALIZARENFERMEROToolStripMenuItem
            // 
            this.aCTUALIZARENFERMEROToolStripMenuItem.Name = "aCTUALIZARENFERMEROToolStripMenuItem";
            this.aCTUALIZARENFERMEROToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.aCTUALIZARENFERMEROToolStripMenuItem.Text = "ACTUALIZAR ENFERMERO";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mNTENIMIENTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUEVOENFERMEROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCTUALIZARENFERMEROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTADODEESPECIALIDADESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTADODEENFERMEROSToolStripMenuItem;
    }
}



