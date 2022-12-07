// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GrpcHelloWorldClient.Protos;

Console.WriteLine("Hello, World!");
using var channel = GrpcChannel.ForAddress("https://localhost:5001");
var client = new HelloService.HelloServiceClient(channel);
var reply = await client.SayHelloAsync(new HelloRequest { Name = "Hello Client" });
Console.WriteLine($"Greatings :{reply.Message} ");
Console.ReadKey();
