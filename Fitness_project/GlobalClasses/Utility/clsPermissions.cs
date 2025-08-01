using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_project.GlobalClasses.Utility
{
    public class clsPermissions
    {
        public enum enPermissions { enAll = 1, enUserTabs = 2, enMembersTabs = 4, enTrainersTab = 8, enCategoriesTab = 16, enSubscriptionTab = 32, enAuditTab = 64 };

        public static bool CheckAccessRights(int userPermission, enPermissions requiredPermission)
        {
            if (userPermission == 1)
            {
                return true;
            }
            return (userPermission & (int)requiredPermission) == (int)requiredPermission;
        }
    }
}
