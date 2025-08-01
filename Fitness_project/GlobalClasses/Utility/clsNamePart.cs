using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_project.GlobalClasses.Utility
{
    public class clsNamePart
    {
        public string firstName {  get; set; }
        public string secondName {  get; set; }
        public string lastName { get; set; }     
        public static clsNamePart ParseFullName(string fullName)
        {
            var result = new clsNamePart();
            string[] parts = fullName.Trim().Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 3)
            {
                result.firstName = parts[0];
                result.secondName = parts[1];
                result.lastName = parts[2];
            }
            else if (parts.Length == 2)
            {
                result.firstName = parts[0];
                result.secondName = "";
                result.lastName = parts[1];
            }
            else if (parts.Length == 1)
            {
                result.firstName = parts[0];
                result.secondName = "";
                result.lastName = "";
            }
            else
                return null;

                return result;
        }
    }
}
