using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// IVAExceptionM9Suppliers
public class RESTEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord : AbstractRESTStructure<EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("SupplierNumber")]
public int? AttrSupplierNumber;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

public RESTEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord() { }

public RESTEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord (EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord obj) { 
  EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord s = new EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssSupplierNumber = obj.AttrSupplierNumber == null ? 0 : obj.AttrSupplierNumber.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord, ssConectaProveedores.RestRecords.RESTEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord FromStructure(EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord(s, config);
}

}


