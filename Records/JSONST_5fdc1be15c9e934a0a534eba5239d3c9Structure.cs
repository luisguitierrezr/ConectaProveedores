using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExcelOrderLogToExport
public class JSONST_5fdc1be15c9e934a0a534eba5239d3c9Structure : AbstractRESTStructure<ST_5fdc1be15c9e934a0a534eba5239d3c9Structure> {
[JsonProperty("OrderName")]
[JsonPropertyName("OrderName")]
public string AttrOrderName;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("Message")]
[JsonPropertyName("Message")]
public string AttrMessage;

public JSONST_5fdc1be15c9e934a0a534eba5239d3c9Structure() { }

public JSONST_5fdc1be15c9e934a0a534eba5239d3c9Structure (ST_5fdc1be15c9e934a0a534eba5239d3c9Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderName = ConvertToRestWithoutDefaults(s.ssOrderName, "");
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrOrderName = s.ssOrderName;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrMessage = s.ssMessage;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_5fdc1be15c9e934a0a534eba5239d3c9Structure, ST_5fdc1be15c9e934a0a534eba5239d3c9Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_5fdc1be15c9e934a0a534eba5239d3c9Structure s) => ToStructure(s, config);
}
public static ST_5fdc1be15c9e934a0a534eba5239d3c9Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_5fdc1be15c9e934a0a534eba5239d3c9Structure obj, IBehaviorsConfiguration config) { 
  ST_5fdc1be15c9e934a0a534eba5239d3c9Structure s = new ST_5fdc1be15c9e934a0a534eba5239d3c9Structure();
  if(obj != null) {
  s.ssOrderName = obj.AttrOrderName == null ? "" : obj.AttrOrderName;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<ST_5fdc1be15c9e934a0a534eba5239d3c9Structure, ssConectaProveedores.RestRecords.JSONST_5fdc1be15c9e934a0a534eba5239d3c9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5fdc1be15c9e934a0a534eba5239d3c9Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_5fdc1be15c9e934a0a534eba5239d3c9Structure FromStructure(ST_5fdc1be15c9e934a0a534eba5239d3c9Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_5fdc1be15c9e934a0a534eba5239d3c9Structure(s, config);
}

}


