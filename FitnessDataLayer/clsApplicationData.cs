using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDataLayer
{
    public class ApplicationDTO
    {
        public int applicationId { get; set; }
        public int memberid { get; set; }
        public int assignment_Id { get; set; }
        public DateTime createdDate { get; set; }
        public bool status { get; set; }
        public DateTime lastUpdateDate { get; set; }

        public ApplicationDTO(int ApplicationId, int MemberId,int assigment_Id,
            DateTime CreatedDate, bool Status, DateTime lastUpdateDate)
        {
            this.applicationId = ApplicationId;
            this.memberid = MemberId;
            this.assignment_Id = assigment_Id;
            this.createdDate = CreatedDate;
            this.status = Status;
            this.lastUpdateDate = lastUpdateDate;
        }
    }

    public class DailyExpiredDTO
    {
        public string Name { get; set; }
        public DateTime SubscriptionEndDate { get; set; }
        public string CategoryName { get; set; }

        public DailyExpiredDTO(string name, DateTime subscriptionEndDate, string categoryName)
        {
            Name = name;
            SubscriptionEndDate = subscriptionEndDate;
            CategoryName = categoryName;
        }
    }
    public class clsApplicationData
    {        
        public static ApplicationDTO FindApplicationByMemberId(int memberId)
        {
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("prApplication_FindByMember", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@member_Id", memberId);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            return new ApplicationDTO(
                                (int)reader["application_id"],
                                memberId,
                                (int)reader["assignment_id"],
                                (DateTime)reader["created_date"],
                                (bool)reader["application_status"],
                                (DateTime)reader["last_update"]
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
        public static ApplicationDTO FindApplicationById(int ApplicationId)
        {
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("prApplication_FindByApplicationId", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@applicationId", ApplicationId);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            return new ApplicationDTO(
                                ApplicationId,
                                (int)reader["member_id"],
                                (int)reader["assignment_id"],
                                (DateTime)reader["created_date"],
                                (bool)reader["application_status"],
                                (DateTime)reader["last_update"]
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
        public static List<DailyExpiredDTO> getAllTopTenApplicants()
        {
            List<DailyExpiredDTO> topApplicant = new List<DailyExpiredDTO>();
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("PrSubscription_getDailyExpiredDate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string name = reader["Name"].ToString();
                            string category = reader["category_name"].ToString();
                            DateTime date = (DateTime)reader["Subscription End Date"];

                            topApplicant.Add(new DailyExpiredDTO(name, date, category));
                        }
                    }
                    catch(Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return null;
                    }
                }
            }return topApplicant;
        }
    }
}
