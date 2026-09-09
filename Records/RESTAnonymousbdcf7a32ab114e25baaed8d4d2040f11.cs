using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalStatusRecord
public class RESTRC_5e94710ba0de64845af2f9d1cc088302 : AbstractRESTStructure<RC_5e94710ba0de64845af2f9d1cc088302> {
[JsonProperty("ApprovalStatus")]
public ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord AttrApprovalStatus;

public RESTRC_5e94710ba0de64845af2f9d1cc088302() { }

public RESTRC_5e94710ba0de64845af2f9d1cc088302 (RC_5e94710ba0de64845af2f9d1cc088302 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalStatus = ConvertToRestWithoutDefaults(s.ssENApprovalStatus, new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.FromStructure, config);
  } else {
AttrApprovalStatus = ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.FromStructure(s.ssENApprovalStatus, config);
  }
}

public static RC_5e94710ba0de64845af2f9d1cc088302 ToStructure(ssConectaProveedores.RestRecords.RESTRC_5e94710ba0de64845af2f9d1cc088302 obj) { 
  RC_5e94710ba0de64845af2f9d1cc088302 s = new RC_5e94710ba0de64845af2f9d1cc088302();
  if(obj != null) {
  s.ssENApprovalStatus = ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.ToStructure(obj.AttrApprovalStatus);
  }
  return s;
}

public static Func<RC_5e94710ba0de64845af2f9d1cc088302, ssConectaProveedores.RestRecords.RESTRC_5e94710ba0de64845af2f9d1cc088302> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5e94710ba0de64845af2f9d1cc088302 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5e94710ba0de64845af2f9d1cc088302 FromStructure(RC_5e94710ba0de64845af2f9d1cc088302 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5e94710ba0de64845af2f9d1cc088302(s, config);
}

}


