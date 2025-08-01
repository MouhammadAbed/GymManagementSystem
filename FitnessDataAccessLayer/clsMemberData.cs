using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDataAccessLayer
{
    public class MemberDTO
    {
        public int memberId { get; set; }
        public bool status { get; set; } 
        public int person_id { get; set; }
        public int added_By_User {  get; set; }

        public MemberDTO(int memberId, bool status, int person_id, int added_By_User)
        {
            this.memberId = memberId;
            this.status = status;
            this.person_id = person_id;
            this.added_By_User = added_By_User;
        }
    }
    // memberId,membership_status,person_Id,added_by_user
    public class clsMemberData
    {
       public static DataTable getAllMembers()
        {
            DataTable allMembers = new DataTable();
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using(SqlCommand cmd = new SqlCommand("prMember_GetAll", connection))
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
                    catch(Exception ex)
                    {
                        allMembers.Load(null);
                    }
                    
                }
            }return allMembers;
        }       
       
        public static DataTable getAllActiveMembers()
        {
            DataTable ActiveMembers = new DataTable();
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using(SqlCommand cmd = new SqlCommand("", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            ActiveMembers.Load(reader);
                        }
                        else
                            ActiveMembers.Load(null);
                    }
                }
            }return ActiveMembers;
        }
       public static MemberDTO? findMember(int id)
        {
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using(SqlCommand cmd = new SqlCommand("prMember_FindById", connection))
                {
                    cmd.CommandType= CommandType.StoredProcedure;
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
                    catch(Exception ex)
                    {
                        return null;
                    }
                    
                }
            }return null;
        }
        public static bool updateMember(int memberId, bool status,int addedByUser)
        {
            int RowAffected = 0;
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using(SqlCommand cmd = new SqlCommand("prMember_Update", connection))
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
                    catch(Exception ex)
                    {
                        RowAffected = 0;
                    }                    
                }return RowAffected > 0;
            }
        }
        public static int AddMember(int person_id,int added_By_User)
        {
            int newId = 0;
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prMember_Add", connection))
                {
                    cmd.CommandType= CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID", person_id);
                    cmd.Parameters.AddWithValue("@AddedByUser", added_By_User);
                    SqlParameter newIdParameter = new SqlParameter("@NewId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        newId= (int)newIdParameter.Value;
                    }catch(Exception ex)
                    {
                        return 0;
                    }
                }
            }
            return newId;           
        }
        public static bool IsPersonAlreadyMember(int personId)
        {
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using(SqlCommand cmd = new SqlCommand("prMember_isPersonSetToAMemeber", connection))
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
                        return (int)outerParameter.Value!=0;
                    }catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }

    }
}
