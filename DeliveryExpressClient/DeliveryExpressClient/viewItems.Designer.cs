namespace DeliveryExpressClient
{
    partial class viewItems
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
            this.itemsGridView = new System.Windows.Forms.DataGridView();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsGridView
            // 
            this.itemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGridView.Location = new System.Drawing.Point(2, 63);
            this.itemsGridView.Name = "itemsGridView";
            this.itemsGridView.Size = new System.Drawing.Size(783, 455);
            this.itemsGridView.TabIndex = 0;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(67, 22);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(153, 20);
            this.txtItemName.TabIndex = 1;
            this.txtItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onsearchbox_KeyPressed);
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(12, 25);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(52, 15);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            // 
            // viewItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 517);
            this.Controls.Add(this.search);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.itemsGridView);
            this.Name = "viewItems";
            this.Text = "VIEW ITEMS";
            this.Load += new System.EventHandler(this.viewItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itemsGridView;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label search;
    }
}