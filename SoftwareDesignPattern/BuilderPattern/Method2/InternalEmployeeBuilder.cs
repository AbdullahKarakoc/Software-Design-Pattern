using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareDesignPattern.SoftwareDesignPattern.BuilderPattern.Method1;

namespace SoftwareDesignPattern.SoftwareDesignPattern.BuilderPattern.Method2
{
    public class InternalEmployeeBuilder : EmployeeBuilderM2
    {
        public override void SetEmailAddress(string emailAddress)
        {
            // abdullahkrkc1453@gmail.com
            var arr = emailAddress.Split('@');
            // endswith @company.com.tr

            Employee.EmailAddress = arr[0] + "@company.com.tr";
        }

        public override void SetFullName(string fullName)
        {
            var arr = fullName.Split(new[]{' ','_','.'});

            Employee.FirstName = arr[0];
            Employee.LastName = arr[1];
        }

        public override void SetUserName(string userName)
        {
            throw new NotImplementedException();
        }
    }
}