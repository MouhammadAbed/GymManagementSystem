using FitnessDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace fitnessDataBusinessLayer
{
    public class clsMembers: clsPeople
    {
        // memberId,membership_status,person_Id,added_by_user
        public enum enMode { enUpdate=1,enAdd =2 }
        public enMode _Mode =enMode.enUpdate;

        public int id { get; set; }
        public bool status { get; set; }
        public int person_id { get; set; }
        public int addByUser { get; set; }

        public clsMembers()
        {
            this.id = 0;
            this.status = true;
            this.person_id = 0;
            this.addByUser = 0;
            _Mode = enMode.enUpdate;
        }

        private clsMembers( MemberDTO member,personDTO? person)
        {
            this.id = id;
            this.status = status;
            this.person_id = person_id;
            this.addByUser = addByUser;
            base.PersonID =person.id;
            base.FirstName = person.firstName;
            base.LastName = person.lastName;
            base.SecondName = person.secondName;
            base.Phone = person.phoneNumber;
            _Mode = enMode.enAdd;
        }
      
        public static DataTable getAllMembers()
        {
            return clsMemberData.getAllMembers();
        }
        public static DataTable getAllActiveMembers()
        {
            return clsMemberData.getAllActiveMembers();
        }
        public static clsMembers? FindMember(int id)
        {
            MemberDTO? member= clsMemberData.findMember(id);
            if (member != null)
            {
                clsPeople? person = clsPeople.FindPerson(member.person_id);
                return new clsMembers(member, person?.convertToPersonDTO);
            }
            return null;
        }
        private bool _AddNewMember()
        {
            this.id = clsMemberData.AddMember(this.person_id, this.addByUser);
           return this.id != 0;          
        }
        private bool _UpdateMembers()
        {
            return clsMemberData.updateMember(this.id,this.status,this.addByUser);
        }
        public bool Save()
        {
            //give the base mode the same mode as the current class
            base.Mode = (clsPeople.enBaseMode)_Mode;
            //person id = 0 than we are going to create a person id and assign the value get it to 
            //perosn id of the member class
            if(this.person_id==0||base.Mode==(clsPeople.enBaseMode)enMode.enUpdate)
            {
                if (base.baseSave())
                {
                    this.person_id = base.PersonID;
                }
                else
                {
                    return false;
                }
            }
            switch (_Mode)
            {
                case enMode.enUpdate:
                    if (_UpdatePersonInfo())
                    {
                        return true;
                    }
                    return false;
                default:
                    if (_AddNewMember())
                    {
                        _Mode = enMode.enUpdate;
                        return true;
                    }
                    return false;
            }
            
        }        
    }
}
