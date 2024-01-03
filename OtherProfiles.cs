using System;

public class OtherProfiles
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Occupation { get; set; }
    public string City { get; set; }

    public OtherProfiles(string name, int age, string gender, string occupation, string city)
    {
        Name = name;
        Age = age;
        Gender = gender;
        Occupation = occupation;
        City = city;
    }
    public void PrintOtherProfiles()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}, Occupation: {Occupation}, City: {City},");
    }
}
