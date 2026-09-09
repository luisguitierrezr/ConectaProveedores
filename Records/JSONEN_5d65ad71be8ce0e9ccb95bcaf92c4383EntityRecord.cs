using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedSelloDigital
public class JSONEN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord : AbstractRESTStructure<EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord> {
[JsonProperty("InvoiceId")]
[JsonPropertyName("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("SelloDigital")]
[JsonPropertyName("SelloDigital")]
public byte[] AttrSelloDigital;

[JsonProperty("_SelloDigitalURL")]
public string _SelloDigitalURL;

public JSONEN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord() { }

public JSONEN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord (EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
if (!config.IsRESTRequest && config.IncludeBinariesURL && s.ssInvoiceId != 0) {
if((s.ssInvoiceId != 0L)) {
_SelloDigitalURL = BinaryContentUtils.GetDatabaseBinaryRestPath(AppInfo.GetAppInfo().eSpaceName, "6dONWMH_kUW9Ti9X5sMIKA*gQwu73tQEE2ahCkNh0wWGQ", "SelloDigital", s.ssInvoiceId.ToString(), AppInfo.GetAppInfo().RequestContext.Session.UserId, s.ssSelloDigital);
}

if (config.OptimizeBinaries) {
s.ssSelloDigital = config.BinariesUsed.Contains("6dONWMH_kUW9Ti9X5sMIKA*1atyTF6eQ0CToXQEvXBEOg") ? s.ssSelloDigital : new byte[] { };
}
}
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrSelloDigital = ConvertToRestWithoutDefaults(s.ssSelloDigital);
  } else {
if (!config.IsRESTRequest && config.IncludeBinariesURL && s.ssInvoiceId != 0) {
if((s.ssInvoiceId != 0L)) {
_SelloDigitalURL = BinaryContentUtils.GetDatabaseBinaryRestPath(AppInfo.GetAppInfo().eSpaceName, "6dONWMH_kUW9Ti9X5sMIKA*gQwu73tQEE2ahCkNh0wWGQ", "SelloDigital", s.ssInvoiceId.ToString(), AppInfo.GetAppInfo().RequestContext.Session.UserId, s.ssSelloDigital);
}

if (config.OptimizeBinaries) {
s.ssSelloDigital = config.BinariesUsed.Contains("6dONWMH_kUW9Ti9X5sMIKA*1atyTF6eQ0CToXQEvXBEOg") ? s.ssSelloDigital : new byte[] { };
}
}
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrSelloDigital = s.ssSelloDigital;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord, EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord s) => ToStructure(s, config);
}
public static EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord s = new EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord();
  if(obj != null) {
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssSelloDigital = obj.AttrSelloDigital == null ? new byte[] {} : obj.AttrSelloDigital;
  }
  return s;
}

public static Func<EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord, ssConectaProveedores.RestRecords.JSONEN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord FromStructure(EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord(s, config);
}

}


