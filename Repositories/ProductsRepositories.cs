using CRUDONT2030.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDONT2030.Repositories
{
    public class ProductsRepositories
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=TSQL2025;Integrated Security=True;Trust Server Certificate=False";

        public List<Products> GetAllProducts()  //method to get all products
        {
            var products = new List<Products>(); //list to hold products object
            return products; //return the list which is currently empty
        }
    }
}
