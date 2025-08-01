using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDataLayer
{
    public class clsTrainerCategoryAssignmentDTO
    {
        public int AssignId { get; set; }
        public int TrainerId { get; set; }
        public int CategoryId { get; set; }
        public decimal Salary { get; set; }

        public clsTrainerCategoryAssignmentDTO(int assignId, int trainerId, int categoryId, decimal salary)
        {
            this.AssignId = assignId;
            this.TrainerId = trainerId;
            this.CategoryId = categoryId;
            this.Salary = salary;
        }
    }
    public class clsTrainerCategoryAssignmentData
    { 
        public static int AssignNewCategoryToTrainer(int TrainerId,int CategoryId,decimal Salary)
        {
            int newId = 0;
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("prTrainerCategory_Add", connection))
                {
                    command.CommandType=System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TrainerId",TrainerId);
                    command.Parameters.AddWithValue("@CategoryId", CategoryId);
                    command.Parameters.AddWithValue("@Salary", Salary);
                    command.Parameters.Add("@NewId", SqlDbType.Int);
                    command.Parameters["@NewId"].Direction = ParameterDirection.Output;
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        newId = (int)command.Parameters["@NewId"].Value;
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return 0;
                    }
                }
            }return newId;
        }
        public static bool DeleteAssignment(int AssignmentId)
        {
            int rowAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("prTrainerCategory_deleteAssignment",connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@assignmentId", AssignmentId);
                    SqlParameter returnParam = new SqlParameter();
                    returnParam.Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add(returnParam);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        rowAffected = (int)returnParam.Value;
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return false ;
                    }
                }
            }return rowAffected > 0;
        }
        public static List<string> GetTrainerCategoriesAssignment(int personId)
        {
            List<string> categories = new List<string>();
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("prTrainerCategory_AssignedCategories", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonId", personId);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                         categories = new List<string>();

                        while (reader.Read())
                        {
                            categories.Add(reader.GetString(0));
                        }
                        return categories;
                    }
                    catch(Exception ex) 
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return null;
                    }
                }
            }
        }
        public static clsTrainerCategoryAssignmentDTO FindAssignment(int AssignmentId)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("prTrainerCategory_FindAssignment", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AssignmentId", AssignmentId);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            return new clsTrainerCategoryAssignmentDTO(
                                AssignmentId,
                                (int)reader["TrainerId"],
                                (int)reader["CategoryId"],
                                Convert.ToDecimal(reader["Salary"])
                                );
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return null;
                    }

                }
                return null;

            }
        }       
        public static int GetAssignmentID(string fullName,string categoryName)
        {
            int assignmentID = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("GetAssignmentIdByTrainerNameAndCategory", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@CategoryName", categoryName);
                    SqlParameter outputParam = new SqlParameter("@AssignmentId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        assignmentID = Convert.ToInt32(outputParam.Value);
                    }                    
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        assignmentID = 0;
                    }

                }
            }return assignmentID;
        }
        public static bool UpdateTrainerSalary(int assigmentId,decimal salary)
        {
            int rowAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("prTrainerCategory_UpdateTrainerSalary", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AssingnmentId", assigmentId);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.Parameters.Add("@Row_Affected", SqlDbType.Int);
                    command.Parameters["@Row_Affected"].Direction = ParameterDirection.Output;
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                       rowAffected = (int)command.Parameters["@Row_Affected"].Value;
                    }
                    catch(Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        rowAffected = 0;
                    }
                
                }
            }return rowAffected > 0;
        }
    }
}
