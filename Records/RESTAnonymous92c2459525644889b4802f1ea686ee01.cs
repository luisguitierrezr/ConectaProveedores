using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUserExtensionSupplierUserRecord
public class RESTRC_60b2ce7251b451294681274f8057cbd6 : AbstractRESTStructure<RC_60b2ce7251b451294681274f8057cbd6> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("UserExtension")]
public ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord AttrUserExtension;

[JsonProperty("SupplierUser")]
public ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord AttrSupplierUser;

public RESTRC_60b2ce7251b451294681274f8057cbd6() { }

public RESTRC_60b2ce7251b451294681274f8057cbd6 (RC_60b2ce7251b451294681274f8057cbd6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUserExtension = ConvertToRestWithoutDefaults(s.ssENUserExtension, new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure, config);
AttrSupplierUser = ConvertToRestWithoutDefaults(s.ssENSupplierUser, new EN_360367a38fba8439556dd1e5826e0428EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUserExtension = ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure(s.ssENUserExtension, config);
AttrSupplierUser = ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure(s.ssENSupplierUser, config);
  }
}

public static RC_60b2ce7251b451294681274f8057cbd6 ToStructure(ssConectaProveedores.RestRecords.RESTRC_60b2ce7251b451294681274f8057cbd6 obj) { 
  RC_60b2ce7251b451294681274f8057cbd6 s = new RC_60b2ce7251b451294681274f8057cbd6();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENUserExtension = ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.ToStructure(obj.AttrUserExtension);
  s.ssENSupplierUser = ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord.ToStructure(obj.AttrSupplierUser);
  }
  return s;
}

public static Func<RC_60b2ce7251b451294681274f8057cbd6, ssConectaProveedores.RestRecords.RESTRC_60b2ce7251b451294681274f8057cbd6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_60b2ce7251b451294681274f8057cbd6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_60b2ce7251b451294681274f8057cbd6 FromStructure(RC_60b2ce7251b451294681274f8057cbd6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_60b2ce7251b451294681274f8057cbd6(s, config);
}

}


