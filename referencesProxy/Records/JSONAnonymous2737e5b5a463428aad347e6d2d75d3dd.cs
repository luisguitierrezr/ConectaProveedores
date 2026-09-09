using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// T_DAT_PROV_OutRecord
public class JSONRC_9d0f900078fdcea91c0916976b02ff7f : AbstractRESTStructure<RC_9d0f900078fdcea91c0916976b02ff7f> {
[JsonProperty("T_DAT_PROV_Out")]
[JsonPropertyName("T_DAT_PROV_Out")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_4639a265770186863b3ecaeafd29fb96Structure AttrT_DAT_PROV_Out;

public JSONRC_9d0f900078fdcea91c0916976b02ff7f() { }

public JSONRC_9d0f900078fdcea91c0916976b02ff7f (RC_9d0f900078fdcea91c0916976b02ff7f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrT_DAT_PROV_Out = ConvertToRestWithoutDefaults(s.ssSTT_DAT_PROV_Out, new ST_4639a265770186863b3ecaeafd29fb96Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_4639a265770186863b3ecaeafd29fb96Structure.FromStructure, config);
  } else {
AttrT_DAT_PROV_Out = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_4639a265770186863b3ecaeafd29fb96Structure.FromStructure(s.ssSTT_DAT_PROV_Out, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_9d0f900078fdcea91c0916976b02ff7f, RC_9d0f900078fdcea91c0916976b02ff7f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_9d0f900078fdcea91c0916976b02ff7f s) => ToStructure(s, config);
}
public static RC_9d0f900078fdcea91c0916976b02ff7f ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_9d0f900078fdcea91c0916976b02ff7f obj, IBehaviorsConfiguration config) { 
  RC_9d0f900078fdcea91c0916976b02ff7f s = new RC_9d0f900078fdcea91c0916976b02ff7f();
  if(obj != null) {
  s.ssSTT_DAT_PROV_Out = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_4639a265770186863b3ecaeafd29fb96Structure.ToStructure(obj.AttrT_DAT_PROV_Out, config);
  }
  return s;
}

public static Func<RC_9d0f900078fdcea91c0916976b02ff7f, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_9d0f900078fdcea91c0916976b02ff7f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9d0f900078fdcea91c0916976b02ff7f s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_9d0f900078fdcea91c0916976b02ff7f FromStructure(RC_9d0f900078fdcea91c0916976b02ff7f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_9d0f900078fdcea91c0916976b02ff7f(s, config);
}

}


