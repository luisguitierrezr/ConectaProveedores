using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AIRoleRecord
public class JSONRC_ed6dfadde1ed7fb74003b4bf09b19473 : AbstractRESTStructure<RC_ed6dfadde1ed7fb74003b4bf09b19473> {
[JsonProperty("AIRole")]
[JsonPropertyName("AIRole")]
public ssConectaProveedores.RestRecords.JSONENAIRoleEntityRecord AttrAIRole;

public JSONRC_ed6dfadde1ed7fb74003b4bf09b19473() { }

public JSONRC_ed6dfadde1ed7fb74003b4bf09b19473 (RC_ed6dfadde1ed7fb74003b4bf09b19473 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIRole = ConvertToRestWithoutDefaults(s.ssENAIRole, new ENAIRoleEntityRecord(), ssConectaProveedores.RestRecords.JSONENAIRoleEntityRecord.FromStructure, config);
  } else {
AttrAIRole = ssConectaProveedores.RestRecords.JSONENAIRoleEntityRecord.FromStructure(s.ssENAIRole, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ed6dfadde1ed7fb74003b4bf09b19473, RC_ed6dfadde1ed7fb74003b4bf09b19473> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ed6dfadde1ed7fb74003b4bf09b19473 s) => ToStructure(s, config);
}
public static RC_ed6dfadde1ed7fb74003b4bf09b19473 ToStructure(ssConectaProveedores.RestRecords.JSONRC_ed6dfadde1ed7fb74003b4bf09b19473 obj, IBehaviorsConfiguration config) { 
  RC_ed6dfadde1ed7fb74003b4bf09b19473 s = new RC_ed6dfadde1ed7fb74003b4bf09b19473();
  if(obj != null) {
  s.ssENAIRole = ssConectaProveedores.RestRecords.JSONENAIRoleEntityRecord.ToStructure(obj.AttrAIRole, config);
  }
  return s;
}

public static Func<RC_ed6dfadde1ed7fb74003b4bf09b19473, ssConectaProveedores.RestRecords.JSONRC_ed6dfadde1ed7fb74003b4bf09b19473> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ed6dfadde1ed7fb74003b4bf09b19473 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ed6dfadde1ed7fb74003b4bf09b19473 FromStructure(RC_ed6dfadde1ed7fb74003b4bf09b19473 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ed6dfadde1ed7fb74003b4bf09b19473(s, config);
}

}


