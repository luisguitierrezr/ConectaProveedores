using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUserExtensionRecord
public class RESTRC_e6a121d9e10463243528b9fbc6a71f2e : AbstractRESTStructure<RC_e6a121d9e10463243528b9fbc6a71f2e> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("UserExtension")]
public ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord AttrUserExtension;

public RESTRC_e6a121d9e10463243528b9fbc6a71f2e() { }

public RESTRC_e6a121d9e10463243528b9fbc6a71f2e (RC_e6a121d9e10463243528b9fbc6a71f2e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUserExtension = ConvertToRestWithoutDefaults(s.ssENUserExtension, new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUserExtension = ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure(s.ssENUserExtension, config);
  }
}

public static RC_e6a121d9e10463243528b9fbc6a71f2e ToStructure(ssConectaProveedores.RestRecords.RESTRC_e6a121d9e10463243528b9fbc6a71f2e obj) { 
  RC_e6a121d9e10463243528b9fbc6a71f2e s = new RC_e6a121d9e10463243528b9fbc6a71f2e();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENUserExtension = ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.ToStructure(obj.AttrUserExtension);
  }
  return s;
}

public static Func<RC_e6a121d9e10463243528b9fbc6a71f2e, ssConectaProveedores.RestRecords.RESTRC_e6a121d9e10463243528b9fbc6a71f2e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e6a121d9e10463243528b9fbc6a71f2e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e6a121d9e10463243528b9fbc6a71f2e FromStructure(RC_e6a121d9e10463243528b9fbc6a71f2e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e6a121d9e10463243528b9fbc6a71f2e(s, config);
}

}


