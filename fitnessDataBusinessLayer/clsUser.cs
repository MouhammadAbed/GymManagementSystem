using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessDataAccessLayer;
using Microsoft.Data.SqlClient;

namespace fitnessDataBusinessLayer
{
    public class clsUser: clsPeople
    {
        enum enMode { enUpdate = 1, enAdd = 2 }
        enMode _Mode = enMode.enUpdate;
        public int UserID { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
        private clsUser(int UserID, string UserName, string Password, int PersonID, string FirstName, string SecondName, string lastName, string Phone)
        {
            this.UserID = UserID;
            this.userName = UserName;
            this.Password = Password;
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.LastName = lastName;
            this.Phone = Phone;
            _Mode = enMode.enUpdate;
        }
        public clsUser()
        {
            this.UserID = 0;
            this.userName = "";
            this.Password = string.Empty;
            this.PersonID = 0;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.LastName = string.Empty;
            this.Phone = string.Empty;
            _Mode = enMode.enAdd;
        }
        public static clsUser? FindUser(int UserID)
        {
            userDTO? findUserDTO = clsUserData.FindUser(UserID);
            if(findUserDTO==null)
            {
                return null;
            }
            clsPeople? findPerson = clsPeople.FindPerson(findUserDTO.personId);
            if (findPerson == null)
            {
                return null;
            }
            return new clsUser(UserID, findUserDTO.userName, findUserDTO.password, findUserDTO.personId,
                findPerson.FirstName, findPerson.SecondName, findPerson.LastName,
                findPerson.Phone);
          
        }
        public static clsUser? FindUser(string UserName)
        {
            userDTO? findUserDTO = clsUserData.FindUserByUserName(UserName);
            if(findUserDTO == null)
            {
                return null;
            }
            clsPeople? FindPerson = clsPeople.FindPerson(findUserDTO.personId);
            if(FindPerson == null)
            {
                return null;
            }
            return new clsUser(findUserDTO.id, findUserDTO.userName, findUserDTO.password, findUserDTO.personId,
                FindPerson.FirstName, FindPerson.SecondName, FindPerson.LastName,
                FindPerson.Phone);

        }
        public static clsUser? FindUserByPersonID(int PersonID)
        {
            userDTO? findUserDTO = clsUserData.FindUserbyPersonID(PersonID);
            if (findUserDTO == null)
                return null;
            clsPeople? findPerson = clsPeople.FindPerson(findUserDTO.personId);
            if (findPerson == null)
                return null;
            return new clsUser(findUserDTO.id, findUserDTO.userName, findUserDTO.password, findUserDTO.personId,
                findPerson.FirstName, findPerson.SecondName, findPerson.LastName,
                findPerson.Phone);
           
        }
        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.userName, this.Password, this.PersonID);
            return this.UserID != -1;
        }
        private bool _UpdateUser()
        {
            return clsUserData.UpdateUserPassword(this.UserID, this.userName, this.Password);
        }
        public new bool Save()
        {
            base.Mode = (clsPeople.enBaseMode)_Mode;
            if (base.baseSave())
            {
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
            }
            return false;
        }
        public static bool UpdateUserPassword(int userID, string userName, string Password)
        {
            return clsUserData.UpdateUserPassword(userID, userName, Password);
        }
        public static bool isUserExistByUserNameAndPassword(string userName, string Password)
        {
            return clsUserData.isUserExistByIDAndPassword(userName, Password);
        }
        public static DataTable? getAllUser()
        {
            return clsUserData.GetAllUsers();
        }
        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DelteUser(UserID);
        }
        public static bool isUserNameExist(string userName)
        {
            return clsUserData.isUserNameExist(userName);
        }
    }
}
