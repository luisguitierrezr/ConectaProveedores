using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValueItem3Record
public class JSONRC_3755be769accfaea24be428bb1876997 : AbstractRESTStructure<RC_3755be769accfaea24be428bb1876997> {
[JsonProperty("ValueItem3")]
[JsonPropertyName("ValueItem3")]
public ssConectaProveedores.RestRecords.JSONST_7103e60d503e9a31fa1ef77b9f0699a9Structure AttrValueItem3;

public JSONRC_3755be769accfaea24be428bb1876997() { }

public JSONRC_3755be769accfaea24be428bb1876997 (RC_3755be769accfaea24be428bb1876997 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValueItem3 = ConvertToRestWithoutDefaults(s.ssSTValueItem3, new ST_7103e60d503e9a31fa1ef77b9f0699a9Structure(), ssConectaProveedores.RestRecords.JSONST_7103e60d503e9a31fa1ef77b9f0699a9Structure.FromStructure, config);
  } else {
AttrValueItem3 = ssConectaProveedores.RestRecords.JSONST_7103e60d503e9a31fa1ef77b9f0699a9Structure.FromStructure(s.ssSTValueItem3, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_3755be769accfaea24be428bb1876997, RC_3755be769accfaea24be428bb1876997> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_3755be769accfaea24be428bb1876997 s) => ToStructure(s, config);
}
public static RC_3755be769accfaea24be428bb1876997 ToStructure(ssConectaProveedores.RestRecords.JSONRC_3755be769accfaea24be428bb1876997 obj, IBehaviorsConfiguration config) { 
  RC_3755be769accfaea24be428bb1876997 s = new RC_3755be769accfaea24be428bb1876997();
  if(obj != null) {
  s.ssSTValueItem3 = ssConectaProveedores.RestRecords.JSONST_7103e60d503e9a31fa1ef77b9f0699a9Structure.ToStructure(obj.AttrValueItem3, config);
  }
  return s;
}

public static Func<RC_3755be769accfaea24be428bb1876997, ssConectaProveedores.RestRecords.JSONRC_3755be769accfaea24be428bb1876997> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3755be769accfaea24be428bb1876997 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_3755be769accfaea24be428bb1876997 FromStructure(RC_3755be769accfaea24be428bb1876997 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_3755be769accfaea24be428bb1876997(s, config);
}

}


