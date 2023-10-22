using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System.Data;

namespace Supermarket_mvp._Repositories
{
    internal class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(CategoryModel categoryModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Categories VALUES (@name,@observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoryModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = categoryModel.Observation;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Categories WHERE Categorie_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategoryModel categoryModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Categories
                                        SET Categorie_Name = @name,
                                        Categorie_Observation =@observation 
                                        WHERE Categorie_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoryModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = categoryModel.Observation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoryModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoryModel> GetAll()
        {
            var categoryList = new List<CategoryModel>();
            using (var connetion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connetion.Open();
                command.Connection = connetion;
                command.CommandText = "SELECT * FROM Categories ORDER BY Categorie_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoryModel();
                        categoryModel.Id = (int)reader["Categorie_Id"];
                        categoryModel.Name = reader["Categorie_Name"].ToString();
                        categoryModel.Observation = reader["Categorie_Observation"].ToString();
                        categoryList.Add(categoryModel);
                    }
                }
            }
            return categoryList;
        }

        public IEnumerable<CategoryModel> GetByValue(string value)
        {
            var categoryList = new List<CategoryModel>();
            int categoryId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categoryName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Categories
                            WHERE Categorie_Id= @id or Categorie_Name LIKE @name+ '%'
                            ORDER By Categorie_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoryId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoryName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoryModel();
                        categoryModel.Id = (int)reader["Categorie_Id"];
                        categoryModel.Name = reader["Categorie_Name"].ToString();
                        categoryModel.Observation = reader["Categorie_Observation"].ToString();
                        categoryList.Add(categoryModel);
                    }
                }
            }
            return categoryList;
        }
    }
}
