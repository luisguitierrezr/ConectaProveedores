using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Entra_Workflow_UserlistRecord
public class JSONRC_8829c69b982d43adb31362f6b3095470 : AbstractRESTStructure<RC_8829c69b982d43adb31362f6b3095470> {
[JsonProperty("Entra_Workflow_Userlist")]
[JsonPropertyName("Entra_Workflow_Userlist")]
public ssConectaProveedores.RestRecords.JSONST_34625f5643caa3d12448dcec7dd4c7d3Structure AttrEntra_Workflow_Userlist;

public JSONRC_8829c69b982d43adb31362f6b3095470() { }

public JSONRC_8829c69b982d43adb31362f6b3095470 (RC_8829c69b982d43adb31362f6b3095470 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEntra_Workflow_Userlist = ConvertToRestWithoutDefaults(s.ssSTEntra_Workflow_Userlist, new ST_34625f5643caa3d12448dcec7dd4c7d3Structure(), ssConectaProveedores.RestRecords.JSONST_34625f5643caa3d12448dcec7dd4c7d3Structure.FromStructure, config);
  } else {
AttrEntra_Workflow_Userlist = ssConectaProveedores.RestRecords.JSONST_34625f5643caa3d12448dcec7dd4c7d3Structure.FromStructure(s.ssSTEntra_Workflow_Userlist, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8829c69b982d43adb31362f6b3095470, RC_8829c69b982d43adb31362f6b3095470> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8829c69b982d43adb31362f6b3095470 s) => ToStructure(s, config);
}
public static RC_8829c69b982d43adb31362f6b3095470 ToStructure(ssConectaProveedores.RestRecords.JSONRC_8829c69b982d43adb31362f6b3095470 obj, IBehaviorsConfiguration config) { 
  RC_8829c69b982d43adb31362f6b3095470 s = new RC_8829c69b982d43adb31362f6b3095470();
  if(obj != null) {
  s.ssSTEntra_Workflow_Userlist = ssConectaProveedores.RestRecords.JSONST_34625f5643caa3d12448dcec7dd4c7d3Structure.ToStructure(obj.AttrEntra_Workflow_Userlist, config);
  }
  return s;
}

public static Func<RC_8829c69b982d43adb31362f6b3095470, ssConectaProveedores.RestRecords.JSONRC_8829c69b982d43adb31362f6b3095470> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8829c69b982d43adb31362f6b3095470 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8829c69b982d43adb31362f6b3095470 FromStructure(RC_8829c69b982d43adb31362f6b3095470 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8829c69b982d43adb31362f6b3095470(s, config);
}

}


