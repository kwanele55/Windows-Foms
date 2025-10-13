using CRUDONT2030.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
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

        //method to get all products
        public List<Products> GetAllProductS()
        {
            var products = new List<Products>(); //list to hold all products objects

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) //database connection and data retrival logic
                {
                    connection.Open(); //Open the Connection
                    string sql = "SELECT* FROM  Production.Products ORDER BY productId DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read()) // read each record
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
        // new method to get all products by productId
        public Products? GetAllProduct(int productId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) 
                {
                    connection.Open();
                    string sql = "SELECT* FROM Production.Products WHERE productId = @productId";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@productId", productId);
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
                Console.WriteLine($"An error occured: {ex.Message}"); 
            }
            return null;
        }
        //new method to create products
        public void CreateProduct(Products products)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) 
                {
                    connection.Open();
                    string sql = "INSERT INTO Production.Products " +
                        "(productName , supplierId, categoryId, unitPrice, discontinued) VALUES" +
                        "(@ProductName, @suppierId, @categoryId, @unitPrice, @discontinued)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@productName", products.productName);
                        command.Parameters.AddWithValue("@supplierId", products.supplierId);
                        command.Parameters.AddWithValue("@categoryId", products.categoryId);
                        command.Parameters.AddWithValue("@unitPrice", products.unitPrice);
                        command.Parameters.AddWithValue("@discontinued", products.discontinued);
                        command.ExecuteNonQuery(); // Execute the command 
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: "+ ex.ToString()); 
            }
        }
        //new method that allow to update products
        public void UpdateProduct(Products products)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) 
                {
                    connection.Open(); 
                    string sql = "UPDATE Production.Products " +
                        "SET productName = @productName , supplierId = @supplierId, categoryId =@categoryId, " +
                        "unitPrice = @unitPrice , discontinued = @discontinued " +
                        "WHERE productId =@productId";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@productName", products.productName);
                        command.Parameters.AddWithValue("@supplierId", products.supplierId);
                        command.Parameters.AddWithValue("@categoryId", products.categoryId);
                        command.Parameters.AddWithValue("@unitPrice", products.unitPrice);
                        command.Parameters.AddWithValue("@discontinued", products.discontinued);
                        command.Parameters.AddWithValue("@productId", products.productId);
                        command.ExecuteNonQuery(); 
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: could not update" + ex.ToString()); 
            }
            
        }
        //new method to allow to delete products
        public void DeleteProduct(int productId)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM Production.Products WHERE productId = @productId;";

                    using (SqlCommand command = new SqlCommand(sql, connection)) //SQL command to execute to replace parameters with actual values
                    {
                        command.Parameters.AddWithValue("@productId", productId);
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} row(s) deleted."); //Inform how many rows were deleted
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }
}
