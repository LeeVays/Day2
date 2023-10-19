namespace Day2.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnCorrectRsult()
        {
            var employee = new Employee("Jan", "Niezbêdny", 37);
            employee.AddGrade(5);
            employee.AddGrade(2);
            employee.AddGrade(-5);
            employee.AddGrade(-1);
            var result = employee.Result;

            Assert.AreEqual(1, result); 
        }
    }
}