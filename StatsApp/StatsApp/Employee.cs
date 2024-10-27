
namespace StatsApp
{
    class Employee
    {

        private List<int> score = new List<int>();

        public static string Company = "HAP";
        public Employee(string name, string lastname, int age)
        {
            this.Name = name;
            this.LastName = lastname;
            this.Age = age;

        }

        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }

        public void theBestWorker()
        {
            
        }

    }
}
