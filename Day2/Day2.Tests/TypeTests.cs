namespace Day2.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetUserReferenceShouldNotBeEqual()
        {
            var employee1 = GetUser("Adam", "nazw", 30);
            var employee2 = GetUser("Adam", "nazw", 30);

            Assert.That(employee2, Is.Not.EqualTo(employee1));

        }

        private Employee GetUser(string name, string surrname, int age)
        {
            return new Employee(name, surrname, age);
        }
        [Test]
        public void IntValueShouldBeTheSame()
        {
            var employee1 = new Employee("Jan", "Niezbędny", 37);
            var employee2 = new Employee("Patryk", "Turak", 37);


            Assert.That(employee2.Age, Is.EqualTo(employee1.Age));
        }
        [Test]
        public void StringValueShouldNotBeTheSame()
        {
            var employee1 = new Employee("Jan", "Niezbędny", 37);
            var employee2 = new Employee("Patryk", "Turak", 37);



            Assert.That(employee2.Surrname, Is.Not.EqualTo(employee1.Surrname));
        }

    }
}
