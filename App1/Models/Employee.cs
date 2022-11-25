using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    internal class Employee
    {
        string _name;
        float _salary;
        public bool IsSuccessfull;


        public string Name{
            get => _name;
            set
            {
                value = value.Trim();

                if (value.Length>=1 && value.Length<30)
                {
                    _name = value;
                }

                else
                {
                    _name = "Wrong Input!";
                }
            } 
        }


        public float Salary {
            get => _salary;
            set
            {
                if (value>=250)
                {
                    _salary = value;
                }

                else
                {
                    _salary = 250;
                }

            } 
        }


       

        public Employee(string name, float salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
