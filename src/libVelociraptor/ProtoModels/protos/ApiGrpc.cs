// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/api.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Proto {
  public static partial class API
  {
    static readonly string __ServiceName = "proto.API";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Proto.VQLCollectorArgs> __Marshaller_proto_VQLCollectorArgs = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Proto.VQLCollectorArgs.Parser));
    static readonly grpc::Marshaller<global::Proto.VQLResponse> __Marshaller_proto_VQLResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Proto.VQLResponse.Parser));
    static readonly grpc::Marshaller<global::Proto.VFSFileBuffer> __Marshaller_proto_VFSFileBuffer = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Proto.VFSFileBuffer.Parser));
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));

    static readonly grpc::Method<global::Proto.VQLCollectorArgs, global::Proto.VQLResponse> __Method_Query = new grpc::Method<global::Proto.VQLCollectorArgs, global::Proto.VQLResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "Query",
        __Marshaller_proto_VQLCollectorArgs,
        __Marshaller_proto_VQLResponse);

    static readonly grpc::Method<global::Proto.VFSFileBuffer, global::Proto.VFSFileBuffer> __Method_VFSGetBuffer = new grpc::Method<global::Proto.VFSFileBuffer, global::Proto.VFSFileBuffer>(
        grpc::MethodType.Unary,
        __ServiceName,
        "VFSGetBuffer",
        __Marshaller_proto_VFSFileBuffer,
        __Marshaller_proto_VFSFileBuffer);

    static readonly grpc::Method<global::Proto.VQLResponse, global::Google.Protobuf.WellKnownTypes.Empty> __Method_WriteEvent = new grpc::Method<global::Proto.VQLResponse, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "WriteEvent",
        __Marshaller_proto_VQLResponse,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Proto.ApiReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of API</summary>
    [grpc::BindServiceMethod(typeof(API), "BindService")]
    public abstract partial class APIBase
    {
      public virtual global::System.Threading.Tasks.Task Query(global::Proto.VQLCollectorArgs request, grpc::IServerStreamWriter<global::Proto.VQLResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Proto.VFSFileBuffer> VFSGetBuffer(global::Proto.VFSFileBuffer request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> WriteEvent(global::Proto.VQLResponse request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for API</summary>
    public partial class APIClient : grpc::ClientBase<APIClient>
    {
      /// <summary>Creates a new client for API</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public APIClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for API that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public APIClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected APIClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected APIClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::Proto.VQLResponse> Query(global::Proto.VQLCollectorArgs request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Query(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Proto.VQLResponse> Query(global::Proto.VQLCollectorArgs request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_Query, null, options, request);
      }
      public virtual global::Proto.VFSFileBuffer VFSGetBuffer(global::Proto.VFSFileBuffer request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return VFSGetBuffer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Proto.VFSFileBuffer VFSGetBuffer(global::Proto.VFSFileBuffer request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_VFSGetBuffer, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Proto.VFSFileBuffer> VFSGetBufferAsync(global::Proto.VFSFileBuffer request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return VFSGetBufferAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Proto.VFSFileBuffer> VFSGetBufferAsync(global::Proto.VFSFileBuffer request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_VFSGetBuffer, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty WriteEvent(global::Proto.VQLResponse request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return WriteEvent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty WriteEvent(global::Proto.VQLResponse request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_WriteEvent, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> WriteEventAsync(global::Proto.VQLResponse request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return WriteEventAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> WriteEventAsync(global::Proto.VQLResponse request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_WriteEvent, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override APIClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new APIClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(APIBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Query, serviceImpl.Query)
          .AddMethod(__Method_VFSGetBuffer, serviceImpl.VFSGetBuffer)
          .AddMethod(__Method_WriteEvent, serviceImpl.WriteEvent).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, APIBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Query, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Proto.VQLCollectorArgs, global::Proto.VQLResponse>(serviceImpl.Query));
      serviceBinder.AddMethod(__Method_VFSGetBuffer, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Proto.VFSFileBuffer, global::Proto.VFSFileBuffer>(serviceImpl.VFSGetBuffer));
      serviceBinder.AddMethod(__Method_WriteEvent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Proto.VQLResponse, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.WriteEvent));
    }

  }
}
#endregion
