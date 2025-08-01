using fitnessDataBusinessLayer;
using FitnessDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBusinessLayer
{
    public class clsMembers : clsPeople
    {
        public enum enMode { enUpdate = 1, enAdd = 2 }
        public enMode _Mode = enMode.enUpdate;

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
            _Mode = enMode.enAdd;
        }
        private clsMembers(MemberDTO member, personDTO person)
        {
            this.id = member.memberId;
            this.status = member.status;
            this.person_id = member.person_id;
            this.addByUser = member.added_By_User;
            base.PersonID = person.id;
            base.FirstName = person.firstName;
            base.LastName = person.lastName;
            base.SecondName = person.secondName;
            base.Phone = person.phoneNumber;
            base.gender = person.gender;
            _Mode = enMode.enUpdate;
        }
        public string StatusString
        {            
            get
            {
                string currentState= this.status == false ?  "UnActive" : "Active";
                return currentState;
            }
        }
        public MemberDTO convertTOMemberDTO
        {
            get
            {
                return new MemberDTO(this.id, this.status, this.person_id, this.addByUser);
            }
        }
        public static DataTable getAllMembers()
        {
            return clsMemberData.getAllMembers();
        }
        public static DataTable getAllActiveMembers()
        {
            return clsMemberData.getAllActiveMembers();
        }
        public static clsMembers FindMember(int id)
        {
            MemberDTO member = clsMemberData.findMember(id);
            if (member != null)
            {
                clsPeople person = clsPeople.FindPerson(member.person_id);
                return new clsMembers(member, person.convertToPersonDTO);
            }
            return null;
        }
        public static clsMembers FindMemberByPersonId(int Id)
        {
            MemberDTO member = clsMemberData.findMemberByPersonid(Id);
            if(member!= null)
            {
                clsPeople person = clsPeople.FindPerson(member.person_id);
                return new clsMembers(member, person.convertToPersonDTO);
            }
            return null;
        }
        public static clsMembers FindMember(string FirstName, string SecondName, string LastName)
        {
            MemberDTO member = clsMemberData.findMember( FirstName,SecondName,LastName );
            if (member != null)
            {
                clsPeople person = clsPeople.FindPerson(member.person_id);
                return new clsMembers(member, person.convertToPersonDTO);
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
            return clsMemberData.updateMember(this.id, this.status, this.addByUser);
        }
        public bool Save()
        {
            base.Mode = (clsPeople.enBaseMode)_Mode;

            if (this.person_id <1 && base.Mode == (clsPeople.enBaseMode)enMode.enUpdate)
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
                    if (_UpdateMembers())
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
