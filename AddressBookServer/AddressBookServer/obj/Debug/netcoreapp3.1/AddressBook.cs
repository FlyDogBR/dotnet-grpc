// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/addressBook.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AddressBookServer {

  /// <summary>Holder for reflection information generated from Protos/addressBook.proto</summary>
  public static partial class AddressBookReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/addressBook.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AddressBookReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhQcm90b3MvYWRkcmVzc0Jvb2sucHJvdG8SB2FkZHJlc3MaHmdvb2dsZS9w",
            "cm90b2J1Zi9kdXJhdGlvbi5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVz",
            "dGFtcC5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvIiAK",
            "EkFkZHJlc3NCb29rUmVxdWVzdBIKCgJpZBgBIAEoCSI2ChNBZGRyZXNzQm9v",
            "a1Jlc3BvbnNlEh8KBnBlb3BsZRgBIAMoCzIPLmFkZHJlc3MuUGVyc29uIs0E",
            "CgZQZXJzb24SDAoEbmFtZRgBIAEoCRIKCgJpZBgCIAEoBRINCgVlbWFpbBgD",
            "IAEoCRIrCgZwaG9uZXMYBCADKAsyGy5hZGRyZXNzLlBlcnNvbi5QaG9uZU51",
            "bWJlchIwCgxsYXN0X3VwZGF0ZWQYBSABKAsyGi5nb29nbGUucHJvdG9idWYu",
            "VGltZXN0YW1wEisKCGR1cmF0aW9uGAYgASgLMhkuZ29vZ2xlLnByb3RvYnVm",
            "LkR1cmF0aW9uEjgKEmRvdWJsZVRlc3ROdWxsVHlwZRgHIAEoCzIcLmdvb2ds",
            "ZS5wcm90b2J1Zi5Eb3VibGVWYWx1ZRI1ChBmbG9hVGVzdE51bGxUeXBlGAgg",
            "ASgLMhsuZ29vZ2xlLnByb3RvYnVmLkZsb2F0VmFsdWUSNgoRaW50MzJUZXN0",
            "TnVsbFR5cGUYCSABKAsyGy5nb29nbGUucHJvdG9idWYuSW50MzJWYWx1ZRI2",
            "ChFpbnQ2NFRlc3ROdWxsVHlwZRgKIAEoCzIbLmdvb2dsZS5wcm90b2J1Zi5J",
            "bnQ2NFZhbHVlEjgKEnN0cmluZ1Rlc3ROdWxsVHlwZRgLIAEoCzIcLmdvb2ds",
            "ZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZRpGCgtQaG9uZU51bWJlchIOCgZudW1i",
            "ZXIYASABKAkSJwoEdHlwZRgCIAEoDjIZLmFkZHJlc3MuUGVyc29uLlBob25l",
            "VHlwZSIrCglQaG9uZVR5cGUSCgoGTU9CSUxFEAASCAoESE9NRRABEggKBFdP",
            "UksQAjJLCgdBZGRyZXNzEkAKA0dldBIbLmFkZHJlc3MuQWRkcmVzc0Jvb2tS",
            "ZXF1ZXN0GhwuYWRkcmVzcy5BZGRyZXNzQm9va1Jlc3BvbnNlQhSqAhFBZGRy",
            "ZXNzQm9va1NlcnZlcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AddressBookServer.AddressBookRequest), global::AddressBookServer.AddressBookRequest.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AddressBookServer.AddressBookResponse), global::AddressBookServer.AddressBookResponse.Parser, new[]{ "People" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AddressBookServer.Person), global::AddressBookServer.Person.Parser, new[]{ "Name", "Id", "Email", "Phones", "LastUpdated", "Duration", "DoubleTestNullType", "FloaTestNullType", "Int32TestNullType", "Int64TestNullType", "StringTestNullType" }, null, new[]{ typeof(global::AddressBookServer.Person.Types.PhoneType) }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::AddressBookServer.Person.Types.PhoneNumber), global::AddressBookServer.Person.Types.PhoneNumber.Parser, new[]{ "Number", "Type" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AddressBookRequest : pb::IMessage<AddressBookRequest> {
    private static readonly pb::MessageParser<AddressBookRequest> _parser = new pb::MessageParser<AddressBookRequest>(() => new AddressBookRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddressBookRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AddressBookServer.AddressBookReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBookRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBookRequest(AddressBookRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBookRequest Clone() {
      return new AddressBookRequest(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddressBookRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddressBookRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddressBookRequest other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class AddressBookResponse : pb::IMessage<AddressBookResponse> {
    private static readonly pb::MessageParser<AddressBookResponse> _parser = new pb::MessageParser<AddressBookResponse>(() => new AddressBookResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddressBookResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AddressBookServer.AddressBookReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBookResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBookResponse(AddressBookResponse other) : this() {
      people_ = other.people_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBookResponse Clone() {
      return new AddressBookResponse(this);
    }

    /// <summary>Field number for the "people" field.</summary>
    public const int PeopleFieldNumber = 1;
    private static readonly pb::FieldCodec<global::AddressBookServer.Person> _repeated_people_codec
        = pb::FieldCodec.ForMessage(10, global::AddressBookServer.Person.Parser);
    private readonly pbc::RepeatedField<global::AddressBookServer.Person> people_ = new pbc::RepeatedField<global::AddressBookServer.Person>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::AddressBookServer.Person> People {
      get { return people_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddressBookResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddressBookResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!people_.Equals(other.people_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= people_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      people_.WriteTo(output, _repeated_people_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += people_.CalculateSize(_repeated_people_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddressBookResponse other) {
      if (other == null) {
        return;
      }
      people_.Add(other.people_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            people_.AddEntriesFrom(input, _repeated_people_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Person : pb::IMessage<Person> {
    private static readonly pb::MessageParser<Person> _parser = new pb::MessageParser<Person>(() => new Person());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Person> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AddressBookServer.AddressBookReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person(Person other) : this() {
      name_ = other.name_;
      id_ = other.id_;
      email_ = other.email_;
      phones_ = other.phones_.Clone();
      lastUpdated_ = other.lastUpdated_ != null ? other.lastUpdated_.Clone() : null;
      duration_ = other.duration_ != null ? other.duration_.Clone() : null;
      DoubleTestNullType = other.DoubleTestNullType;
      FloaTestNullType = other.FloaTestNullType;
      Int32TestNullType = other.Int32TestNullType;
      Int64TestNullType = other.Int64TestNullType;
      StringTestNullType = other.StringTestNullType;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person Clone() {
      return new Person(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 3;
    private string email_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Email {
      get { return email_; }
      set {
        email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "phones" field.</summary>
    public const int PhonesFieldNumber = 4;
    private static readonly pb::FieldCodec<global::AddressBookServer.Person.Types.PhoneNumber> _repeated_phones_codec
        = pb::FieldCodec.ForMessage(34, global::AddressBookServer.Person.Types.PhoneNumber.Parser);
    private readonly pbc::RepeatedField<global::AddressBookServer.Person.Types.PhoneNumber> phones_ = new pbc::RepeatedField<global::AddressBookServer.Person.Types.PhoneNumber>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::AddressBookServer.Person.Types.PhoneNumber> Phones {
      get { return phones_; }
    }

    /// <summary>Field number for the "last_updated" field.</summary>
    public const int LastUpdatedFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp lastUpdated_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp LastUpdated {
      get { return lastUpdated_; }
      set {
        lastUpdated_ = value;
      }
    }

    /// <summary>Field number for the "duration" field.</summary>
    public const int DurationFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Duration duration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration Duration {
      get { return duration_; }
      set {
        duration_ = value;
      }
    }

    /// <summary>Field number for the "doubleTestNullType" field.</summary>
    public const int DoubleTestNullTypeFieldNumber = 7;
    private static readonly pb::FieldCodec<double?> _single_doubleTestNullType_codec = pb::FieldCodec.ForStructWrapper<double>(58);
    private double? doubleTestNullType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double? DoubleTestNullType {
      get { return doubleTestNullType_; }
      set {
        doubleTestNullType_ = value;
      }
    }


    /// <summary>Field number for the "floaTestNullType" field.</summary>
    public const int FloaTestNullTypeFieldNumber = 8;
    private static readonly pb::FieldCodec<float?> _single_floaTestNullType_codec = pb::FieldCodec.ForStructWrapper<float>(66);
    private float? floaTestNullType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float? FloaTestNullType {
      get { return floaTestNullType_; }
      set {
        floaTestNullType_ = value;
      }
    }


    /// <summary>Field number for the "int32TestNullType" field.</summary>
    public const int Int32TestNullTypeFieldNumber = 9;
    private static readonly pb::FieldCodec<int?> _single_int32TestNullType_codec = pb::FieldCodec.ForStructWrapper<int>(74);
    private int? int32TestNullType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int? Int32TestNullType {
      get { return int32TestNullType_; }
      set {
        int32TestNullType_ = value;
      }
    }


    /// <summary>Field number for the "int64TestNullType" field.</summary>
    public const int Int64TestNullTypeFieldNumber = 10;
    private static readonly pb::FieldCodec<long?> _single_int64TestNullType_codec = pb::FieldCodec.ForStructWrapper<long>(82);
    private long? int64TestNullType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Int64TestNullType {
      get { return int64TestNullType_; }
      set {
        int64TestNullType_ = value;
      }
    }


    /// <summary>Field number for the "stringTestNullType" field.</summary>
    public const int StringTestNullTypeFieldNumber = 11;
    private static readonly pb::FieldCodec<string> _single_stringTestNullType_codec = pb::FieldCodec.ForClassWrapper<string>(90);
    private string stringTestNullType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StringTestNullType {
      get { return stringTestNullType_; }
      set {
        stringTestNullType_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Person);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Person other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Id != other.Id) return false;
      if (Email != other.Email) return false;
      if(!phones_.Equals(other.phones_)) return false;
      if (!object.Equals(LastUpdated, other.LastUpdated)) return false;
      if (!object.Equals(Duration, other.Duration)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseNullableDoubleEqualityComparer.Equals(DoubleTestNullType, other.DoubleTestNullType)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer.Equals(FloaTestNullType, other.FloaTestNullType)) return false;
      if (Int32TestNullType != other.Int32TestNullType) return false;
      if (Int64TestNullType != other.Int64TestNullType) return false;
      if (StringTestNullType != other.StringTestNullType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      hash ^= phones_.GetHashCode();
      if (lastUpdated_ != null) hash ^= LastUpdated.GetHashCode();
      if (duration_ != null) hash ^= Duration.GetHashCode();
      if (doubleTestNullType_ != null) hash ^= pbc::ProtobufEqualityComparers.BitwiseNullableDoubleEqualityComparer.GetHashCode(DoubleTestNullType);
      if (floaTestNullType_ != null) hash ^= pbc::ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer.GetHashCode(FloaTestNullType);
      if (int32TestNullType_ != null) hash ^= Int32TestNullType.GetHashCode();
      if (int64TestNullType_ != null) hash ^= Int64TestNullType.GetHashCode();
      if (stringTestNullType_ != null) hash ^= StringTestNullType.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Id);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Email);
      }
      phones_.WriteTo(output, _repeated_phones_codec);
      if (lastUpdated_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(LastUpdated);
      }
      if (duration_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Duration);
      }
      if (doubleTestNullType_ != null) {
        _single_doubleTestNullType_codec.WriteTagAndValue(output, DoubleTestNullType);
      }
      if (floaTestNullType_ != null) {
        _single_floaTestNullType_codec.WriteTagAndValue(output, FloaTestNullType);
      }
      if (int32TestNullType_ != null) {
        _single_int32TestNullType_codec.WriteTagAndValue(output, Int32TestNullType);
      }
      if (int64TestNullType_ != null) {
        _single_int64TestNullType_codec.WriteTagAndValue(output, Int64TestNullType);
      }
      if (stringTestNullType_ != null) {
        _single_stringTestNullType_codec.WriteTagAndValue(output, StringTestNullType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      size += phones_.CalculateSize(_repeated_phones_codec);
      if (lastUpdated_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LastUpdated);
      }
      if (duration_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Duration);
      }
      if (doubleTestNullType_ != null) {
        size += _single_doubleTestNullType_codec.CalculateSizeWithTag(DoubleTestNullType);
      }
      if (floaTestNullType_ != null) {
        size += _single_floaTestNullType_codec.CalculateSizeWithTag(FloaTestNullType);
      }
      if (int32TestNullType_ != null) {
        size += _single_int32TestNullType_codec.CalculateSizeWithTag(Int32TestNullType);
      }
      if (int64TestNullType_ != null) {
        size += _single_int64TestNullType_codec.CalculateSizeWithTag(Int64TestNullType);
      }
      if (stringTestNullType_ != null) {
        size += _single_stringTestNullType_codec.CalculateSizeWithTag(StringTestNullType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Person other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      phones_.Add(other.phones_);
      if (other.lastUpdated_ != null) {
        if (lastUpdated_ == null) {
          LastUpdated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        LastUpdated.MergeFrom(other.LastUpdated);
      }
      if (other.duration_ != null) {
        if (duration_ == null) {
          Duration = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        Duration.MergeFrom(other.Duration);
      }
      if (other.doubleTestNullType_ != null) {
        if (doubleTestNullType_ == null || other.DoubleTestNullType != 0D) {
          DoubleTestNullType = other.DoubleTestNullType;
        }
      }
      if (other.floaTestNullType_ != null) {
        if (floaTestNullType_ == null || other.FloaTestNullType != 0F) {
          FloaTestNullType = other.FloaTestNullType;
        }
      }
      if (other.int32TestNullType_ != null) {
        if (int32TestNullType_ == null || other.Int32TestNullType != 0) {
          Int32TestNullType = other.Int32TestNullType;
        }
      }
      if (other.int64TestNullType_ != null) {
        if (int64TestNullType_ == null || other.Int64TestNullType != 0L) {
          Int64TestNullType = other.Int64TestNullType;
        }
      }
      if (other.stringTestNullType_ != null) {
        if (stringTestNullType_ == null || other.StringTestNullType != "") {
          StringTestNullType = other.StringTestNullType;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Id = input.ReadInt32();
            break;
          }
          case 26: {
            Email = input.ReadString();
            break;
          }
          case 34: {
            phones_.AddEntriesFrom(input, _repeated_phones_codec);
            break;
          }
          case 42: {
            if (lastUpdated_ == null) {
              LastUpdated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastUpdated);
            break;
          }
          case 50: {
            if (duration_ == null) {
              Duration = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(Duration);
            break;
          }
          case 58: {
            double? value = _single_doubleTestNullType_codec.Read(input);
            if (doubleTestNullType_ == null || value != 0D) {
              DoubleTestNullType = value;
            }
            break;
          }
          case 66: {
            float? value = _single_floaTestNullType_codec.Read(input);
            if (floaTestNullType_ == null || value != 0F) {
              FloaTestNullType = value;
            }
            break;
          }
          case 74: {
            int? value = _single_int32TestNullType_codec.Read(input);
            if (int32TestNullType_ == null || value != 0) {
              Int32TestNullType = value;
            }
            break;
          }
          case 82: {
            long? value = _single_int64TestNullType_codec.Read(input);
            if (int64TestNullType_ == null || value != 0L) {
              Int64TestNullType = value;
            }
            break;
          }
          case 90: {
            string value = _single_stringTestNullType_codec.Read(input);
            if (stringTestNullType_ == null || value != "") {
              StringTestNullType = value;
            }
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Person message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum PhoneType {
        [pbr::OriginalName("MOBILE")] Mobile = 0,
        [pbr::OriginalName("HOME")] Home = 1,
        [pbr::OriginalName("WORK")] Work = 2,
      }

      public sealed partial class PhoneNumber : pb::IMessage<PhoneNumber> {
        private static readonly pb::MessageParser<PhoneNumber> _parser = new pb::MessageParser<PhoneNumber>(() => new PhoneNumber());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<PhoneNumber> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::AddressBookServer.Person.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PhoneNumber() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PhoneNumber(PhoneNumber other) : this() {
          number_ = other.number_;
          type_ = other.type_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PhoneNumber Clone() {
          return new PhoneNumber(this);
        }

        /// <summary>Field number for the "number" field.</summary>
        public const int NumberFieldNumber = 1;
        private string number_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Number {
          get { return number_; }
          set {
            number_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 2;
        private global::AddressBookServer.Person.Types.PhoneType type_ = global::AddressBookServer.Person.Types.PhoneType.Mobile;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::AddressBookServer.Person.Types.PhoneType Type {
          get { return type_; }
          set {
            type_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as PhoneNumber);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(PhoneNumber other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Number != other.Number) return false;
          if (Type != other.Type) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Number.Length != 0) hash ^= Number.GetHashCode();
          if (Type != global::AddressBookServer.Person.Types.PhoneType.Mobile) hash ^= Type.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Number.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Number);
          }
          if (Type != global::AddressBookServer.Person.Types.PhoneType.Mobile) {
            output.WriteRawTag(16);
            output.WriteEnum((int) Type);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Number.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Number);
          }
          if (Type != global::AddressBookServer.Person.Types.PhoneType.Mobile) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(PhoneNumber other) {
          if (other == null) {
            return;
          }
          if (other.Number.Length != 0) {
            Number = other.Number;
          }
          if (other.Type != global::AddressBookServer.Person.Types.PhoneType.Mobile) {
            Type = other.Type;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                Number = input.ReadString();
                break;
              }
              case 16: {
                Type = (global::AddressBookServer.Person.Types.PhoneType) input.ReadEnum();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code