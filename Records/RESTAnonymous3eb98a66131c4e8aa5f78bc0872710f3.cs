using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LinesReport63Record
public class RESTRC_c39f3c10ad99d866d1fba066291cd7c9 : AbstractRESTStructure<RC_c39f3c10ad99d866d1fba066291cd7c9> {
[JsonProperty("LinesReport63")]
public ssConectaProveedores.RestRecords.RESTST_4d9dc458054302bbc44781a77ddc1e39Structure AttrLinesReport63;

public RESTRC_c39f3c10ad99d866d1fba066291cd7c9() { }

public RESTRC_c39f3c10ad99d866d1fba066291cd7c9 (RC_c39f3c10ad99d866d1fba066291cd7c9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLinesReport63 = ConvertToRestWithoutDefaults(s.ssSTLinesReport63, new ST_4d9dc458054302bbc44781a77ddc1e39Structure(), ssConectaProveedores.RestRecords.RESTST_4d9dc458054302bbc44781a77ddc1e39Structure.FromStructure, config);
  } else {
AttrLinesReport63 = ssConectaProveedores.RestRecords.RESTST_4d9dc458054302bbc44781a77ddc1e39Structure.FromStructure(s.ssSTLinesReport63, config);
  }
}

public static RC_c39f3c10ad99d866d1fba066291cd7c9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_c39f3c10ad99d866d1fba066291cd7c9 obj) { 
  RC_c39f3c10ad99d866d1fba066291cd7c9 s = new RC_c39f3c10ad99d866d1fba066291cd7c9();
  if(obj != null) {
  s.ssSTLinesReport63 = ssConectaProveedores.RestRecords.RESTST_4d9dc458054302bbc44781a77ddc1e39Structure.ToStructure(obj.AttrLinesReport63);
  }
  return s;
}

public static Func<RC_c39f3c10ad99d866d1fba066291cd7c9, ssConectaProveedores.RestRecords.RESTRC_c39f3c10ad99d866d1fba066291cd7c9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c39f3c10ad99d866d1fba066291cd7c9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c39f3c10ad99d866d1fba066291cd7c9 FromStructure(RC_c39f3c10ad99d866d1fba066291cd7c9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c39f3c10ad99d866d1fba066291cd7c9(s, config);
}

}


