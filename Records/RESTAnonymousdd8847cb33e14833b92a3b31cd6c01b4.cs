using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ItemEM_RMRecord
public class RESTRC_715f3e88ae56d2a37280e6d709b67948 : AbstractRESTStructure<RC_715f3e88ae56d2a37280e6d709b67948> {
[JsonProperty("ItemEM_RM")]
public ssConectaProveedores.RestRecords.RESTST_121fe028e1d357d74e80a524b7b1ba16Structure AttrItemEM_RM;

public RESTRC_715f3e88ae56d2a37280e6d709b67948() { }

public RESTRC_715f3e88ae56d2a37280e6d709b67948 (RC_715f3e88ae56d2a37280e6d709b67948 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItemEM_RM = ConvertToRestWithoutDefaults(s.ssSTItemEM_RM, new ST_121fe028e1d357d74e80a524b7b1ba16Structure(), ssConectaProveedores.RestRecords.RESTST_121fe028e1d357d74e80a524b7b1ba16Structure.FromStructure, config);
  } else {
AttrItemEM_RM = ssConectaProveedores.RestRecords.RESTST_121fe028e1d357d74e80a524b7b1ba16Structure.FromStructure(s.ssSTItemEM_RM, config);
  }
}

public static RC_715f3e88ae56d2a37280e6d709b67948 ToStructure(ssConectaProveedores.RestRecords.RESTRC_715f3e88ae56d2a37280e6d709b67948 obj) { 
  RC_715f3e88ae56d2a37280e6d709b67948 s = new RC_715f3e88ae56d2a37280e6d709b67948();
  if(obj != null) {
  s.ssSTItemEM_RM = ssConectaProveedores.RestRecords.RESTST_121fe028e1d357d74e80a524b7b1ba16Structure.ToStructure(obj.AttrItemEM_RM);
  }
  return s;
}

public static Func<RC_715f3e88ae56d2a37280e6d709b67948, ssConectaProveedores.RestRecords.RESTRC_715f3e88ae56d2a37280e6d709b67948> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_715f3e88ae56d2a37280e6d709b67948 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_715f3e88ae56d2a37280e6d709b67948 FromStructure(RC_715f3e88ae56d2a37280e6d709b67948 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_715f3e88ae56d2a37280e6d709b67948(s, config);
}

}


