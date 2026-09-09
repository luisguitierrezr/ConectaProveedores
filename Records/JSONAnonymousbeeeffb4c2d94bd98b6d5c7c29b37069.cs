using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUserExtensionRecord
public class JSONRC_e6a121d9e10463243528b9fbc6a71f2e : AbstractRESTStructure<RC_e6a121d9e10463243528b9fbc6a71f2e> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("UserExtension")]
[JsonPropertyName("UserExtension")]
public ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord AttrUserExtension;

public JSONRC_e6a121d9e10463243528b9fbc6a71f2e() { }

public JSONRC_e6a121d9e10463243528b9fbc6a71f2e (RC_e6a121d9e10463243528b9fbc6a71f2e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUserExtension = ConvertToRestWithoutDefaults(s.ssENUserExtension, new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure(s.ssENUserExtension, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e6a121d9e10463243528b9fbc6a71f2e, RC_e6a121d9e10463243528b9fbc6a71f2e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e6a121d9e10463243528b9fbc6a71f2e s) => ToStructure(s, config);
}
public static RC_e6a121d9e10463243528b9fbc6a71f2e ToStructure(ssConectaProveedores.RestRecords.JSONRC_e6a121d9e10463243528b9fbc6a71f2e obj, IBehaviorsConfiguration config) { 
  RC_e6a121d9e10463243528b9fbc6a71f2e s = new RC_e6a121d9e10463243528b9fbc6a71f2e();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.ToStructure(obj.AttrUserExtension, config);
  }
  return s;
}

public static Func<RC_e6a121d9e10463243528b9fbc6a71f2e, ssConectaProveedores.RestRecords.JSONRC_e6a121d9e10463243528b9fbc6a71f2e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e6a121d9e10463243528b9fbc6a71f2e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e6a121d9e10463243528b9fbc6a71f2e FromStructure(RC_e6a121d9e10463243528b9fbc6a71f2e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e6a121d9e10463243528b9fbc6a71f2e(s, config);
}

}


