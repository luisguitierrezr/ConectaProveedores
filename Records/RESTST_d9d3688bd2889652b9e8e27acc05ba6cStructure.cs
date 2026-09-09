using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExcelProposalLogToExport
public class RESTST_d9d3688bd2889652b9e8e27acc05ba6cStructure : AbstractRESTStructure<ST_d9d3688bd2889652b9e8e27acc05ba6cStructure> {
[JsonProperty("ProposalName")]
public string AttrProposalName;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("Message")]
public string AttrMessage;

public RESTST_d9d3688bd2889652b9e8e27acc05ba6cStructure() { }

public RESTST_d9d3688bd2889652b9e8e27acc05ba6cStructure (ST_d9d3688bd2889652b9e8e27acc05ba6cStructure s, IBehaviorsConfiguration config) {
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

public static ST_d9d3688bd2889652b9e8e27acc05ba6cStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_d9d3688bd2889652b9e8e27acc05ba6cStructure obj) { 
  ST_d9d3688bd2889652b9e8e27acc05ba6cStructure s = new ST_d9d3688bd2889652b9e8e27acc05ba6cStructure();
  if(obj != null) {
  s.ssProposalName = obj.AttrProposalName == null ? "" : obj.AttrProposalName;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<ST_d9d3688bd2889652b9e8e27acc05ba6cStructure, ssConectaProveedores.RestRecords.RESTST_d9d3688bd2889652b9e8e27acc05ba6cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d9d3688bd2889652b9e8e27acc05ba6cStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_d9d3688bd2889652b9e8e27acc05ba6cStructure FromStructure(ST_d9d3688bd2889652b9e8e27acc05ba6cStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_d9d3688bd2889652b9e8e27acc05ba6cStructure(s, config);
}

}


