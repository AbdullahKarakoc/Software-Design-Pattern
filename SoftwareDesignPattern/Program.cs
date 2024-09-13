using System.Text;
using BuilderPattern.Method1;
using SoftwareDesignPattern.SoftwareDesignPattern.BuilderPattern.Method1;
using SoftwareDesignPattern.SoftwareDesignPattern.BuilderPattern.Method2;
using SoftwareDesignPattern.SoftwareDesignPattern.DecoratorPattern.Computers;


//  BUILDER PATTERN

/*
var sb = new StringBuilder();

sb.Append("Abdullah").Append(" ").Append("Karakoç");
sb.Append(" Karakoç");

var fullname = sb.ToString();


var eb = new BuilderPattern.Method1.EndpointBuilder("https://localhost");

    eb
        .Append("api")
        .Append("v1")
        .Append("user")
        .AppendParam("id", "5")
        .AppendParam("username", "Abdullah");



var url = eb.Build();

//System.Console.WriteLine("Final Url: " + url);


var empBuilder = new EmployeeBuilderM1();

var employee = empBuilder
    .SetFullName("Abdullah Karakoç")
    .SetUserName("Akrkc66")
    .SetEmailAddress("abdullahkrkc1453@gmail.com")
    .BuildEmployee();

//System.Console.WriteLine("M1 Employee FirstName: "+ employee.FirstName);


var emp = GenerateEmployee("Abdullah Karakoç", "abdullahkrkc1453@gmail.com", 0);
System.Console.WriteLine("Email address: " + emp.EmailAddress);


IEmployeeBuilderM2 employeeBuilder = new InternalEmployeeBuilder();

employeeBuilder.SetEmailAddress("abdullahkrkc1453@gmail.com");
employeeBuilder.SetFullName("Abdullah Karakoç");

var emp = employeeBuilder.BuildEmployee();

System.Console.WriteLine("Email address: " + emp.EmailAddress);


EmployeeM2 GenerateEmployee(string fullName, string emailAddress, int empType)
{
    IEmployeeBuilderM2 employeeBuilder;
    if(empType == 0)
        employeeBuilder = new InternalEmployeeBuilder();
    else
        employeeBuilder = new ExternalEmployeeBuilder();

    employeeBuilder.SetFullName(fullName);
    employeeBuilder.SetEmailAddress(emailAddress);

    return employeeBuilder.BuildEmployee();
}   */





//   DECORATOR PATTERN


AppleLaptop al = new AppleLaptop();
al.CloseLid();

DellLaptop dl = new();
dl.CloseLid();
