namespace DeliveryExpressClient
{
    partial class EmlpoyeeContainer
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
            this.orderMenuStrip = new System.Windows.Forms.MenuStrip();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderMenuStrip
            // 
            this.orderMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem,
            this.updateOrderToolStripMenuItem});
            this.orderMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.orderMenuStrip.Name = "orderMenuStrip";
            this.orderMenuStrip.Size = new System.Drawing.Size(384, 24);
            this.orderMenuStrip.TabIndex = 1;
            this.orderMenuStrip.Text = "menuStrip1";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.newOrderToolStripMenuItem.Text = "New Order";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.menu_Clicked);
            // 
            // updateOrderToolStripMenuItem
            // 
            this.updateOrderToolStripMenuItem.Name = "updateOrderToolStripMenuItem";
            this.updateOrderToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.updateOrderToolStripMenuItem.Text = "Update Order";
            this.updateOrderToolStripMenuItem.Click += new System.EventHandler(this.menu_Clicked);
            // 
            // EmlpoyeeContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.orderMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.orderMenuStrip;
            this.Name = "EmlpoyeeContainer";
            this.Text = "EMPLOYEE INTERFACE";
            this.Load += new System.EventHandler(this.EmlpoyeeContainer_Load);
            this.orderMenuStrip.ResumeLayout(false);
            this.orderMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip orderMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateOrderToolStripMenuItem;
    }
}