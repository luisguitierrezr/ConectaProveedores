using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// l_ApprovalProcessIdl_IsSelectFirstApproverRecord
public class RESTRC_e05385e784b7ab877b391b661988aada : AbstractRESTStructure<RC_e05385e784b7ab877b391b661988aada> {
[JsonProperty("l_ApprovalProcessId")]
public long? Attrl_ApprovalProcessId;

[JsonProperty("l_IsSelectFirstApprover")]
public bool? Attrl_IsSelectFirstApprover;

public RESTRC_e05385e784b7ab877b391b661988aada() { }

public RESTRC_e05385e784b7ab877b391b661988aada (RC_e05385e784b7ab877b391b661988aada s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrl_ApprovalProcessId = ConvertToRestWithoutDefaults(s.ssl_ApprovalProcessId, 0L);
Attrl_IsSelectFirstApprover = ConvertToRestWithoutDefaults(s.ssl_IsSelectFirstApprover, false);
  } else {
Attrl_ApprovalProcessId = (long?) s.ssl_ApprovalProcessId;
Attrl_IsSelectFirstApprover = (bool?) s.ssl_IsSelectFirstApprover;
  }
}

public static RC_e05385e784b7ab877b391b661988aada ToStructure(ssConectaProveedores.RestRecords.RESTRC_e05385e784b7ab877b391b661988aada obj) { 
  RC_e05385e784b7ab877b391b661988aada s = new RC_e05385e784b7ab877b391b661988aada();
  if(obj != null) {
  s.ssl_ApprovalProcessId = obj.Attrl_ApprovalProcessId == null ? 0L : obj.Attrl_ApprovalProcessId.Value;
  s.ssl_IsSelectFirstApprover = obj.Attrl_IsSelectFirstApprover == null ? false : obj.Attrl_IsSelectFirstApprover.Value;
  }
  return s;
}

public static Func<RC_e05385e784b7ab877b391b661988aada, ssConectaProveedores.RestRecords.RESTRC_e05385e784b7ab877b391b661988aada> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e05385e784b7ab877b391b661988aada s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e05385e784b7ab877b391b661988aada FromStructure(RC_e05385e784b7ab877b391b661988aada s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e05385e784b7ab877b391b661988aada(s, config);
}

}


