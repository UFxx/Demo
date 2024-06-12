namespace Demo
{
    partial class GuestForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSet = new Demo.DemoDataSet();
            this.productsTableAdapter = new Demo.DemoDataSetTableAdapters.ProductsTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginAsGuestLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDproductDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productCategoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDproductDataGridViewTextBoxColumn
            // 
            this.iDproductDataGridViewTextBoxColumn.DataPropertyName = "ID_product";
            this.iDproductDataGridViewTextBoxColumn.HeaderText = "ID_product";
            this.iDproductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDproductDataGridViewTextBoxColumn.Name = "iDproductDataGridViewTextBoxColumn";
            this.iDproductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            this.productDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productCategoryDataGridViewTextBoxColumn
            // 
            this.productCategoryDataGridViewTextBoxColumn.DataPropertyName = "ProductCategory";
            this.productCategoryDataGridViewTextBoxColumn.HeaderText = "ProductCategory";
            this.productCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productCategoryDataGridViewTextBoxColumn.Name = "productCategoryDataGridViewTextBoxColumn";
            this.productCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.demoDataSet;
            // 
            // demoDataSet
            // 
            this.demoDataSet.DataSetName = "DemoDataSet";
            this.demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // loginAsGuestLabel
            // 
            this.loginAsGuestLabel.AutoSize = true;
            this.loginAsGuestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginAsGuestLabel.ForeColor = System.Drawing.Color.Silver;
            this.loginAsGuestLabel.Location = new System.Drawing.Point(278, 290);
            this.loginAsGuestLabel.Name = "loginAsGuestLabel";
            this.loginAsGuestLabel.Size = new System.Drawing.Size(243, 29);
            this.loginAsGuestLabel.TabIndex = 3;
            this.loginAsGuestLabel.Text = "Вы вошли как Гость";
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginAsGuestLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GuestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аккаунт Гостя";
            this.Load += new System.EventHandler(this.GuestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DemoDataSet demoDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DemoDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.Label loginAsGuestLabel;
    }
}