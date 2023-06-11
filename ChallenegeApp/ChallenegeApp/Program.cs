using ChallenegeApp;
Employee employee1 = new Employee("Adam", "Kowalski", 34);
Employee employee2 = new Employee("Monika", "Nowak", 25);
Employee employee3 = new Employee("Zuzia", "Wisniewska", 30);

employee1.AddScore(6);
employee1.AddScore(2);
employee1.AddScore(7);
employee1.AddScore(1);
employee1.AddScore(2);

employee2.AddScore(3);
employee2.AddScore(3);
employee2.AddScore(1);
employee2.AddScore(4);
employee2.AddScore(9);

employee3.AddScore(5);
employee3.AddScore(3);
employee3.AddScore(2);
employee3.AddScore(1);
employee3.AddScore(1);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = 0;
Employee userWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        userWithMaxResult = employee;
        maxResult = employee.Result;
    }  
}

Console.WriteLine("Dane pracownika z najwyższą liczbą punktów: ");
Console.WriteLine(userWithMaxResult.Name + " " + userWithMaxResult.LastName);
Console.WriteLine("Wiek: " + userWithMaxResult.Age);
Console.WriteLine("Punkty: " + userWithMaxResult.Result);

