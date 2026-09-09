using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderTempRecord
public class JSONRC_1cda0f8d3a174e3a7f752b5be5436b83 : AbstractRESTStructure<RC_1cda0f8d3a174e3a7f752b5be5436b83> {
[JsonProperty("OrderTemp")]
[JsonPropertyName("OrderTemp")]
public ssConectaProveedores.RestRecords.JSONST_9b020d447acc32d28b5e58ce81130d00Structure AttrOrderTemp;

public JSONRC_1cda0f8d3a174e3a7f752b5be5436b83() { }

public JSONRC_1cda0f8d3a174e3a7f752b5be5436b83 (RC_1cda0f8d3a174e3a7f752b5be5436b83 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderTemp = ConvertToRestWithoutDefaults(s.ssSTOrderTemp, new ST_9b020d447acc32d28b5e58ce81130d00Structure(), ssConectaProveedores.RestRecords.JSONST_9b020d447acc32d28b5e58ce81130d00Structure.FromStructure, config);
  } else {
AttrOrderTemp = ssConectaProveedores.RestRecords.JSONST_9b020d447acc32d28b5e58ce81130d00Structure.FromStructure(s.ssSTOrderTemp, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1cda0f8d3a174e3a7f752b5be5436b83, RC_1cda0f8d3a174e3a7f752b5be5436b83> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1cda0f8d3a174e3a7f752b5be5436b83 s) => ToStructure(s, config);
}
public static RC_1cda0f8d3a174e3a7f752b5be5436b83 ToStructure(ssConectaProveedores.RestRecords.JSONRC_1cda0f8d3a174e3a7f752b5be5436b83 obj, IBehaviorsConfiguration config) { 
  RC_1cda0f8d3a174e3a7f752b5be5436b83 s = new RC_1cda0f8d3a174e3a7f752b5be5436b83();
  if(obj != null) {
  s.ssSTOrderTemp = ssConectaProveedores.RestRecords.JSONST_9b020d447acc32d28b5e58ce81130d00Structure.ToStructure(obj.AttrOrderTemp, config);
  }
  return s;
}

public static Func<RC_1cda0f8d3a174e3a7f752b5be5436b83, ssConectaProveedores.RestRecords.JSONRC_1cda0f8d3a174e3a7f752b5be5436b83> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1cda0f8d3a174e3a7f752b5be5436b83 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1cda0f8d3a174e3a7f752b5be5436b83 FromStructure(RC_1cda0f8d3a174e3a7f752b5be5436b83 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1cda0f8d3a174e3a7f752b5be5436b83(s, config);
}

}


