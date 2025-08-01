using FitnessDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBusinessLayer
{
    public class clsAudit
    {
        public static DataTable getYears()
        {
            return clsAuditData.LoadYearsFromDatabase();
        }
        public static int TotalSubscrbers(int categoryId,int month,int year)
        {
            return clsAuditData.GetTotalSubscribers(categoryId, month, year);
        }
        public static int TotalApplicants(int categoryId, int month , int year)
        {
            return clsAuditData.getTotalApplicants(categoryId, month , year);
        }
        public static decimal TotalFees(int categoryId,int month ,int year)
        {
            return clsAuditData.gettotalFees(categoryId, month , year);
        }
    }
}
