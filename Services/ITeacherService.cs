using System.Collections.Generic;
using SchoolManagementMVC.Models;
using SchoolManagementMVC.ViewModels;
namespace SchoolManagementMVC.Services
{
    public interface ITeacherService
    {
         List<Teacher> GetListTeachers();
        void AddTeacher(Teacher teacher);
        Teacher GetSingleTeacherById(int id);
        void UpdateTeacher(Teacher newTeacher);
        void DeleteTeacher(int id);
        List<Student> GetStudentsByTeacherId(int teacherId);
        TeacherViewModel TeacherDeletionConfirmation(int id);
        TeacherViewModel TeacherDetails(int id);
    }
}