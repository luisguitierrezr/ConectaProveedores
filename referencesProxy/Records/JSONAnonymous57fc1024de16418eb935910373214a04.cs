using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ApprovalProcessTypeRecord
public class JSONRC_66db0edcff7ea9b0aa258e335add1ccc : AbstractRESTStructure<RC_66db0edcff7ea9b0aa258e335add1ccc> {
[JsonProperty("ApprovalProcessType")]
[JsonPropertyName("ApprovalProcessType")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord AttrApprovalProcessType;

public JSONRC_66db0edcff7ea9b0aa258e335add1ccc() { }

public JSONRC_66db0edcff7ea9b0aa258e335add1ccc (RC_66db0edcff7ea9b0aa258e335add1ccc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcessType = ConvertToRestWithoutDefaults(s.ssENApprovalProcessType, new EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord.FromStructure, config);
  } else {
AttrApprovalProcessType = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord.FromStructure(s.ssENApprovalProcessType, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_66db0edcff7ea9b0aa258e335add1ccc, RC_66db0edcff7ea9b0aa258e335add1ccc> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_66db0edcff7ea9b0aa258e335add1ccc s) => ToStructure(s, config);
}
public static RC_66db0edcff7ea9b0aa258e335add1ccc ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_66db0edcff7ea9b0aa258e335add1ccc obj, IBehaviorsConfiguration config) { 
  RC_66db0edcff7ea9b0aa258e335add1ccc s = new RC_66db0edcff7ea9b0aa258e335add1ccc();
  if(obj != null) {
  s.ssENApprovalProcessType = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord.ToStructure(obj.AttrApprovalProcessType, config);
  }
  return s;
}

public static Func<RC_66db0edcff7ea9b0aa258e335add1ccc, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_66db0edcff7ea9b0aa258e335add1ccc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_66db0edcff7ea9b0aa258e335add1ccc s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_66db0edcff7ea9b0aa258e335add1ccc FromStructure(RC_66db0edcff7ea9b0aa258e335add1ccc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_66db0edcff7ea9b0aa258e335add1ccc(s, config);
}

}


