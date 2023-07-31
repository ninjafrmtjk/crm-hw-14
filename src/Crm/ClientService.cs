using Crm;

public sealed class ClientService
{
    private List<Client> clients;
    public ClientService()
    {
        clients = new List<Client>();
    }
    public Client CreateClient(
        string firstName,
        string lastName,
        string middleName,
        string phoneNumber,
        string email,
        string password,
        short age,
        string passportNumber,
        string gender
    )
    {
        Client newClient = new();
        clients.Add(newClient);
        return newClient;
    }   
}