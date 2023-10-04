using System;
using System.Security.AccessControl;
namespace NewApp.Models{
public class Person
{
    public int PersonID { get; set; }
    public string FullName { get; set; }

    public void NhapThongTin()
    {
        Console.WriteLine("ID: ");
        PersonID = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Full Name: ");
        FullName = Console.ReadLine();
    }
}
}