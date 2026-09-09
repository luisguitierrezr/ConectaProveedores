using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// T_FACT_PEN_PAG_InRecord
public class JSONRC_1c505a8024c41aaa0d011f8eb7450033 : AbstractRESTStructure<RC_1c505a8024c41aaa0d011f8eb7450033> {
[JsonProperty("T_FACT_PEN_PAG_In")]
[JsonPropertyName("T_FACT_PEN_PAG_In")]
public ssConectaProveedores.RestRecords.JSONST_0310bb62d750573571d23e0cd61c55b3Structure AttrT_FACT_PEN_PAG_In;

public JSONRC_1c505a8024c41aaa0d011f8eb7450033() { }

public JSONRC_1c505a8024c41aaa0d011f8eb7450033 (RC_1c505a8024c41aaa0d011f8eb7450033 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrT_FACT_PEN_PAG_In = ConvertToRestWithoutDefaults(s.ssSTT_FACT_PEN_PAG_In, new ST_0310bb62d750573571d23e0cd61c55b3Structure(), ssConectaProveedores.RestRecords.JSONST_0310bb62d750573571d23e0cd61c55b3Structure.FromStructure, config);
  } else {
AttrT_FACT_PEN_PAG_In = ssConectaProveedores.RestRecords.JSONST_0310bb62d750573571d23e0cd61c55b3Structure.FromStructure(s.ssSTT_FACT_PEN_PAG_In, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1c505a8024c41aaa0d011f8eb7450033, RC_1c505a8024c41aaa0d011f8eb7450033> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1c505a8024c41aaa0d011f8eb7450033 s) => ToStructure(s, config);
}
public static RC_1c505a8024c41aaa0d011f8eb7450033 ToStructure(ssConectaProveedores.RestRecords.JSONRC_1c505a8024c41aaa0d011f8eb7450033 obj, IBehaviorsConfiguration config) { 
  RC_1c505a8024c41aaa0d011f8eb7450033 s = new RC_1c505a8024c41aaa0d011f8eb7450033();
  if(obj != null) {
  s.ssSTT_FACT_PEN_PAG_In = ssConectaProveedores.RestRecords.JSONST_0310bb62d750573571d23e0cd61c55b3Structure.ToStructure(obj.AttrT_FACT_PEN_PAG_In, config);
  }
  return s;
}

public static Func<RC_1c505a8024c41aaa0d011f8eb7450033, ssConectaProveedores.RestRecords.JSONRC_1c505a8024c41aaa0d011f8eb7450033> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1c505a8024c41aaa0d011f8eb7450033 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1c505a8024c41aaa0d011f8eb7450033 FromStructure(RC_1c505a8024c41aaa0d011f8eb7450033 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1c505a8024c41aaa0d011f8eb7450033(s, config);
}

}


