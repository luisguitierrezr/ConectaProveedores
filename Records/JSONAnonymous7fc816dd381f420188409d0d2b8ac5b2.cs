using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXFFIMF_CONTA_FACTURASRespRecord
public class JSONRC_8e7b41268a95e1ad7ec0b5b322dfb1e7 : AbstractRESTStructure<RC_8e7b41268a95e1ad7ec0b5b322dfb1e7> {
[JsonProperty("ZMXFFIMF_CONTA_FACTURASResp")]
[JsonPropertyName("ZMXFFIMF_CONTA_FACTURASResp")]
public ssConectaProveedores.RestRecords.JSONST_926df962559a6c34055113c885aa4885Structure AttrZMXFFIMF_CONTA_FACTURASResp;

public JSONRC_8e7b41268a95e1ad7ec0b5b322dfb1e7() { }

public JSONRC_8e7b41268a95e1ad7ec0b5b322dfb1e7 (RC_8e7b41268a95e1ad7ec0b5b322dfb1e7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXFFIMF_CONTA_FACTURASResp = ConvertToRestWithoutDefaults(s.ssSTZMXFFIMF_CONTA_FACTURASResp, new ST_926df962559a6c34055113c885aa4885Structure(), ssConectaProveedores.RestRecords.JSONST_926df962559a6c34055113c885aa4885Structure.FromStructure, config);
  } else {
AttrZMXFFIMF_CONTA_FACTURASResp = ssConectaProveedores.RestRecords.JSONST_926df962559a6c34055113c885aa4885Structure.FromStructure(s.ssSTZMXFFIMF_CONTA_FACTURASResp, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8e7b41268a95e1ad7ec0b5b322dfb1e7, RC_8e7b41268a95e1ad7ec0b5b322dfb1e7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8e7b41268a95e1ad7ec0b5b322dfb1e7 s) => ToStructure(s, config);
}
public static RC_8e7b41268a95e1ad7ec0b5b322dfb1e7 ToStructure(ssConectaProveedores.RestRecords.JSONRC_8e7b41268a95e1ad7ec0b5b322dfb1e7 obj, IBehaviorsConfiguration config) { 
  RC_8e7b41268a95e1ad7ec0b5b322dfb1e7 s = new RC_8e7b41268a95e1ad7ec0b5b322dfb1e7();
  if(obj != null) {
  s.ssSTZMXFFIMF_CONTA_FACTURASResp = ssConectaProveedores.RestRecords.JSONST_926df962559a6c34055113c885aa4885Structure.ToStructure(obj.AttrZMXFFIMF_CONTA_FACTURASResp, config);
  }
  return s;
}

public static Func<RC_8e7b41268a95e1ad7ec0b5b322dfb1e7, ssConectaProveedores.RestRecords.JSONRC_8e7b41268a95e1ad7ec0b5b322dfb1e7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8e7b41268a95e1ad7ec0b5b322dfb1e7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8e7b41268a95e1ad7ec0b5b322dfb1e7 FromStructure(RC_8e7b41268a95e1ad7ec0b5b322dfb1e7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8e7b41268a95e1ad7ec0b5b322dfb1e7(s, config);
}

}


