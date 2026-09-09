using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessMatrixRecord
public class RESTRC_40e7a439bb45c9955de25b1debc0650f : AbstractRESTStructure<RC_40e7a439bb45c9955de25b1debc0650f> {
[JsonProperty("ApprovalProcessMatrix")]
public ssConectaProveedores.RestRecords.RESTEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord AttrApprovalProcessMatrix;

public RESTRC_40e7a439bb45c9955de25b1debc0650f() { }

public RESTRC_40e7a439bb45c9955de25b1debc0650f (RC_40e7a439bb45c9955de25b1debc0650f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcessMatrix = ConvertToRestWithoutDefaults(s.ssENApprovalProcessMatrix, new EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcessMatrix = ssConectaProveedores.RestRecords.RESTEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord.FromStructure(s.ssENApprovalProcessMatrix, config);
  }
}

public static RC_40e7a439bb45c9955de25b1debc0650f ToStructure(ssConectaProveedores.RestRecords.RESTRC_40e7a439bb45c9955de25b1debc0650f obj) { 
  RC_40e7a439bb45c9955de25b1debc0650f s = new RC_40e7a439bb45c9955de25b1debc0650f();
  if(obj != null) {
  s.ssENApprovalProcessMatrix = ssConectaProveedores.RestRecords.RESTEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord.ToStructure(obj.AttrApprovalProcessMatrix);
  }
  return s;
}

public static Func<RC_40e7a439bb45c9955de25b1debc0650f, ssConectaProveedores.RestRecords.RESTRC_40e7a439bb45c9955de25b1debc0650f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_40e7a439bb45c9955de25b1debc0650f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_40e7a439bb45c9955de25b1debc0650f FromStructure(RC_40e7a439bb45c9955de25b1debc0650f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_40e7a439bb45c9955de25b1debc0650f(s, config);
}

}


