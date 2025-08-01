using FitnessDataLayer;
using System.Data;
using static FitnessDataLayer.personDTO;

namespace fitnessDataBusinessLayer
{
    public class clsPeople
    {
        public enum enBaseMode { enUpdate = 1, enAdd = 2 }
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public bool gender { get; set; }

        public enBaseMode Mode = enBaseMode.enUpdate;
        public clsPeople(int PersonID, string FirstName, string SecondName, string LastName, string Phone, bool gender)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.gender = gender;
            Mode = enBaseMode.enUpdate;
        }
        public clsPeople()
        {
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.LastName = string.Empty;
            this.Phone = string.Empty;
            Mode = enBaseMode.enAdd;
        }

        public personDTO convertToPersonDTO
        {
            get
            {
                return new personDTO(this.PersonID, this.FirstName, this.SecondName,
                    this.LastName, this.Phone,this.gender);
            }
        }
        public string fullName
        {
            get
            {
                return this.FirstName + " " + this.SecondName + " " + this.LastName;
            }
        }

        public string GenderText => this.gender ? "Male" : "Female";
        public static clsPeople FindPerson(int PersonID)
        {
            personDTO findPerson = clsPeopleData.FindPersonByID(PersonID);
            if (findPerson != null)
            {
                return new clsPeople(findPerson.id, findPerson.firstName, findPerson.secondName,
                    findPerson.lastName, findPerson.phoneNumber,findPerson.gender);
            }
            return null;
        }
        public static clsPeople FindPerson(string firstName,string secondName,string lastName)
        {
            personDTO findPerson = clsPeopleData.FindPersonByName(firstName,secondName,lastName);
            if (findPerson != null)
            {
                return new clsPeople(findPerson.id, findPerson.firstName, findPerson.secondName,
                    findPerson.lastName, findPerson.phoneNumber, findPerson.gender);
            }
            return null;
        }
        public bool _AddNewPerson()
        {
            this.PersonID = clsPeopleData.AddNewPerson(this.FirstName, this.SecondName, this.LastName, this.Phone,this.gender);
            return this.PersonID != -1;
        }
        public bool _UpdatePersonInfo()
        {
            if (clsPeopleData.updatePersonInfo(this.PersonID, this.FirstName, this.SecondName, this.LastName, this.Phone,this.gender))
                return true;

            return false;
        }
        public static DataTable GetAllPeople()
        {
            return clsPeopleData.getAllPeople();
        }
        public static bool isPersonExist(int personID)
        {
            return clsPeopleData.isPersonExist(personID);
        }
        public bool baseSave()
        {
            switch (Mode)
            {
                case enBaseMode.enUpdate:

                    if (_UpdatePersonInfo())
                        return true;

                    return false;

                case enBaseMode.enAdd:

                    if (_AddNewPerson())
                    {
                        Mode = enBaseMode.enUpdate;
                        return true;
                    }
                    return false;
            }
            return false;
        }
        public static bool DeletePerson(int PersonID)
        {
            return clsPeopleData.DeletePerson(PersonID);
        }
        public static int GetPersonIDByName(string fullName)
        {
            return clsPeopleData.getPersonIdByName(fullName);
        }
    }
}
