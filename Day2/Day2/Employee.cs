using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Employee
    {
        private List<int> grade = new List<int>();

        public Employee(string name, string surrname, int age)
        {
            this.Name=name;
            this.Surrname = surrname;
            this.Age = age;
        }
        public string Name {  get; private set; }
        public string Surrname { get; private set; }
        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return this.grade.Sum();
            }
        }

        public void AddGrade(int grade)
        {
            this.grade.Add(grade);
        }
    }
}
