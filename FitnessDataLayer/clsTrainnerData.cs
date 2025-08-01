using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDataLayer
{
    public class trainerDTO
    {
        public int id { get; set; }
        public int personId { get; set; }
        public bool isActive { get; set; }
        public trainerDTO(int id,bool isActive, int personId)
        {
            this.id = id;
            this.isActive = isActive;
            this.personId = personId;
        }
    }
    public class clsTrainnerData
    {
        public static trainerDTO findTrainer(int id)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prTrainer_Find", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@trainer_id", id);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            return new trainerDTO(
                                id,
                                reader.GetBoolean(reader.GetOrdinal("IsDeleted")),
                                reader.GetInt32(reader.GetOrdinal("person_id"))
                                );
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
        public static trainerDTO findTrainerByPersonId(int personId)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prTrainer_FindTrainerByPersonId", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", personId);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            return new trainerDTO(
                                reader.GetInt32(reader.GetOrdinal("trainer_id")),
                                reader.GetBoolean(reader.GetOrdinal("IsDeleted")),
                                personId
                                );
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
        public static trainerDTO findTrainer(string firstName,string secondName,string lastName)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prTrainer_FindTrainerByName", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    if(secondName=="")
                        cmd.Parameters.AddWithValue("@SecondName", secondName);
                    else
                        cmd.Parameters.AddWithValue("@SecondName", secondName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            return new trainerDTO(
                                reader.GetInt32(reader.GetOrdinal("trainer_id")),
                                reader.GetBoolean(reader.GetOrdinal("IsDeleted")),
                                 reader.GetInt32(reader.GetOrdinal("person_Id"))
                                );
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
        public static DataTable getAllTrainers()
        {
            DataTable dtTrainers = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prTrainer_GetAll", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            dtTrainers.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return null;
                    }

                }
            }
            return dtTrainers;
        }
        public static int addNewTrainer( int personId)
        {
            int newId = 0;
            using (SqlConnection connetion = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prTrainer_Add", connetion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@person_id", personId);
                    cmd.Parameters.Add("@newTrainerId", SqlDbType.Int);
                    cmd.Parameters["@newTrainerId"].Direction = ParameterDirection.Output;                                      
                    try
                    {
                        connetion.Open();
                        cmd.ExecuteNonQuery();
                        newId = (int)cmd.Parameters["@newTrainerId"].Value;

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
        public static bool isPersonATrainer(int personId)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prTrainer_isPersonSetToATrainer", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonId", personId);
                    SqlParameter outerParam = new SqlParameter("@isExist", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output,
                    };
                    cmd.Parameters.Add(outerParam);
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        return Convert.ToInt16(outerParam.Value) != 0;
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return false;
                    }
                }
            }
        }
        public static bool DeleteTrainer(int PersonId)
        {
            bool isDelete = false;
            using (SqlConnection connection =new SqlConnection (clsConnection.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("prDeleteTrainerAndAssignments", connection))
                {
                    command.CommandType=CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("", PersonId);
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return false ;
                    }
                }
            }
            return isDelete; 
        }
    }
}