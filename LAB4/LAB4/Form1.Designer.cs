
namespace LAB4
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
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.btnListProducts = new System.Windows.Forms.Button();
            this.btnListSuppliers = new System.Windows.Forms.Button();
            this.btnListCategories = new System.Windows.Forms.Button();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnSearchSuppliers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(13, 174);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(801, 264);
            this.dataTable.TabIndex = 0;
            // 
            // btnListProducts
            // 
            this.btnListProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListProducts.Location = new System.Drawing.Point(113, 48);
            this.btnListProducts.Name = "btnListProducts";
            this.btnListProducts.Size = new System.Drawing.Size(142, 23);
            this.btnListProducts.TabIndex = 1;
            this.btnListProducts.Text = "List all Products";
            this.btnListProducts.UseVisualStyleBackColor = true;
            this.btnListProducts.Click += new System.EventHandler(this.btnListProducts_Click);
            // 
            // btnListSuppliers
            // 
            this.btnListSuppliers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListSuppliers.Location = new System.Drawing.Point(347, 48);
            this.btnListSuppliers.Name = "btnListSuppliers";
            this.btnListSuppliers.Size = new System.Drawing.Size(142, 23);
            this.btnListSuppliers.TabIndex = 2;
            this.btnListSuppliers.Text = "List all Suppliers";
            this.btnListSuppliers.UseVisualStyleBackColor = true;
            this.btnListSuppliers.Click += new System.EventHandler(this.btnListSuppliers_Click);
            // 
            // btnListCategories
            // 
            this.btnListCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListCategories.Location = new System.Drawing.Point(583, 48);
            this.btnListCategories.Name = "btnListCategories";
            this.btnListCategories.Size = new System.Drawing.Size(142, 23);
            this.btnListCategories.TabIndex = 3;
            this.btnListCategories.Text = "List all Categories\r\n";
            this.btnListCategories.UseVisualStyleBackColor = true;
            this.btnListCategories.Click += new System.EventHandler(this.btnListCategories_Click);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchProduct.Location = new System.Drawing.Point(170, 117);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(210, 23);
            this.btnSearchProduct.TabIndex = 4;
            this.btnSearchProduct.Text = "Search Products By Product Name";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // btnSearchSuppliers
            // 
            this.btnSearchSuppliers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchSuppliers.Location = new System.Drawing.Point(456, 117);
            this.btnSearchSuppliers.Name = "btnSearchSuppliers";
            this.btnSearchSuppliers.Size = new System.Drawing.Size(210, 23);
            this.btnSearchSuppliers.TabIndex = 5;
            this.btnSearchSuppliers.Text = "Search Suppliers by Company Name";
            this.btnSearchSuppliers.UseVisualStyleBackColor = true;
            this.btnSearchSuppliers.Click += new System.EventHandler(this.btnSearchSuppliers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.btnSearchSuppliers);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.btnListCategories);
            this.Controls.Add(this.btnListSuppliers);
            this.Controls.Add(this.btnListProducts);
            this.Controls.Add(this.dataTable);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAB4 - LE ANH TUAN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button btnListProducts;
        private System.Windows.Forms.Button btnListSuppliers;
        private System.Windows.Forms.Button btnListCategories;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Button btnSearchSuppliers;
    }
}

