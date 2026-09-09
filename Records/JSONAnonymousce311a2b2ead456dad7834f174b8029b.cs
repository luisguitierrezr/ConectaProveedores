using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AuditRecord
public class JSONRC_1549014643485d6d2fd0ba657a6961ac : AbstractRESTStructure<RC_1549014643485d6d2fd0ba657a6961ac> {
[JsonProperty("Audit")]
[JsonPropertyName("Audit")]
public ssConectaProveedores.RestRecords.JSONEN_fdc6adeb06d4944308e866b4240fd4efEntityRecord AttrAudit;

public JSONRC_1549014643485d6d2fd0ba657a6961ac() { }

public JSONRC_1549014643485d6d2fd0ba657a6961ac (RC_1549014643485d6d2fd0ba657a6961ac s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAudit = ConvertToRestWithoutDefaults(s.ssENAudit, new EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_fdc6adeb06d4944308e866b4240fd4efEntityRecord.FromStructure, config);
  } else {
AttrAudit = ssConectaProveedores.RestRecords.JSONEN_fdc6adeb06d4944308e866b4240fd4efEntityRecord.FromStructure(s.ssENAudit, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1549014643485d6d2fd0ba657a6961ac, RC_1549014643485d6d2fd0ba657a6961ac> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1549014643485d6d2fd0ba657a6961ac s) => ToStructure(s, config);
}
public static RC_1549014643485d6d2fd0ba657a6961ac ToStructure(ssConectaProveedores.RestRecords.JSONRC_1549014643485d6d2fd0ba657a6961ac obj, IBehaviorsConfiguration config) { 
  RC_1549014643485d6d2fd0ba657a6961ac s = new RC_1549014643485d6d2fd0ba657a6961ac();
  if(obj != null) {
  s.ssENAudit = ssConectaProveedores.RestRecords.JSONEN_fdc6adeb06d4944308e866b4240fd4efEntityRecord.ToStructure(obj.AttrAudit, config);
  }
  return s;
}

public static Func<RC_1549014643485d6d2fd0ba657a6961ac, ssConectaProveedores.RestRecords.JSONRC_1549014643485d6d2fd0ba657a6961ac> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1549014643485d6d2fd0ba657a6961ac s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1549014643485d6d2fd0ba657a6961ac FromStructure(RC_1549014643485d6d2fd0ba657a6961ac s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1549014643485d6d2fd0ba657a6961ac(s, config);
}

}


