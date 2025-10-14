namespace CRUDONT2030
{
    partial class CreateEditForm
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
            createTitle = new Label();
            pId = new Label();
            pName = new Label();
            sId = new Label();
            cId = new Label();
            UnitPrice = new Label();
            Discontinued = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtProductName = new TextBox();
            txtSupplierId = new TextBox();
            txtCategoryId = new TextBox();
            txtUnitPrice = new TextBox();
            chkDiscontinued = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // createTitle
            // 
            createTitle.AutoSize = true;
            createTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTitle.Location = new Point(322, 9);
            createTitle.Name = "createTitle";
            createTitle.Size = new Size(119, 25);
            createTitle.TabIndex = 0;
            createTitle.Text = "Add Product";
            // 
            // pId
            // 
            pId.AutoSize = true;
            pId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pId.Location = new Point(128, 73);
            pId.Name = "pId";
            pId.Size = new Size(81, 21);
            pId.TabIndex = 1;
            pId.Text = "Product Id";
            // 
            // pName
            // 
            pName.AutoSize = true;
            pName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pName.Location = new Point(128, 126);
            pName.Name = "pName";
            pName.Size = new Size(110, 21);
            pName.TabIndex = 2;
            pName.Text = "Product Name";
            // 
            // sId
            // 
            sId.AutoSize = true;
            sId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sId.Location = new Point(128, 179);
            sId.Name = "sId";
            sId.Size = new Size(85, 21);
            sId.TabIndex = 3;
            sId.Text = "Supplier Id";
            // 
            // cId
            // 
            cId.AutoSize = true;
            cId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cId.Location = new Point(128, 230);
            cId.Name = "cId";
            cId.Size = new Size(90, 21);
            cId.TabIndex = 4;
            cId.Text = "Category Id";
            // 
            // UnitPrice
            // 
            UnitPrice.AutoSize = true;
            UnitPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnitPrice.Location = new Point(128, 280);
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Size = new Size(77, 21);
            UnitPrice.TabIndex = 5;
            UnitPrice.Text = "Unit Price";
            // 
            // Discontinued
            // 
            Discontinued.AutoSize = true;
            Discontinued.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Discontinued.Location = new Point(128, 324);
            Discontinued.Name = "Discontinued";
            Discontinued.Size = new Size(101, 21);
            Discontinued.TabIndex = 6;
            Discontinued.Text = "Discontinued";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(322, 371);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 32);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(568, 371);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 32);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(322, 128);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(100, 23);
            txtProductName.TabIndex = 10;
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(322, 181);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(100, 23);
            txtSupplierId.TabIndex = 11;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(322, 228);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(100, 23);
            txtCategoryId.TabIndex = 12;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(322, 282);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(100, 23);
            txtUnitPrice.TabIndex = 13;
            // 
            // chkDiscontinued
            // 
            chkDiscontinued.AutoSize = true;
            chkDiscontinued.Location = new Point(322, 324);
            chkDiscontinued.Name = "chkDiscontinued";
            chkDiscontinued.Size = new Size(15, 14);
            chkDiscontinued.TabIndex = 14;
            chkDiscontinued.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 79);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 15;
            label1.Text = "Keep Empty";
            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(chkDiscontinued);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtCategoryId);
            Controls.Add(txtSupplierId);
            Controls.Add(txtProductName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(Discontinued);
            Controls.Add(UnitPrice);
            Controls.Add(cId);
            Controls.Add(sId);
            Controls.Add(pName);
            Controls.Add(pId);
            Controls.Add(createTitle);
            Name = "CreateEditForm";
            Text = "Create Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTitle;
        private Label pId;
        private Label pName;
        private Label sId;
        private Label cId;
        private Label UnitPrice;
        private Label Discontinued;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtProductName;
        private TextBox txtSupplierId;
        private TextBox txtCategoryId;
        private TextBox txtUnitPrice;
        private CheckBox chkDiscontinued;
        private Label label1;
    }
}