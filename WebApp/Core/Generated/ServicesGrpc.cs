// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Services.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace BusinessMicroservice {
  public static partial class StudentsGrpService
  {
    static readonly string __ServiceName = "StudentsGrpService";

    static readonly grpc::Marshaller<global::BusinessMicroservice.GetStudentsRequest> __Marshaller_GetStudentsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BusinessMicroservice.GetStudentsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::BusinessMicroservice.GetStudentsResponse> __Marshaller_GetStudentsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BusinessMicroservice.GetStudentsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::BusinessMicroservice.GetStudentsRequest, global::BusinessMicroservice.GetStudentsResponse> __Method_GetStudents = new grpc::Method<global::BusinessMicroservice.GetStudentsRequest, global::BusinessMicroservice.GetStudentsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetStudents",
        __Marshaller_GetStudentsRequest,
        __Marshaller_GetStudentsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::BusinessMicroservice.ServicesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for StudentsGrpService</summary>
    public partial class StudentsGrpServiceClient : grpc::ClientBase<StudentsGrpServiceClient>
    {
      /// <summary>Creates a new client for StudentsGrpService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public StudentsGrpServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for StudentsGrpService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public StudentsGrpServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected StudentsGrpServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected StudentsGrpServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::BusinessMicroservice.GetStudentsResponse GetStudents(global::BusinessMicroservice.GetStudentsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStudents(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::BusinessMicroservice.GetStudentsResponse GetStudents(global::BusinessMicroservice.GetStudentsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetStudents, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::BusinessMicroservice.GetStudentsResponse> GetStudentsAsync(global::BusinessMicroservice.GetStudentsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStudentsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::BusinessMicroservice.GetStudentsResponse> GetStudentsAsync(global::BusinessMicroservice.GetStudentsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetStudents, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override StudentsGrpServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new StudentsGrpServiceClient(configuration);
      }
    }

  }
}
#endregion
