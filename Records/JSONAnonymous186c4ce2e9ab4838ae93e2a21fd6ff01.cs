using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TO_RESULTADO_InRecord
public class JSONRC_4e56da462177bd5a32125e4b7b238f14 : AbstractRESTStructure<RC_4e56da462177bd5a32125e4b7b238f14> {
[JsonProperty("TO_RESULTADO_In")]
[JsonPropertyName("TO_RESULTADO_In")]
public ssConectaProveedores.RestRecords.JSONST_1881d7eeaa3bae99e7aa7a6ecb977980Structure AttrTO_RESULTADO_In;

public JSONRC_4e56da462177bd5a32125e4b7b238f14() { }

public JSONRC_4e56da462177bd5a32125e4b7b238f14 (RC_4e56da462177bd5a32125e4b7b238f14 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTO_RESULTADO_In = ConvertToRestWithoutDefaults(s.ssSTTO_RESULTADO_In, new ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure(), ssConectaProveedores.RestRecords.JSONST_1881d7eeaa3bae99e7aa7a6ecb977980Structure.FromStructure, config);
  } else {
AttrTO_RESULTADO_In = ssConectaProveedores.RestRecords.JSONST_1881d7eeaa3bae99e7aa7a6ecb977980Structure.FromStructure(s.ssSTTO_RESULTADO_In, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_4e56da462177bd5a32125e4b7b238f14, RC_4e56da462177bd5a32125e4b7b238f14> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_4e56da462177bd5a32125e4b7b238f14 s) => ToStructure(s, config);
}
public static RC_4e56da462177bd5a32125e4b7b238f14 ToStructure(ssConectaProveedores.RestRecords.JSONRC_4e56da462177bd5a32125e4b7b238f14 obj, IBehaviorsConfiguration config) { 
  RC_4e56da462177bd5a32125e4b7b238f14 s = new RC_4e56da462177bd5a32125e4b7b238f14();
  if(obj != null) {
  s.ssSTTO_RESULTADO_In = ssConectaProveedores.RestRecords.JSONST_1881d7eeaa3bae99e7aa7a6ecb977980Structure.ToStructure(obj.AttrTO_RESULTADO_In, config);
  }
  return s;
}

public static Func<RC_4e56da462177bd5a32125e4b7b238f14, ssConectaProveedores.RestRecords.JSONRC_4e56da462177bd5a32125e4b7b238f14> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4e56da462177bd5a32125e4b7b238f14 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_4e56da462177bd5a32125e4b7b238f14 FromStructure(RC_4e56da462177bd5a32125e4b7b238f14 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_4e56da462177bd5a32125e4b7b238f14(s, config);
}

}


