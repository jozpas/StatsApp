
using System.Diagnostics.CodeAnalysis;

namespace StatsApp
{
    public class Employee
    {

        private List<float> grades = new List<float>();

        public static string Company = "HAP";
        public Employee(string name, string lastname, int age)
        {
            this.Name = name;
            this.LastName = lastname;
            this.Age = age;

        }

        public Employee(string name, string lastname)
        {
            this.Name = name;
            this.LastName = lastname;
        }

        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }


        public void AddScore(float grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;
         //   statistics.Average /= this.grades.Count;

           



            return statistics;
        }


    }
}
