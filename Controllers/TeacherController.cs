using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementMVC.Models;
using SchoolManagementMVC.Services;
using Microsoft.AspNetCore.Authorization;

namespace CrudCoreMVC.Controllers
{
    [Authorize]
    public class TeacherController : Controller
    {
        private ITeacherService _teacherService;
        private ISchoolService _schoolService;
        public TeacherController(ITeacherService teacherService, ISchoolService schoolService)
        {
            _teacherService = teacherService;
            _schoolService = schoolService;

        }

        [AllowAnonymous]
        public IActionResult ListTeachers()
        {
            return View(_teacherService.GetListTeachers());
        }
        public IActionResult CreateTeacher()
        {
            ViewBag.Schools = _schoolService.GetListSchools();
            return View();
        }
        public IActionResult TeacherCreated(Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Something went wrong");
                ViewBag.Schools = _schoolService.GetListSchools();
                return View("CreateTeacher");
            }
            _teacherService.AddTeacher(teacher);
            return View();
        }
        public IActionResult EditTeacher(int id)
        {
            ViewBag.Schools = _schoolService.GetListSchools();
            return View(_teacherService.GetSingleTeacherById(id));
        }
        public IActionResult TeacherEdited(Teacher newTeacher)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Something went wrong");
                ViewBag.Schools = _schoolService.GetListSchools();
                return View("EditTeacher", newTeacher);
            }
            _teacherService.UpdateTeacher(newTeacher);
            return View();

        }

        public IActionResult DeleteTeacher(int id) => View(_teacherService.TeacherDeletionConfirmation(id));

        public IActionResult TeacherDeleted(int id)
        {
            _teacherService.DeleteTeacher(id);

            return View();
        }
        public IActionResult TeacherDetails(int id)
        {
            return View(_teacherService.TeacherDetails(id));
        }
    }
}