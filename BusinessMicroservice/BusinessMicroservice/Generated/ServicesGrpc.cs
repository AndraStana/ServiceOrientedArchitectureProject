// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Services.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace BusinessMicroservice {
  public static partial class StudentsGrpcService
  {
    static readonly string __ServiceName = "StudentsGrpcService";

    static readonly grpc::Marshaller<global::BusinessMicroservice.GetStudentsRequest> __Marshaller_GetStudentsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BusinessMicroservice.GetStudentsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::BusinessMicroservice.GetStudentsResponse> __Marshaller_GetStudentsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BusinessMicroservice.GetStudentsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::BusinessMicroservice.GetStudentDetailsRequest> __Marshaller_GetStudentDetailsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BusinessMicroservice.GetStudentDetailsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::BusinessMicroservice.GetStudentDetailsResponse> __Marshaller_GetStudentDetailsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BusinessMicroservice.GetStudentDetailsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::BusinessMicroservice.DeleteStudentRequest> __Marshaller_DeleteStudentRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BusinessMicroservice.DeleteStudentRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::BusinessMicroservice.DeleteStudentResponse> __Marshaller_DeleteStudentResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BusinessMicroservice.DeleteStudentResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::BusinessMicroservice.GetStudentsRequest, global::BusinessMicroservice.GetStudentsResponse> __Method_GetStudents = new grpc::Method<global::BusinessMicroservice.GetStudentsRequest, global::BusinessMicroservice.GetStudentsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetStudents",
        __Marshaller_GetStudentsRequest,
        __Marshaller_GetStudentsResponse);

    static readonly grpc::Method<global::BusinessMicroservice.GetStudentDetailsRequest, global::BusinessMicroservice.GetStudentDetailsResponse> __Method_GetStudentDetails = new grpc::Method<global::BusinessMicroservice.GetStudentDetailsRequest, global::BusinessMicroservice.GetStudentDetailsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetStudentDetails",
        __Marshaller_GetStudentDetailsRequest,
        __Marshaller_GetStudentDetailsResponse);

    static readonly grpc::Method<global::BusinessMicroservice.DeleteStudentRequest, global::BusinessMicroservice.DeleteStudentResponse> __Method_DeleteStudent = new grpc::Method<global::BusinessMicroservice.DeleteStudentRequest, global::BusinessMicroservice.DeleteStudentResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteStudent",
        __Marshaller_DeleteStudentRequest,
        __Marshaller_DeleteStudentResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::BusinessMicroservice.ServicesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of StudentsGrpcService</summary>
    [grpc::BindServiceMethod(typeof(StudentsGrpcService), "BindService")]
    public abstract partial class StudentsGrpcServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::BusinessMicroservice.GetStudentsResponse> GetStudents(global::BusinessMicroservice.GetStudentsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::BusinessMicroservice.GetStudentDetailsResponse> GetStudentDetails(global::BusinessMicroservice.GetStudentDetailsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::BusinessMicroservice.DeleteStudentResponse> DeleteStudent(global::BusinessMicroservice.DeleteStudentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(StudentsGrpcServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetStudents, serviceImpl.GetStudents)
          .AddMethod(__Method_GetStudentDetails, serviceImpl.GetStudentDetails)
          .AddMethod(__Method_DeleteStudent, serviceImpl.DeleteStudent).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, StudentsGrpcServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetStudents, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BusinessMicroservice.GetStudentsRequest, global::BusinessMicroservice.GetStudentsResponse>(serviceImpl.GetStudents));
      serviceBinder.AddMethod(__Method_GetStudentDetails, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BusinessMicroservice.GetStudentDetailsRequest, global::BusinessMicroservice.GetStudentDetailsResponse>(serviceImpl.GetStudentDetails));
      serviceBinder.AddMethod(__Method_DeleteStudent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BusinessMicroservice.DeleteStudentRequest, global::BusinessMicroservice.DeleteStudentResponse>(serviceImpl.DeleteStudent));
    }

  }
  public static partial class GradesGrpcService
  {
    static readonly string __ServiceName = "GradesGrpcService";

    static readonly grpc::Marshaller<global::BusinessMicroservice.AddGradeRequest> __Marshaller_AddGradeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BusinessMicroservice.AddGradeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::BusinessMicroservice.AddGradeResponse> __Marshaller_AddGradeResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BusinessMicroservice.AddGradeResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::BusinessMicroservice.AddGradeRequest, global::BusinessMicroservice.AddGradeResponse> __Method_AddGrade = new grpc::Method<global::BusinessMicroservice.AddGradeRequest, global::BusinessMicroservice.AddGradeResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddGrade",
        __Marshaller_AddGradeRequest,
        __Marshaller_AddGradeResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::BusinessMicroservice.ServicesReflection.Descriptor.Services[1]; }
    }

    /// <summary>Base class for server-side implementations of GradesGrpcService</summary>
    [grpc::BindServiceMethod(typeof(GradesGrpcService), "BindService")]
    public abstract partial class GradesGrpcServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::BusinessMicroservice.AddGradeResponse> AddGrade(global::BusinessMicroservice.AddGradeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GradesGrpcServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddGrade, serviceImpl.AddGrade).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GradesGrpcServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddGrade, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BusinessMicroservice.AddGradeRequest, global::BusinessMicroservice.AddGradeResponse>(serviceImpl.AddGrade));
    }

  }
}
#endregion
