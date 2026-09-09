using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LinesReport63Record
public class JSONRC_c39f3c10ad99d866d1fba066291cd7c9 : AbstractRESTStructure<RC_c39f3c10ad99d866d1fba066291cd7c9> {
[JsonProperty("LinesReport63")]
[JsonPropertyName("LinesReport63")]
public ssConectaProveedores.RestRecords.JSONST_4d9dc458054302bbc44781a77ddc1e39Structure AttrLinesReport63;

public JSONRC_c39f3c10ad99d866d1fba066291cd7c9() { }

public JSONRC_c39f3c10ad99d866d1fba066291cd7c9 (RC_c39f3c10ad99d866d1fba066291cd7c9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLinesReport63 = ConvertToRestWithoutDefaults(s.ssSTLinesReport63, new ST_4d9dc458054302bbc44781a77ddc1e39Structure(), ssConectaProveedores.RestRecords.JSONST_4d9dc458054302bbc44781a77ddc1e39Structure.FromStructure, config);
  } else {
AttrLinesReport63 = ssConectaProveedores.RestRecords.JSONST_4d9dc458054302bbc44781a77ddc1e39Structure.FromStructure(s.ssSTLinesReport63, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c39f3c10ad99d866d1fba066291cd7c9, RC_c39f3c10ad99d866d1fba066291cd7c9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c39f3c10ad99d866d1fba066291cd7c9 s) => ToStructure(s, config);
}
public static RC_c39f3c10ad99d866d1fba066291cd7c9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_c39f3c10ad99d866d1fba066291cd7c9 obj, IBehaviorsConfiguration config) { 
  RC_c39f3c10ad99d866d1fba066291cd7c9 s = new RC_c39f3c10ad99d866d1fba066291cd7c9();
  if(obj != null) {
  s.ssSTLinesReport63 = ssConectaProveedores.RestRecords.JSONST_4d9dc458054302bbc44781a77ddc1e39Structure.ToStructure(obj.AttrLinesReport63, config);
  }
  return s;
}

public static Func<RC_c39f3c10ad99d866d1fba066291cd7c9, ssConectaProveedores.RestRecords.JSONRC_c39f3c10ad99d866d1fba066291cd7c9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c39f3c10ad99d866d1fba066291cd7c9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c39f3c10ad99d866d1fba066291cd7c9 FromStructure(RC_c39f3c10ad99d866d1fba066291cd7c9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c39f3c10ad99d866d1fba066291cd7c9(s, config);
}

}


