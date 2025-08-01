using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDataLayer
{
    public class clsAuditData
    {
        public static DataTable LoadYearsFromDatabase()
        {
            DataTable dtYears = new DataTable();
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("PrAudit_getSubscriptionYears", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {                        
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if(reader.HasRows)
                        {
                            dtYears.Load(reader);
                        }
                    }
                    catch(Exception ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return null;
                    }
                }
            }
            return dtYears;
        }
        public static int GetTotalSubscribers(int  categoryId,int month,int year)
        {
            int totalSubscribers = 0;   
            using(SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("PrAudit_GetTotalSubscriptionByDuration", connection))
                {
                    command.CommandType=CommandType.StoredProcedure;
                    if (categoryId == 0)
                        command.Parameters.AddWithValue("@CategoryId", null);
                    else
                        command.Parameters.AddWithValue("@CategoryId", categoryId);

                    if (month == 0)
                        command.Parameters.AddWithValue("@Month", null);
                    else
                        command.Parameters.AddWithValue("@Month", month);
                    
                    if(year == 0)
                        command.Parameters.AddWithValue("@Year", null);
                    else
                        command.Parameters.AddWithValue("@Year", year);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        int.TryParse(result.ToString(),out totalSubscribers);
                    }
                    catch(SqlException ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return 0;
                    }
                }
            }return totalSubscribers;
        }       
        public static int getTotalApplicants(int categoryId, int month,int year)
        {
            int totalApplicants = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("PrAudit_GetTotalApplicantsByDuration", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (categoryId ==0)
                        command.Parameters.AddWithValue("@CategoryId", null);
                    else
                        command.Parameters.AddWithValue("@CategoryId", categoryId);

                    if (month == 0)
                        command.Parameters.AddWithValue("@Month", null);
                    else
                        command.Parameters.AddWithValue("@Month", month);

                    if (year == 0)
                        command.Parameters.AddWithValue("@Year", null);
                    else
                        command.Parameters.AddWithValue("@Year", year);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        int.TryParse(result.ToString(), out totalApplicants);
                    }
                    catch (SqlException ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return 0;
                    }
                }
            }
            return totalApplicants;
        }        
        public static decimal gettotalFees(int categoryId,int month,int year)
        {
            decimal totalFees = 0;
            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("PrAudit_GetTotalFeesByDuration", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (categoryId == 0)
                        command.Parameters.AddWithValue("@CategoryId", null);
                    else
                        command.Parameters.AddWithValue("@CategoryId", categoryId);

                    if (month == 0)
                        command.Parameters.AddWithValue("@Month", null);
                    else
                        command.Parameters.AddWithValue("@Month", month);

                    if (year == 0)
                        command.Parameters.AddWithValue("@Year", null);
                    else
                        command.Parameters.AddWithValue("@Year", year);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        decimal.TryParse(result.ToString(), out totalFees);
                    }
                    catch (SqlException ex)
                    {
                        clsEventLogEntry.SaveEventToEventLogEntry(ex.Message, clsEventLogEntry.enEventLogEntry.enError);
                        return 0;
                    }
                }
            }
            return totalFees;
        }
    }
}
