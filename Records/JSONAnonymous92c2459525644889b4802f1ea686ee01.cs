using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUserExtensionSupplierUserRecord
public class JSONRC_60b2ce7251b451294681274f8057cbd6 : AbstractRESTStructure<RC_60b2ce7251b451294681274f8057cbd6> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("UserExtension")]
[JsonPropertyName("UserExtension")]
public ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord AttrUserExtension;

[JsonProperty("SupplierUser")]
[JsonPropertyName("SupplierUser")]
public ssConectaProveedores.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord AttrSupplierUser;

public JSONRC_60b2ce7251b451294681274f8057cbd6() { }

public JSONRC_60b2ce7251b451294681274f8057cbd6 (RC_60b2ce7251b451294681274f8057cbd6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUserExtension = ConvertToRestWithoutDefaults(s.ssENUserExtension, new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure, config);
AttrSupplierUser = ConvertToRestWithoutDefaults(s.ssENSupplierUser, new EN_360367a38fba8439556dd1e5826e0428EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure(s.ssENUserExtension, config);
AttrSupplierUser = ssConectaProveedores.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure(s.ssENSupplierUser, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_60b2ce7251b451294681274f8057cbd6, RC_60b2ce7251b451294681274f8057cbd6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_60b2ce7251b451294681274f8057cbd6 s) => ToStructure(s, config);
}
public static RC_60b2ce7251b451294681274f8057cbd6 ToStructure(ssConectaProveedores.RestRecords.JSONRC_60b2ce7251b451294681274f8057cbd6 obj, IBehaviorsConfiguration config) { 
  RC_60b2ce7251b451294681274f8057cbd6 s = new RC_60b2ce7251b451294681274f8057cbd6();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.ToStructure(obj.AttrUserExtension, config);
  s.ssENSupplierUser = ssConectaProveedores.RestRecords.JSONEN_360367a38fba8439556dd1e5826e0428EntityRecord.ToStructure(obj.AttrSupplierUser, config);
  }
  return s;
}

public static Func<RC_60b2ce7251b451294681274f8057cbd6, ssConectaProveedores.RestRecords.JSONRC_60b2ce7251b451294681274f8057cbd6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_60b2ce7251b451294681274f8057cbd6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_60b2ce7251b451294681274f8057cbd6 FromStructure(RC_60b2ce7251b451294681274f8057cbd6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_60b2ce7251b451294681274f8057cbd6(s, config);
}

}


