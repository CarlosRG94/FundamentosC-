// See https://aka.ms/new-console-template for more information
class MyClass
{
    static void Main(string[] args)
    {
        Person person = new Person("juan", 34);
        Doctor doctor1 = new Doctor("pepe", 37, "Dermatologo");
        Dev dev = new Dev("paco", 45, "C++");
        Console.WriteLine(dev.GetData());
        Console.WriteLine(doctor1.GetData());
        Console.WriteLine(person.GetInfo());
    }
}
class Person
{
    private string _name;
    private int _age;
    public Person(string name, int age)
    { 
        _age = age;
        _name = name;   
    }
    public string GetInfo() 
    {
        return _name + "  " + _age;
    }
}
class Doctor : Person {
    private string _especialidad;
    public Doctor(string name, int age, string especialidad):base(name, age)
    {
        _especialidad = especialidad;  

    }
    public string GetData()
    {
        return GetInfo()+" "+ _especialidad;
    }
}
class Dev : Person
{
    private string _language;
    public Dev(string name, int age, string language) : base(name, age)
    {
        _language = language;

    }
    public string GetData()
    {
        return GetInfo() + " " + _language;
    }
}

