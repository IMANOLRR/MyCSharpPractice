using System;

public class Person
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public bool Married { get; set; }
    public string Id { get; private set; }
    public string Profession { get; private set; }

    public Person(string name, string lastname, int age, bool married, string id, string profession)
    {
        Name = name;
        LastName = lastname;
        Age = age;
        Married = married;
        Id = id;
        Profession = profession;
    }


    public void Action1()
    {
        switch (Profession)
        {
            case "Architect":
                Console.WriteLine($"{Name} {LastName} is designing a blueprint.");
                break;
            case "Developer":
                Console.WriteLine($"{Name} {LastName} is writing code.");
                break;
            case "Doctor":
                Console.WriteLine($"{Name} {LastName} is diagnosing a patient.");
                break;
            case "Assistant":
                Console.WriteLine($"{Name} {LastName} is organizing files.");
                break;
            case "Pilot":
                Console.WriteLine($"{Name} {LastName} is planning a flight route.");
                break;
            case "Teacher":
                Console.WriteLine($"{Name} {LastName} is grading assignments.");
                break;
            case "Engineer":
                Console.WriteLine($"{Name} {LastName} is creating a machine design.");
                break;
        }
    }

    public void Action2()
    {
        switch (Profession)
        {
            case "Architect":
                Console.WriteLine($"{Name} {LastName} is meeting with a client.");
                break;
            case "Developer":
                Console.WriteLine($"{Name} {LastName} is debugging a program.");
                break;
            case "Doctor":
                Console.WriteLine($"{Name} {LastName} is preparing for surgery.");
                break;
            case "Assistant":
                Console.WriteLine($"{Name} {LastName} is setting up a meeting.");
                break;
            case "Pilot":
                Console.WriteLine($"{Name} {LastName} is checking the weather conditions.");
                break;
            case "Teacher":
                Console.WriteLine($"{Name} {LastName} is preparing lesson plans.");
                break;
            case "Engineer":
                Console.WriteLine($"{Name} {LastName} is running simulations.");
                break;
        }
    }

    public void Action3()
    {
        switch (Profession)
        {
            case "Architect":
                Console.WriteLine($"{Name} {LastName} is reviewing project blueprints.");
                break;
            case "Developer":
                Console.WriteLine($"{Name} {LastName} is collaborating with team members.");
                break;
            case "Doctor":
                Console.WriteLine($"{Name} {LastName} is discussing treatment plans.");
                break;
            case "Assistant":
                Console.WriteLine($"{Name} {LastName} is managing schedules.");
                break;
            case "Pilot":
                Console.WriteLine($"{Name} {LastName} is checking fuel levels.");
                break;
            case "Teacher":
                Console.WriteLine($"{Name} {LastName} is delivering a lecture.");
                break;
            case "Engineer":
                Console.WriteLine($"{Name} {LastName} is overseeing production.");
                break;
        }
    }

    public static void Main(string[] args)
    {
        Person persona1 = new Person("Imanol", "Rodriguez", 18, false, "402-1226026-5", "Developer");
        persona1.Action1();
        persona1.Action2();
        persona1.Action3();

        Person persona2 = new Person("Juan", "Perez", 34, true, "123-4567890-1", "Engineer");
        persona2.Action1();
        persona2.Action2();
        persona2.Action3();

        Person persona3 = new Person("Sara", "Azul", 25, false, "402-1234567-5", "Architect");
        persona3.Action1();
        persona3.Action2();
        persona3.Action3();


        Person persona4 = new Person("Carlos", "Minaya", 69, true, "402-6206221-4", "Pilot");
        persona4.Action1();
        persona4.Action2();
        persona4.Action3();


        Person persona5 = new Person("Karla", "Rosario", 32, false, "543-2105924-6", "Doctor");
        persona5.Action1();
        persona5.Action2();
        persona5.Action3();


        Person persona6 = new Person("Marcos", "Vargas", 20, true, "402-0193749-5", "Assistant");
        persona6.Action1();
        persona6.Action2();
        persona6.Action3();


        Person persona7 = new Person("Starling", "Germosen", 30, true, "570-8074523-5", "Teacher");
        persona7.Action1();
        persona7.Action2();
        persona7.Action3();
    }

}











//public void Desing()
//{ 
//    if (Profesion == "Desing")
//    {
//        Console.WriteLine($"{Name} it's designing a plan");
//    }
//}

//public void Developer()
//{
//    if (Profesion == "S.Developer")
//    {
//        Console.WriteLine($"{Name} it's developing a program");
//    }
//}

//public void Singer()
//{
//    if (Profesion == "Singer")
//    {
//        Console.WriteLine($"{Name} it's singer");
//    }
//}

//public static void Main(string[] args)
//{
//    Person persona1 = new Person("Imanol", "Rodriguez", 18, false, "402-1226026-5", "S.Developer");
//    persona1.Developer();
//}







//public void PerfomeAction()
//{
//    switch (Profesion)
//    {
//        case "Architect":
//            Console.WriteLine($"{Name} {LastName}, {Age}, {Married}, {Id} is designing a plan");
//            break;
//        case "Developer":
//            Console.WriteLine($"{Name} {LastName}, {Age}, {Married}, {Id} is developing a software");
//            break;
//        case "Doctor":
//            Console.WriteLine($"{Name} {LastName}, {Age}, {Married}, {Id} is operating on a patient");
//            break;
//        case "Assistant":
//            Console.WriteLine($"{Name} {LastName}, {Age}, {Married}, {Id} is doing homework");
//            break;
//        case "Pilot":
//            Console.WriteLine($"{Name} {LastName}, {Age}, {Married}, {Id} is flying a plane");
//            break;
//        case "Teacher":
//            Console.WriteLine($"{Name} {LastName}, {Age}, {Married}, {Id} is teaching a class");
//            break;
//        case "Engineer":
//            Console.WriteLine($"{Name} {LastName}, {Age}, {Married}, {Id} is designing a machine");
//            break;

//    }
//}

//public static void Main( string[] args )
//{
//    Person persona1 = new Person("Imanol", "Rodriguez", 18, false, "402-1226026-5", "Developer");
//    persona1.PerfomeAction();
//    Person persona2 = new Person("Juan", "Perez", 34, true, "123-4567890-1", "Engineer");
//    persona2.PerfomeAction();
//    Person persona3 = new Person("Sara", "Azul", 25, false, "402-1234567-5", "Architect");
//    persona3.PerfomeAction();
//    Person persona4 = new Person("Carlos", "Minaya", 69, true, "402-6206221-4", "Pilot");
//    persona4.PerfomeAction();
//    Person persona5 = new Person("Karla", "Rosario", 32, false, "543-2105924-6", "Doctor");
//    persona5.PerfomeAction();
//    Person persona6 = new Person("Marcos", "Vargas", 20, true, "402-0193749-5", "Assistant");
//    persona6.PerfomeAction();
//    Person persona7 = new Person("Starling", "Germosen", 30, true, "570-8074523-5", "Teacher");
//    persona7.PerfomeAction();
//}