using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RegionRecord
public class JSONRC_deb85dc36640fa928dae5df2493065d0 : AbstractRESTStructure<RC_deb85dc36640fa928dae5df2493065d0> {
[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_deb85dc36640fa928dae5df2493065d0() { }

public JSONRC_deb85dc36640fa928dae5df2493065d0 (RC_deb85dc36640fa928dae5df2493065d0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_deb85dc36640fa928dae5df2493065d0, RC_deb85dc36640fa928dae5df2493065d0> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_deb85dc36640fa928dae5df2493065d0 s) => ToStructure(s, config);
}
public static RC_deb85dc36640fa928dae5df2493065d0 ToStructure(ssConectaProveedores.RestRecords.JSONRC_deb85dc36640fa928dae5df2493065d0 obj, IBehaviorsConfiguration config) { 
  RC_deb85dc36640fa928dae5df2493065d0 s = new RC_deb85dc36640fa928dae5df2493065d0();
  if(obj != null) {
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_deb85dc36640fa928dae5df2493065d0, ssConectaProveedores.RestRecords.JSONRC_deb85dc36640fa928dae5df2493065d0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_deb85dc36640fa928dae5df2493065d0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_deb85dc36640fa928dae5df2493065d0 FromStructure(RC_deb85dc36640fa928dae5df2493065d0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_deb85dc36640fa928dae5df2493065d0(s, config);
}

}


