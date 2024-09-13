using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareDesignPattern.SoftwareDesignPattern.BuilderPattern.Method1
{
    public class EmployeeM2
    {
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string EmailAddress { get; set;}
        public string UserName { get; set;}


        public override string ToString()
        {
            return $"{FirstName} {LastName} ({UserName})";
        }

    }
}