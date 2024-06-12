namespace Demo
{
    partial class WorkerPersonalAccount
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
            this.demoDataSet2 = new Demo.DemoDataSet2();
            this.productsTableAdapter = new Demo.DemoDataSet2TableAdapters.ProductsTableAdapter();
            this.addProductTitle = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.productDesriptionLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productCategoryTextBox = new System.Windows.Forms.TextBox();
            this.productDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.deleteProductLabelTitle = new System.Windows.Forms.Label();
            this.deleteProductLabel = new System.Windows.Forms.Label();
            this.deleteProductTextbox = new System.Windows.Forms.TextBox();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDproductDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productCategoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
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
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productCategoryDataGridViewTextBoxColumn
            // 
            this.productCategoryDataGridViewTextBoxColumn.DataPropertyName = "ProductCategory";
            this.productCategoryDataGridViewTextBoxColumn.HeaderText = "ProductCategory";
            this.productCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productCategoryDataGridViewTextBoxColumn.Name = "productCategoryDataGridViewTextBoxColumn";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.demoDataSet2;
            // 
            // demoDataSet2
            // 
            this.demoDataSet2.DataSetName = "DemoDataSet2";
            this.demoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // addProductTitle
            // 
            this.addProductTitle.AutoSize = true;
            this.addProductTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.addProductTitle.Location = new System.Drawing.Point(128, 206);
            this.addProductTitle.Name = "addProductTitle";
            this.addProductTitle.Size = new System.Drawing.Size(201, 29);
            this.addProductTitle.TabIndex = 1;
            this.addProductTitle.Text = "Добавить товар:";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.productNameLabel.Location = new System.Drawing.Point(12, 270);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(217, 29);
            this.productNameLabel.TabIndex = 2;
            this.productNameLabel.Text = "Название товара:";
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.productCategoryLabel.Location = new System.Drawing.Point(12, 311);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(227, 29);
            this.productCategoryLabel.TabIndex = 3;
            this.productCategoryLabel.Text = "Категория товара:";
            // 
            // productDesriptionLabel
            // 
            this.productDesriptionLabel.AutoSize = true;
            this.productDesriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.productDesriptionLabel.Location = new System.Drawing.Point(13, 349);
            this.productDesriptionLabel.Name = "productDesriptionLabel";
            this.productDesriptionLabel.Size = new System.Drawing.Size(222, 29);
            this.productDesriptionLabel.TabIndex = 4;
            this.productDesriptionLabel.Text = "Описание товара:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(253, 277);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(164, 22);
            this.productNameTextBox.TabIndex = 5;
            // 
            // productCategoryTextBox
            // 
            this.productCategoryTextBox.Location = new System.Drawing.Point(253, 318);
            this.productCategoryTextBox.Name = "productCategoryTextBox";
            this.productCategoryTextBox.Size = new System.Drawing.Size(164, 22);
            this.productCategoryTextBox.TabIndex = 6;
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.Location = new System.Drawing.Point(253, 356);
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(164, 96);
            this.productDescriptionTextBox.TabIndex = 7;
            this.productDescriptionTextBox.Text = "";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(289, 474);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(93, 38);
            this.addProductButton.TabIndex = 8;
            this.addProductButton.Text = "Добавить";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // deleteProductLabelTitle
            // 
            this.deleteProductLabelTitle.AutoSize = true;
            this.deleteProductLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.deleteProductLabelTitle.Location = new System.Drawing.Point(538, 206);
            this.deleteProductLabelTitle.Name = "deleteProductLabelTitle";
            this.deleteProductLabelTitle.Size = new System.Drawing.Size(190, 29);
            this.deleteProductLabelTitle.TabIndex = 9;
            this.deleteProductLabelTitle.Text = "Удалить товар:";
            // 
            // deleteProductLabel
            // 
            this.deleteProductLabel.AutoSize = true;
            this.deleteProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.deleteProductLabel.Location = new System.Drawing.Point(509, 270);
            this.deleteProductLabel.Name = "deleteProductLabel";
            this.deleteProductLabel.Size = new System.Drawing.Size(257, 29);
            this.deleteProductLabel.TabIndex = 10;
            this.deleteProductLabel.Text = "Введите ID продукта:";
            // 
            // deleteProductTextbox
            // 
            this.deleteProductTextbox.Location = new System.Drawing.Point(514, 311);
            this.deleteProductTextbox.Name = "deleteProductTextbox";
            this.deleteProductTextbox.Size = new System.Drawing.Size(108, 22);
            this.deleteProductTextbox.TabIndex = 11;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(642, 308);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(124, 29);
            this.deleteProductButton.TabIndex = 12;
            this.deleteProductButton.Text = "Удалить";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // WorkerPersonalAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.deleteProductTextbox);
            this.Controls.Add(this.deleteProductLabel);
            this.Controls.Add(this.deleteProductLabelTitle);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.productDescriptionTextBox);
            this.Controls.Add(this.productCategoryTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productDesriptionLabel);
            this.Controls.Add(this.productCategoryLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.addProductTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WorkerPersonalAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аккаунт сотрудника";
            this.Load += new System.EventHandler(this.WorkerPersonalAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DemoDataSet2 demoDataSet2;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DemoDataSet2TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label addProductTitle;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productCategoryLabel;
        private System.Windows.Forms.Label productDesriptionLabel;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productCategoryTextBox;
        private System.Windows.Forms.RichTextBox productDescriptionTextBox;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Label deleteProductLabelTitle;
        private System.Windows.Forms.Label deleteProductLabel;
        private System.Windows.Forms.TextBox deleteProductTextbox;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
    }
}