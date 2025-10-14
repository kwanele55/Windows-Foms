using CRUDONT2030.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CRUDONT2030
{
    public partial class CreateEditForm : Form
    {
        public CreateEditForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;// dialogue result to cancel
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //create a new product object and set its properties from the text boxes
            Products products = new Products();
            products.productId = 0; // set to 0 for new product, will be ignored by the database
            products.productName = this.txtProductName.Text;
            products.supplierId = int.Parse(txtSupplierId.Text);
            products.categoryId = int.Parse(txtCategoryId.Text);
            products.unitPrice = decimal.Parse(txtUnitPrice.Text);
            products.discontinued = chkDiscontinued.Checked;

            var repo = new Repositories.ProductsRepositories(); // create an instance of the repository
            repo.CreateProduct(products); // call the method to create a new product in the database

            this.DialogResult = DialogResult.OK; // set the dialog result to OK when save is clicked
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // set the dialog result to Cancel when cancel is clicked
        }
    }
}

