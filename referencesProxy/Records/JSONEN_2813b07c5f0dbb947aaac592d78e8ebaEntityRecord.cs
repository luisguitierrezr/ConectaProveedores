using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Storage
public class JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord : AbstractRESTStructure<EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Concept")]
[JsonPropertyName("Concept")]
public string AttrConcept;

[JsonProperty("InternalConceptId")]
[JsonPropertyName("InternalConceptId")]
public int? AttrInternalConceptId;

[JsonProperty("File")]
[JsonPropertyName("File")]
public byte[] AttrFile;

[JsonProperty("_FileURL")]
public string _FileURL;

[JsonProperty("Filename")]
[JsonPropertyName("Filename")]
public string AttrFilename;

[JsonProperty("Vendor")]
[JsonPropertyName("Vendor")]
public string AttrVendor;

[JsonProperty("Doc_Type")]
[JsonPropertyName("Doc_Type")]
public string AttrDoc_Type;

[JsonProperty("Object_type")]
[JsonPropertyName("Object_type")]
public string AttrObject_type;

[JsonProperty("IstoSendToExternal")]
[JsonPropertyName("IstoSendToExternal")]
public bool? AttrIstoSendToExternal;

[JsonProperty("WithEntegrationError")]
[JsonPropertyName("WithEntegrationError")]
public bool? AttrWithEntegrationError;

[JsonProperty("IsExternal")]
[JsonPropertyName("IsExternal")]
public bool? AttrIsExternal;

[JsonProperty("Archive_ID")]
[JsonPropertyName("Archive_ID")]
public string AttrArchive_ID;

[JsonProperty("Arc_Doc_ID")]
[JsonPropertyName("Arc_Doc_ID")]
public string AttrArc_Doc_ID;

[JsonProperty("Error_Message")]
[JsonPropertyName("Error_Message")]
public string AttrError_Message;

[JsonProperty("SentWhen")]
[JsonPropertyName("SentWhen")]
public String AttrSentWhen;

[JsonProperty("IsToDelete")]
[JsonPropertyName("IsToDelete")]
public bool? AttrIsToDelete;

[JsonProperty("IsToBig")]
[JsonPropertyName("IsToBig")]
public bool? AttrIsToBig;

[JsonProperty("Attempt")]
[JsonPropertyName("Attempt")]
public int? AttrAttempt;

[JsonProperty("Size")]
[JsonPropertyName("Size")]
public long? AttrSize;

[JsonProperty("CreateAt")]
[JsonPropertyName("CreateAt")]
public String AttrCreateAt;

public JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord() { }

public JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord (EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
if (!config.IsRESTRequest && config.IncludeBinariesURL && s.ssId != 0) {
if((s.ssId != 0L)) {
_FileURL = BinaryContentUtils.GetDatabaseBinaryRestPath(AppInfo.GetAppInfo().eSpaceName, "P1c8u+QdeUmxego1hLjHsw*iOWp8+lfQk2DH8eeqSEzJA", "File", s.ssId.ToString(), AppInfo.GetAppInfo().RequestContext.Session.UserId, s.ssFile);
}

if (config.OptimizeBinaries) {
s.ssFile = config.BinariesUsed.Contains("P1c8u+QdeUmxego1hLjHsw*nD4OLJ4HcEaVK80_2VnyGA") ? s.ssFile : new byte[] { };
}
}
AttrId = (long?) s.ssId;
AttrConcept = ConvertToRestWithoutDefaults(s.ssConcept, "");
AttrInternalConceptId = (int?) s.ssInternalConceptId;
AttrFile = ConvertToRestWithoutDefaults(s.ssFile);
AttrFilename = ConvertToRestWithoutDefaults(s.ssFilename, "");
AttrVendor = s.ssVendor;
AttrDoc_Type = ConvertToRestWithoutDefaults(s.ssDoc_Type, "");
AttrObject_type = ConvertToRestWithoutDefaults(s.ssObject_type, "");
AttrIstoSendToExternal = ConvertToRestWithoutDefaults(s.ssIstoSendToExternal, false);
AttrWithEntegrationError = ConvertToRestWithoutDefaults(s.ssWithEntegrationError, false);
AttrIsExternal = ConvertToRestWithoutDefaults(s.ssIsExternal, false);
AttrArchive_ID = ConvertToRestWithoutDefaults(s.ssArchive_ID, "");
AttrArc_Doc_ID = ConvertToRestWithoutDefaults(s.ssArc_Doc_ID, "");
AttrError_Message = ConvertToRestWithoutDefaults(s.ssError_Message, "");
AttrSentWhen = ConvertDateTimeToRestWithoutDefaults(s.ssSentWhen, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrIsToDelete = ConvertToRestWithoutDefaults(s.ssIsToDelete, false);
AttrIsToBig = ConvertToRestWithoutDefaults(s.ssIsToBig, false);
AttrAttempt = ConvertToRestWithoutDefaults(s.ssAttempt, 1);
AttrSize = ConvertToRestWithoutDefaults(s.ssSize, 0L);
AttrCreateAt = ConvertDateToRestWithoutDefaults(s.ssCreateAt, BuiltInFunction.CurrDate ());
  } else {
if (!config.IsRESTRequest && config.IncludeBinariesURL && s.ssId != 0) {
if((s.ssId != 0L)) {
_FileURL = BinaryContentUtils.GetDatabaseBinaryRestPath(AppInfo.GetAppInfo().eSpaceName, "P1c8u+QdeUmxego1hLjHsw*iOWp8+lfQk2DH8eeqSEzJA", "File", s.ssId.ToString(), AppInfo.GetAppInfo().RequestContext.Session.UserId, s.ssFile);
}

if (config.OptimizeBinaries) {
s.ssFile = config.BinariesUsed.Contains("P1c8u+QdeUmxego1hLjHsw*nD4OLJ4HcEaVK80_2VnyGA") ? s.ssFile : new byte[] { };
}
}
AttrId = (long?) s.ssId;
AttrConcept = s.ssConcept;
AttrInternalConceptId = (int?) s.ssInternalConceptId;
AttrFile = s.ssFile;
AttrFilename = s.ssFilename;
AttrVendor = s.ssVendor;
AttrDoc_Type = s.ssDoc_Type;
AttrObject_type = s.ssObject_type;
AttrIstoSendToExternal = (bool?) s.ssIstoSendToExternal;
AttrWithEntegrationError = (bool?) s.ssWithEntegrationError;
AttrIsExternal = (bool?) s.ssIsExternal;
AttrArchive_ID = s.ssArchive_ID;
AttrArc_Doc_ID = s.ssArc_Doc_ID;
AttrError_Message = s.ssError_Message;
AttrSentWhen = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssSentWhen, config.DateTimeFormat);
AttrIsToDelete = (bool?) s.ssIsToDelete;
AttrIsToBig = (bool?) s.ssIsToBig;
AttrAttempt = (int?) s.ssAttempt;
AttrSize = (long?) s.ssSize;
AttrCreateAt = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssCreateAt);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord, EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord s) => ToStructure(s, config);
}
public static EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord s = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssConcept = obj.AttrConcept == null ? "" : obj.AttrConcept;
  s.ssInternalConceptId = obj.AttrInternalConceptId == null ? 0 : obj.AttrInternalConceptId.Value;
  s.ssFile = obj.AttrFile == null ? new byte[] {} : obj.AttrFile;
  s.ssFilename = obj.AttrFilename == null ? "" : obj.AttrFilename;
  s.ssVendor = obj.AttrVendor == null ? "" : obj.AttrVendor;
  s.ssDoc_Type = obj.AttrDoc_Type == null ? "" : obj.AttrDoc_Type;
  s.ssObject_type = obj.AttrObject_type == null ? "" : obj.AttrObject_type;
  s.ssIstoSendToExternal = obj.AttrIstoSendToExternal == null ? false : obj.AttrIstoSendToExternal.Value;
  s.ssWithEntegrationError = obj.AttrWithEntegrationError == null ? false : obj.AttrWithEntegrationError.Value;
  s.ssIsExternal = obj.AttrIsExternal == null ? false : obj.AttrIsExternal.Value;
  s.ssArchive_ID = obj.AttrArchive_ID == null ? "" : obj.AttrArchive_ID;
  s.ssArc_Doc_ID = obj.AttrArc_Doc_ID == null ? "" : obj.AttrArc_Doc_ID;
  s.ssError_Message = obj.AttrError_Message == null ? "" : obj.AttrError_Message;
  s.ssSentWhen = obj.AttrSentWhen == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrSentWhen, config.DateTimeFormat);
  s.ssIsToDelete = obj.AttrIsToDelete == null ? false : obj.AttrIsToDelete.Value;
  s.ssIsToBig = obj.AttrIsToBig == null ? false : obj.AttrIsToBig.Value;
  s.ssAttempt = obj.AttrAttempt == null ? 1 : obj.AttrAttempt.Value;
  s.ssSize = obj.AttrSize == null ? 0L : obj.AttrSize.Value;
  s.ssCreateAt = obj.AttrCreateAt == null ? BuiltInFunction.CurrDate () : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrCreateAt);
  }
  return s;
}

public static Func<EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord FromStructure(EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(s, config);
}

}


