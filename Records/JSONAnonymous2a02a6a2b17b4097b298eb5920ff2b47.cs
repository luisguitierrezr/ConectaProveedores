using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserExtensionRecord
public class JSONRC_620c1ad5411dbb3ddbe0616529c19a2e : AbstractRESTStructure<RC_620c1ad5411dbb3ddbe0616529c19a2e> {
[JsonProperty("UserExtension")]
[JsonPropertyName("UserExtension")]
public ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord AttrUserExtension;

public JSONRC_620c1ad5411dbb3ddbe0616529c19a2e() { }

public JSONRC_620c1ad5411dbb3ddbe0616529c19a2e (RC_620c1ad5411dbb3ddbe0616529c19a2e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserExtension = ConvertToRestWithoutDefaults(s.ssENUserExtension, new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure, config);
  } else {
AttrUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure(s.ssENUserExtension, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_620c1ad5411dbb3ddbe0616529c19a2e, RC_620c1ad5411dbb3ddbe0616529c19a2e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_620c1ad5411dbb3ddbe0616529c19a2e s) => ToStructure(s, config);
}
public static RC_620c1ad5411dbb3ddbe0616529c19a2e ToStructure(ssConectaProveedores.RestRecords.JSONRC_620c1ad5411dbb3ddbe0616529c19a2e obj, IBehaviorsConfiguration config) { 
  RC_620c1ad5411dbb3ddbe0616529c19a2e s = new RC_620c1ad5411dbb3ddbe0616529c19a2e();
  if(obj != null) {
  s.ssENUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.ToStructure(obj.AttrUserExtension, config);
  }
  return s;
}

public static Func<RC_620c1ad5411dbb3ddbe0616529c19a2e, ssConectaProveedores.RestRecords.JSONRC_620c1ad5411dbb3ddbe0616529c19a2e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_620c1ad5411dbb3ddbe0616529c19a2e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_620c1ad5411dbb3ddbe0616529c19a2e FromStructure(RC_620c1ad5411dbb3ddbe0616529c19a2e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_620c1ad5411dbb3ddbe0616529c19a2e(s, config);
}

}


