using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalLineApprovalLevelRecord
public class RESTRC_875fb45d4123a91fce83831f0f554d8e : AbstractRESTStructure<RC_875fb45d4123a91fce83831f0f554d8e> {
[JsonProperty("ProposalLineApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord AttrProposalLineApprovalLevel;

public RESTRC_875fb45d4123a91fce83831f0f554d8e() { }

public RESTRC_875fb45d4123a91fce83831f0f554d8e (RC_875fb45d4123a91fce83831f0f554d8e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalLineApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalLineApprovalLevel, new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.FromStructure, config);
  } else {
AttrProposalLineApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.FromStructure(s.ssENProposalLineApprovalLevel, config);
  }
}

public static RC_875fb45d4123a91fce83831f0f554d8e ToStructure(ssConectaProveedores.RestRecords.RESTRC_875fb45d4123a91fce83831f0f554d8e obj) { 
  RC_875fb45d4123a91fce83831f0f554d8e s = new RC_875fb45d4123a91fce83831f0f554d8e();
  if(obj != null) {
  s.ssENProposalLineApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.ToStructure(obj.AttrProposalLineApprovalLevel);
  }
  return s;
}

public static Func<RC_875fb45d4123a91fce83831f0f554d8e, ssConectaProveedores.RestRecords.RESTRC_875fb45d4123a91fce83831f0f554d8e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_875fb45d4123a91fce83831f0f554d8e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_875fb45d4123a91fce83831f0f554d8e FromStructure(RC_875fb45d4123a91fce83831f0f554d8e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_875fb45d4123a91fce83831f0f554d8e(s, config);
}

}


