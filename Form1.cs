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

        private void ProductsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

