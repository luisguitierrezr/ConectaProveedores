using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExcelOrderEntriesLogToExport
public class RESTST_8a84c0565c68734bf5e2c1c8f79fe30cStructure : AbstractRESTStructure<ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure> {
[JsonProperty("ItemPosition")]
public string AttrItemPosition;

[JsonProperty("Quantity")]
public decimal? AttrQuantity;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

public RESTST_8a84c0565c68734bf5e2c1c8f79fe30cStructure() { }

public RESTST_8a84c0565c68734bf5e2c1c8f79fe30cStructure (ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure s, IBehaviorsConfiguration config) {
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

public static ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_8a84c0565c68734bf5e2c1c8f79fe30cStructure obj) { 
  ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure s = new ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure();
  if(obj != null) {
  s.ssItemPosition = obj.AttrItemPosition == null ? "" : obj.AttrItemPosition;
  s.ssQuantity = obj.AttrQuantity == null ? 0.0M : obj.AttrQuantity.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  }
  return s;
}

public static Func<ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure, ssConectaProveedores.RestRecords.RESTST_8a84c0565c68734bf5e2c1c8f79fe30cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_8a84c0565c68734bf5e2c1c8f79fe30cStructure FromStructure(ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_8a84c0565c68734bf5e2c1c8f79fe30cStructure(s, config);
}

}


