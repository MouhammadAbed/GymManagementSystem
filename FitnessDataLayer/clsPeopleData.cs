using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDataLayer
{
    public class personDTO
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public bool gender { get; set; }
        public personDTO(int id, string firstName, string secondName, string lastName, string phoneNumber, bool gender)
        {
            this.id = id;
            this.firstName = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.gender = gender;
        }
        public class clsPeopleData
        {
            public static personDTO FindPersonByID(int personId)
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
                                 reader["second_name"] == DBNull.Value ? "" : (string)reader["second_name"],
                                 (string)reader["last_name"],
                                  (string)reader["phone_number"],
                                    (bool)reader["gender"]);
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
            public static personDTO FindPersonByName(string firstName,string secondName,string lastName)
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("prPeople_FindByName", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        if (secondName == "")
                            cmd.Parameters.AddWithValue("@secondName", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@secondName", secondName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                return new personDTO(
                                   (int)reader["personid"],
                                   (string)reader["first_name"],
                                   reader["second_name"] == DBNull.Value ? "" : (string)reader["second_name"],
                                   (string)reader["last_name"],
                                   (string)reader["phone_number"],
                                   (bool)reader["gender"]);
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
            public static int AddNewPerson(string FirstName, string SecondName, string LastName, string Phone,bool gender)
            {
                int newID = -1;
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("prPeople_Add", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        if (string.IsNullOrWhiteSpace(SecondName))
                            cmd.Parameters.AddWithValue("@SecondName", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@SecondName", SecondName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@Phone", Phone);
                        cmd.Parameters.AddWithValue("@NewPersonID", SqlDbType.Int);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters["@NewPersonID"].Direction = ParameterDirection.Output;

                        try
                        {
                            connection.Open();
                            newID = cmd.ExecuteNonQuery();
                            newID = Convert.ToInt32(cmd.Parameters["@NewPersonID"].Value);
                        }
                        catch (Exception ex)
                        {
                            clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
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
                            clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                            isExist = false;
                        }
                    }
                }
                return isExist;
            }
            public static bool updatePersonInfo(int PersonID, string FirstName, string SecondName, string LastName, 
                string Phone,bool gender)
            {
                int RowAffected = 0;
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("prPeople_UpdateInfo", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", PersonID);
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        if (string.IsNullOrWhiteSpace(SecondName))
                            cmd.Parameters.AddWithValue("@SecondName", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@SecondName", SecondName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@Phone", Phone);
                        cmd.Parameters.AddWithValue("@Gender", gender);
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
                            clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                            RowAffected = 0;
                        }
                    }
                }
                return RowAffected != 0;
            }
            public static DataTable getAllPeople()
            {
                DataTable dt = new DataTable();
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
                            clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
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
                            clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                            RowAffectedf = 0;
                        }
                    }
                }
                return RowAffectedf != 0;
            }
            public static int getPersonIdByName(string fullName)
            {
                int findId = 0;
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("pr_isNameExist", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@fullName", fullName);

                        SqlParameter outerParm = new SqlParameter("@PersonId", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outerParm);

                        try
                        {
                            connection.Open();
                            cmd.ExecuteNonQuery(); 
                            findId = (int)cmd.Parameters["@PersonId"].Value;
                        }
                        catch(Exception ex)
                        {
                            clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                            findId = 0;
                        }
                    }
                }
                return findId;
            }
        }
    }
}
