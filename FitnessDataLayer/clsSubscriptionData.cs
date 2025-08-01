using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FitnessDataLayer
{
    public class SubscriptionDTO
    {
        public int subscriptionId { get; set; }
        public int applicationId { get; set; }
        public DateTime subscriptionStartDate{get;set;}
        public DateTime subscriptionEndDate { get; set; }
        public decimal fees {  get; set; }
        public int registerViaUser { get; set; }
        public int monthsDuration { get; set; }
        public float discount { get; set; }
        public decimal finalFees {  get; set; }
        public bool isRenewd { get; set; }

        public SubscriptionDTO(int subscriptionId, int applicationId, DateTime subscriptionStartDate, DateTime subscriptionEndDate, decimal fees, int registerViaUser,int monthsDuration, float discount, decimal finalFees,bool isRenewd)
        {
            this.subscriptionId = subscriptionId;
            this.applicationId = applicationId;
            this.subscriptionStartDate = subscriptionStartDate;
            this.subscriptionEndDate = subscriptionEndDate;
            this.fees = fees;
            this.registerViaUser = registerViaUser;
            this.monthsDuration = monthsDuration;   
            this.discount = discount;
            this.finalFees = finalFees;
            this.isRenewd = isRenewd;
        }
    }
    public class clsSubscriptionData
    {
        public static int AddNewSubscription(SubscriptionDTO dto,int PersonId,int assignmentId)
        {
            int newId = 0;
            using(SqlConnection connection =new SqlConnection(clsConnection.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("[prSubscription_AddSubscriptionAndManageApplication]", connection))
                {
                    command .CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonId", PersonId);
                    command.Parameters.AddWithValue("@assigment_Id", assignmentId);
                    command.Parameters.AddWithValue("@subscription_start_date", dto.subscriptionStartDate);
                    command.Parameters.AddWithValue("@subscription_end_date", dto.subscriptionEndDate);
                    command.Parameters.AddWithValue("@fees", dto.fees);
                    command.Parameters.AddWithValue("@discount", dto.discount);
                    command.Parameters.AddWithValue("@months_duration", dto.monthsDuration);
                    command.Parameters.AddWithValue("@finalFees", dto.finalFees);
                    command.Parameters.AddWithValue("@registered_via_user", dto.registerViaUser);                    
                    SqlParameter outerParameter = new SqlParameter();
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
                        newId = -1;
                    }
                }
            }return newId;
        }
        public static bool UpdateSubscription(int subscriptionId ,DateTime startDate, DateTime endDate,decimal fees,int registerViaUser,int monthDuration, float discount)
        {
            int rowAffected = 0;
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("prSubscription_UpdateSubscription", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@subscription_Id", subscriptionId);
                    command.Parameters.AddWithValue("@subscription_Start_Date", startDate);
                    command.Parameters.AddWithValue("@subscription_End_Date", endDate);
                    command.Parameters.AddWithValue("@Fees", fees);
                    command.Parameters.AddWithValue("@Register_Via_User", registerViaUser);
                    command.Parameters.AddWithValue("@month_Duration", monthDuration);
                    command.Parameters.AddWithValue("@Discount", discount);
                    SqlParameter returnValue = new SqlParameter
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    command.Parameters.Add(returnValue);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        rowAffected = (int)returnValue.Value;
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        rowAffected = 0;
                    }
                }
            }
            return rowAffected != 0;
        }
        public static DataTable getAllSubscription()
        {
            DataTable dt = new DataTable();
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("prSubscriptions_getAllSubscribers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
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

        public static DataTable getSubscriptionHistoryList()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("prSubscription_GetHistoryList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
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
        public static SubscriptionDTO findSubscriptionBySubscriptionId(int SubscriptionId)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("prSubscription_FindSubscriptionById", connection))
                {
                    command.CommandType=CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Subscription_Id", SubscriptionId);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            return new SubscriptionDTO(
                                SubscriptionId,
                                (int)reader["Application_id"],
                                (DateTime)reader["subscriptions_start_date"],
                                (DateTime)reader["subscriptions_end_date"],
                                (decimal)reader["fees"],
                                (int)reader["Register_via_user"],
                                (int)reader["months_duration"],
                                Convert.ToSingle(reader["discount"]),
                                (decimal)reader["final_fees"],
                                (bool)reader["isRenewed"]
                            );

                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return null;
                    }
                }
            }return null;
        }
        public static SubscriptionDTO findSubscriptionsByPersonId(int personId)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("prSubscription_FindSubscriptionByPersonId", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Person_Id", personId);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            return new SubscriptionDTO(
                                (int)reader["subscription_id"],
                                (int)reader["Application_id"],
                                (DateTime)reader["subscriptions_start_date"],
                                (DateTime)reader["subscriptions_end_date"],
                                (decimal)reader["fees"],
                                (int)reader["Register_via_user"],
                                (int)reader["months_duration"],
                                Convert.ToSingle(reader["discount"]),
                                (decimal)reader["final_fees"],
                                 (bool)reader["isRenewed"]
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
        public static SubscriptionDTO findSubscriptionByName(string firstName,string secondName,string lastName)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("prSubscription_FindSubscriptionByName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@First_Name", firstName);
                    if (secondName == "")
                        command.Parameters.AddWithValue("@Second_Name", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Second_Name", secondName);

                    command.Parameters.AddWithValue("@Last_Name", lastName);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            return new SubscriptionDTO(
                                (int)reader["subscription_id"],
                                (int)reader["Application_id"],
                                (DateTime)reader["subscriptions_start_date"],
                                (DateTime)reader["subscriptions_end_date"],
                                (decimal)reader["fees"],
                                (int)reader["Register_via_user"],
                                (int)reader["months_duration"],
                                Convert.ToSingle(reader["discount"]),
                                (decimal)reader["final_fees"],
                                 (bool)reader["isRenewed"]
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
        public static SubscriptionDTO isPersonAlreadySubscribeToCategory(int personId, string categoryName)
        {
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {               
                using(SqlCommand command = new SqlCommand ("prSubscription_isPersonHadAnActiveSubscription", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@person_Id", personId);
                    command.Parameters.AddWithValue("@category_Name", categoryName);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            return new SubscriptionDTO(
                                (int)reader["subscription_id"],
                                (int)reader["Application_id"],
                                (DateTime)reader["subscriptions_start_date"],
                                (DateTime)reader["subscriptions_end_date"],
                                (decimal)reader["fees"],
                                (int)reader["Register_via_user"],
                                (int)reader["months_duration"],
                                Convert.ToSingle(reader["discount"]),
                                (decimal)reader["final_fees"],
                                 (bool)reader["isRenewed"]);
                        }                        
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return null;
                    }
                }
            }return null;
        }
        public static int RenewSubscription( int monthDuration,SubscriptionDTO previousSubscription,int catgoryId,float discount)
        {
            int newId = -1;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("prSubscription_Renew", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Subscription_Id",previousSubscription.subscriptionId);
                    command.Parameters.AddWithValue("@MonthsDuration", monthDuration);
                    command.Parameters.AddWithValue("@Application_id", previousSubscription.applicationId);
                    command.Parameters.AddWithValue("@Subscription_Start_Date", previousSubscription.subscriptionStartDate);
                    command.Parameters.AddWithValue("@Subscription_End_Date", previousSubscription.subscriptionEndDate);
                    command.Parameters.AddWithValue("@Register_Via_User", previousSubscription.registerViaUser);
                    command.Parameters.AddWithValue("@Category_id", catgoryId);
                    command.Parameters.AddWithValue("@Discount", discount);
                    SqlParameter outerParameter = new SqlParameter();
                    command.Parameters.Add("@New_Subscription_Id", SqlDbType.Int);
                    command.Parameters["@New_Subscription_Id"].Direction = ParameterDirection.Output;
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        newId = (int)command.Parameters["@New_Subscription_Id"].Value;
                    }
                    catch (Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        newId = -1;
                    }
                }
            }return newId;
        }
        public static bool DeleteSubscription(int subscriptionId)
        {
            int rowAffected = 0;
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("", subscriptionId);
                    SqlParameter returnValue = new SqlParameter
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    command.Parameters.Add(returnValue);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
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
    }
}
