using FitnessDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBusinessLayer
{
    public class clsApplication
    {
        public int applicationId { get; set; }
        public int memberId { get; set; }

        int assigmentId { get; set; }
        public DateTime createdDate { get; set; }
        public bool applicationStatus { get; set; }
        public DateTime lastUpdate { get; set; }
        public clsMembers memberInfo;
        public clsTrainerCategoryAssignment trainerCategoryInfo;
        public clsApplication(ApplicationDTO appDTO)
        {
            this.applicationId = appDTO.applicationId;
            this.memberId = appDTO.memberid;
            this.assigmentId=appDTO.assignment_Id;
            this.createdDate = appDTO.createdDate;
            this.applicationStatus = appDTO.status;
            this.lastUpdate = appDTO.lastUpdateDate;
            memberInfo=clsMembers.FindMember(memberId);
            trainerCategoryInfo = clsTrainerCategoryAssignment.findAssignment(this.assigmentId);
        }
        public static clsApplication findApplicationByMemberId(int memberId)
        {
            ApplicationDTO findAppliction = clsApplicationData.FindApplicationByMemberId(memberId);
            if(findAppliction != null)
            {
                return new clsApplication(findAppliction);
            }
            return null;
        }
        public static clsApplication findApplicationByAppId(int appId)
        {            
            ApplicationDTO findAppliction = clsApplicationData.FindApplicationById(appId);
            if (findAppliction != null)
            {
                return new clsApplication(findAppliction);
            }
            return null;
        }
        public static List<DailyExpiredDTO> findTopApplicants()
        {
            return clsApplicationData.getAllTopTenApplicants();
        }

        

    }
}
