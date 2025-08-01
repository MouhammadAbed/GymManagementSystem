using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDataAccessLayer
{
    public class categoryDTO
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public decimal fees { get; set; }
        public categoryDTO(int id, string categoryName, decimal fees)
        {
            this.id = id;
            this.categoryName = categoryName;
            this.fees = fees;
        }   
    }
    public class clsCategoriesData
    {
        public static DataTable? getAllCategories()
        {
            DataTable? allCategories = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using(SqlCommand cmd = new SqlCommand("pr_GetAllCategories", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                allCategories.Load(reader);
                            }
                        }
                    }catch (Exception ex)
                    {
                        return null;
                    }
                }
            }return allCategories;
        }
        public static int addCategory(string categoryName, decimal fees)
        {
            int newId = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("pr_AddCategory", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@category_name", categoryName);
                    cmd.Parameters.AddWithValue("@fees", fees);

                    SqlParameter outputId = new SqlParameter("@newCategoryId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputId);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        newId = (int)outputId.Value;
                    }
                    catch (Exception ex)
                    {
                        newId = 0;
                    }
                }
            }
            return newId;
        }
        public static bool updateCategory(int id, string categoryName, decimal fees)
        {
            int rowAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("pr_UpdateCategory", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@category_id", id);
                    cmd.Parameters.AddWithValue("@category_name", categoryName);
                    cmd.Parameters.AddWithValue("@fees", fees);

                    SqlParameter returnValue = new SqlParameter
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    cmd.Parameters.Add(returnValue);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        rowAffected = (int)returnValue.Value;
                    }
                    catch (Exception ex)
                    {
                        rowAffected = 0;
                    }
                }
            }
            return rowAffected > 0;
        }
        public static bool deleteCategory(int id)
        {
            int rowAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("pr_DeleteCategory", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@category_id", id);

                    SqlParameter returnValue = new SqlParameter
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    cmd.Parameters.Add(returnValue);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        rowAffected = (int)returnValue.Value;
                    }
                    catch (Exception ex)
                    {
                        rowAffected = 0;
                    }
                }
            }
            return rowAffected > 0;
        }
        public static categoryDTO? findCategory(int id)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("pr_FindCategoryById", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@category_id", id);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new categoryDTO(
                                    id,
                                    reader.GetString(reader.GetOrdinal("category_name")),
                                    reader.GetDecimal(reader.GetOrdinal("fees"))
                                );
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                }
            }
            return null;
        }

    }
}
