
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

            statistics.Average = statistics.Average / this.grades.Count;
            //   statistics.Average /= this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (int i = 0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average += this.grades[i];
            }
            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;
            while (index < this.grades.Count)
            {
                if (this.grades[index] == 5)
                {
                    break;
                }

                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            }
            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            } while (index < this.grades.Count);
            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }

    }
}
