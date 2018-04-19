namespace DeliveryExpressClient
{
    partial class FrmContainer
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
            this.fileMenuStrip = new System.Windows.Forms.MenuStrip();
            this.NewItemStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateItemStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewItemsStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileMenuStrip
            // 
            this.fileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewItemStrip,
            this.UpdateItemStrip,
            this.ViewItemsStrip});
            this.fileMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.fileMenuStrip.Name = "fileMenuStrip";
            this.fileMenuStrip.Size = new System.Drawing.Size(742, 24);
            this.fileMenuStrip.TabIndex = 1;
            this.fileMenuStrip.Text = "file";
            // 
            // NewItemStrip
            // 
            this.NewItemStrip.Name = "NewItemStrip";
            this.NewItemStrip.Size = new System.Drawing.Size(70, 20);
            this.NewItemStrip.Text = "New Item";
            this.NewItemStrip.Click += new System.EventHandler(this.menuClicked);
            // 
            // UpdateItemStrip
            // 
            this.UpdateItemStrip.Name = "UpdateItemStrip";
            this.UpdateItemStrip.Size = new System.Drawing.Size(84, 20);
            this.UpdateItemStrip.Text = "Update Item";
            this.UpdateItemStrip.Click += new System.EventHandler(this.menuClicked);
            // 
            // ViewItemsStrip
            // 
            this.ViewItemsStrip.Name = "ViewItemsStrip";
            this.ViewItemsStrip.Size = new System.Drawing.Size(76, 20);
            this.ViewItemsStrip.Text = "View Items";
            this.ViewItemsStrip.Click += new System.EventHandler(this.menuClicked);
            // 
            // FrmContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 506);
            this.Controls.Add(this.fileMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.fileMenuStrip;
            this.Name = "FrmContainer";
            this.Text = "DeliveryExpress";
            this.fileMenuStrip.ResumeLayout(false);
            this.fileMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip fileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NewItemStrip;
        private System.Windows.Forms.ToolStripMenuItem UpdateItemStrip;
        private System.Windows.Forms.ToolStripMenuItem ViewItemsStrip;
    }
}

