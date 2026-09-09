using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ItemEM_RMRecord
public class JSONRC_715f3e88ae56d2a37280e6d709b67948 : AbstractRESTStructure<RC_715f3e88ae56d2a37280e6d709b67948> {
[JsonProperty("ItemEM_RM")]
[JsonPropertyName("ItemEM_RM")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_121fe028e1d357d74e80a524b7b1ba16Structure AttrItemEM_RM;

public JSONRC_715f3e88ae56d2a37280e6d709b67948() { }

public JSONRC_715f3e88ae56d2a37280e6d709b67948 (RC_715f3e88ae56d2a37280e6d709b67948 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItemEM_RM = ConvertToRestWithoutDefaults(s.ssSTItemEM_RM, new ST_121fe028e1d357d74e80a524b7b1ba16Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_121fe028e1d357d74e80a524b7b1ba16Structure.FromStructure, config);
  } else {
AttrItemEM_RM = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_121fe028e1d357d74e80a524b7b1ba16Structure.FromStructure(s.ssSTItemEM_RM, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_715f3e88ae56d2a37280e6d709b67948, RC_715f3e88ae56d2a37280e6d709b67948> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_715f3e88ae56d2a37280e6d709b67948 s) => ToStructure(s, config);
}
public static RC_715f3e88ae56d2a37280e6d709b67948 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_715f3e88ae56d2a37280e6d709b67948 obj, IBehaviorsConfiguration config) { 
  RC_715f3e88ae56d2a37280e6d709b67948 s = new RC_715f3e88ae56d2a37280e6d709b67948();
  if(obj != null) {
  s.ssSTItemEM_RM = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_121fe028e1d357d74e80a524b7b1ba16Structure.ToStructure(obj.AttrItemEM_RM, config);
  }
  return s;
}

public static Func<RC_715f3e88ae56d2a37280e6d709b67948, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_715f3e88ae56d2a37280e6d709b67948> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_715f3e88ae56d2a37280e6d709b67948 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_715f3e88ae56d2a37280e6d709b67948 FromStructure(RC_715f3e88ae56d2a37280e6d709b67948 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_715f3e88ae56d2a37280e6d709b67948(s, config);
}

}


