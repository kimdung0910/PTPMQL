using System.Diagnostics;
public class Program
{
    private static void Main(string[]args)
    {
        int a = 10;
        if(a<0)
        {
            System.Console.WriteLine("{0} là số nguyên âm", a);

        }else{
        if(a%2 ==0){
            System.Console.WriteLine("{0} là số nguyên chắn",a);

        }else{
            System.Console.WriteLine("{0} là số nguyên dương lẻ",a);
        }

        }
    }
}