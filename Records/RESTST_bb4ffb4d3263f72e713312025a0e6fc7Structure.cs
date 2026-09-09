using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NotificationErrorStruct
public class RESTST_bb4ffb4d3263f72e713312025a0e6fc7Structure : AbstractRESTStructure<ST_bb4ffb4d3263f72e713312025a0e6fc7Structure> {
[JsonProperty("Title")]
public string AttrTitle;

[JsonProperty("ApprovalErrorList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_1f579c47758735b50f415dd5b367a40b> AttrApprovalErrorList;

public RESTST_bb4ffb4d3263f72e713312025a0e6fc7Structure() { }

public RESTST_bb4ffb4d3263f72e713312025a0e6fc7Structure (ST_bb4ffb4d3263f72e713312025a0e6fc7Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTitle = ConvertToRestWithoutDefaults(s.ssTitle, "");
AttrApprovalErrorList = s.ssApprovalErrorList.Length == 0 ? null : s.ssApprovalErrorList.ToRestList<ssConectaProveedores.RestRecords.RESTRC_1f579c47758735b50f415dd5b367a40b>(ssConectaProveedores.RestRecords.RESTRC_1f579c47758735b50f415dd5b367a40b.FromStructureDelegate(config));
  } else {
AttrTitle = s.ssTitle;
AttrApprovalErrorList = s.ssApprovalErrorList.ToRestList<ssConectaProveedores.RestRecords.RESTRC_1f579c47758735b50f415dd5b367a40b>(ssConectaProveedores.RestRecords.RESTRC_1f579c47758735b50f415dd5b367a40b.FromStructureDelegate(config));
  }
}

public static ST_bb4ffb4d3263f72e713312025a0e6fc7Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_bb4ffb4d3263f72e713312025a0e6fc7Structure obj) { 
  ST_bb4ffb4d3263f72e713312025a0e6fc7Structure s = new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure();
  if(obj != null) {
  s.ssTitle = obj.AttrTitle == null ? "" : obj.AttrTitle;
  s.ssApprovalErrorList = RL_b07a2c599719eeabf4cf87e53c7dda78.FromRestList(obj.AttrApprovalErrorList, ssConectaProveedores.RestRecords.RESTRC_1f579c47758735b50f415dd5b367a40b.ToStructure);
  }
  return s;
}

public static Func<ST_bb4ffb4d3263f72e713312025a0e6fc7Structure, ssConectaProveedores.RestRecords.RESTST_bb4ffb4d3263f72e713312025a0e6fc7Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_bb4ffb4d3263f72e713312025a0e6fc7Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_bb4ffb4d3263f72e713312025a0e6fc7Structure FromStructure(ST_bb4ffb4d3263f72e713312025a0e6fc7Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_bb4ffb4d3263f72e713312025a0e6fc7Structure(s, config);
}

}


