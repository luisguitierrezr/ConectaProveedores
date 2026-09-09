using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalTempDataRecord
public class JSONRC_b6220f9cda8becc85872c79fa9ac74d5 : AbstractRESTStructure<RC_b6220f9cda8becc85872c79fa9ac74d5> {
[JsonProperty("ProposalTempData")]
[JsonPropertyName("ProposalTempData")]
public ssConectaProveedores.RestRecords.JSONST_ba28fce29317fb1a65969ecb0fce5c4bStructure AttrProposalTempData;

public JSONRC_b6220f9cda8becc85872c79fa9ac74d5() { }

public JSONRC_b6220f9cda8becc85872c79fa9ac74d5 (RC_b6220f9cda8becc85872c79fa9ac74d5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalTempData = ConvertToRestWithoutDefaults(s.ssSTProposalTempData, new ST_ba28fce29317fb1a65969ecb0fce5c4bStructure(), ssConectaProveedores.RestRecords.JSONST_ba28fce29317fb1a65969ecb0fce5c4bStructure.FromStructure, config);
  } else {
AttrProposalTempData = ssConectaProveedores.RestRecords.JSONST_ba28fce29317fb1a65969ecb0fce5c4bStructure.FromStructure(s.ssSTProposalTempData, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b6220f9cda8becc85872c79fa9ac74d5, RC_b6220f9cda8becc85872c79fa9ac74d5> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b6220f9cda8becc85872c79fa9ac74d5 s) => ToStructure(s, config);
}
public static RC_b6220f9cda8becc85872c79fa9ac74d5 ToStructure(ssConectaProveedores.RestRecords.JSONRC_b6220f9cda8becc85872c79fa9ac74d5 obj, IBehaviorsConfiguration config) { 
  RC_b6220f9cda8becc85872c79fa9ac74d5 s = new RC_b6220f9cda8becc85872c79fa9ac74d5();
  if(obj != null) {
  s.ssSTProposalTempData = ssConectaProveedores.RestRecords.JSONST_ba28fce29317fb1a65969ecb0fce5c4bStructure.ToStructure(obj.AttrProposalTempData, config);
  }
  return s;
}

public static Func<RC_b6220f9cda8becc85872c79fa9ac74d5, ssConectaProveedores.RestRecords.JSONRC_b6220f9cda8becc85872c79fa9ac74d5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b6220f9cda8becc85872c79fa9ac74d5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b6220f9cda8becc85872c79fa9ac74d5 FromStructure(RC_b6220f9cda8becc85872c79fa9ac74d5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b6220f9cda8becc85872c79fa9ac74d5(s, config);
}

}


