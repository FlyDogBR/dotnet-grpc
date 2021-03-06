// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/shopper-profile.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ShopperProfileServer {
  public static partial class ShopperProfile
  {
    static readonly string __ServiceName = "profile.ShopperProfile";

    static readonly grpc::Marshaller<global::ShopperProfileServer.ShopperProfileRequest> __Marshaller_profile_ShopperProfileRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ShopperProfileServer.ShopperProfileRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ShopperProfileServer.ShopperProfileResponse> __Marshaller_profile_ShopperProfileResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ShopperProfileServer.ShopperProfileResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::ShopperProfileServer.ShopperProfileRequest, global::ShopperProfileServer.ShopperProfileResponse> __Method_GetShopperProfile = new grpc::Method<global::ShopperProfileServer.ShopperProfileRequest, global::ShopperProfileServer.ShopperProfileResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetShopperProfile",
        __Marshaller_profile_ShopperProfileRequest,
        __Marshaller_profile_ShopperProfileResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ShopperProfileServer.ShopperProfileReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ShopperProfile</summary>
    [grpc::BindServiceMethod(typeof(ShopperProfile), "BindService")]
    public abstract partial class ShopperProfileBase
    {
      public virtual global::System.Threading.Tasks.Task<global::ShopperProfileServer.ShopperProfileResponse> GetShopperProfile(global::ShopperProfileServer.ShopperProfileRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ShopperProfileBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetShopperProfile, serviceImpl.GetShopperProfile).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ShopperProfileBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetShopperProfile, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ShopperProfileServer.ShopperProfileRequest, global::ShopperProfileServer.ShopperProfileResponse>(serviceImpl.GetShopperProfile));
    }

  }
}
#endregion
