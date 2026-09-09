using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalStatusIdLabelESCountRecord
public class RESTRC_afab2cefd38800554ad4d08254da5d01 : AbstractRESTStructure<RC_afab2cefd38800554ad4d08254da5d01> {
[JsonProperty("ApprovalStatusId")]
public int? AttrApprovalStatusId;

[JsonProperty("LabelES")]
public string AttrLabelES;

[JsonProperty("Count")]
public long? AttrCount;

public RESTRC_afab2cefd38800554ad4d08254da5d01() { }

public RESTRC_afab2cefd38800554ad4d08254da5d01 (RC_afab2cefd38800554ad4d08254da5d01 s, IBehaviorsConfiguration config) {
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

public static RC_afab2cefd38800554ad4d08254da5d01 ToStructure(ssConectaProveedores.RestRecords.RESTRC_afab2cefd38800554ad4d08254da5d01 obj) { 
  RC_afab2cefd38800554ad4d08254da5d01 s = new RC_afab2cefd38800554ad4d08254da5d01();
  if(obj != null) {
  s.ssApprovalStatusId = obj.AttrApprovalStatusId == null ? 0 : obj.AttrApprovalStatusId.Value;
  s.ssLabelES = obj.AttrLabelES == null ? "" : obj.AttrLabelES;
  s.ssCount = obj.AttrCount == null ? 0L : obj.AttrCount.Value;
  }
  return s;
}

public static Func<RC_afab2cefd38800554ad4d08254da5d01, ssConectaProveedores.RestRecords.RESTRC_afab2cefd38800554ad4d08254da5d01> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_afab2cefd38800554ad4d08254da5d01 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_afab2cefd38800554ad4d08254da5d01 FromStructure(RC_afab2cefd38800554ad4d08254da5d01 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_afab2cefd38800554ad4d08254da5d01(s, config);
}

}


