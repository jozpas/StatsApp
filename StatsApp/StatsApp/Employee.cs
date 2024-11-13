
using System.Diagnostics;
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
            int valueInInt = (int)grade;
            //int valueInInt2 = (int)Math.Ceiling(grade);
            //int valueInInt3 = Math.Floor();
            //float f = valueInInt;

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Błędna ocena.");
                Console.WriteLine("Możliwa ocena w zekresie od 0 do 100");
            }
        }
        public void AddScore(double grade)
        {
            float gradeInFloat = (float)grade;
            this.grades.Add(gradeInFloat);
        }

        public void AddScore(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddScore(result);
            }
            else
            {
                Console.WriteLine("To nie jest cyfra");
            }
        }

        public void AddScore(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    Console.WriteLine("Błędna litera");
                    //  this.grades.Add(0);
                    break;

            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }

            // statistics.Average = statistics.Average / this.grades.Count;
            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
                
                

            return statistics;
        }
    }
}

