using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// T_FACT_PEN_PAG_OutRecord
public class JSONRC_4211d0c81727d9df025d8205e67ad09b : AbstractRESTStructure<RC_4211d0c81727d9df025d8205e67ad09b> {
[JsonProperty("T_FACT_PEN_PAG_Out")]
[JsonPropertyName("T_FACT_PEN_PAG_Out")]
public ssConectaProveedores.RestRecords.JSONST_9f44b824af1405b8fbe038a5a393bb86Structure AttrT_FACT_PEN_PAG_Out;

public JSONRC_4211d0c81727d9df025d8205e67ad09b() { }

public JSONRC_4211d0c81727d9df025d8205e67ad09b (RC_4211d0c81727d9df025d8205e67ad09b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrT_FACT_PEN_PAG_Out = ConvertToRestWithoutDefaults(s.ssSTT_FACT_PEN_PAG_Out, new ST_9f44b824af1405b8fbe038a5a393bb86Structure(), ssConectaProveedores.RestRecords.JSONST_9f44b824af1405b8fbe038a5a393bb86Structure.FromStructure, config);
  } else {
AttrT_FACT_PEN_PAG_Out = ssConectaProveedores.RestRecords.JSONST_9f44b824af1405b8fbe038a5a393bb86Structure.FromStructure(s.ssSTT_FACT_PEN_PAG_Out, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_4211d0c81727d9df025d8205e67ad09b, RC_4211d0c81727d9df025d8205e67ad09b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_4211d0c81727d9df025d8205e67ad09b s) => ToStructure(s, config);
}
public static RC_4211d0c81727d9df025d8205e67ad09b ToStructure(ssConectaProveedores.RestRecords.JSONRC_4211d0c81727d9df025d8205e67ad09b obj, IBehaviorsConfiguration config) { 
  RC_4211d0c81727d9df025d8205e67ad09b s = new RC_4211d0c81727d9df025d8205e67ad09b();
  if(obj != null) {
  s.ssSTT_FACT_PEN_PAG_Out = ssConectaProveedores.RestRecords.JSONST_9f44b824af1405b8fbe038a5a393bb86Structure.ToStructure(obj.AttrT_FACT_PEN_PAG_Out, config);
  }
  return s;
}

public static Func<RC_4211d0c81727d9df025d8205e67ad09b, ssConectaProveedores.RestRecords.JSONRC_4211d0c81727d9df025d8205e67ad09b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4211d0c81727d9df025d8205e67ad09b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_4211d0c81727d9df025d8205e67ad09b FromStructure(RC_4211d0c81727d9df025d8205e67ad09b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_4211d0c81727d9df025d8205e67ad09b(s, config);
}

}


