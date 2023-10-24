using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
{
    public class Student
    {
        [Required]
        public string StudentID{ get; set; }
        [Required]
        public string FullName{ get; set; }
//Tran Thi Kim Dung - 2021050135    
    }
}