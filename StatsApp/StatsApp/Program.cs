using StatsApp;
using System.Linq.Expressions;

var employee = new Employee("Józef", "Paszkiewicz", 34); 
employee.AddScore(2);
employee.AddScore(3);
employee.AddScore(13);
employee.AddScore(133);
employee.AddScore("15");
employee.AddScore("ADAM");
employee.AddScore(1.55);


var statistics = employee.GetStatistics();


Console.WriteLine($"Max dla {employee.Name} {employee.LastName} z firmy {Employee.Company} wynosi {statistics.Max}.");
Console.WriteLine($"Min dla {employee.Name} wynosi {statistics.Min}.");
Console.WriteLine($"Average dla {employee.Name} wynosi {statistics.Average:N2}.");
Console.WriteLine("===============================================");


