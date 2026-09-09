using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExcelInvoiceLogToExport
public class JSONST_dcf36ec11d8d763002f3a9a106379cf7Structure : AbstractRESTStructure<ST_dcf36ec11d8d763002f3a9a106379cf7Structure> {
[JsonProperty("InvoiceName")]
[JsonPropertyName("InvoiceName")]
public string AttrInvoiceName;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("Message")]
[JsonPropertyName("Message")]
public string AttrMessage;

public JSONST_dcf36ec11d8d763002f3a9a106379cf7Structure() { }

public JSONST_dcf36ec11d8d763002f3a9a106379cf7Structure (ST_dcf36ec11d8d763002f3a9a106379cf7Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceName = ConvertToRestWithoutDefaults(s.ssInvoiceName, "");
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrInvoiceName = s.ssInvoiceName;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrMessage = s.ssMessage;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_dcf36ec11d8d763002f3a9a106379cf7Structure, ST_dcf36ec11d8d763002f3a9a106379cf7Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_dcf36ec11d8d763002f3a9a106379cf7Structure s) => ToStructure(s, config);
}
public static ST_dcf36ec11d8d763002f3a9a106379cf7Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_dcf36ec11d8d763002f3a9a106379cf7Structure obj, IBehaviorsConfiguration config) { 
  ST_dcf36ec11d8d763002f3a9a106379cf7Structure s = new ST_dcf36ec11d8d763002f3a9a106379cf7Structure();
  if(obj != null) {
  s.ssInvoiceName = obj.AttrInvoiceName == null ? "" : obj.AttrInvoiceName;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<ST_dcf36ec11d8d763002f3a9a106379cf7Structure, ssConectaProveedores.RestRecords.JSONST_dcf36ec11d8d763002f3a9a106379cf7Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_dcf36ec11d8d763002f3a9a106379cf7Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_dcf36ec11d8d763002f3a9a106379cf7Structure FromStructure(ST_dcf36ec11d8d763002f3a9a106379cf7Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_dcf36ec11d8d763002f3a9a106379cf7Structure(s, config);
}

}


