using Day2;
using System.ComponentModel.DataAnnotations;

Employee employee1 = new("Kamil", "Nowak", 21);
Employee employee2 = new("Pawel", "Przybysz", 34);
Employee employee3 = new("Jan", "Niezbędny", 37);

Random random = new Random();
for (int i = 0; i < 5; i++)
{
    int number1 = random.Next(1, 11);
    employee1.AddGrade(number1);
    int number2 = random.Next(1, 11);
    employee2.AddGrade(number2);
    int number3 = random.Next(1, 11);
    employee3.AddGrade(number3);
}
var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

Console.WriteLine("Wynik pierwszego pracownika "+result1);
Console.WriteLine("Wynik drugiego pracownika " +result2);
Console.WriteLine("Wynik trzeciego pracownika " +result3);

var winner1 = Math.Max(result1, result2);
var winner2 = Math.Max(winner1, result3);

if(winner2 ==result1)
{
    Console.WriteLine("najwyższy wynik to " + winner2+" i należy do "+employee1.Name+" "+employee1.Surrname+" wiek "+employee1.Age+" lat");
}else if(winner2 == result2)
{
    Console.WriteLine("najwyższy wynik to " + winner2 + " i należy do " + employee2.Name + " " + employee2.Surrname + " wiek " + employee2.Age + " lat");
}
else
{
    Console.WriteLine("najwyższy wynik to " + winner2 + " i należy do " + employee3.Name + " " + employee3.Surrname + " wiek " + employee3.Age + " lat");
}
