﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    internal class Assistant:Manager
    {
        
        public void GetFeedBack(Employee employee)
        {
            if (employee.IsSuccessfull)
            {
                GetPromotion(employee);
            }

            else
            {
                Console.WriteLine("Ugurlu işçi deyil!");
            }
        }
    }
}
