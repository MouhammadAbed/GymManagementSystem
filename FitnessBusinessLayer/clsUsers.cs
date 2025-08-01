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
    public class clsUser : clsPeople
    {
        enum enMode { enUpdate = 1, enAdd = 2 }
        enMode _Mode = enMode.enUpdate;
        public int UserID { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }
        public int PersonId { get; set; }
        private clsUser(userDTO UserDTO,personDTO PersonDTO)
        {
            this.UserID = UserDTO.id;
            this.userName = UserDTO.userName;
            this.Password = UserDTO.password;
            this.Permissions = UserDTO.permissions;
            this.PersonID = UserDTO.personId;
            base.FirstName = PersonDTO.firstName;
            base.SecondName = PersonDTO.secondName;
            base.LastName = PersonDTO.lastName;
            base.Phone = PersonDTO.phoneNumber;           
            _Mode = enMode.enUpdate;
        }
        public clsUser()
        {
            this.UserID = 0;
            this.userName = "";
            this.Password = string.Empty;
            this.Permissions = 0;
            this.PersonID = 0;
            base.FirstName = string.Empty;
            base.SecondName = string.Empty;
            base.LastName = string.Empty;
            base.Phone = string.Empty;
            _Mode = enMode.enAdd;
        }
        public static clsUser FindUser(int UserID)
        {
            userDTO findUserDTO = clsUserData.FindUser(UserID);
            if (findUserDTO == null)
            {
                return null;
            }
            clsPeople findPerson = clsPeople.FindPerson(findUserDTO.personId);
            
            if (findPerson == null)
            {
                return null;
            }
            personDTO person = findPerson.convertToPersonDTO;
            return new clsUser(findUserDTO,person);

        }
        public static clsUser FindUser(string UserName)
        {
            userDTO findUserDTO = clsUserData.FindUserByUserName(UserName);
            if (findUserDTO == null)
            {
                return null;
            }
            clsPeople FindPerson = clsPeople.FindPerson(findUserDTO.personId);

            if (FindPerson == null)
            {
                return null;
            }
            personDTO person = FindPerson.convertToPersonDTO;
            return new clsUser(findUserDTO,person);

        }
        public static clsUser FindUserByPersonID(int PersonID)
        {
            userDTO findUserDTO = clsUserData.FindUserbyPersonID(PersonID);
            if (findUserDTO == null)
                return null;
            clsPeople findPerson = clsPeople.FindPerson(findUserDTO.personId);
            if (findPerson == null)
                return null;
            personDTO person = findPerson.convertToPersonDTO;
            return new clsUser(findUserDTO,person);
        }
        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.userName, this.Password,this.Permissions, this.PersonID);
            return this.UserID != -1;
        }
        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.PersonID, this.userName, this.Password,this.Permissions);
        }
        public bool Save()
        {
            if (this.PersonID < 1)
            {
                base.Mode = (clsPeople.enBaseMode)_Mode;
                if (!base.baseSave())
                {
                    return false;
                }
            }
            switch (_Mode)
            {
                case enMode.enUpdate:
                    if (_UpdateUser())
                        return true;
                    return false;

                case enMode.enAdd:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.enUpdate;
                        return true;
                    }
                    return false;
            }
            
            return false;
        }
        public static bool isUserExistByUserNameAndPassword(string userName, string Password)
        {
            return clsUserData.isUserExistByIDAndPassword(userName, Password);
        }
        public static DataTable getAllUser()
        {
            return clsUserData.GetAllUsers();
        }
        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DelteUser(UserID);
        }
        public static bool DeleteUserByPersonId(int PersonId)
        {
            return clsUserData.DeleteUserByPersonId(PersonId);
        }
        public static bool isUserNameExist(string userName)
        {
            return clsUserData.isUserNameExist(userName);
        }
    }
}
