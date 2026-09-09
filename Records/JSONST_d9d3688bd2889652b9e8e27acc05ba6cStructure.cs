using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExcelProposalLogToExport
public class JSONST_d9d3688bd2889652b9e8e27acc05ba6cStructure : AbstractRESTStructure<ST_d9d3688bd2889652b9e8e27acc05ba6cStructure> {
[JsonProperty("ProposalName")]
[JsonPropertyName("ProposalName")]
public string AttrProposalName;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("Message")]
[JsonPropertyName("Message")]
public string AttrMessage;

public JSONST_d9d3688bd2889652b9e8e27acc05ba6cStructure() { }

public JSONST_d9d3688bd2889652b9e8e27acc05ba6cStructure (ST_d9d3688bd2889652b9e8e27acc05ba6cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalName = ConvertToRestWithoutDefaults(s.ssProposalName, "");
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrProposalName = s.ssProposalName;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrMessage = s.ssMessage;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_d9d3688bd2889652b9e8e27acc05ba6cStructure, ST_d9d3688bd2889652b9e8e27acc05ba6cStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_d9d3688bd2889652b9e8e27acc05ba6cStructure s) => ToStructure(s, config);
}
public static ST_d9d3688bd2889652b9e8e27acc05ba6cStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_d9d3688bd2889652b9e8e27acc05ba6cStructure obj, IBehaviorsConfiguration config) { 
  ST_d9d3688bd2889652b9e8e27acc05ba6cStructure s = new ST_d9d3688bd2889652b9e8e27acc05ba6cStructure();
  if(obj != null) {
  s.ssProposalName = obj.AttrProposalName == null ? "" : obj.AttrProposalName;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<ST_d9d3688bd2889652b9e8e27acc05ba6cStructure, ssConectaProveedores.RestRecords.JSONST_d9d3688bd2889652b9e8e27acc05ba6cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d9d3688bd2889652b9e8e27acc05ba6cStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_d9d3688bd2889652b9e8e27acc05ba6cStructure FromStructure(ST_d9d3688bd2889652b9e8e27acc05ba6cStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_d9d3688bd2889652b9e8e27acc05ba6cStructure(s, config);
}

}


