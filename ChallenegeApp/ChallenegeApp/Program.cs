int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();
string[] decNumber = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
int[] countTab = new int[10];

foreach (char leter in letters)
{
    if (leter == '0')
    {
        countTab[0]++;
    }
    else if (leter == '1')
    {
        countTab[1]++;
    }
    else if (leter == '2')
    {
        countTab[2]++;
    }
    else if (leter == '3')
    {
        countTab[3]++;
    }
    else if (leter == '4')
    {
        countTab[4]++;
    }
    else if (leter == '5')
    {
        countTab[5]++;
    }
    else if (leter == '6')
    {
        countTab[6]++;
    }
    else if (leter == '7')
    {
        countTab[7]++;
    }
    else if (leter == '8')
    {
        countTab[8]++;
    }
    else if (leter == '9')
    {
        countTab[9]++;
    }
}
Console.WriteLine("Wynik dla liczby: " + number);
for (int i = 0; i < 10; i++)
{
    string display = decNumber[i] + " => " + countTab[i];
    Console.WriteLine(display);
}