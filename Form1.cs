using System.Data;
namespace CRUDONT2030
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadProducts();
        }
        private void ReadProducts()
        {
            DataTable dataTable = new DataTable(); // create a DataTable to hold the data
            dataTable.Columns.Add("Product ID", typeof(int));
            dataTable.Columns.Add("Product Name", typeof(string));
            dataTable.Columns.Add("Supplier ID", typeof(int));
            dataTable.Columns.Add("Category ID", typeof(int));
            dataTable.Columns.Add("Unit Price", typeof(decimal));
            dataTable.Columns.Add("Discontinued", typeof(bool));


            var repo = new Repositories.ProductsRepositories(); // create an instance of the repository
            var products = repo.GetAllProducts(); // get all products from the database

            foreach (var product in products) // loop through each product and add it to the DataTable
            {
                var row = dataTable.NewRow();
                row["Product ID"] = product.productId;
                row["Product Name"] = product.productName;
                row["Supplier ID"] = product.supplierId;
                row["Category ID"] = product.categoryId;
                row["Unit Price"] = product.unitPrice;
                row["Discontinued"] = product.discontinued;

                dataTable.Rows.Add(row); // add the row to the DataTable
            }

            this.ProductsTable.DataSource = dataTable; // bind the DataTable to the DataGridView

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateEditForm form = new CreateEditForm(); // create an instance of the CreateEditForm
            if (form.ShowDialog() == DialogResult.OK) // show the form as a dialog and check if the result is OK
            {
                ReadProducts(); // refresh the product list if a new product was added
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // get the value of the first cell in the selected row
            var val = this.ProductsTable.SelectedRows[0].Cells[0].Value.ToString();
            //var val = this.productsTable.SelectedRows[0].Cells[0].Value.ToString(); // get the value of the first cell in the selected row
            if (val == null || val.Length == 0) // check if the value is null or empty

                return; // exit the method

            int productId = int.Parse(val); // parse the value to an integer

            var repo = new Repositories.ProductsRepositories(); // create an instance of the repository
            var products = repo.GetAllProduct(productId); // get the product by ID from the database

            if (products == null) return; // check if the product is null

            CreateEditForm form = new CreateEditForm(); // create an instance of the CreateEditForm
            form.EditProduct(products); // call the method to populate the form with product data for editing
            if (form.ShowDialog() == DialogResult.OK) // show the form as a dialog and check if the result is OK
            {
                ReadProducts(); // refresh the product list if a product was edited
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // To delete a product, we will get the product ID from the selected row in the DataGridView
            var val = this.ProductsTable.SelectedRows[0].Cells[0].Value.ToString(); // get the value of the first cell in the selected row
            if (val == null || val.Length == 0) // check if the value is null or empty
                return; // exit the method

            int productId = int.Parse(val); // parse the value to an integer

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.No) return; // if the user clicks No, exit the method

            var repo = new Repositories.ProductsRepositories(); // create an instance of the repository
            repo.DeleteProduct(productId); // call the method to delete the product by ID from the database

            ReadProducts(); // refresh the product list after deletion
        }
    }
}

