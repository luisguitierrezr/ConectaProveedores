using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// File3
public class JSONEN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord : AbstractRESTStructure<EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Binary")]
[JsonPropertyName("Binary")]
public byte[] AttrBinary;

[JsonProperty("_BinaryURL")]
public string _BinaryURL;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

public JSONEN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord() { }

public JSONEN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord (EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
if (!config.IsRESTRequest && config.IncludeBinariesURL && s.ssId != 0) {
if((s.ssId != 0L)) {
_BinaryURL = BinaryContentUtils.GetDatabaseBinaryRestPath(AppInfo.GetAppInfo().eSpaceName, "6dONWMH_kUW9Ti9X5sMIKA*Vob4q9FhEk6C0S+mGlvUew", "Binary", s.ssId.ToString(), AppInfo.GetAppInfo().RequestContext.Session.UserId, s.ssBinary);
}

if (config.OptimizeBinaries) {
s.ssBinary = config.BinariesUsed.Contains("6dONWMH_kUW9Ti9X5sMIKA*XYoHDu6ZPk+jX1KYy_SLhA") ? s.ssBinary : new byte[] { };
}
}
AttrId = (long?) s.ssId;
AttrBinary = s.ssBinary;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
  } else {
if (!config.IsRESTRequest && config.IncludeBinariesURL && s.ssId != 0) {
if((s.ssId != 0L)) {
_BinaryURL = BinaryContentUtils.GetDatabaseBinaryRestPath(AppInfo.GetAppInfo().eSpaceName, "6dONWMH_kUW9Ti9X5sMIKA*Vob4q9FhEk6C0S+mGlvUew", "Binary", s.ssId.ToString(), AppInfo.GetAppInfo().RequestContext.Session.UserId, s.ssBinary);
}

if (config.OptimizeBinaries) {
s.ssBinary = config.BinariesUsed.Contains("6dONWMH_kUW9Ti9X5sMIKA*XYoHDu6ZPk+jX1KYy_SLhA") ? s.ssBinary : new byte[] { };
}
}
AttrId = (long?) s.ssId;
AttrBinary = s.ssBinary;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord, EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord s) => ToStructure(s, config);
}
public static EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord s = new EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssBinary = obj.AttrBinary == null ? new byte[] {} : obj.AttrBinary;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  }
  return s;
}

public static Func<EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord, ssConectaProveedores.RestRecords.JSONEN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord FromStructure(EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord(s, config);
}

}


