using App1.Models;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Assistant assistant = new();



            Employee em1 = new Employee("Tarlan", 250)
            {
                IsSuccessfull = true   
            };
            Console.WriteLine("İshchinin evvelki maashı");
            Console.WriteLine($"Name: {em1.Name}\nSalary: {em1.Salary}");
            assistant.GetFeedBack(em1);
            Console.WriteLine("İshchinin sonrakı maashı");
            Console.WriteLine($"Name: {em1.Name}\nSalary: {em1.Salary}");
        }
    }
}