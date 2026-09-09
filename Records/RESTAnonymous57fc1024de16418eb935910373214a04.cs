using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessTypeRecord
public class RESTRC_66db0edcff7ea9b0aa258e335add1ccc : AbstractRESTStructure<RC_66db0edcff7ea9b0aa258e335add1ccc> {
[JsonProperty("ApprovalProcessType")]
public ssConectaProveedores.RestRecords.RESTEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord AttrApprovalProcessType;

public RESTRC_66db0edcff7ea9b0aa258e335add1ccc() { }

public RESTRC_66db0edcff7ea9b0aa258e335add1ccc (RC_66db0edcff7ea9b0aa258e335add1ccc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcessType = ConvertToRestWithoutDefaults(s.ssENApprovalProcessType, new EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord.FromStructure, config);
  } else {
AttrApprovalProcessType = ssConectaProveedores.RestRecords.RESTEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord.FromStructure(s.ssENApprovalProcessType, config);
  }
}

public static RC_66db0edcff7ea9b0aa258e335add1ccc ToStructure(ssConectaProveedores.RestRecords.RESTRC_66db0edcff7ea9b0aa258e335add1ccc obj) { 
  RC_66db0edcff7ea9b0aa258e335add1ccc s = new RC_66db0edcff7ea9b0aa258e335add1ccc();
  if(obj != null) {
  s.ssENApprovalProcessType = ssConectaProveedores.RestRecords.RESTEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord.ToStructure(obj.AttrApprovalProcessType);
  }
  return s;
}

public static Func<RC_66db0edcff7ea9b0aa258e335add1ccc, ssConectaProveedores.RestRecords.RESTRC_66db0edcff7ea9b0aa258e335add1ccc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_66db0edcff7ea9b0aa258e335add1ccc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_66db0edcff7ea9b0aa258e335add1ccc FromStructure(RC_66db0edcff7ea9b0aa258e335add1ccc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_66db0edcff7ea9b0aa258e335add1ccc(s, config);
}

}


