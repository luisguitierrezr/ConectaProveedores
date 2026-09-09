using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalStatusRecord
public class JSONRC_5e94710ba0de64845af2f9d1cc088302 : AbstractRESTStructure<RC_5e94710ba0de64845af2f9d1cc088302> {
[JsonProperty("ApprovalStatus")]
[JsonPropertyName("ApprovalStatus")]
public ssConectaProveedores.RestRecords.JSONEN_e97ac0d21205ff90ab42100bba6097baEntityRecord AttrApprovalStatus;

public JSONRC_5e94710ba0de64845af2f9d1cc088302() { }

public JSONRC_5e94710ba0de64845af2f9d1cc088302 (RC_5e94710ba0de64845af2f9d1cc088302 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalStatus = ConvertToRestWithoutDefaults(s.ssENApprovalStatus, new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.FromStructure, config);
  } else {
AttrApprovalStatus = ssConectaProveedores.RestRecords.JSONEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.FromStructure(s.ssENApprovalStatus, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_5e94710ba0de64845af2f9d1cc088302, RC_5e94710ba0de64845af2f9d1cc088302> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_5e94710ba0de64845af2f9d1cc088302 s) => ToStructure(s, config);
}
public static RC_5e94710ba0de64845af2f9d1cc088302 ToStructure(ssConectaProveedores.RestRecords.JSONRC_5e94710ba0de64845af2f9d1cc088302 obj, IBehaviorsConfiguration config) { 
  RC_5e94710ba0de64845af2f9d1cc088302 s = new RC_5e94710ba0de64845af2f9d1cc088302();
  if(obj != null) {
  s.ssENApprovalStatus = ssConectaProveedores.RestRecords.JSONEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.ToStructure(obj.AttrApprovalStatus, config);
  }
  return s;
}

public static Func<RC_5e94710ba0de64845af2f9d1cc088302, ssConectaProveedores.RestRecords.JSONRC_5e94710ba0de64845af2f9d1cc088302> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5e94710ba0de64845af2f9d1cc088302 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_5e94710ba0de64845af2f9d1cc088302 FromStructure(RC_5e94710ba0de64845af2f9d1cc088302 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_5e94710ba0de64845af2f9d1cc088302(s, config);
}

}


