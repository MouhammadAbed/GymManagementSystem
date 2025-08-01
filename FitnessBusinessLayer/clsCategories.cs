using FitnessDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBusinessLayer
{
    public class clsCategories
    {
        public enum enMode { enUpdate = 1, enAdd = 2 }
        public enMode _Mode = enMode.enUpdate;
        public int id { get; set; }
        public string name { get; set; }
        public decimal fees { get; set; }
        public string Description { get; set; } 
        private clsCategories(int id, string name, decimal fees, string description)
        {
            this.id = id;
            this.name = name;
            this.fees = fees;
            this.Description = description;
            Description = description;
            _Mode = enMode.enUpdate;
        }
        public clsCategories()
        {
            this.id = 0;
            this.name = string.Empty;
            this.fees = 0;
            this.Description = string.Empty;
            _Mode = enMode.enAdd;
        }
        public static DataTable getAllCategories()
        {
            return clsCategoriesData.getAllCategories();
        }
        public static clsCategories FindCategory(int id)
        {
            categoryDTO category = clsCategoriesData.findCategory(id);
            if (category != null)
            {
                return new clsCategories(category.id, category.categoryName, category.fees,category.description);
            }
            return null;
        }
        public static clsCategories FindCategory(string categoryName)
        {
            categoryDTO category = clsCategoriesData.findCategory(categoryName);
            if (category != null)
            {
                return new clsCategories(category.id, category.categoryName, category.fees,category.description);
            }
            return null;
        }
        public static bool isCategoryExist(string categoryName)
        {
            return clsCategoriesData.isCategoryExist(categoryName);
        }
        private bool _UpdateCategory()
        {
            return clsCategoriesData.updateCategory(this.id, this.name, this.fees,this.Description);
        }
        private bool _AddCategory()
        {
            this.id = clsCategoriesData.addCategory(this.name, this.fees,this.Description);
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
                    }
                    return false;
                default:
                    if (_AddCategory())
                    {
                        _Mode = enMode.enUpdate;
                        return true;
                    }
                    return false;
            }
        }
        public static bool DeleteCategory(int id)
        {
            return clsCategoriesData.deleteCategory(id);
        }
        public static int GetCategoriesCount()
        {
            return clsCategoriesData.GetCategoryCount();
        }
    }
}
