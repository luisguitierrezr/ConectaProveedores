using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NotificationErrorStruct
public class JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure : AbstractRESTStructure<ST_bb4ffb4d3263f72e713312025a0e6fc7Structure> {
[JsonProperty("Title")]
[JsonPropertyName("Title")]
public string AttrTitle;

[JsonProperty("ApprovalErrorList")]
[JsonPropertyName("ApprovalErrorList")]
public ssConectaProveedores.RestRecords.JSONRC_1f579c47758735b50f415dd5b367a40b[] AttrApprovalErrorList;

public JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure() { }

public JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure (ST_bb4ffb4d3263f72e713312025a0e6fc7Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTitle = ConvertToRestWithoutDefaults(s.ssTitle, "");
AttrApprovalErrorList = s.ssApprovalErrorList.Length == 0 ? null : s.ssApprovalErrorList.ToArray<ssConectaProveedores.RestRecords.JSONRC_1f579c47758735b50f415dd5b367a40b>(ssConectaProveedores.RestRecords.JSONRC_1f579c47758735b50f415dd5b367a40b.FromStructureDelegate(config));
  } else {
AttrTitle = s.ssTitle;
AttrApprovalErrorList = s.ssApprovalErrorList.ToArray<ssConectaProveedores.RestRecords.JSONRC_1f579c47758735b50f415dd5b367a40b>(ssConectaProveedores.RestRecords.JSONRC_1f579c47758735b50f415dd5b367a40b.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure, ST_bb4ffb4d3263f72e713312025a0e6fc7Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure s) => ToStructure(s, config);
}
public static ST_bb4ffb4d3263f72e713312025a0e6fc7Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure obj, IBehaviorsConfiguration config) { 
  ST_bb4ffb4d3263f72e713312025a0e6fc7Structure s = new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure();
  if(obj != null) {
  s.ssTitle = obj.AttrTitle == null ? "" : obj.AttrTitle;
  s.ssApprovalErrorList = RL_b07a2c599719eeabf4cf87e53c7dda78.ToList(obj.AttrApprovalErrorList, ssConectaProveedores.RestRecords.JSONRC_1f579c47758735b50f415dd5b367a40b.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_bb4ffb4d3263f72e713312025a0e6fc7Structure, ssConectaProveedores.RestRecords.JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_bb4ffb4d3263f72e713312025a0e6fc7Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure FromStructure(ST_bb4ffb4d3263f72e713312025a0e6fc7Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_bb4ffb4d3263f72e713312025a0e6fc7Structure(s, config);
}

}


