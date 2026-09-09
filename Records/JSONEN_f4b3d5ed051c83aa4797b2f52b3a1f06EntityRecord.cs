using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFile
public class JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord : AbstractRESTStructure<EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord> {
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

[JsonProperty("IsReport")]
[JsonPropertyName("IsReport")]
public bool? AttrIsReport;

[JsonProperty("StorageId")]
[JsonPropertyName("StorageId")]
public long? AttrStorageId;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

public JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord() { }

public JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord (EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrFilename = ConvertToRestWithoutDefaults(s.ssFilename, "");
AttrIsExtra = ConvertToRestWithoutDefaults(s.ssIsExtra, false);
AttrIsReport = ConvertToRestWithoutDefaults(s.ssIsReport, false);
AttrStorageId = ConvertToRestWithoutDefaults(s.ssStorageId, 0L);
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrFilename = s.ssFilename;
AttrIsExtra = (bool?) s.ssIsExtra;
AttrIsReport = (bool?) s.ssIsReport;
AttrStorageId = (long?) s.ssStorageId;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord, EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord s) => ToStructure(s, config);
}
public static EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord s = new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssFilename = obj.AttrFilename == null ? "" : obj.AttrFilename;
  s.ssIsExtra = obj.AttrIsExtra == null ? false : obj.AttrIsExtra.Value;
  s.ssIsReport = obj.AttrIsReport == null ? false : obj.AttrIsReport.Value;
  s.ssStorageId = obj.AttrStorageId == null ? 0L : obj.AttrStorageId.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  }
  return s;
}

public static Func<EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord, ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord FromStructure(EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(s, config);
}

}


