using CRUDONT2030.Models;
using Microsoft.Data.SqlClient;
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

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) //database connection and data retrival logic
                {
                    connection.Open();
                    string sql = "SELECT* FROM  Production.Products ORDER BY productId DSC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Products product = new Products
                                {
                                    productId = reader.GetInt32(0),
                                    productName = reader.GetString(1),
                                    supplierId = reader.GetInt32(2),
                                    categoryId = reader.GetInt32(3),
                                    unitPrice = reader.GetDecimal(4),
                                    discontinued = reader.GetBoolean(5)
                                };
                                products.Add(product);
                            }
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error has occured"); // handle exceptions
            }
            return products;

        }
        public Products? GetAllProduct(int productId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) //database connection and data retrival logic
                {
                    connection.Open();
                    string sql = "SELECT* FROM  Production.Products WHERE productId = @productId";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Products products = new Products();
                                products.productId = reader.GetInt32(0);
                                products.productName = reader.GetString(1);
                                products.supplierId = reader.GetInt32(2);
                                products.categoryId = reader.GetInt32(3);
                                products.unitPrice = reader.GetDecimal(4);
                                products.discontinued = reader.GetBoolean(5);

                                return products;
                            }
                        }    
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occured: {ex.Message}"); // handle exceptions
            }
            return null;
        }
    }
}
