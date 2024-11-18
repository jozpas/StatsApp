using StatsApp;
using System;
using System.Linq.Expressions;


Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("=======================================");
Console.WriteLine();
//Console.WriteLine("Podaj ocenę pracownika: ");

//var employee = new Employee("Józef", "Paszkiewicz", 34);
var employee = new Employee("Józef");

//try
//{
//    Employee emp = null;
//    var name = emp.LastName;
//}
//catch (Exception exc)
//{
//    Console.WriteLine(exc.Message);
//}
//finally
//{
//    Console.WriteLine("Finally her");
//}


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika lub wpisz 'q' aby wyjść z programu...");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    
    try
    {
        employee.AddScore(input);
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Wystąpił wyjątek. {exc.Message}");
    }
   
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Max dla {employee.Name} {employee.LastName} z firmy {Employee.Company} wynosi {statistics.Max}.");
Console.WriteLine($"Min dla {employee.Name} wynosi {statistics.Min}.");
Console.WriteLine($"Average dla {employee.Name} wynosi {statistics.Average:N2}.");
Console.WriteLine($"AverageLetter dla {employee.Name} wynosi '{statistics.AverageLetter}' .");
Console.WriteLine("===============================================");
Console.WriteLine("===============================================");
Console.WriteLine($"Input: {statistics.Average}");



