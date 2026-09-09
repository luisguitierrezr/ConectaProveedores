using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalLineApprovalLevelRecord
public class JSONRC_875fb45d4123a91fce83831f0f554d8e : AbstractRESTStructure<RC_875fb45d4123a91fce83831f0f554d8e> {
[JsonProperty("ProposalLineApprovalLevel")]
[JsonPropertyName("ProposalLineApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord AttrProposalLineApprovalLevel;

public JSONRC_875fb45d4123a91fce83831f0f554d8e() { }

public JSONRC_875fb45d4123a91fce83831f0f554d8e (RC_875fb45d4123a91fce83831f0f554d8e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalLineApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalLineApprovalLevel, new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.FromStructure, config);
  } else {
AttrProposalLineApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.FromStructure(s.ssENProposalLineApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_875fb45d4123a91fce83831f0f554d8e, RC_875fb45d4123a91fce83831f0f554d8e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_875fb45d4123a91fce83831f0f554d8e s) => ToStructure(s, config);
}
public static RC_875fb45d4123a91fce83831f0f554d8e ToStructure(ssConectaProveedores.RestRecords.JSONRC_875fb45d4123a91fce83831f0f554d8e obj, IBehaviorsConfiguration config) { 
  RC_875fb45d4123a91fce83831f0f554d8e s = new RC_875fb45d4123a91fce83831f0f554d8e();
  if(obj != null) {
  s.ssENProposalLineApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.ToStructure(obj.AttrProposalLineApprovalLevel, config);
  }
  return s;
}

public static Func<RC_875fb45d4123a91fce83831f0f554d8e, ssConectaProveedores.RestRecords.JSONRC_875fb45d4123a91fce83831f0f554d8e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_875fb45d4123a91fce83831f0f554d8e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_875fb45d4123a91fce83831f0f554d8e FromStructure(RC_875fb45d4123a91fce83831f0f554d8e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_875fb45d4123a91fce83831f0f554d8e(s, config);
}

}


