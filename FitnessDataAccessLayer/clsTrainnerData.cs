using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient; 

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FitnessDataAccessLayer
{
    public class trainerDTO
    {
        public int id { get; set; }
        public int categoryId { get; set; }
        public int personId { get; set; }
        public trainerDTO(int id, int categoryId, int personId)
        {
            this.id = id;
            this.categoryId = categoryId;
            this.personId = personId;
        }
    }
    public class clsTrainnerData
    {        
        //update trainer info after we modify some fields in the database table
        public static trainerDTO? findTrainer(int id)
        {
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using(SqlCommand cmd = new SqlCommand("prTrainer_Find", connection))
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
                                reader.GetInt32(reader.GetOrdinal("category_id")),
                                reader.GetInt32(reader.GetOrdinal("person_id"))
                                );
                        }
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                }
            }return null;
        }
        public static DataTable getAllTrainers()
        {
            DataTable dtTrainers= new DataTable();
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using( SqlCommand cmd = new SqlCommand("prTrainer_GetAll", connection) )
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if(reader.HasRows)
                        {
                            dtTrainers.Load(reader);
                        }
                    }catch(Exception ex)
                    {
                        return null ;
                    }

                }
            }return dtTrainers;
        }
        public static int addNewTrainer(int categoryId,int personId)
        {
            int newId = 0;
            using (SqlConnection connetion = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prTrainer_Add", connetion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@category_id", categoryId);
                    cmd.Parameters.AddWithValue("@person_id", personId);
                    SqlParameter outerParameter = new SqlParameter("@newTrainerId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    try
                    {
                        connetion.Open();
                        cmd.ExecuteReader();
                        newId = (int)outerParameter.Value;

                    }
                    catch (Exception ex)
                    {
                        newId = 0;
                        //clsEventloagData.SaveEventToEventLogEntry(ex.Message, clsEventloagData.enEventLogEntry.enError);
                    }

                }
            }return newId;
        }
        public static bool updateTrainer(int id,int categoryId)
        {
            int rowAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prTrainer_Update", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@catgoryid", categoryId);

                    SqlParameter ReturnValue = new SqlParameter();
                    ReturnValue.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(ReturnValue);
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        rowAffected = (int)ReturnValue.Value;
                    }
                    catch (Exception ex)
                    {
                        //clsEventloagData.SaveEventToEventLogEntry(ex.Message, clsEventloagData.enEventLogEntry.enError);
                        rowAffected = 0;
                    }
                }
            }
            return rowAffected != 0;
        }
        public static bool deleteTrainer(int id)
        {
            int RowAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prTrainer_Delete", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlParameter returnParam = new SqlParameter();
                    returnParam.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(returnParam);
                    try
                    {

                        connection.Close();
                        cmd.ExecuteNonQuery();
                        RowAffected = (int)returnParam.Value;
                    }
                    catch (Exception ex)
                    {
                        //clsEventloagData.SaveEventToEventLogEntry(ex.Message, clsEventloagData.enEventLogEntry.enError);
                        RowAffected = 0;
                    }
                }
            }
            return RowAffected != 0;
        }
        public static bool isPersonATrainer(int personId)
        {
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using(SqlCommand cmd = new SqlCommand("prTrainer_isPersonSetToATrainer", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonId", personId);
                    SqlParameter outerParam = new SqlParameter("@isExist", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output,
                    };
                    try
                    {
                        connection.Open();
                        cmd.ExecuteReader();
                        return (int)outerParam.Value != 0;
                    }catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }
    }
}
