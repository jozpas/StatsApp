using StatsApp;
using System;
using System.Linq.Expressions;


Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("=======================================");
Console.WriteLine();
Console.WriteLine("Podaj ocenę pracownika: ");

var employee = new Employee("Józef", "Paszkiewicz", 34);

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddScore(input);
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Max dla {employee.Name} {employee.LastName} z firmy {Employee.Company} wynosi {statistics.Max}.");
Console.WriteLine($"Min dla {employee.Name} wynosi {statistics.Min}.");
Console.WriteLine($"Average dla {employee.Name} wynosi {statistics.Average:N2}.");
Console.WriteLine($"AverageLetter dla {employee.Name} wynosi '{statistics.AverageLetter}' .");
Console.WriteLine("===============================================");
Console.WriteLine("===============================================");
Console.WriteLine($"Input: {statistics.Average}");



