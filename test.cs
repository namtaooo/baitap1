using System;

public class student
{
	private string name { get; set; };
	private int id { get; set; }
	private int age { get; set; }
	private int total { get; set; }

	public student(string Name, int Id, int Age,int Total)
	{
		name = Name;
		id = Id;
		age = Age;
		total = Total;
	}
	public getInfo()
	{
		Console.WriteLine(name);
        Console.WriteLine(id);
        Console.WriteLine(age);
        Console.WriteLine(total);

    }
}
