class Patient
{
    public string? FirstName;
    public string? LastName;
    public string? Sex;
    public int Age;
    public string? Smoking;
    public Patient()
    {
        Console.WriteLine("Answer next questions.");
        Console.WriteLine("What is your name?");
        FirstName = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        LastName = Console.ReadLine();
        Console.WriteLine("What is your sex?");
        Sex = Console.ReadLine();
        Console.WriteLine("What is your age?");
        Age = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Are you smoking? Enter yes or no.");
        Smoking = Console.ReadLine();

    }
    public void PrintAll()
    {
        Console.Write($"Patient: {FirstName}, {LastName}, {Sex}, {Age}.");
        if (Smoking == "yes") Console.Write(" Smoking.");
        else Console.Write(" No Smoking.");
    }
}
