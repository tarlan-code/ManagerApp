﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    internal class Manager
    {

        protected Employee GetPromotion(Employee employee)
        {
            employee.Salary += 100;
            Console.WriteLine("\nMaaş artırıldı\n");
            return employee;
        }
    }
}
