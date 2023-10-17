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
            this.name=name;
            this.surrname = surrname;
            this.age = age;
        }
        public string name {  get; private set; }
        public string surrname { get; private set; }
        public int age { get; private set; }

        public int Result
        {
            get
            {
                return this.grade.Sum();
            }
        }

        public void addGrade(int grade)
        {
            this.grade.Add(grade);
        }
    }
}
