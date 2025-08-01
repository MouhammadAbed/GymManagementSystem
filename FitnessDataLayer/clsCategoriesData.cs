using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace FitnessDataLayer
{
    public class categoryDTO
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public decimal fees { get; set; }
        public string description { get; set; }
        public categoryDTO(int id, string categoryName, decimal fees,string description)
        {
            this.id = id;
            this.categoryName = categoryName;
            this.fees = fees;
            this.description = description;
        }
    }
    public class clsCategoriesData
    {
        public static DataTable getAllCategories()
        {
            DataTable allCategories = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("pr_GetAllCategories", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                allCategories.Load(reader);
                            }
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return null;
                    }
                }
            }
            return allCategories;
        }
        public static int addCategory(string categoryName, decimal fees,string description)
        {
            int newId = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("pr_AddCategory", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@category_name", categoryName);
                    cmd.Parameters.AddWithValue("@fees", fees);
                    
                    if (string.IsNullOrWhiteSpace(description))
                        cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.AddWithValue("@Description", description);

                    try
                    {
                        connection.Open();
                        object result = cmd.ExecuteScalar(); // Capture SCOPE_IDENTITY()
                        if (result != null)
                            newId = Convert.ToInt32(result);
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        newId = 0;
                    }
                }
            }
            return newId;
        }
        public static bool updateCategory(int id, string categoryName, decimal fees, string description)
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
                    if (description == "")
                        cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Description", description);
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
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
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
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        rowAffected = 0;
                    }
                }
            }
            return rowAffected > 0;
        }
        public static categoryDTO findCategory(int id)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("pr_FindCategory", connection))
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
                                string desc = reader.IsDBNull(reader.GetOrdinal("Description"))
                           ? string.Empty
                           : reader.GetString(reader.GetOrdinal("Description"));

                                return new categoryDTO(
                                    id,
                                    reader.GetString(reader.GetOrdinal("category_name")),
                                    reader.GetDecimal(reader.GetOrdinal("fees")),
                                    desc 
                                );
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return null;
                    }
                }
            }
            return null;
        }
        public static categoryDTO findCategory(string CategoryName)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("pr_FindCategoryByName", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoryName", CategoryName);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string descr = reader.IsDBNull(reader.GetOrdinal("Description"))
                           ? string.Empty
                           : reader.GetString(reader.GetOrdinal("Description"));
                                return new categoryDTO(
                                    reader.GetInt32(reader.GetOrdinal("category_id")),
                                    CategoryName,
                                    reader.GetDecimal(reader.GetOrdinal("fees")),
                                    descr
                                );
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return null;
                    }
                }
            }
            return null;
        }
        public static bool isCategoryExist(string CategoryName)
        {
            bool isExist = false;
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("pr_isCategoryExist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CategoryName", CategoryName);
                    SqlParameter isExistParam = new SqlParameter("@isExist", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(isExistParam);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        isExist = Convert.ToInt32(isExistParam.Value) == 1;
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        isExist = false;
                    }
                }
            }return isExist;
        }
        public static int GetCategoryCount()
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_CategoriesCount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        return (result != null) ? Convert.ToInt32(result) : 0;
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return 0;
                    }

                }
            }
        }
    }
}
