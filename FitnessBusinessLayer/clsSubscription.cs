using FitnessDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBusinessLayer
{
    public class clsSubscription
    {
        public int subscriptionId { get; set; }
        public int applicationId { get; set; }
        public DateTime subscriptionStartDate { get; set; }
        public DateTime subscriptionEndDate { get; set; }
        public decimal fees { get; set; }
        public int registerViaUser { get; set; }
        public int monthDuration { get; set; }
        public float discount { get; set; }
        public decimal finalFees { get; set; }
        public bool isRenewed { get; set; } 

        public clsApplication applicationInfo;
        public clsSubscription()
        {
            this.subscriptionId = 0;
            this.applicationId = 0;
            this.subscriptionStartDate = DateTime.MinValue;
            this.subscriptionEndDate = DateTime.MinValue;
            this.fees = 0;
            this.registerViaUser = 0;
            this.monthDuration = 0;
            this.discount = 0;
            this.finalFees = 0;
        }
        private clsSubscription(int subscriptionId, int applicationId, DateTime subscriptionStartDate,
            DateTime subscriptionEndDate, decimal fees, int registerViaUser,int monthDuration, float discount, decimal finalFees, bool isRenewed    )
        {
            this.subscriptionId = subscriptionId;
            this.applicationId = applicationId;
            this.subscriptionStartDate = subscriptionStartDate;
            this.subscriptionEndDate = subscriptionEndDate;
            this.fees = fees;
            this.registerViaUser = registerViaUser;
            this.monthDuration = monthDuration;
            this.discount = discount;
            this.finalFees = finalFees;
            applicationInfo = clsApplication.findApplicationByAppId(applicationId);
            this.isRenewed = isRenewed;
        }
        public SubscriptionDTO ConvertSuscriptionToDTO
        {
            get
            {
                return new SubscriptionDTO(this.subscriptionId, this.applicationId, this.subscriptionStartDate,
                this.subscriptionEndDate, this.fees, this.registerViaUser, this.monthDuration, this.discount, this.finalFees,this.isRenewed);
            }
        }
        public int AddNewSubscription(int personId,int assignmentId)
        {
            this.subscriptionId = clsSubscriptionData.AddNewSubscription(this.ConvertSuscriptionToDTO, personId, assignmentId);
            return this.subscriptionId;
        }
        public static DataTable GetAllSubscriptions()
        {
            return clsSubscriptionData.getAllSubscription();
        }
        public static clsSubscription FindSubscriptionBySubsId(int SubscriptionId)
        {
            SubscriptionDTO findSubscription = clsSubscriptionData.findSubscriptionBySubscriptionId(SubscriptionId);
            if (findSubscription == null)
            {
                return null;
            }
            return new clsSubscription(findSubscription.subscriptionId, findSubscription.applicationId, findSubscription.subscriptionStartDate, findSubscription.subscriptionEndDate, findSubscription.fees, findSubscription.registerViaUser, findSubscription.monthsDuration,findSubscription.discount, findSubscription.finalFees,findSubscription.isRenewd);
        }           
        public static DataTable GetSubscriptionHistroyList()
        {
            return clsSubscriptionData.getSubscriptionHistoryList();
        }
        public static clsSubscription FindSubscriptionByPersonId(int PersonId)
        {
            SubscriptionDTO findSubscription = clsSubscriptionData.findSubscriptionsByPersonId(PersonId);
            if (findSubscription == null)
            {
                return null;
            }
            return new clsSubscription(findSubscription.subscriptionId, findSubscription.applicationId, findSubscription.subscriptionStartDate,
                findSubscription.subscriptionEndDate, findSubscription.fees, findSubscription.monthsDuration, 
                findSubscription.registerViaUser, findSubscription.discount, findSubscription.finalFees,findSubscription.isRenewd);
        }
        public static clsSubscription FindSubscriptionByName(string firstName,string secondName,string lastName)
        {
            SubscriptionDTO findSubscription = clsSubscriptionData.findSubscriptionByName(firstName,secondName,lastName);
            if (findSubscription == null)
            {
                return null;
            }
            return new clsSubscription(findSubscription.subscriptionId, findSubscription.applicationId, findSubscription.subscriptionStartDate,
                findSubscription.subscriptionEndDate, findSubscription.fees, findSubscription.monthsDuration,
                findSubscription.registerViaUser, findSubscription.discount, findSubscription.finalFees, findSubscription.isRenewd);
        }
        public static clsSubscription isPersonHadAnActiveSubscription(int personId, string categoryName)
        {
            SubscriptionDTO findSubscription= clsSubscriptionData.isPersonAlreadySubscribeToCategory(personId, categoryName);
            if (findSubscription==null)
            {
                return null;
            }
            return new clsSubscription(findSubscription.subscriptionId, findSubscription.applicationId, findSubscription.subscriptionStartDate,
                findSubscription.subscriptionEndDate, findSubscription.fees, findSubscription.registerViaUser, findSubscription.monthsDuration,
                findSubscription.discount, findSubscription.finalFees,findSubscription.isRenewd);
        }
        public int renewSubscription (int monthDuration,int categoryId,float discount)
        {
           return clsSubscriptionData.RenewSubscription(monthDuration, this.ConvertSuscriptionToDTO,categoryId, discount);
        }
        public static bool UpdateSubscription(int subscriptionId, DateTime startDate, DateTime endDate, decimal fees, int registerViaUser, int monthDuration, float discount)
        {
            return clsSubscriptionData.UpdateSubscription(subscriptionId, startDate, endDate, fees, registerViaUser, monthDuration, discount);
        }
        public static bool DeleteSubscription(int subscriptionId)
        {
            return clsSubscriptionData.DeleteSubscription(subscriptionId);
        }
    
    }
}