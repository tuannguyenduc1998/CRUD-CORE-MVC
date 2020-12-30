using SchoolManagementMVC.Models;
using System.Collections.Generic;
using SchoolManagementMVC.ViewModels;
namespace SchoolManagementMVC.Services
{
    public interface IStudentService
    {
        List<Student> GetListStudents();
        void AddStudent(Student student);
        Student GetSingleStudentById(int id);
        void UpdateStudent(Student newStudent);
        void DeleteStudent(int id);
        StudentViewModel StudentDeletionConfirmation(int id); 
    }
}