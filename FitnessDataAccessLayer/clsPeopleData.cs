using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDataAccessLayer
{
    public class personDTO
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public personDTO(int id, string firstName, string secondName, string lastName, string phoneNumber)
        {
            this.id = id;
            this.firstName = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;

        }
        public class clsPeopleData
        {
            public static personDTO? FindPersonByID(int personId)
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("prPeople_Find", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", personId);
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                return new personDTO(
                                    personId,
                              (string)reader["first_name"],
                                 (string)reader["second_name"],
                                 (string)reader["last_name"],
                                  (string)reader["last_name"]);
                            }
                        }
                        catch (Exception ex)
                        {
                            //clsEventloagData.SaveEventToEventLogEntry(ex.Message, clsEventloagData.enEventLogEntry.enError);

                        }
                    }
                }
                return null;
            }
            public static int AddNewPerson(  string FirstName,  string SecondName,  string LastName,  string Phone)
            {
                int newID = -1;
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("prPeople_Add", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@SecondName", SecondName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@Phone", Phone);
                        cmd.Parameters.Add("@NewPersonID", SqlDbType.Int);
                        cmd.Parameters["@NewPersonID"].Direction = ParameterDirection.Output;

                        try
                        {
                            connection.Open();
                            newID = cmd.ExecuteNonQuery();
                            newID = Convert.ToInt32(cmd.Parameters["@NewPersonID"].Value);
                        }
                        catch (Exception ex)
                        {
                            //clsEventloagData.SaveEventToEventLogEntry(ex.Message, clsEventloagData.enEventLogEntry.enError);
                            newID = -1;
                        }
                    }
                }
                return newID;
            }
            public static bool isPersonExist(int PersonID)
            {
                bool isExist = false;
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("prPeople_IsExist", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        SqlParameter ReturnValue = new SqlParameter();
                        ReturnValue.Direction = ParameterDirection.ReturnValue;
                        cmd.Parameters.Add(ReturnValue);
                        try
                        {
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            isExist = Convert.ToBoolean(ReturnValue.Value);
                        }
                        catch (Exception ex)
                        {
                            //clsEventloagData.SaveEventToEventLogEntry(ex.Message, clsEventloagData.enEventLogEntry.enError);
                            isExist = false;
                        }
                    }
                }
                return isExist;
            }
            public static bool updatePersonInfo(int PersonID,string FirstName,string SecondName,string LastName, string Phone)
            {
                //i directly use person dto as parameter since in databusines layer we will send
                //the personId and we're going to find the person using the function find person the return dto
                int RowAffected = 0;
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("prPeople_UpdateInfo", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", PersonID);
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@secondName", SecondName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@Phone", Phone);
                        SqlParameter ReturnValue = new SqlParameter();
                        ReturnValue.Direction = ParameterDirection.ReturnValue;
                        cmd.Parameters.Add(ReturnValue);
                        try
                        {
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            RowAffected = (int)ReturnValue.Value;
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
            public static DataTable? getAllPeople()
            {
                DataTable? dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("prPeople_GetAll", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                        catch (Exception ex)
                        {
                            //clsEventloagData.SaveEventToEventLogEntry(ex.Message, clsEventloagData.enEventLogEntry.enError);
                          return null;
                        }
                    }
                }
                return dt;
            }
            public static bool DeletePerson(int ID)
            {
                int RowAffectedf = 0;
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("prPeople_Delete", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PersonID", ID);
                        SqlParameter ReturnValue = new SqlParameter();
                        ReturnValue.Direction = ParameterDirection.ReturnValue;
                        cmd.Parameters.Add(ReturnValue);
                        try
                        {
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            RowAffectedf = (int)ReturnValue.Value;
                        }
                        catch (Exception ex)
                        {
                            //clsEventloagData.SaveEventToEventLogEntry(ex.Message, clsEventloagData.enEventLogEntry.enError);
                            RowAffectedf = 0;
                        }
                    }
                }
                return RowAffectedf != 0;
            }
            public static int getPersonIdByName(string fullName)
            {
                int findId = 0;
                using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using(SqlCommand cmd = new SqlCommand("pr_isNameExist", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@fullName", fullName);
                        SqlParameter outerParm = new SqlParameter("", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        try{
                            connection.Open();
                            cmd.ExecuteReader();
                            findId = (int)outerParm.Value;
                        }
                        catch
                        {
                            findId = 0;
                        }
                        
                    }
                }return findId;
            }
        }
    }
}
