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
    public class clsTrainers : clsPeople
    {
        public enum enMode { enUpdate = 1, enAdd = 2 }
        public enMode _Mode = enMode.enUpdate;
        public int id { get; set; }
        public clsPeople personInfo;
        bool isActive = false;
        private clsTrainers(trainerDTO trainer, personDTO person)
        {
            this.id = trainer.id;
            this.isActive = trainer.isActive;
            base.PersonID = trainer.personId;
            base.SecondName = person.secondName;
            base.LastName = person.lastName;
            base.Phone = person.phoneNumber;
            base.gender = person.gender;
            base.FirstName = person.firstName;
            this._Mode = enMode.enUpdate;
        }
        public clsTrainers()
        {
            base.PersonID = 0;            
            _Mode = enMode.enAdd;
        }
        public trainerDTO convertToTrainerDTO
        {
            get { return new trainerDTO(this.id,this.isActive, this.PersonID); }
        }
        private bool _AddNewTrainer()
        {
            this.id = clsTrainnerData.addNewTrainer( base.PersonID);
            return this.id != 0;
        }
        public static DataTable GetAllTrainers()
        {
            return clsTrainnerData.getAllTrainers();
        }
        public static clsTrainers FindTrainer(int id)
        {
            trainerDTO dto = clsTrainnerData.findTrainer(id);
            if (dto == null)
            {
                return null;
            }
            clsPeople findPerson = clsPeople.FindPerson(dto.personId);
            if (findPerson == null)
                return null;
            return new clsTrainers(dto, findPerson.convertToPersonDTO);
        }
        public static clsTrainers FindTrainer(string firstName,string secondName,string lastName)
        {
            trainerDTO dto = clsTrainnerData.findTrainer(firstName,secondName,lastName);
            if (dto == null)
            {
                return null;
            }
            clsPeople findPerson = clsPeople.FindPerson(dto.personId);
            if (findPerson == null)
                return null;
            return new clsTrainers(dto, findPerson.convertToPersonDTO);
        }
        public static clsTrainers FindTrainerByPersonid(int PersonId)
        {
            trainerDTO dto = clsTrainnerData.findTrainerByPersonId(PersonId);
            if (dto == null)
            {
                return null;
            }
            clsPeople findPerson = clsPeople.FindPerson(dto.personId);
            if (findPerson == null)
                return null;
            return new clsTrainers(dto, findPerson.convertToPersonDTO);
        }
        public bool Save()
        {
            base.Mode = (clsPeople.enBaseMode)_Mode;
            if (base.PersonID == 0)
            {
                if (!base.baseSave())
                {
                    return false;
                    
                }
            }
            switch (_Mode)
            {
                case enMode.enAdd:
                    if (_AddNewTrainer())
                    {
                        _Mode = enMode.enUpdate;
                        return true;
                    }
                    else
                        return false;
            }
            return false;
        }
        public static bool IsPersonTrainer(int personId)
        {
            return clsTrainnerData.isPersonATrainer(personId);
        }
        public static bool DeleteTrainer(int PersonId)
        {
            return clsTrainnerData.DeleteTrainer(PersonId);
        }
    }
}
