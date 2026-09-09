using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AuditRecord
public class RESTRC_1549014643485d6d2fd0ba657a6961ac : AbstractRESTStructure<RC_1549014643485d6d2fd0ba657a6961ac> {
[JsonProperty("Audit")]
public ssConectaProveedores.RestRecords.RESTEN_fdc6adeb06d4944308e866b4240fd4efEntityRecord AttrAudit;

public RESTRC_1549014643485d6d2fd0ba657a6961ac() { }

public RESTRC_1549014643485d6d2fd0ba657a6961ac (RC_1549014643485d6d2fd0ba657a6961ac s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAudit = ConvertToRestWithoutDefaults(s.ssENAudit, new EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_fdc6adeb06d4944308e866b4240fd4efEntityRecord.FromStructure, config);
  } else {
AttrAudit = ssConectaProveedores.RestRecords.RESTEN_fdc6adeb06d4944308e866b4240fd4efEntityRecord.FromStructure(s.ssENAudit, config);
  }
}

public static RC_1549014643485d6d2fd0ba657a6961ac ToStructure(ssConectaProveedores.RestRecords.RESTRC_1549014643485d6d2fd0ba657a6961ac obj) { 
  RC_1549014643485d6d2fd0ba657a6961ac s = new RC_1549014643485d6d2fd0ba657a6961ac();
  if(obj != null) {
  s.ssENAudit = ssConectaProveedores.RestRecords.RESTEN_fdc6adeb06d4944308e866b4240fd4efEntityRecord.ToStructure(obj.AttrAudit);
  }
  return s;
}

public static Func<RC_1549014643485d6d2fd0ba657a6961ac, ssConectaProveedores.RestRecords.RESTRC_1549014643485d6d2fd0ba657a6961ac> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1549014643485d6d2fd0ba657a6961ac s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_1549014643485d6d2fd0ba657a6961ac FromStructure(RC_1549014643485d6d2fd0ba657a6961ac s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_1549014643485d6d2fd0ba657a6961ac(s, config);
}

}


