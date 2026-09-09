using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExcelOrderLogToExport
public class RESTST_5fdc1be15c9e934a0a534eba5239d3c9Structure : AbstractRESTStructure<ST_5fdc1be15c9e934a0a534eba5239d3c9Structure> {
[JsonProperty("OrderName")]
public string AttrOrderName;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("Message")]
public string AttrMessage;

public RESTST_5fdc1be15c9e934a0a534eba5239d3c9Structure() { }

public RESTST_5fdc1be15c9e934a0a534eba5239d3c9Structure (ST_5fdc1be15c9e934a0a534eba5239d3c9Structure s, IBehaviorsConfiguration config) {
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

public static ST_5fdc1be15c9e934a0a534eba5239d3c9Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_5fdc1be15c9e934a0a534eba5239d3c9Structure obj) { 
  ST_5fdc1be15c9e934a0a534eba5239d3c9Structure s = new ST_5fdc1be15c9e934a0a534eba5239d3c9Structure();
  if(obj != null) {
  s.ssOrderName = obj.AttrOrderName == null ? "" : obj.AttrOrderName;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<ST_5fdc1be15c9e934a0a534eba5239d3c9Structure, ssConectaProveedores.RestRecords.RESTST_5fdc1be15c9e934a0a534eba5239d3c9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5fdc1be15c9e934a0a534eba5239d3c9Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_5fdc1be15c9e934a0a534eba5239d3c9Structure FromStructure(ST_5fdc1be15c9e934a0a534eba5239d3c9Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_5fdc1be15c9e934a0a534eba5239d3c9Structure(s, config);
}

}


