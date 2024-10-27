
using StatsApp;
using System.Diagnostics.Contracts;


Employee employee1 = new Employee("Józef", "Paszkiewicz", 34);
Employee employee2 = new Employee("Adam", "Kowalski", 23);
Employee employee3 = new Employee("Jan", "Nowak", 52);

var rand = new Random();
employee1.AddScore(rand.Next(1, 11));
employee1.AddScore(3);
employee1.AddScore(6);
employee1.AddScore(2);
employee1.AddScore(1);

employee2.AddScore(rand.Next(1, 11));
employee2.AddScore(3);
employee2.AddScore(6);
employee2.AddScore(2);
employee2.AddScore(1);

employee3.AddScore(rand.Next(1, 11));
employee3.AddScore(3);
employee3.AddScore(6);
employee3.AddScore(2);
employee3.AddScore(1);



var resultEmployee1 = employee1.Result;
var resultEmployee2 = employee2.Result;
var resultEmployee3 = employee3.Result;
Console.WriteLine(employee1.Name +" "+ employee1.LastName+": "+ resultEmployee1);
Console.WriteLine(employee2.Name +" "+ employee2.LastName+": "+ resultEmployee2);
Console.WriteLine(employee3.Name +" "+ employee3.LastName+": "+ resultEmployee3);

Console.WriteLine(Employee.Company);
//Console.WriteLine(employee1.score);



List <Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee bestEmployee = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        bestEmployee = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine("Najlepszy pracownik ma "+bestEmployee.Age + " lata i nazywa się "+ bestEmployee.Name +" "+bestEmployee.LastName);



