 using System.ComponentModel.DataAnnotations;
 using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("Persons")]

    public class Person
    {
      [Key]
    public string PersonID { get; set; }
    
    public string FullName { get; set; }
  
    public string Address { get; set; }
    public int Age { get; set; }
    }
    }

//Tran Thi Kim Dung 2021050135