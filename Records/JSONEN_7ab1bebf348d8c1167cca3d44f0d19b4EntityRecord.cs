using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// IVAExceptionM9Suppliers
public class JSONEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord : AbstractRESTStructure<EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("SupplierNumber")]
[JsonPropertyName("SupplierNumber")]
public int? AttrSupplierNumber;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
[JsonPropertyName("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
[JsonPropertyName("UpdatedBy")]
public string AttrUpdatedBy;

public JSONEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord() { }

public JSONEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord (EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrSupplierNumber = ConvertToRestWithoutDefaults(s.ssSupplierNumber, 0);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrSupplierNumber = (int?) s.ssSupplierNumber;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord, EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord s) => ToStructure(s, config);
}
public static EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord s = new EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssSupplierNumber = obj.AttrSupplierNumber == null ? 0 : obj.AttrSupplierNumber.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord, ssConectaProveedores.RestRecords.JSONEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord FromStructure(EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord(s, config);
}

}


