# dotnet-grpc
The goal of this project is test GRPC in .Net 3.1 and how put in clean architecture.

gRPC with .NET Core 3.1
https://medium.com/@nickfane/grpc-with-net-core-3-1-24a4f6d155c4

github
https://github.com/NickFane/grpc-netcore/tree/master/01_simple-client-server/ShopperProfileServer/Protos

Protocol Buffer Basics: C#
https://developers.google.com/protocol-buffers/docs/csharptutorial

Language Guide (proto3)
https://developers.google.com/protocol-buffers/docs/proto3

Implementing Microservices with gRPC and .NET Core 3.1
https://auth0.com/blog/implementing-microservices-grpc-dotnet-core-3/

Basics Tutorial
https://www.grpc.io/docs/languages/csharp/basics/

Protobuf scalar data types
https://docs.microsoft.com/pt-br/dotnet/architecture/grpc-for-wcf-developers/protobuf-data-types


-> Create a new grpc server

dotnet new grpc -o ShopperProfileServer
cd ./ShopperProfileServer


-> Create a new grpc client

dotnet new console -o ShopperProfileClient
cd ./ShopperProfileClient

dotnet add ShopperProfileClient.csproj package Grpc.Net.Client 
dotnet add ShopperProfileClient.csproj package Google.Protobuf 
dotnet add ShopperProfileClient.csproj package Grpc.Tools


-> Create AddressBookServer and AddressBookClient.

...


Protobuf scalar data types
https://docs.microsoft.com/pt-br/dotnet/architecture/grpc-for-wcf-developers/protobuf-data-types

Nullable types
https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/wrappers.proto


