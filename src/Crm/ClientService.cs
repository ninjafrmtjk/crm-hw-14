using Crm;

public sealed class ClientService
{
    private List<Client> clients = new List<Client>();
    public Client CreateClient(ClientInfo clientInfo)
    {
        clients.Add(CreateClient(clientInfo));

        return new()
        {
            FirstName = clientInfo.FirstName,
            LastName = clientInfo.LastName,
            MiddleName = clientInfo.MiddleName,
            PhoneNumber = clientInfo.PhoneNumber,
            Email = clientInfo.Email,
            Password = clientInfo.Password,
            Age = clientInfo.Age,
            PassportNumber = clientInfo.PassportNumber,
            Gender = clientInfo.Gender
        };
    }

    
}