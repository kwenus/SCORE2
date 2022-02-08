class Patient
{
    public string? FirstName;
    public string? LastName;
    public string? Sex;
    public int Age;
    public Patient()
    {
        Console.WriteLine("Answer next questions.");
        Console.WriteLine("What is your name?");
        FirstName = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        LastName = Console.ReadLine();
        Console.WriteLine("What is your sex?");
        Sex = Console.ReadLine();
        Console.WriteLine("What is your age");
        Age = Convert.ToInt16(Console.ReadLine());
    }
    public void PrintAll() => Console.WriteLine($"Patient: {FirstName}, {LastName}");
}
