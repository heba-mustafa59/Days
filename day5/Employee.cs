using System;
using System.Collections.Generic;
namespace Delegates
{

    public class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int DepId { get; set; }

        public float Salary { get; set; }

        public override string ToString()
        {
            return $"Employee data: DepId = {DepId},Name: {Name}, Address: {Address},salary:{Salary}";
   
        }

    }
}
