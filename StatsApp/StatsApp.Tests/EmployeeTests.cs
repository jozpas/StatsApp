namespace StatsApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void CheckMax()
        {

            var employee = new Employee("Kuba", "Bekas", 22);
            employee.AddScore(5);
            employee.AddScore(6);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(6, statistics.Max);

        }

        [Test]
        public void CheckMin()
        {

            var employee = new Employee("Kuba", "Bekas", 22);
            employee.AddScore(5);
            employee.AddScore(-5);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(-5, statistics.Min);

        }

        [Test]
        public void CheckAverage()
        {

            var employee = new Employee("Kuba", "Bekas", 22);
            employee.AddScore(10);
            employee.AddScore(5);

           var statistics = employee.GetStatistics();

            Assert.AreEqual(7.5, statistics.Average);
        }
    }
}