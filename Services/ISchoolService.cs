using System.Collections.Generic;
using SchoolManagementMVC.Models;
using SchoolManagementMVC.ViewModels;
namespace SchoolManagementMVC.Services
{
    public interface ISchoolService
    {
         List<School> GetListSchools();
        void AddSchool(School school);
        School GetSingleSchoolById(int id);
        void UpdateSchool(School newSchool);
        void DeleteSchool(int id);
        List<Teacher> GetTeachersBySchoolId(int schoolId);
        SchoolViewModel SchoolDeletionConfirmation(int id);
        SchoolViewModel SchoolDetails(int id);
    }
}