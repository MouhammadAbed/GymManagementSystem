using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDataLayer
{
    public class userDTO
    {
        public int id;
        public string userName;
        public string password;
        public int personId;
        public int permissions;

        public userDTO(int id, string userName, string password,int permissions, int personId)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.permissions = permissions;
            this.personId = personId;
        }
    }

    public class clsUserData
    {
        public static userDTO FindUser(int UserID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prUser_Find", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            return new userDTO(
                                UserID,
                            (string)reader["userName"],
                             (string)reader["Password"],
                             (int)reader["user_Permissions"],
                             (int)reader["person_id"]);
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
        public static userDTO FindUserbyPersonID(int PersonID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prUser_FindByPersonID", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            return new userDTO(
                                (int)reader["person_id"],
                                (string)reader["userName"],
                                 (string)reader["Password"],
                                (int)reader["user_Permissions"],
                                 PersonID
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
        public static int AddNewUser(string userName, string Password,int Permissions, int PersonID)
        {
            int NewID = -1;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prUser_Add", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@Persmissions", Permissions);
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    SqlParameter outerParameter = new SqlParameter();
                    cmd.Parameters.Add("@user", SqlDbType.Int);
                    cmd.Parameters["@user"].Direction = ParameterDirection.Output;
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        NewID = (int)cmd.Parameters["@user"].Value;
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        NewID = -1;
                    }
                }
            }
            return NewID;
        }
        public static bool UpdateUser(int ID,string userName,string Password,int permissions)
        {
            int RowAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prUser_update", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonId",ID);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@Permissions", permissions);
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
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prUser_GetAll", connection))
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
        public static userDTO FindUserByUserName(string userName)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prUser_FindByUserName", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            return new userDTO(
                                (int)reader["person_id"],
                                userName,
                                (string)reader["Password"],
                                (int)reader["user_Permissions"],
                                (int)reader["person_id"]
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
        public static bool DelteUser(int UserID)
        {
            int RowAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prUser_Delete", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    SqlParameter returnParam = new SqlParameter();
                    returnParam.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(returnParam);
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        RowAffected = (int)returnParam.Value;
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
        public static bool DeleteUserByPersonId(int personId)
        {
            int RowAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prUser_DeleteUserByPersonId", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonId", personId);
                    SqlParameter returnParam = new SqlParameter();
                    returnParam.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(returnParam);
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        RowAffected = (int)returnParam.Value;
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
        public static bool isUserExistByIDAndPassword(string UserName, string password)
        {
            bool isExist = false;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prUser_isExist", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.Parameters.AddWithValue("@Password", password);
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
                return isExist;
            }
        }
        public static bool isUserNameExist(string userName)
        {
            byte Found = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PrUser_isUserNameExist", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userName", userName);
                    SqlParameter ReturnValueparameter = new SqlParameter();
                    ReturnValueparameter.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(ReturnValueparameter);
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        Found = Convert.ToByte(ReturnValueparameter.Value);
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        Found = 0;
                    }
                }
            }
            return Found != 0;
        }
    }
}
