using Crm;

ClientService clientService = new();
CreateClient();
OrderService orderService = new();
CreateOrder();

void CreateClient()
{
    string firstName = Console.ReadLine();
    string lastName = Console.ReadLine();
    string middleName = Console.ReadLine();
    short age = short.Parse(Console.ReadLine());
    string passportNumber = Console.ReadLine();
    string gender = Console.ReadLine();

    Client newClient = clientService.CreateClient(new ClientInfo() {
        FirstName = firstName,
        LastName = lastName,
        MiddleName = middleName,
        Age = age,
        PassportNumber = passportNumber,
        Gender = gender
    });

    Console.WriteLine("Name: {0} {1} {2}", firstName, middleName, lastName);
    Console.WriteLine("Age: {0}", age);
    Console.WriteLine("Passport Number: {0}", passportNumber);
    Console.WriteLine("Gender: {0}", gender);
}

void CreateOrder()
{
    string name = Console.ReadLine();
    string color = Console.ReadLine();
    string id = Console.ReadLine();
    short price = short.Parse(Console.ReadLine());

    Order newOrder = orderService.CreateOrder(new OrderInfo() {
        Name = name,
        Color = color,
        ID = id,
        Price = price
    });

    Console.WriteLine("Name: {0}", name);
    Console.WriteLine("Color: {0}", color);
    Console.WriteLine("ID: {0}", id);
    Console.WriteLine("Price: {0}", price);
}