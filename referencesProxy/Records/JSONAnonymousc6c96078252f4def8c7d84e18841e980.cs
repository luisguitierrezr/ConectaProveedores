using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// UserApplicationRoleRecord
public class JSONRC_44a1416c6a0b117b6b7e5164f9d5147f : AbstractRESTStructure<RC_44a1416c6a0b117b6b7e5164f9d5147f> {
[JsonProperty("UserApplicationRole")]
[JsonPropertyName("UserApplicationRole")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord AttrUserApplicationRole;

public JSONRC_44a1416c6a0b117b6b7e5164f9d5147f() { }

public JSONRC_44a1416c6a0b117b6b7e5164f9d5147f (RC_44a1416c6a0b117b6b7e5164f9d5147f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserApplicationRole = ConvertToRestWithoutDefaults(s.ssENUserApplicationRole, new EN_d70717a411b3cebe926da612400b1467EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure, config);
  } else {
AttrUserApplicationRole = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure(s.ssENUserApplicationRole, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_44a1416c6a0b117b6b7e5164f9d5147f, RC_44a1416c6a0b117b6b7e5164f9d5147f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_44a1416c6a0b117b6b7e5164f9d5147f s) => ToStructure(s, config);
}
public static RC_44a1416c6a0b117b6b7e5164f9d5147f ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_44a1416c6a0b117b6b7e5164f9d5147f obj, IBehaviorsConfiguration config) { 
  RC_44a1416c6a0b117b6b7e5164f9d5147f s = new RC_44a1416c6a0b117b6b7e5164f9d5147f();
  if(obj != null) {
  s.ssENUserApplicationRole = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.ToStructure(obj.AttrUserApplicationRole, config);
  }
  return s;
}

public static Func<RC_44a1416c6a0b117b6b7e5164f9d5147f, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_44a1416c6a0b117b6b7e5164f9d5147f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_44a1416c6a0b117b6b7e5164f9d5147f s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_44a1416c6a0b117b6b7e5164f9d5147f FromStructure(RC_44a1416c6a0b117b6b7e5164f9d5147f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_44a1416c6a0b117b6b7e5164f9d5147f(s, config);
}

}


