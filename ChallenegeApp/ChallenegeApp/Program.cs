﻿string name = "Maria";
bool gender = false;
int age = 28;
if (age < 30 && gender == false)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age == 30 && name == "Ewa" && gender == false)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age < 18 && gender == true)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Żaden warunek nie jest spelniony");
}
