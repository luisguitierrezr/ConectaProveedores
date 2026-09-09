using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// T_DAT_PROV_OutRecord
public class RESTRC_9d0f900078fdcea91c0916976b02ff7f : AbstractRESTStructure<RC_9d0f900078fdcea91c0916976b02ff7f> {
[JsonProperty("T_DAT_PROV_Out")]
public ssConectaProveedores.RestRecords.RESTST_4639a265770186863b3ecaeafd29fb96Structure AttrT_DAT_PROV_Out;

public RESTRC_9d0f900078fdcea91c0916976b02ff7f() { }

public RESTRC_9d0f900078fdcea91c0916976b02ff7f (RC_9d0f900078fdcea91c0916976b02ff7f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrT_DAT_PROV_Out = ConvertToRestWithoutDefaults(s.ssSTT_DAT_PROV_Out, new ST_4639a265770186863b3ecaeafd29fb96Structure(), ssConectaProveedores.RestRecords.RESTST_4639a265770186863b3ecaeafd29fb96Structure.FromStructure, config);
  } else {
AttrT_DAT_PROV_Out = ssConectaProveedores.RestRecords.RESTST_4639a265770186863b3ecaeafd29fb96Structure.FromStructure(s.ssSTT_DAT_PROV_Out, config);
  }
}

public static RC_9d0f900078fdcea91c0916976b02ff7f ToStructure(ssConectaProveedores.RestRecords.RESTRC_9d0f900078fdcea91c0916976b02ff7f obj) { 
  RC_9d0f900078fdcea91c0916976b02ff7f s = new RC_9d0f900078fdcea91c0916976b02ff7f();
  if(obj != null) {
  s.ssSTT_DAT_PROV_Out = ssConectaProveedores.RestRecords.RESTST_4639a265770186863b3ecaeafd29fb96Structure.ToStructure(obj.AttrT_DAT_PROV_Out);
  }
  return s;
}

public static Func<RC_9d0f900078fdcea91c0916976b02ff7f, ssConectaProveedores.RestRecords.RESTRC_9d0f900078fdcea91c0916976b02ff7f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9d0f900078fdcea91c0916976b02ff7f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_9d0f900078fdcea91c0916976b02ff7f FromStructure(RC_9d0f900078fdcea91c0916976b02ff7f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_9d0f900078fdcea91c0916976b02ff7f(s, config);
}

}


