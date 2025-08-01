using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDataLayer
{
    public class MemberDTO
    {
        public int memberId { get; set; }
        public bool status { get; set; }
        public int person_id { get; set; }
        public int added_By_User { get; set; }

        public MemberDTO(int memberId, bool status, int person_id, int added_By_User)
        {
            this.memberId = memberId;
            this.status = status;
            this.person_id = person_id;
            this.added_By_User = added_By_User;
        }
    }
    public class clsMemberData
    {
        public static DataTable getAllMembers()
        {
            DataTable allMembers = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prMember_GetAll", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                allMembers.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        allMembers.Load(null);
                    }

                }
            }
            return allMembers;
        }
        public static DataTable getAllActiveMembers()
        {
            DataTable ActiveMembers = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                ActiveMembers.Load(reader);
                            }
                            else
                                ActiveMembers.Load(null);
                        }
                    }
                    catch(Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return null;
                    }
                }
            }
            return ActiveMembers;
        }
        public static MemberDTO findMember(int id)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prMember_FindById", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MemberID", id);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new MemberDTO(
                                    id,
                                    reader.GetBoolean(reader.GetOrdinal("membership_status")),
                                    reader.GetInt32(reader.GetOrdinal("person_Id")),
                                    reader.GetInt32(reader.GetOrdinal("added_by_user")));
                            }
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return null;
                    }

                }
            }
        }
        public static MemberDTO findMemberByPersonid(int id)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prMember_FindByPersonId", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonId", id);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new MemberDTO(
                                    reader.GetInt32(reader.GetOrdinal("memberId")),
                                    reader.GetBoolean(reader.GetOrdinal("membership_status")),
                                    id,
                                    reader.GetInt32(reader.GetOrdinal("added_by_user")));
                            }
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return null;
                    }

                }
            }
        }
        public static MemberDTO findMember(string FirstName,string SecondName,string LastName)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prMember_FindMemberByName", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    if (SecondName == "")
                        cmd.Parameters.AddWithValue("@SecondName", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@SecondName", SecondName);
                    cmd.Parameters.AddWithValue("@lastName", LastName);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new MemberDTO(
                                    reader.GetInt32(reader.GetOrdinal("memberId")),
                                    reader.GetBoolean(reader.GetOrdinal("membership_status")),
                                   reader.GetInt32(reader.GetOrdinal("Person_Id")),
                                    reader.GetInt32(reader.GetOrdinal("added_by_user")));
                            }
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return null;
                    }

                }
            }
        }
        public static bool updateMember(int memberId, bool status, int addedByUser)
        {
            int RowAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prMember_Update", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MemberID", memberId);
                    cmd.Parameters.AddWithValue("@MembershipStatus", status);
                    cmd.Parameters.AddWithValue("@AddedByUser", addedByUser);
                    SqlParameter outerParameter = new SqlParameter("@RowAffected", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    try
                    {
                        connection.Open();
                        cmd.ExecuteReader();
                        RowAffected = (int)outerParameter.Value;
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        RowAffected = 0;
                    }
                }
                return RowAffected > 0;
            }
        }
        public static int AddMember(int person_id, int added_By_User)
        {
            int newId = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prMember_Add", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID", person_id);
                    cmd.Parameters.AddWithValue("@AddedByUser", added_By_User);
                    SqlParameter outerParameter = new SqlParameter();
                    cmd.Parameters.Add("@NewId", SqlDbType.Int);
                    cmd.Parameters["@NewId"].Direction = ParameterDirection.Output;
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        newId = (int)cmd.Parameters["@NewId"].Value;
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return 0;
                    }
                }
            }
            return newId;
        }
        public static bool IsPersonAlreadyMember(int personId)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prMember_isPersonSetToAMemeber", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonId", personId);
                    SqlParameter outerParameter = new SqlParameter("@isExist", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        return (int)outerParameter.Value != 0;
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return false;
                    }
                }
            }
        }
    }
}
