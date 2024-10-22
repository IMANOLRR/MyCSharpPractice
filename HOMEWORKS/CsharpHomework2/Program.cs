using System;

Console.WriteLine("Bienvenido a mi lista de Contactes");

bool running = true;
List<int> ids = new List<int>();
Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> lastnames = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, string> telephones = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();

while (running)
{
    Console.WriteLine(@"1. Agregar Contacto     2. Ver Contactos    3. Buscar Contactos     4. Modificar Contacto   5. Eliminar Contacto    6. Salir");
    Console.WriteLine("Digite el número de la opción deseada");

    int typeOption = Convert.ToInt32(Console.ReadLine());

    switch (typeOption)
    {
        case 1:
            AddContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;
        case 2:
            ShowAllContacts(ids, names, lastnames, addresses, emails, ages, bestFriends);
            break;
        case 3:
            SearchOneContact(ids, names, lastnames, addresses, emails, ages);
            break;
        case 4:
            ModifyContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;
        case 5:
            DeleteContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;
        case 6:
            running = false;
            break;
        default:
            Console.WriteLine("Tu eres o te haces el idiota?");
            break;
    }
}

static void AddContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Digite el nombre de la persona");
    string name = Console.ReadLine();
    Console.WriteLine("Digite el apellido de la persona");
    string lastname = Console.ReadLine();
    Console.WriteLine("Digite la dirección");
    string address = Console.ReadLine();
    Console.WriteLine("Digite el teléfono de la persona");
    string phone = Console.ReadLine();
    Console.WriteLine("Digite el email de la persona");
    string email = Console.ReadLine();
    Console.WriteLine("Digite la edad de la persona");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Es mejor amigo? 1. Sí, 2. No");
    bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

    var id = ids.Count + 1;
    ids.Add(id);
    names.Add(id, name);
    lastnames.Add(id, lastname);
    addresses.Add(id, address);
    telephones.Add(id, phone);
    emails.Add(id, email);
    ages.Add(id, age);
    bestFriends.Add(id, isBestFriend);
}

static void ShowAllContacts(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    Console.WriteLine("++ Name \t Lastname \t Address \t Email \t Age \t Best Friend ++");
    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

    foreach (int id in ids)
    {
        string isBestFriendStr = bestFriends[id] ? "Sí" : "No";
        Console.WriteLine($"{names[id]} \t {lastnames[id]} \t {addresses[id]} \t {emails[id]} \t {ages[id]} \t {isBestFriendStr}");
    }
}

static void SearchOneContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> emails, Dictionary<int, int> ages)
{
    Console.WriteLine("Digite el ID del contacto a buscar:");
    int id = Convert.ToInt32(Console.ReadLine());

    if (ids.Contains(id))
    {
        Console.WriteLine($"{names[id]} \t {lastnames[id]} \t {addresses[id]} \t {emails[id]} \t {ages[id]}");
    }
    else
    {
        Console.WriteLine("No existe un contacto con este ID.");
    }
}

static void ModifyContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Digite el ID del contacto a modificar:");
    int id = Convert.ToInt32(Console.ReadLine());

    if (ids.Contains(id))
    {
        Console.WriteLine("Digite el nuevo nombre:");
        names[id] = Console.ReadLine();
        Console.WriteLine("Digite el nuevo apellido:");
        lastnames[id] = Console.ReadLine();
        Console.WriteLine("Digite la nueva dirección:");
        addresses[id] = Console.ReadLine();
        Console.WriteLine("Digite el nuevo teléfono:");
        telephones[id] = Console.ReadLine();
        Console.WriteLine("Digite el nuevo email:");
        emails[id] = Console.ReadLine();
        Console.WriteLine("Digite la nueva edad:");
        ages[id] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Es mejor amigo? 1. Sí, 2. No");
        bestFriends[id] = Convert.ToInt32(Console.ReadLine()) == 1;

        Console.WriteLine("Contacto modificado.");
    }
    else
    {
        Console.WriteLine("No existe un contacto con este ID.");
    }
}

static void DeleteContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Digite el ID del contacto a eliminar:");
    int id = Convert.ToInt32(Console.ReadLine());

    if (ids.Contains(id))
    {
        ids.Remove(id);
        names.Remove(id);
        lastnames.Remove(id);
        addresses.Remove(id);
        telephones.Remove(id);
        emails.Remove(id);
        ages.Remove(id);
        bestFriends.Remove(id);

        Console.WriteLine("Contacto eliminado.");
    }
    else
    {
        Console.WriteLine("No existe un contacto con este ID.");
    }
}
