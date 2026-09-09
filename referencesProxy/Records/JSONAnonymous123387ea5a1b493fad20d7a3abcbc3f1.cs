using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// T_FAC_PAG_CAB_InRecord
public class JSONRC_14a12c4391e73b0f0f3e412d9ecca347 : AbstractRESTStructure<RC_14a12c4391e73b0f0f3e412d9ecca347> {
[JsonProperty("T_FAC_PAG_CAB_In")]
[JsonPropertyName("T_FAC_PAG_CAB_In")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_828ac715d3b2e46c74367f017543eab1Structure AttrT_FAC_PAG_CAB_In;

public JSONRC_14a12c4391e73b0f0f3e412d9ecca347() { }

public JSONRC_14a12c4391e73b0f0f3e412d9ecca347 (RC_14a12c4391e73b0f0f3e412d9ecca347 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrT_FAC_PAG_CAB_In = ConvertToRestWithoutDefaults(s.ssSTT_FAC_PAG_CAB_In, new ST_828ac715d3b2e46c74367f017543eab1Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_828ac715d3b2e46c74367f017543eab1Structure.FromStructure, config);
  } else {
AttrT_FAC_PAG_CAB_In = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_828ac715d3b2e46c74367f017543eab1Structure.FromStructure(s.ssSTT_FAC_PAG_CAB_In, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_14a12c4391e73b0f0f3e412d9ecca347, RC_14a12c4391e73b0f0f3e412d9ecca347> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_14a12c4391e73b0f0f3e412d9ecca347 s) => ToStructure(s, config);
}
public static RC_14a12c4391e73b0f0f3e412d9ecca347 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_14a12c4391e73b0f0f3e412d9ecca347 obj, IBehaviorsConfiguration config) { 
  RC_14a12c4391e73b0f0f3e412d9ecca347 s = new RC_14a12c4391e73b0f0f3e412d9ecca347();
  if(obj != null) {
  s.ssSTT_FAC_PAG_CAB_In = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_828ac715d3b2e46c74367f017543eab1Structure.ToStructure(obj.AttrT_FAC_PAG_CAB_In, config);
  }
  return s;
}

public static Func<RC_14a12c4391e73b0f0f3e412d9ecca347, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_14a12c4391e73b0f0f3e412d9ecca347> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_14a12c4391e73b0f0f3e412d9ecca347 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_14a12c4391e73b0f0f3e412d9ecca347 FromStructure(RC_14a12c4391e73b0f0f3e412d9ecca347 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_14a12c4391e73b0f0f3e412d9ecca347(s, config);
}

}


