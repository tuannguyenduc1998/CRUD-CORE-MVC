using System.Collections.Generic;
using SchoolManagementMVC.Models;
namespace SchoolManagementMVC.ViewModels
{
    public class SchoolViewModel
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}