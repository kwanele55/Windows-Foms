namespace CRUDONT2030
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            New_Product = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ProductsTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ProductsTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 0;
            label1.Text = "List of Products";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // New_Product
            // 
            New_Product.Location = new Point(1207, 319);
            New_Product.Name = "New_Product";
            New_Product.Size = new Size(75, 23);
            New_Product.TabIndex = 1;
            New_Product.Text = "button1";
            New_Product.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.AutoSize = true;
            btnCreate.BackColor = SystemColors.Info;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(12, 31);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(88, 27);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Add Product";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = SystemColors.Info;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(481, 31);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 27);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Product";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = SystemColors.Info;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(684, 31);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 27);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Product";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // ProductsTable
            // 
            ProductsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsTable.Location = new Point(12, 82);
            ProductsTable.MultiSelect = false;
            ProductsTable.Name = "ProductsTable";
            ProductsTable.RowHeadersVisible = false;
            ProductsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsTable.Size = new Size(776, 356);
            ProductsTable.TabIndex = 5;
            ProductsTable.CellContentClick += ProductsTable_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProductsTable);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(New_Product);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Products Manager";
            ((System.ComponentModel.ISupportInitialize)ProductsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button New_Product;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView ProductsTable;
    }
}
