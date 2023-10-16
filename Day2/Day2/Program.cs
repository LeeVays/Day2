string myName = "Kamil";
string sex = "Male";
int myAge = 24;

if (sex == "Male"){
    if (myAge < 30)
    {
        Console.WriteLine(sex + ", " + "ponizej 30 lat");
    }
    else
    {
        Console.WriteLine(sex + ", " + "powyzej 30 lat");
    }
}
else{
    if (myAge < 30)
    {
        Console.WriteLine(myName + ", " + "ponizej 30 lat");
    }
    else
    {
        Console.WriteLine(myName + ", " + "powyzej 30 lat");
    }
}
    
Console.WriteLine(myName + ", " + "lat " + myAge);

if (myAge >= 18){
    if (sex == "Male") {
        Console.WriteLine("Pelnoletni mezczyna");
    }
    else {
        Console.WriteLine("Pelnoletnia kobieta");
    }
}
else{
    if (sex == "Male"){
        Console.WriteLine("Niepelnoletni mezczyna");
    }
    else{
        Console.WriteLine("Niepelnoletnia kobieta");
    }
}
