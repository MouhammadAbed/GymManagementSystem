using FitnessDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnessDataBusinessLayer
{
    public class clsCategories
    {
        public enum enMode { enUpdate = 1, enAdd = 2 }
        public enMode _Mode = enMode.enUpdate;
        public int id { get; set; }
        public string name { get; set; }
        public decimal fees { get; set; }
        private clsCategories(int id, string name, decimal fees)
        {
            this.id = id;
            this.name = name;
            this.fees = fees;
            _Mode = enMode.enUpdate;
        }
        public clsCategories()
        {
            this.id = 0;
            this.name = "";
            this.fees = 0;
        }

        public static DataTable? getAllCategories()
        {
            return clsCategoriesData.getAllCategories();
        }

        public static clsCategories? FindCategory(int id)
        {
            categoryDTO? category = clsCategoriesData.findCategory(id);
            if(category !=null)
            {
                return new clsCategories(category.id,category.categoryName,category.fees);
            }
            return null;
        }

        private bool _UpdateCategory()
        {
            return clsCategoriesData.updateCategory(this.id, this.name, this.fees); 
        }

        private bool _AddCategory()
        {
            this.id = clsCategoriesData.addCategory(this.name, this.fees);
            return this.id > 0;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.enUpdate:
                    if (_UpdateCategory())
                    {
                        return true;
                    }return false;
                default:
                    if (_AddCategory())
                    {
                        _Mode=enMode.enUpdate;
                        return true;
                    }
                    return false;
            }
        }

        public static bool DeleteCategory(int id)
        {
            return clsCategoriesData.deleteCategory(id);
        }
    }
}
