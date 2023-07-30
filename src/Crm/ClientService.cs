using Crm;

public sealed class ClientService
{
    public Client CreateClient(ClientInfo clientInfo)
    {
        return new()
        {
            FirstName = clientInfo.FirstName,
            LastName = clientInfo.LastName,
            MiddleName = clientInfo.MiddleName,
            Age = clientInfo.Age,
            PassportNumber = clientInfo.PassportNumber,
            Gender = clientInfo.Gender
        };
    }   
}