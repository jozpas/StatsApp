namespace StatsApp.Tests
{
    public class Tests
    {
        [Test]
        public void CheckResult()
        {

            var employee = new Employee("Kuba", "Bekas", 22);
            employee.AddScore(5);
            employee.AddScore(6);

            int result = employee.Result;

            Assert.AreEqual(11, result);

        }

        [Test]
        public void CheckResultWithNegativeNumber()
        {

            var employee = new Employee("Kuba", "Bekas", 22);
            employee.AddScore(5);
            employee.AddScore(-5);

            int result = employee.Result;

            Assert.AreEqual(0, result);

        }

        [Test]
        public void CheckResultWithTwoNegativeNumbers()
        {

            var employee = new Employee("Kuba", "Bekas", 22);
            employee.AddScore(-10);
            employee.AddScore(-5);

            int result = employee.Result;

            Assert.AreEqual(-15, result);
        }
    }
}