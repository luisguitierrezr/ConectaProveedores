using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ApprovalProcessMatrixRecord
public class JSONRC_40e7a439bb45c9955de25b1debc0650f : AbstractRESTStructure<RC_40e7a439bb45c9955de25b1debc0650f> {
[JsonProperty("ApprovalProcessMatrix")]
[JsonPropertyName("ApprovalProcessMatrix")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord AttrApprovalProcessMatrix;

public JSONRC_40e7a439bb45c9955de25b1debc0650f() { }

public JSONRC_40e7a439bb45c9955de25b1debc0650f (RC_40e7a439bb45c9955de25b1debc0650f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcessMatrix = ConvertToRestWithoutDefaults(s.ssENApprovalProcessMatrix, new EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcessMatrix = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord.FromStructure(s.ssENApprovalProcessMatrix, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_40e7a439bb45c9955de25b1debc0650f, RC_40e7a439bb45c9955de25b1debc0650f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_40e7a439bb45c9955de25b1debc0650f s) => ToStructure(s, config);
}
public static RC_40e7a439bb45c9955de25b1debc0650f ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_40e7a439bb45c9955de25b1debc0650f obj, IBehaviorsConfiguration config) { 
  RC_40e7a439bb45c9955de25b1debc0650f s = new RC_40e7a439bb45c9955de25b1debc0650f();
  if(obj != null) {
  s.ssENApprovalProcessMatrix = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord.ToStructure(obj.AttrApprovalProcessMatrix, config);
  }
  return s;
}

public static Func<RC_40e7a439bb45c9955de25b1debc0650f, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_40e7a439bb45c9955de25b1debc0650f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_40e7a439bb45c9955de25b1debc0650f s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_40e7a439bb45c9955de25b1debc0650f FromStructure(RC_40e7a439bb45c9955de25b1debc0650f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_40e7a439bb45c9955de25b1debc0650f(s, config);
}

}


