using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// T_DAT_PROV_InRecord
public class JSONRC_ad606c6dbce21f6b806288bf3ea0b634 : AbstractRESTStructure<RC_ad606c6dbce21f6b806288bf3ea0b634> {
[JsonProperty("T_DAT_PROV_In")]
[JsonPropertyName("T_DAT_PROV_In")]
public ssConectaProveedores.RestRecords.JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure AttrT_DAT_PROV_In;

public JSONRC_ad606c6dbce21f6b806288bf3ea0b634() { }

public JSONRC_ad606c6dbce21f6b806288bf3ea0b634 (RC_ad606c6dbce21f6b806288bf3ea0b634 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrT_DAT_PROV_In = ConvertToRestWithoutDefaults(s.ssSTT_DAT_PROV_In, new ST_b19d23fc0038c4f52f978d3d75427ea7Structure(), ssConectaProveedores.RestRecords.JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure.FromStructure, config);
  } else {
AttrT_DAT_PROV_In = ssConectaProveedores.RestRecords.JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure.FromStructure(s.ssSTT_DAT_PROV_In, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ad606c6dbce21f6b806288bf3ea0b634, RC_ad606c6dbce21f6b806288bf3ea0b634> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ad606c6dbce21f6b806288bf3ea0b634 s) => ToStructure(s, config);
}
public static RC_ad606c6dbce21f6b806288bf3ea0b634 ToStructure(ssConectaProveedores.RestRecords.JSONRC_ad606c6dbce21f6b806288bf3ea0b634 obj, IBehaviorsConfiguration config) { 
  RC_ad606c6dbce21f6b806288bf3ea0b634 s = new RC_ad606c6dbce21f6b806288bf3ea0b634();
  if(obj != null) {
  s.ssSTT_DAT_PROV_In = ssConectaProveedores.RestRecords.JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure.ToStructure(obj.AttrT_DAT_PROV_In, config);
  }
  return s;
}

public static Func<RC_ad606c6dbce21f6b806288bf3ea0b634, ssConectaProveedores.RestRecords.JSONRC_ad606c6dbce21f6b806288bf3ea0b634> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ad606c6dbce21f6b806288bf3ea0b634 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ad606c6dbce21f6b806288bf3ea0b634 FromStructure(RC_ad606c6dbce21f6b806288bf3ea0b634 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ad606c6dbce21f6b806288bf3ea0b634(s, config);
}

}


