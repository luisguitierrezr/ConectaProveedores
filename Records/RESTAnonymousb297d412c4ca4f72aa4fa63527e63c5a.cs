using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RegionRecord
public class RESTRC_deb85dc36640fa928dae5df2493065d0 : AbstractRESTStructure<RC_deb85dc36640fa928dae5df2493065d0> {
[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_deb85dc36640fa928dae5df2493065d0() { }

public RESTRC_deb85dc36640fa928dae5df2493065d0 (RC_deb85dc36640fa928dae5df2493065d0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_deb85dc36640fa928dae5df2493065d0 ToStructure(ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0 obj) { 
  RC_deb85dc36640fa928dae5df2493065d0 s = new RC_deb85dc36640fa928dae5df2493065d0();
  if(obj != null) {
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_deb85dc36640fa928dae5df2493065d0, ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_deb85dc36640fa928dae5df2493065d0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0 FromStructure(RC_deb85dc36640fa928dae5df2493065d0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0(s, config);
}

}


