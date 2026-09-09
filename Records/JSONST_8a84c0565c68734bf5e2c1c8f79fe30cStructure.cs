using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExcelOrderEntriesLogToExport
public class JSONST_8a84c0565c68734bf5e2c1c8f79fe30cStructure : AbstractRESTStructure<ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure> {
[JsonProperty("ItemPosition")]
[JsonPropertyName("ItemPosition")]
public string AttrItemPosition;

[JsonProperty("Quantity")]
[JsonPropertyName("Quantity")]
public decimal? AttrQuantity;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

public JSONST_8a84c0565c68734bf5e2c1c8f79fe30cStructure() { }

public JSONST_8a84c0565c68734bf5e2c1c8f79fe30cStructure (ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItemPosition = ConvertToRestWithoutDefaults(s.ssItemPosition, "");
AttrQuantity = ConvertToRestWithoutDefaults(s.ssQuantity, 0.0M);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrItemPosition = s.ssItemPosition;
AttrQuantity = (decimal?) s.ssQuantity;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_8a84c0565c68734bf5e2c1c8f79fe30cStructure, ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_8a84c0565c68734bf5e2c1c8f79fe30cStructure s) => ToStructure(s, config);
}
public static ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_8a84c0565c68734bf5e2c1c8f79fe30cStructure obj, IBehaviorsConfiguration config) { 
  ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure s = new ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure();
  if(obj != null) {
  s.ssItemPosition = obj.AttrItemPosition == null ? "" : obj.AttrItemPosition;
  s.ssQuantity = obj.AttrQuantity == null ? 0.0M : obj.AttrQuantity.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  }
  return s;
}

public static Func<ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure, ssConectaProveedores.RestRecords.JSONST_8a84c0565c68734bf5e2c1c8f79fe30cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_8a84c0565c68734bf5e2c1c8f79fe30cStructure FromStructure(ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_8a84c0565c68734bf5e2c1c8f79fe30cStructure(s, config);
}

}


