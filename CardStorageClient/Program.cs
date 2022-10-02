


using Grpc.Net.Client;
using static CardStorageServiceProtos.CardService;
using static CardStorageServiceProtos.ClientService;

AppContext.SetSwitch("System.Net.Http.SocketHttpHandler.Http2UnencryptedSupport", true);

//CardServiceClient
//ClientServiceClient

using var channel = GrpcChannel.ForAddress("http://localhost:5001");

ClientServiceClient clientService = new ClientServiceClient(channel);

var createClientResponse = clientService.Create(new CardStorageServiceProtos.CreateClientRequest
{
    FirstName = "Artem",
    SurName = "Khimin",
    Patronymic = "Pavlovich"
});

Console.WriteLine($"Client {createClientResponse.ClientId} created successfully.");

CardServiceClient cardService = new CardServiceClient(channel);

var getByClientIdResponse = cardService.GetByClientId(new CardStorageServiceProtos.GetByClientIdRequest
{
    ClientId = 1
});

Console.WriteLine("Cards:");
Console.WriteLine("======");

foreach (var card in getByClientIdResponse.Cards)
{
    Console.WriteLine($"{card.CardNo}; {card.Name}; {card.CVV2}; {card.ExpDate}");
}

Console.ReadKey();
