using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalStatusIdLabelESCountRecord
public class JSONRC_afab2cefd38800554ad4d08254da5d01 : AbstractRESTStructure<RC_afab2cefd38800554ad4d08254da5d01> {
[JsonProperty("ApprovalStatusId")]
[JsonPropertyName("ApprovalStatusId")]
public int? AttrApprovalStatusId;

[JsonProperty("LabelES")]
[JsonPropertyName("LabelES")]
public string AttrLabelES;

[JsonProperty("Count")]
[JsonPropertyName("Count")]
public long? AttrCount;

public JSONRC_afab2cefd38800554ad4d08254da5d01() { }

public JSONRC_afab2cefd38800554ad4d08254da5d01 (RC_afab2cefd38800554ad4d08254da5d01 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalStatusId = ConvertToRestWithoutDefaults(s.ssApprovalStatusId, 0);
AttrLabelES = ConvertToRestWithoutDefaults(s.ssLabelES, "");
AttrCount = ConvertToRestWithoutDefaults(s.ssCount, 0L);
  } else {
AttrApprovalStatusId = (int?) s.ssApprovalStatusId;
AttrLabelES = s.ssLabelES;
AttrCount = (long?) s.ssCount;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_afab2cefd38800554ad4d08254da5d01, RC_afab2cefd38800554ad4d08254da5d01> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_afab2cefd38800554ad4d08254da5d01 s) => ToStructure(s, config);
}
public static RC_afab2cefd38800554ad4d08254da5d01 ToStructure(ssConectaProveedores.RestRecords.JSONRC_afab2cefd38800554ad4d08254da5d01 obj, IBehaviorsConfiguration config) { 
  RC_afab2cefd38800554ad4d08254da5d01 s = new RC_afab2cefd38800554ad4d08254da5d01();
  if(obj != null) {
  s.ssApprovalStatusId = obj.AttrApprovalStatusId == null ? 0 : obj.AttrApprovalStatusId.Value;
  s.ssLabelES = obj.AttrLabelES == null ? "" : obj.AttrLabelES;
  s.ssCount = obj.AttrCount == null ? 0L : obj.AttrCount.Value;
  }
  return s;
}

public static Func<RC_afab2cefd38800554ad4d08254da5d01, ssConectaProveedores.RestRecords.JSONRC_afab2cefd38800554ad4d08254da5d01> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_afab2cefd38800554ad4d08254da5d01 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_afab2cefd38800554ad4d08254da5d01 FromStructure(RC_afab2cefd38800554ad4d08254da5d01 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_afab2cefd38800554ad4d08254da5d01(s, config);
}

}


