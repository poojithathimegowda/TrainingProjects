public class PersonClass
{
    static void PersonClassMain(string[] args)
    {
        PersonClass personClass = new PersonClass("Murthy", "Ranjith", 33, 121212);

        var data = PersonClass.Pi;
        var data2 = personClass.Pireadonly;


        personClass.Age = 21;

        //personClass.Namereadonly = "Namereadonly";
        //personClass.Name = "adssad";

        var data3 = PersonClass.Pireadonlystatic;

    }

    public  const  double Pi = Math.PI;
    public static  readonly double Pireadonlystatic =1212121; // constuctor  value can be set  

    public readonly double Pireadonly = 12121;
    // Properties
    public readonly string Namereadonly;

    public  string Name { get; }
    public  int Age { get; set; }

    static PersonClass()
    {

        Pireadonlystatic = 22222;
    }


    // Constructor
    public PersonClass(string namereadonly, string name, int age, double pireadonly)
    {
        Namereadonly = namereadonly;
        Name = name;
        Age = age;
        Pireadonly = pireadonly;
       Namereadonly = namereadonly;
 
    }

    public PersonClass()
    {
    }

    // Method to display information about the person
    public void DisplayInfo()
    {
       
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
