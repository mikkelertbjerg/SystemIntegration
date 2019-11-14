// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Booking.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Faraday_BE_gRPC {
  public static partial class Booking
  {
    static readonly string __ServiceName = "Book.Booking";

    static readonly grpc::Marshaller<global::Faraday_BE_gRPC.EmptyRequest> __Marshaller_Book_EmptyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Faraday_BE_gRPC.EmptyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Faraday_BE_gRPC.LocationRequest> __Marshaller_Book_LocationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Faraday_BE_gRPC.LocationRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Faraday_BE_gRPC.BookingRequest> __Marshaller_Book_BookingRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Faraday_BE_gRPC.BookingRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Faraday_BE_gRPC.ComfirmReply> __Marshaller_Book_ComfirmReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Faraday_BE_gRPC.ComfirmReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Faraday_BE_gRPC.CustomerRequest> __Marshaller_Book_CustomerRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Faraday_BE_gRPC.CustomerRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Faraday_BE_gRPC.CarReply> __Marshaller_Book_CarReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Faraday_BE_gRPC.CarReply.Parser.ParseFrom);

    static readonly grpc::Method<global::Faraday_BE_gRPC.EmptyRequest, global::Faraday_BE_gRPC.LocationRequest> __Method_MakeNewBookingGRPC = new grpc::Method<global::Faraday_BE_gRPC.EmptyRequest, global::Faraday_BE_gRPC.LocationRequest>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "MakeNewBookingGRPC",
        __Marshaller_Book_EmptyRequest,
        __Marshaller_Book_LocationRequest);

    static readonly grpc::Method<global::Faraday_BE_gRPC.BookingRequest, global::Faraday_BE_gRPC.ComfirmReply> __Method_CreateCarBookingGRPC = new grpc::Method<global::Faraday_BE_gRPC.BookingRequest, global::Faraday_BE_gRPC.ComfirmReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateCarBookingGRPC",
        __Marshaller_Book_BookingRequest,
        __Marshaller_Book_ComfirmReply);

    static readonly grpc::Method<global::Faraday_BE_gRPC.CustomerRequest, global::Faraday_BE_gRPC.ComfirmReply> __Method_RegisterCustomerGRPC = new grpc::Method<global::Faraday_BE_gRPC.CustomerRequest, global::Faraday_BE_gRPC.ComfirmReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RegisterCustomerGRPC",
        __Marshaller_Book_CustomerRequest,
        __Marshaller_Book_ComfirmReply);

    static readonly grpc::Method<global::Faraday_BE_gRPC.LocationRequest, global::Faraday_BE_gRPC.CarReply> __Method_ShowAvailableCarsGRPC = new grpc::Method<global::Faraday_BE_gRPC.LocationRequest, global::Faraday_BE_gRPC.CarReply>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ShowAvailableCarsGRPC",
        __Marshaller_Book_LocationRequest,
        __Marshaller_Book_CarReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Faraday_BE_gRPC.BookingReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Booking</summary>
    [grpc::BindServiceMethod(typeof(Booking), "BindService")]
    public abstract partial class BookingBase
    {
      public virtual global::System.Threading.Tasks.Task MakeNewBookingGRPC(global::Faraday_BE_gRPC.EmptyRequest request, grpc::IServerStreamWriter<global::Faraday_BE_gRPC.LocationRequest> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Faraday_BE_gRPC.ComfirmReply> CreateCarBookingGRPC(global::Faraday_BE_gRPC.BookingRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Faraday_BE_gRPC.ComfirmReply> RegisterCustomerGRPC(global::Faraday_BE_gRPC.CustomerRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task ShowAvailableCarsGRPC(global::Faraday_BE_gRPC.LocationRequest request, grpc::IServerStreamWriter<global::Faraday_BE_gRPC.CarReply> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(BookingBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_MakeNewBookingGRPC, serviceImpl.MakeNewBookingGRPC)
          .AddMethod(__Method_CreateCarBookingGRPC, serviceImpl.CreateCarBookingGRPC)
          .AddMethod(__Method_RegisterCustomerGRPC, serviceImpl.RegisterCustomerGRPC)
          .AddMethod(__Method_ShowAvailableCarsGRPC, serviceImpl.ShowAvailableCarsGRPC).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BookingBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_MakeNewBookingGRPC, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Faraday_BE_gRPC.EmptyRequest, global::Faraday_BE_gRPC.LocationRequest>(serviceImpl.MakeNewBookingGRPC));
      serviceBinder.AddMethod(__Method_CreateCarBookingGRPC, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Faraday_BE_gRPC.BookingRequest, global::Faraday_BE_gRPC.ComfirmReply>(serviceImpl.CreateCarBookingGRPC));
      serviceBinder.AddMethod(__Method_RegisterCustomerGRPC, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Faraday_BE_gRPC.CustomerRequest, global::Faraday_BE_gRPC.ComfirmReply>(serviceImpl.RegisterCustomerGRPC));
      serviceBinder.AddMethod(__Method_ShowAvailableCarsGRPC, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Faraday_BE_gRPC.LocationRequest, global::Faraday_BE_gRPC.CarReply>(serviceImpl.ShowAvailableCarsGRPC));
    }

  }
}
#endregion