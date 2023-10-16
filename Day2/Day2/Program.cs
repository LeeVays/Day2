int number = 4566;
string numberIsString = number.ToString();
char[] letters = numberIsString.ToCharArray();
int[] digitCount = new int[10];

foreach (char letter in letters){
    if (char.IsDigit(letter)){
        int digit = int.Parse(letter.ToString());
        digitCount[digit]++; 
    }
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + " => " + digitCount[i]);
}