using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models{
    public class Employee:Person
    {
        public string EmployeeID { get; set; }
        public string Age { get; set; }
        public string FullName { get; internal set; }
    }
}
//Tran Thi Kim Dung - 2021050135