using CourseSheduleManagement.DataAccess;
using CourseSheduleManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace CourseSheduleManagement.Method
{
    public class ModuleMethod
    {
        ModuleDataAccess _moduleDataAccess = new ModuleDataAccess();

        public DataTable GetModules()
        {
            DataTable dt = _moduleDataAccess.GetModules();
           
            return dt;
        }
        public Module GetModuleById(int id)
        {
            Module module = new Module();
            DataTable dt = _moduleDataAccess.GetModuleById(id);
            if (dt.Rows.Count == 1)
            {
                module.ModuleId =Convert.ToInt32(dt.Rows[0]["ModuleId"].ToString());
                module.Name = dt.Rows[0]["Name"].ToString();
                module.Description =  dt.Rows[0]["Description"].ToString();
                module.CourseId =Convert.ToInt32(dt.Rows[0]["CourseId"].ToString());
            }
            return module;
        }
        public void AddOrEditModule(int moduleId, string name, string description, int courseId)
        {
            _moduleDataAccess.AddOrEditModule(moduleId,name,description,courseId);
        }

        public void DeleteModule(int moduleId)
        {
            _moduleDataAccess.DeleteModule(moduleId);
        }
    }


}
