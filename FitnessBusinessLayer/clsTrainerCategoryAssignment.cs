using FitnessDataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBusinessLayer
{
    public class clsTrainerCategoryAssignment:clsTrainers
    {
        public int AssignmentId { get; set; }  
        public int TrainerId { get; set; }
        public int CategoryId { get; set; }
        public decimal Salary { get; set; }        

       public clsTrainers trainerInfo;
       public clsCategories categoryInfo;
        public clsTrainerCategoryAssignment()
        {
            AssignmentId = 0;
            TrainerId = 0;
            CategoryId = 0;
            Salary = 0;
            base.PersonID = 0;
        }
        private clsTrainerCategoryAssignment(clsTrainerCategoryAssignmentDTO assignDTO,trainerDTO trainerDTO)
        {
            AssignmentId = assignDTO.AssignId;
            TrainerId = assignDTO.TrainerId;
            CategoryId = assignDTO.CategoryId;
            Salary = assignDTO.Salary;
            base.PersonID = trainerDTO.personId;
            categoryInfo = clsCategories.FindCategory(CategoryId);
            trainerInfo=clsTrainers.FindTrainer(TrainerId);
        }
        public int AssignNewCategoryToTrainer()
        {
           if(this.TrainerId == 0)
           {
                if (!base.Save())
                {
                    return 0 ;
                }
                else
                {
                    this.TrainerId = base.id;
                }
           }
          return  clsTrainerCategoryAssignmentData.AssignNewCategoryToTrainer(this.TrainerId, this.CategoryId, this.Salary);

        }
        public static bool DeleteAssignment(int assignId)
        {
            return clsTrainerCategoryAssignmentData.DeleteAssignment(assignId);
        }
        public static List<string> GetTrainerCategoriesAssignment(int PersonId)
        {
            return clsTrainerCategoryAssignmentData.GetTrainerCategoriesAssignment(PersonId);
        }       
        public static clsTrainerCategoryAssignment findAssignment(int assignmentId)
        {
            clsTrainerCategoryAssignmentDTO assignDTO = clsTrainerCategoryAssignmentData.FindAssignment(assignmentId);
            if (assignDTO != null)
            {
                clsTrainers trainer = clsTrainers.FindTrainer(assignDTO.TrainerId);
                if(trainer != null)
                {
                    trainerDTO trainerDTO = trainer.convertToTrainerDTO;
                    return new clsTrainerCategoryAssignment(assignDTO, trainerDTO);

                }
                
            }
            return null;
        }
        public static int GetAssignmentId(string fullName,string categoryName)
        {
            return clsTrainerCategoryAssignmentData.GetAssignmentID(fullName,categoryName);
        }        
        public static bool UpdateTrainerSalary(int assignmentId,decimal salary)
        {
            return clsTrainerCategoryAssignmentData.UpdateTrainerSalary(assignmentId,salary);
        }
    }
}
