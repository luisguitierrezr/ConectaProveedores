using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFiles
public class JSONST_d381fba44897ce4382b17d5149465d51Structure : AbstractRESTStructure<ST_d381fba44897ce4382b17d5149465d51Structure> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("InvoiceId")]
[JsonPropertyName("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("Filename")]
[JsonPropertyName("Filename")]
public string AttrFilename;

[JsonProperty("IsExtra")]
[JsonPropertyName("IsExtra")]
public bool? AttrIsExtra;

[JsonProperty("StorageId")]
[JsonPropertyName("StorageId")]
public long? AttrStorageId;

[JsonProperty("CreatedByName")]
[JsonPropertyName("CreatedByName")]
public string AttrCreatedByName;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("InvoiceStatusLabel")]
[JsonPropertyName("InvoiceStatusLabel")]
public string AttrInvoiceStatusLabel;

[JsonProperty("InvoiceStatusClass")]
[JsonPropertyName("InvoiceStatusClass")]
public string AttrInvoiceStatusClass;

[JsonProperty("Size")]
[JsonPropertyName("Size")]
public long? AttrSize;

public JSONST_d381fba44897ce4382b17d5149465d51Structure() { }

public JSONST_d381fba44897ce4382b17d5149465d51Structure (ST_d381fba44897ce4382b17d5149465d51Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrFilename = ConvertToRestWithoutDefaults(s.ssFilename, "");
AttrIsExtra = ConvertToRestWithoutDefaults(s.ssIsExtra, false);
AttrStorageId = ConvertToRestWithoutDefaults(s.ssStorageId, 0L);
AttrCreatedByName = s.ssCreatedByName;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrInvoiceStatusLabel = ConvertToRestWithoutDefaults(s.ssInvoiceStatusLabel, "");
AttrInvoiceStatusClass = ConvertToRestWithoutDefaults(s.ssInvoiceStatusClass, "");
AttrSize = ConvertToRestWithoutDefaults(s.ssSize, 0L);
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrFilename = s.ssFilename;
AttrIsExtra = (bool?) s.ssIsExtra;
AttrStorageId = (long?) s.ssStorageId;
AttrCreatedByName = s.ssCreatedByName;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrInvoiceStatusLabel = s.ssInvoiceStatusLabel;
AttrInvoiceStatusClass = s.ssInvoiceStatusClass;
AttrSize = (long?) s.ssSize;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_d381fba44897ce4382b17d5149465d51Structure, ST_d381fba44897ce4382b17d5149465d51Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_d381fba44897ce4382b17d5149465d51Structure s) => ToStructure(s, config);
}
public static ST_d381fba44897ce4382b17d5149465d51Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_d381fba44897ce4382b17d5149465d51Structure obj, IBehaviorsConfiguration config) { 
  ST_d381fba44897ce4382b17d5149465d51Structure s = new ST_d381fba44897ce4382b17d5149465d51Structure();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssFilename = obj.AttrFilename == null ? "" : obj.AttrFilename;
  s.ssIsExtra = obj.AttrIsExtra == null ? false : obj.AttrIsExtra.Value;
  s.ssStorageId = obj.AttrStorageId == null ? 0L : obj.AttrStorageId.Value;
  s.ssCreatedByName = obj.AttrCreatedByName == null ? "" : obj.AttrCreatedByName;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssInvoiceStatusLabel = obj.AttrInvoiceStatusLabel == null ? "" : obj.AttrInvoiceStatusLabel;
  s.ssInvoiceStatusClass = obj.AttrInvoiceStatusClass == null ? "" : obj.AttrInvoiceStatusClass;
  s.ssSize = obj.AttrSize == null ? 0L : obj.AttrSize.Value;
  }
  return s;
}

public static Func<ST_d381fba44897ce4382b17d5149465d51Structure, ssConectaProveedores.RestRecords.JSONST_d381fba44897ce4382b17d5149465d51Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d381fba44897ce4382b17d5149465d51Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_d381fba44897ce4382b17d5149465d51Structure FromStructure(ST_d381fba44897ce4382b17d5149465d51Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_d381fba44897ce4382b17d5149465d51Structure(s, config);
}

}


