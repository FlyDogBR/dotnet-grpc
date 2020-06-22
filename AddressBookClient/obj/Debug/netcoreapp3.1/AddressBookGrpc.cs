// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/addressBook.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace AddressBookServer {
  public static partial class Address
  {
    static readonly string __ServiceName = "address.Address";

    static readonly grpc::Marshaller<global::AddressBookServer.AddressBookRequest> __Marshaller_address_AddressBookRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AddressBookServer.AddressBookRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::AddressBookServer.AddressBookResponse> __Marshaller_address_AddressBookResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AddressBookServer.AddressBookResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::AddressBookServer.AddressBookRequest, global::AddressBookServer.AddressBookResponse> __Method_Get = new grpc::Method<global::AddressBookServer.AddressBookRequest, global::AddressBookServer.AddressBookResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_address_AddressBookRequest,
        __Marshaller_address_AddressBookResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AddressBookServer.AddressBookReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Address</summary>
    public partial class AddressClient : grpc::ClientBase<AddressClient>
    {
      /// <summary>Creates a new client for Address</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AddressClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Address that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AddressClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AddressClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AddressClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::AddressBookServer.AddressBookResponse Get(global::AddressBookServer.AddressBookRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::AddressBookServer.AddressBookResponse Get(global::AddressBookServer.AddressBookRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::AddressBookServer.AddressBookResponse> GetAsync(global::AddressBookServer.AddressBookRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::AddressBookServer.AddressBookResponse> GetAsync(global::AddressBookServer.AddressBookRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AddressClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AddressClient(configuration);
      }
    }

  }
}
#endregion