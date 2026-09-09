using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserApplicationRoleRecord
public class RESTRC_44a1416c6a0b117b6b7e5164f9d5147f : AbstractRESTStructure<RC_44a1416c6a0b117b6b7e5164f9d5147f> {
[JsonProperty("UserApplicationRole")]
public ssConectaProveedores.RestRecords.RESTEN_d70717a411b3cebe926da612400b1467EntityRecord AttrUserApplicationRole;

public RESTRC_44a1416c6a0b117b6b7e5164f9d5147f() { }

public RESTRC_44a1416c6a0b117b6b7e5164f9d5147f (RC_44a1416c6a0b117b6b7e5164f9d5147f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserApplicationRole = ConvertToRestWithoutDefaults(s.ssENUserApplicationRole, new EN_d70717a411b3cebe926da612400b1467EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure, config);
  } else {
AttrUserApplicationRole = ssConectaProveedores.RestRecords.RESTEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure(s.ssENUserApplicationRole, config);
  }
}

public static RC_44a1416c6a0b117b6b7e5164f9d5147f ToStructure(ssConectaProveedores.RestRecords.RESTRC_44a1416c6a0b117b6b7e5164f9d5147f obj) { 
  RC_44a1416c6a0b117b6b7e5164f9d5147f s = new RC_44a1416c6a0b117b6b7e5164f9d5147f();
  if(obj != null) {
  s.ssENUserApplicationRole = ssConectaProveedores.RestRecords.RESTEN_d70717a411b3cebe926da612400b1467EntityRecord.ToStructure(obj.AttrUserApplicationRole);
  }
  return s;
}

public static Func<RC_44a1416c6a0b117b6b7e5164f9d5147f, ssConectaProveedores.RestRecords.RESTRC_44a1416c6a0b117b6b7e5164f9d5147f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_44a1416c6a0b117b6b7e5164f9d5147f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_44a1416c6a0b117b6b7e5164f9d5147f FromStructure(RC_44a1416c6a0b117b6b7e5164f9d5147f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_44a1416c6a0b117b6b7e5164f9d5147f(s, config);
}

}


