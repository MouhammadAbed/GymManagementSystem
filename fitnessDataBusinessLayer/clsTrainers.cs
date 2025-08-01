using FitnessDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnessDataBusinessLayer
{
    public class clsTrainers:clsPeople
    {
        public enum enMode { enUpdate = 1, enAdd = 2 }
        public enMode _Mode = enMode.enUpdate;
        public int id { get; set; }
        public int categoryId { get; set; }
        public int personId { get; set; }

        public clsPeople? personInfo;
        public clsCategories? categoryInfo;
        private clsTrainers(trainerDTO trainer,personDTO person )
        {
            this.id = trainer.id;
            this.categoryId = trainer.categoryId;
            this.personId = trainer.personId;
            base.FirstName = person.firstName;
            base.SecondName = person.secondName;
            base.LastName = person.lastName;
            base.Phone = person.phoneNumber;
            personInfo=clsPeople.FindPerson(person.id);
            categoryInfo=clsCategories.FindCategory(categoryId);
            this._Mode = enMode.enUpdate;
        }
        public clsTrainers()
        {
            this.id = 0;
            this.categoryId = 0;
            this.personId = 0;
            _Mode = enMode.enAdd;
        }
        private bool _AddNewTrainer()
        {
            this.id = clsTrainnerData.addNewTrainer(this.categoryId, this.personId);
            return this.id != 0;
        }
        private bool _UpdateTrainer()
        {
            return clsTrainnerData.updateTrainer(this.id, this.categoryId);
        }
        public static DataTable GetAllTrainers()
        {
            return clsTrainnerData.getAllTrainers();            
        }
        public static clsTrainers? GetTrainerById(int id)
        {
            trainerDTO? dto= clsTrainnerData.findTrainer(id);
            if(dto == null)
            {
                return null;
            }
            clsPeople? findPerson = clsPeople.FindPerson(dto.personId);
            if (findPerson == null)
                return null;
            return new clsTrainers(dto,findPerson!.convertToPersonDTO);
        }
        public bool Save()
        {
            base.Mode = (clsPeople.enBaseMode)_Mode;
            if (this.personId == 0)
            {
                if (base.baseSave())
                {
                    this.personId = base.PersonID;
                }
                else
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
                default:
                    if (_UpdateTrainer())
                    {
                        return true;
                    }
                    return false;

            }
        }
        public static bool IsPersonTrainer(int personId)
        {
            return clsTrainnerData.isPersonATrainer(personId);
        }
        public static bool DeleteTrainer(int id)
        {
            return clsTrainnerData.deleteTrainer(id);
        }
    }
}
